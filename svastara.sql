select top 10 sifra, ime, prezime from Kupci;

select * from Kupci where ime='Luka';

select * from Artikli where cijena between 130 and 260
and kratkiNaziv like '%BUŠILICA%'
and kratkiNaziv like '%BOSCH%';

update Artikli set cijena=cijena/7.53450;

select top 10 * from Primke;

update ArtikliNaPrimci set cijena=cijena/7.53450;

select d.naziv as dobavljac, c.kratkiNaziv, b.cijena, b.kolicina, c.cijena-b.cijena as razlika
from Primke a 
inner join ArtikliNaPrimci b on a.sifra=b.primka
inner join Artikli c on b.artikl=c.sifra
inner join Dobavljaci d on a.dobavljac=d.sifra
where a.redniBroj='7/2008';