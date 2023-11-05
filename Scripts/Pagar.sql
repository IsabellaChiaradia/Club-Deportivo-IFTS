DELIMITER //
DROP PROCEDURE IF EXISTS Pagar //
CREATE PROCEDURE Pagar(IN dni_miembro varchar(15), IN monto double, IN fecha_pago date, IN tipo_pago int, out rta int)
BEGIN
    DECLARE miembro_id INT;
    DECLARE fecha_vencimiento date;
    DECLARE es_Socio tinyint;
    
    -- Buscamos el ID del miembro por DNI
    SELECT IDMiembro INTO miembro_id
    FROM Miembro
    WHERE DNI = dni_miembro;
    
    -- Verificamos si el miembro existe
    IF miembro_id IS NOT NULL THEN
    
		SELECT EsSocio INTO es_Socio
			FROM Miembro
				WHERE IDMiembro = miembro_id;
		
        IF (tipo_pago = 1 AND es_Socio) THEN -- EL PAGO ES MENSUAL Y SOLO LOS SOCIOS LO PUEDEN PAGAR
			SET fecha_vencimiento = DATE_ADD(fecha_pago, INTERVAL 1 MONTH);
            INSERT INTO Cuota (Monto, FechaPago, FechaVenc, IDMiembro)
			VALUES (monto, fecha_pago, fecha_vencimiento, miembro_id);
            SET rta = 1;
        ELSEIF (tipo_pago = 2 AND !es_Socio) THEN -- EL PAGO ES DE ACTIVIDAD Y SOLO LOS NO SOCIOS DEBEN PAGARLO
			SET fecha_vencimiento = DATE_ADD(fecha_pago, INTERVAL 1 DAY);
			INSERT INTO Cuota (Monto, FechaPago, FechaVenc, IDMiembro)
			VALUES (monto, fecha_pago, fecha_vencimiento, miembro_id);
            SET rta = 1;
		ELSE 
			SET rta = 0; 
		-- DEVOLVEMOS 0 SI EL DNI INGRESADO, EN EL FORMULARIO DE PAGO MENSUAL, FUE DE UN "NO SOCIO"
        -- O TAMBIEN DEVOLVEMOS 0 SI EL DNI INGRESADO, EN EL FORMULARIO DE PAGO ACTIVIDAD, FUE DE UN "SOCIO"
        -- LOS SOCIOS PUEDEN ACCEDER A CUALQUIER ACTIVIDAD POR ESO NO DEBEN PAGAR POR LAS MISMAS
        END IF;
    ELSE
        -- DEVOLVEMOS -1 SI EL MIEMBRO NO EXISTE EN LA BD 
        SET rta = -1;
    END IF;
END;//
DELIMITER ;