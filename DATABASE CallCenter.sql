use CallCenter
go


create table Perfiles(
ID tinyint primary key iden tity(1,1) not null,
Perfil varchar(100) not null,
)
go

create table Estados(
ID Tinyint primary key identity(1,1) not null,
Estados varchar(100) not null,
)
go

create table prioridad(
ID tinyint primary key identity(1,1) not null,
Prioridad varchar(50) not null,
)
go

create table TipoIncidencia(
ID tinyint primary key identity(1,1) not null,
TipoInc Varchar(100) not null,
)
go


create table Clientes(
ID bigint primary key identity(1,1),
NomClien varchar(50) not null,
ApellClien varchar(100)not null,
DNIClien bigint unique not null,
Tel varchar(25) not null,
Email varchar(100) not null, 
Domicilio varchar(200) not null,
)
go


create table Usuarios(
ID bigint primary key identity(1,1),
Nombre varchar(50) not null,
Apellido varchar(100)not null,
DNI bigint unique not null,
IDPerf tinyint foreign key references Perfiles(ID) not null,
)
go

create table Incidencia(
ID bigint primary key identity(1,1),
IDcliente bigint foreign key references Clientes(ID) not null,
IDestado tinyint foreign key references Estados(ID) not null,
IDusuario bigint foreign key references Usuarios(ID) not null,
Problematica varchar(1000) not null,
Comentarios varchar(1000) null,
)
go