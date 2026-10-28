create database PDV_BD;
use PDV_BD;
create table productos(
	clave varchar(50) primary key,
    nombre varchar(25),
    precio decimal(10,2)
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