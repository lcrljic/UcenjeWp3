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