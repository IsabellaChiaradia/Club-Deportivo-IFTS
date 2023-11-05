delimiter //  
drop procedure if exists IngresoLogin//
create procedure IngresoLogin(in correo varchar(20),in psw varchar(15))
begin
  select NomRol
	from usuario s inner join roles r on s.IDRol = r.IDRol
		where email = correo and psw = contrasenia /* se compara con los parametros */
			and estaActivo = 1; /* el usuario debe estar activo */
end 
//