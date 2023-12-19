create database vrtic;

drop table odgojne_skupine;
drop table djeca;
drop table odgajateljice;

use vrtic;

create table odgojneskupine(
	sifra int not null primary key identity(1,1),
	dob int not null,
	brojdjece int,
	odgajateljice int not null,
	djeca int not null,
);

create table djeca(
	sifra int not null primary key identity(1,1),
	ime varchar(50) not null,
	prezime varchar(50)not null,
	datumrodenja datetime not null,
	odgojneskupine int not null,
	foreign key (odgojneskupine) references odgojneskupine(sifra)
);

create table odgajateljice(
	sifra int not null primary key identity(1,1),
	ime varchar(50) not null,
	prezime varchar(50) not null,
	adresa varchar(100) not null,
	datumrodenja datetime not null,
	oib char(11) not null,
	iban char(13) not null,
	odgojneskupine int not null,
	foreign key (odgojneskupine) references odgojneskupine(sifra)
);

--alter table odgojneskupine add foreign key (odgajateljice) references odgajateljice(sifra);
--alter table odgojneskupine add foreign key (djeca) references djeca(sifra);
--alter table djeca add foreign key (odgojneskupine) references odgojneskupine(sifra);
--alter table odgajateljice add foreign key (odgojneskupine) references odgojneskupine(sifra);