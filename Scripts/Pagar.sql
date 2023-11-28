DELIMITER //
DROP PROCEDURE IF EXISTS Pagar //
CREATE PROCEDURE Pagar(
    IN dni_miembro VARCHAR(15),
    IN monto DOUBLE,
    IN fecha_pago DATE,
    IN tipo_pago INT,
    OUT rta INT
)
BEGIN
    DECLARE miembro_id INT;
    DECLARE es_Socio TINYINT;
    
    -- Buscamos el ID del miembro por DNI
    SELECT IDMiembro INTO miembro_id
    FROM Miembro
    WHERE DNI = dni_miembro;
    
    -- Verificamos si el miembro existe
    IF miembro_id IS NOT NULL THEN
        SELECT EsSocio INTO es_Socio
        FROM Miembro
        WHERE IDMiembro = miembro_id;
        
        IF (tipo_pago = 1 AND es_Socio) THEN
            -- Verificamos si ya pagó la cuota del mes actual
            IF NOT EXISTS (
                SELECT 1
                FROM Cuota
                WHERE IDMiembro = miembro_id
                    AND MONTH(FechaPago) = MONTH(fecha_pago)
                    AND YEAR(FechaPago) = YEAR(fecha_pago)
            ) THEN
                -- Si no ha pagado, realizamos el pago y establecemos la respuesta a 1
                INSERT INTO Cuota (Monto, FechaPago, FechaVenc, IDMiembro)
                VALUES (monto, fecha_pago, DATE_ADD(fecha_pago, INTERVAL 1 MONTH), miembro_id);
                SET rta = 1;
            ELSE
                -- DEVOLVEMOS 3 SI YA PAGÓ LA CUOTA DEL MES ACTUAL
                SET rta = 3;
            END IF;
        ELSEIF (tipo_pago = 2 AND NOT es_Socio) THEN
            -- El pago es de actividad y solo los no socios deben pagarlo
            INSERT INTO Cuota (Monto, FechaPago, FechaVenc, IDMiembro)
            VALUES (monto, fecha_pago, DATE_ADD(fecha_pago, INTERVAL 1 DAY), miembro_id);
            SET rta = 1;
        ELSE 
            -- DEVOLVEMOS 0 SI EL DNI INGRESADO, EN EL FORMULARIO DE PAGO MENSUAL, FUE DE UN "NO SOCIO"
            -- O TAMBIÉN DEVOLVEMOS 0 SI EL DNI INGRESADO, EN EL FORMULARIO DE PAGO ACTIVIDAD, FUE DE UN "SOCIO"
            -- LOS SOCIOS PUEDEN ACCEDER A CUALQUIER ACTIVIDAD POR ESO NO DEBEN PAGAR POR LAS MISMAS
            SET rta = 0; 
        END IF;
    ELSE
        -- DEVOLVEMOS -1 SI EL MIEMBRO NO EXISTE EN LA BD 
        SET rta = -1;
    END IF;
END;//
DELIMITER ;
