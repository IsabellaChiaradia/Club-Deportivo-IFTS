DELIMITER //
DROP PROCEDURE IF EXISTS PagarCuota //
CREATE PROCEDURE PagarCuota(IN dni_miembro varchar(15), IN monto double, IN fecha_pago date, out rta int)
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
                
		IF es_Socio THEN
			-- Calculamos la fecha de vencimiento como un mes después de la fecha de pago
			SET fecha_vencimiento = DATE_ADD(fecha_pago, INTERVAL 1 MONTH);
		ELSE
			SET fecha_vencimiento = DATE_ADD(fecha_pago, INTERVAL 1 DAY);
        END IF;
        
        -- Insertamos el registro de cuota
        INSERT INTO Cuota (Monto, FechaPago, FechaVenc, IDMiembro)
        VALUES (monto, fecha_pago, fecha_vencimiento, miembro_id);
        
        -- Devolvemos 1 si el pago se realizó con éxito 
        SET rta = 1;
    ELSE
        -- Devolvemos 0 si no pudimos asentar el pago 
        SET rta = 0;
    END IF;
END;//