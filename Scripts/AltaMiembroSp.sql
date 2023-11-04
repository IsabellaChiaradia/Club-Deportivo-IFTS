delimiter // 
 drop procedure if exists NuevoMiembro//
 create procedure NuevoMiembro(in Nom varchar(50),in Ape varchar(50), in Dni varchar(15), in EsSocio BOOLEAN, in Correo varchar(50), in Direccion varchar(50), in FNac varchar(50), in AptoM BOOLEAN, out rta int)
 begin
     declare filas int default 0;
	 declare existe int default 0;
    
     set filas = (select count(*) from miembro);
     if filas = 0 then
		set filas = 1001; /* consideramos a este numero como el primer numero de postulante */
     else
     /* -------------------------------------------------------------------------------
		buscamos el ultimo numero de postulante almacenado para sumarle una unidad y
		considerarla como PRIMARY KEY de la tabla
   ___________________________________________________________________________ */
		set filas = (select max(IDMiembro) + 1 from miembro);
		
		/* ---------------------------------------------------------
			para saber si ya esta almacenado el postulante
		------------------------------------------------------- */	
		set existe = (select count(*) from miembro m where m.Correo = Correo or m.DNI = Dni);
     end if;
	 
	  if existe = 0 then	 
		 insert into miembro values(filas,Nom,Ape,Dni,EsSocio,Correo,Direccion,FNac,AptoM);
		 set rta  = filas; -- esto devuelve el id del postulante
	  else
		 set rta = existe; -- si devuelve 1 ya existe
      end if;		 
    
     end //