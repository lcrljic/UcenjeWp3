use master;
go
drop database if exists zavrsni;
go
create database zavrsni collate Croatian_CI_AS;
go
use zavrsni;

create table Proizvodi(
	sifra int not null primary key identity(1,1),
	naziv varchar(50) not null,
	cijena decimal(18,2),
	datumNabave datetime,
	aktivan bit
);

create table Kupci(
	sifra int not null primary key identity(1,1),
	ime varchar(50) not null,
	prezime varchar(50) not null,
	mjesto varchar(50) not null,
	ulicaIBroj varchar(255) not null,
	brojMobitela varchar(20)
);

create table Racuni(
	sifra int not null primary key identity(1,1),
	kupac int not null,
	datum datetime,
	statusRacuna varchar(50)
);

create table Stavke(
	racun int not null,
	proizvod int not null,
	kolicina int not null,
	cijena decimal(18,2)
);

alter table Racuni add foreign key (kupac) references Kupci(sifra);
alter table Stavke add foreign key (proizvod) references Proizvodi(sifra);

insert into Proizvodi(naziv,cijena,datumNabave,aktivan) values
('Motorna pila','250.00','2024-01-23',1),
('Kosilica','360.00','2024-01-23',1),
('Pumpa za vodu','340.00','2024-01-23',0),
('Uređaj za bušenje','1250.00','2024-01-23',1),
('Motorna kopačica','820.00','2024-01-23',0);

insert into Kupci(ime,prezime,mjesto,ulicaIBroj,brojMobitela) values
('Luka','Crljić','Osijek','Vukovarska 50','091/234-5678'),
('Danijel','Stojavić','Osijek','Vukovarska 32a','091/234-5679'),
('Marko','Marković','Vukovar','Duga 61','091/234-5670'),
('Marta','Martić','Zagreb','Ilica 155','091/234-5622'),
('Karlo','Karlović','Split','Sinjska 22','091/234-2678');

insert into Racuni(kupac,datum,statusRacuna) values
(1,'2024-01-23','Izdan'),
(2,'2024-01-23','Izdan'),
(3,'2024-01-23','Izdan'),
(4,'2024-01-23','Izdan'),
(5,'2024-01-23','Izdan');

insert into Stavke(racun,proizvod,kolicina,cijena) values
(1,1,'2','250.00'),
(2,2,'5','350.00'),
(3,3,'1','340.00'),
(4,4,'3','1260.00'),
(5,5,'2','820.00');