drop database if exists club_deportivo;
create database club_deportivo;
use club_deportivo; 

create table roles(
IDRol int,
NomRol varchar(30),
constraint primary key(IDRol)
);

insert into roles values
(1,'Administrador'),
(2,'Empleado');

create table Miembro(
IDMiembro int,
Nombre varchar(50),
Apellido varchar(50),
DNI varchar(15),
EsSocio boolean,
Correo varchar(50),
Direccion varchar(50),
FechaNac varchar(50),
AptoMedico boolean,
constraint pk_miembro primary key (IDMiembro)
);
insert into miembro(IDMiembro, Nombre, Apellido, DNI, EsSocio, Correo, Direccion, FechaNac, AptoMedico) values
(1001, 'Juan', 'Perez', '123456789', 1, 'juan.perez@hotmail.com', 'Calle D 123', '01/01/1990', 1),
(1002, 'Maria', 'Gomez', '987654321', 1, 'maria.gomez@gmail.com', 'Avenida Sarmiento 456', '15/05/1985', 1),
(1003, 'Carlos', 'Rodriguez', '456789123', 0, 'carlos.rodriguez@gmail.com', 'Plaza Principal 980', '30/11/1988', 1);

create table Usuario(
IDUsuario int auto_increment,
Nombre varchar(50),
Apellido varchar(50),
IDRol int,
email varchar(50),
contrasenia varchar(50),
EstaActivo boolean,
constraint pk_usuario primary key (IDUsuario),
constraint fk_miembro_rol foreign key(IDRol) references roles (IDRol)
);

insert into usuario(IDUsuario,Nombre, Apellido, IDRol,email,contrasenia, EstaActivo) values
(1, "Juan", "Gomez", 1,'admin@admin',1234, 1),
(2, "Lucia", "Garcia", 2,'noadmin@admin',1234, 0),
(3, "Jose", "Rodriguez", 1, 'admin1@admin', 2345, 1);


create table Actividad(
IDActiv int,
Nombre varchar(20),
Horario varchar(8),
Fecha date,
CupoMax int,
Costo int,
constraint pk_actividad primary key (IDActiv)
);

insert into actividad(IDActiv, Nombre, CupoMax, Costo) values
('101', 'CrossFit', '30', '700'),
('102', 'Natacion', '15', '1200'),
('103', 'Funcional', '50', '500'),
('104', 'Musculacion', '60', '800');

create table Inscripcion(
IDInscrip int,
IDMiembro int,
IDActiv int,
FechaInsc date,
FechaVenc date,
constraint pk_inscripcion primary key (IdInscrip),
constraint fk_inscripcion_miembro foreign key (IDMiembro) references Miembro (IDMiembro),
constraint fk_inscripcion_actividad foreign key (IDActiv) references Actividad (IDActiv)
);

create table Cuota(
IDCuota int auto_increment,
Monto double,
FechaPago date,
FechaVenc date,
IDMiembro int,
constraint pk_cuota primary key (IDCuota),
constraint fk_cuota_miembro foreign key (IDMiembro) references Miembro (IDMiembro)
);

insert into Cuota (Monto, FechaPago, FechaVenc, IDMiembro) values
(7800, '2023-10-29', DATE_ADD('2023-10-29', INTERVAL 30 DAY), 1001),
(7800, '2023-10-30', DATE_ADD('2023-10-30', INTERVAL 30 DAY), 1002);