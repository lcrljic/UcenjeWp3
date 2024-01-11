select * from smjerovi where sifra=1;

select * from grupe;

select a.naziv as smjer, b.naziv as grupa
from smjerovi a inner join grupe b
on b.smjer = a.sifra;

select a.naziv, concat(b.ime,' ',b.prezime) as predavac
from grupe a inner join predavaci b
on b.sifra = a.predavac;

select * from grupe;

select a.naziv as smjer,
b.naziv as grupa,
concat(c.ime,' ',c.prezime) as predavac,
concat(e.ime,' ',e.prezime) as polaznik
from smjerovi a 
inner join grupe b on a.sifra=b.smjer
inner join predavaci c on b.predavac=c.sifra
inner join clanovi d on d.grupa=b.sifra
inner join polaznici e on d.polaznik=e.sifra;

select * from predavaci;

select * from grupe where predavac=2;

select * from grupe;

update grupe
set predavac=2
where sifra=2;

select a.naziv as smjer, b.naziv as grupa
from smjerovi a left join grupe b
on a.sifra=b.smjer 
order by 2;

use knjiznica;

select a.naslov
from katalog a inner join autor b
on a.autor=b.sifra
where b.ime='August' and b.prezime='Šenoa';

select a.naslov
from katalog a inner join mjesto b
on a.mjesto=b.sifra
where b.naziv='Osijek';

select naziv from izdavac where naziv like '%d.o.o.%'
or naziv like '%doo%'
or naziv like '%d.o.o%';

insert into autor (sifra,ime,prezime,datumrodenja)
values(4,'Luka', 'Crljić', '2002-08-07');

select top 10 * from autor;

select ime, prezime from autor where datumrodenja between '2002-01-01' and '2002-12-31';

select concat(a.ime,' ',a.prezime) as autor
from autor a inner join katalog b on b.autor=a.sifra
inner join mjesto c on b.mjesto=c.sifra
where c.naziv='Zagreb';

select a.ime, a.prezime, b.naslov
from autor a left join katalog b on a.sifra=b.autor
where b.naslov is null;

select count(*) from autor;

delete a
from autor a left join katalog b on a.sifra=b.autor
where b.naslov is null;

select concat('Plemeniti ',a.ime), c.naziv
from autor a inner join katalog b on a.sifra=b.autor
inner join mjesto c on b.mjesto=c.sifra
where c.naziv like '%a%';

update a set a.ime=concat('Plemeniti ',a.ime)
from autor a
inner join katalog b on a.sifra=b.autor
inner join mjesto c on b.mjesto=c.sifra
where c.naziv like '%a%';