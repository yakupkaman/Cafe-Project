create procedure kulGiris (
@kulAdi varchar(50) ,
@sifre varchar(50)
)
as 
begin

select * from kullanicilar where @kulAdi=kulAdi and @sifre=sifre

end 
