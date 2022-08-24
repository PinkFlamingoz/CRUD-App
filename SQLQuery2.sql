create database AnimalDatabase
go
use AnimalDatabase
go
create table Pet
(
  Pet_Id int identity (100000,1) primary key,
  Pet_Name nvarchar (50) not null,
  Pet_Type nvarchar (50) not null,
  Pet_Colour nvarchar (50) not null,  
  Pet_Age int not null,
  Pet_Sex nvarchar(1) not null,
  Pet_BirthDate datetime not null,
  Pet_Owner nvarchar(50) not null,
  Owner_Phone nvarchar(20) not null
)
go
insert into Pet values('Buttons', 'Dog', 'White', '2','f', 'Jan  19 2020 12:00:00:000AM', 'Mike','0308-0321')
insert into Pet values('Coda', 'Cat', 'Multicolor','3','m', 'Feb  4 2020 12:00:00:000AM', 'Galore','9555-4729')
insert into Pet values('Merlin', 'Parrot', 'Green-Yellow','2','f', 'Mar  24 2020 12:00:00:000AM', 'Martin','8555-3932')
insert into Pet values('Nina', 'Turtle', 'Dark Gray','40','f', 'Apr  24 2020 12:00:00:000AM', 'Migel','1555-7788')
insert into Pet values('Domino', 'Rabbit', 'White','2','m', 'May  14 2020 12:00:00:000AM', 'Mikel','0921-3465')
insert into Pet values('Luna', 'Hamster', 'Orange','1','f', 'Jun  20 2020 12:00:00:000AM', 'Molly','0621-8460')
insert into Pet values('Lucy', 'Monkey', 'Brown','4','f', 'Jul  18 2020 12:00:00:000AM', 'Melany','9125-1425')
insert into Pet values('Daysi', 'Horse', 'White','9','f', 'Aug  14 2020 12:00:00:000AM', 'Martadela','7115-3555')
insert into Pet values('Zoe', 'Snake', 'Yellow white','7','f', 'Sep  10 2020 12:00:00:000AM', 'Magdalena','7125-5525')
insert into Pet values('Max', 'Budgie', 'Yellow','2','m', 'Oct  5 2020 12:00:00:000AM', 'Maria','7515-3125')
insert into Pet values('Charlie', 'Mouse', 'White','2','m', 'Nov  12 2020 12:00:00:000AM', 'Monika','5615-3155')
insert into Pet values('Rocky', 'Squirrel', 'Brown-Orange','7','f', 'Dec  4 2020 12:00:00:000AM', 'Mikelangelo','7675-3425')
insert into Pet values('Leo', 'Dog', 'White-Black','3','m', 'Jan  3 2020 12:00:00:000AM', 'Mitra','5675-3125')
insert into Pet values('Loki', 'Cat', 'Black','5','m', 'Feb  4 2020 12:00:00:000AM', 'Marika','7125-1425')
insert into Pet values('Jasper', 'Dog', 'Silver','4','m', 'Mar  4 2020 12:00:00:000AM', 'Milka','7225-1125')
go