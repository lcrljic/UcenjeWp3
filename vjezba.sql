--use master;
--go
--drop database if exists tvrtka;
--go
--create database tvrtka collate Croatian_CI_AS;
--go
--use tvrtka;

--create table zaposlenici(
--	sifra int not null primary key identity(1,1),
--	ime varchar(50),
--	prezime varchar(50),
--	datumrodenja datetime,
--	placa decimal(18,2),
--	invalid bit
--);

--create table slike(
--	sifra int not null primary key identity(1,1),
--	zaposlenik int,
--	rednibroj int,
--	putanja varchar(50)
--);

--alter table slike add foreign key (zaposlenik) references zaposlenici(sifra);

--select * from zaposlenici;

--insert into zaposlenici (ime, prezime, datumrodenja, placa, invalid) values
---- 1
--('Luka', 'Crljić', '2002-08-07 03:00:00', 1000.00, 0),
---- 2
--('Marko', 'Marković', '2000-01-01 10:00:00', 1521.44, 1),
---- 3
--('Matija', 'Matić', '1999-07-25 22:00:00', 555.55, 0);

--select * from slike;

--insert into slike (zaposlenik, putanja) values
--(1, 'putanja1'),
--(1, 'putanja2'),
--(2, 'putanja3'),
--(2, 'putanja4'),
--(3, 'putanja5'),
--(3, 'putanja6');






--use master;
--go
--drop database if exists webshop;
--go
--create database webshop collate Croatian_CI_AS;
--go
--use webshop;

--create table proizvodi(
--	sifra int not null primary key identity(1,1),
--	naziv varchar(100),
--	datumnabave datetime,
--	cijena decimal(18,2),
--	aktivan bit
--);

--create table stavke(
--	racun int,
--	proizvod int,
--	kolicina int,
--	cijena decimal(18,2)
--);

--create table racuni(
--	sifra int not null primary key identity(1,1),
--	datum datetime,
--	kupac int,
--	status bit,
--);

--create table kupci(
--	sifra int not null primary key identity(1,1),
--	ime varchar(50),
--	prezime varchar(50),
--	ulica varchar(100),
--	mjesto varchar(100)
--);

--alter table stavke add foreign key (racun) references racuni(sifra);
--alter table stavke add foreign key (proizvod) references proizvodi(sifra);
--alter table racuni add foreign key (kupac) references kupci(sifra);