-- Angel David Zavala Rodriguez
-- Alan Salgado Salas
-- Francisco Xavier Nieto Orozco
-- Brian Menendez Lopez

CREATE DATABASE ERFRA;
USE ERFRA;

CREATE TABLE Usuario(
	IdUsuario INT(8) PRIMARY KEY AUTO_INCREMENT NOT NULL,
	Nombre VARCHAR(40) NOT NULL,
	Apellidos VARCHAR(50) NOT NULL,
	NombreUsuario VARCHAR(20) NOT NULL,
	Correo VARCHAR(40) NOT NULL,
	Password VARCHAR(255) NOT NULL,
	Genero ENUM('Hombre', 'Mujer', 'Otro'),
	Rol ENUM('Administrador','Empleado')
);

CREATE TABLE Proveedor(
	IdProveedor INT(8) PRIMARY KEY AUTO_INCREMENT NOT NULL,
	NombreProveedor VARCHAR(40) NOT NULL,
	DireccionProveedor VARCHAR(50) NOT NULL,
	TelefonoProveedor VARCHAR(10) NOT NULL,
	CorreoProveedor VARCHAR(30) NOT NULL,
	BorradoLogico INT NOT NULL
);

CREATE TABLE MateriaPrima(
	IdMaterial INT (8) auto_increment, 
	CodigoMaterial varchar(10) NOT NULL,
	NombreMaterial VARCHAR(40) NOT NULL,
	ColorMaterial VARCHAR(30) NOT NULL,
	CantidadMaterial INT(5) NOT NULL CHECK(CantidadMaterial>0),
	TipoMaterial VARCHAR(30) NOT NULL,
	FechaEntrada VARCHAR(30) NOT NULL,
	IdProveedor INT(8) NOT NULL,
	IdUsuario INT(8) NOT NULL,
    borradoLogico int not null,
	PRIMARY KEY (IdMaterial, IdProveedor, IdUsuario),
	CONSTRAINT fk_MateriaPrima_Proveedor FOREIGN KEY (IdProveedor) REFERENCES Proveedor (IdProveedor),
	CONSTRAINT fk_MateriaPrima_Usuario FOREIGN KEY (IdUsuario) REFERENCES Usuario (IdUsuario)
);

CREATE TABLE SolicitudesVentas(
	IdSolicitud INT(8) AUTO_INCREMENT NOT NULL,
	NombreCliente VARCHAR(40) NOT NULL,
	NombreProducto VARCHAR(40) NOT NULL,
	Descripcion VARCHAR(120) NOT NULL,
	Lote INT(5) NOT NULL CHECK(Lote>=20 and Lote<=500),
	PrecioUnitario INT(5) NOT NULL CHECK(PrecioUnitario>0),
	Importe INT(10) NOT NULL CHECK(Importe>0),
	IdUsuario INT(8) NOT NULL,
    Estado ENUM('Sin Iniciar','En Proceso','Terminada','Entregada') NOT NULL,
    borradoLogico int not null,
	PRIMARY KEY (IdSolicitud, IdUsuario),
	CONSTRAINT fk_SolicitudVenta_Usuario FOREIGN KEY (IdUsuario) REFERENCES Usuario (IdUsuario)
);

insert into Usuario values (default,'Alan','Salgado Salas','ElSalas','alanslgdo2902@gmail.com','fakiu','Hombre','Empleado');
insert into SolicitudesVentas values (default,'Brian Menendez','Pantalon','Pantalon de mezclilla',34,200.00,100.00,1,'Sin Iniciar',1);
insert into SolicitudesVentas values (default,'Angel David Zavala','Camisa','Camisa blanca bien percudida alv',30,175.00,125.00,1,'En Proceso');
insert into SolicitudesVentas values (default,'David Perez','Pantalon','Pantalon de tercio pelo',22,250.00,55.00,1,'Terminada');
insert into SolicitudesVentas values (default,'Brian Menendez','Gorra','Gorra de los pumas',34,200.00,100.00,1,'Sin Iniciar');
insert into SolicitudesVentas values (default,'Angel David Zavala','Zapatos','Zapatos Gucci',30,175.00,125.00,1,'En Proceso');
insert into SolicitudesVentas values (default,'David Perez','Pantalon','Pantalon acampanado alv',22,250.00,55.00,1,'Entregada');
INSERT INTO SolicitudesVentas VALUES (default, 'Uriel Mtzz','Uniforme', 'simon', 22, 250, 55, 1, 'Sin Iniciar');
