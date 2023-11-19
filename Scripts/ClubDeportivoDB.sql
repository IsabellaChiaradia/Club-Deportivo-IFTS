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