create database Proyecto1

create table clientes
(num_clien int primary key identity (1,1) not null, -- Auto numeraci�n primary key
Nombre_Clien varchar (40), 
RFC_Clien varchar (13),
Correo_Clien varchar (50),
Tel_Clien varchar(12)) -- 10 d�gitos + c�digo de pa�s 2 

create table Propuestas
(num_Propuesta int primary key identity (1,1) not null,
Propuesta varchar(300), num_Clien int references Clientes)

insert into clientes values
('Novemce S.A. de C.V','NOV04087ME1','novemce@gmail.com','5555897465'),
('Asphalt S. de R.L.','ASP12094HA5','asphalt@gmail.com','5567981207'),
('Comercializadora Excel Sport S A','CES250609ME1','excelsport@gmail.com','5580064949'),
('Traiber S. A.','TRA060395BE5','traiber@hotmail.com','5592148691'),
('Andsel 600 S.A.','AND120702AN9','andsel@gmail.com','5604232433'),
('EGRAF S. A.','EGR060395BE5','egraf@hotmail.com','5616316175'),
('Kailash Model S.A.','KAI060395BE5','kailashmodel@hotmail.com','5628399917'),
('Mararte S.A.','MAR060395BE5','mararte@gmail.com','5640483659'),
('Cuatelart S.A.','CUA060395BE5','cuatelart@hotmail.com','5652567401'),
('Tediscome S.A.','TED060395BE5','tediscome@hotmail.com','5664651143'),
('Faimagen S.A.','FAI060395BE5','faimagen@gmail.com','5676734885'),
('Belpla S.A.','BEL060395BE5','belpla@gmail.com','5688818627'),
('Ciprian Garces Ester Palmira','CIGE790312C93','ciprian@gmail.com','5700902369'),
('Esmu S.A.','ESM060395BE5','esmu@hotmail.com','5712986111')

insert into Propuestas values
('Por este medio proponemos realizar una mejora en el servicio de cobro, en las tiendas,
ya que asistimos a una tienda y el servicio de la persona que nos atendi� fue muy malo,
adem�s de que tard� mucho tiempo',12)
insert into Propuestas values
('Es necesario realizar una mejora en la calidad del algod�n que usan en su ropa',12)

select * from clientes 
where Correo_Clien = 'belpla@gmail.com' and RFC_Clien = 'BEL060395BE5'

delete from clientes where Nombre_Clien='123'



