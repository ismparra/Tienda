create database PDV_BD;
use PDV_BD;
create table productos(
	clave varchar(50) primary key,
    nombre varchar(25),
    precio decimal(10,2),
    stock int
);

create table ventas(
	id_venta INT primary key auto_increment,
    fecha timestamp DEFAULT current_timestamp,
    subtotal decimal(10,2),
    iva decimal(10,2),
    total decimal(10,2)
);

create table detalles_venta(
	id_venta int,
    clave varchar(50),
    precio_unitario decimal(10,2),
    cantidad int,
    importe decimal(10,2),
    primary key(id_venta,clave),
    foreign key (id_venta) references ventas(id_venta),
    foreign key (clave) references productos(clave)
);

INSERT INTO productos VALUES
('7622210595416', 'Clorets', 0.00,100),
('7508310245041', 'Hojas', 0.00,100),
('7501742138264', 'Libreta', 0.00,100),
('7500810049686', 'Tartinas', 0.00,100),
('7501030418399', 'Donas', 0.00,100),
('7501086801121', 'Agua epura', 0.00,100),
('7502212175963', 'Carpeta', 0.00,100),
('7501015213551', 'Marcatexto', 0.00,100),
('6922723252983', 'Marcador', 0.00,100),
('3154147490747', 'Pincel', 0.00,100),
('7501030683469', 'Lapicero', 0.00,100),
('7501015213162', 'Borrador', 0.00,100),
('7501214980377', 'Corrector', 0.00,100),
('3154148517214', 'Lapiz', 0.00,100),
('72067153715', 'Pegamento', 0.00,100);