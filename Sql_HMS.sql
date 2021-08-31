use hostel
--create table rooms( 
--roomNo bigint not null primary key,
--roomStatus varchar (250) not null,
--Booked varchar(150) default 'No'
--)
--insert into rooms values('401','Yes','Yes');
--insert into rooms values('402','Yes','No');
--insert into rooms values('403','Yes','No');
--insert into rooms values('404','Yes','Yes');
--insert into rooms values('405','yes','yes');
select *from rooms
--create table newStudent(
--id int identity(1,1) primary key,
--mobile bigint not null,
--name varchar(250) not null,
--fname varchar(250) not null,
--mname varchar(250) not null,
--email varchar(250) not null,
--paddress varchar(250) not null,
--college varchar(250) not null,
--RegNo varchar(250) not null,
--roomNo bigint not null,
--living varchar(250) default 'Yes',
--FOREIGN KEY (roomNo) REFERENCES rooms(roomNo)
--)
select *from newStudent
--create table fees( 
--mobileNo bigint not null, 
--fmonth varchar(60) not null, 
--amount bigint not null
--)

--insert into fees values('1234567890','October 2020',2700);

select *from fees
GO
--create view [living_v] as
--select b.id,b.mobile,b.name,b.email,a.roomNo,b.living
--FROM rooms a, newStudent b
--where living='Yes';
select *from living_v;
GO