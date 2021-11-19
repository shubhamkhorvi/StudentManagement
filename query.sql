create table signup(
signid int primary key identity(1,1),
email nvarchar(25),
username nvarchar(25),
pword nvarchar(25),
cpword nvarchar(25),
)



create table stuDetails(
sid int primary key identity(1,1),
branchId int,
rollNo nvarchar,
name nvarchar(30),
age int,
address nvarchar(50),
phoneNo nvarchar(10),
DOB date,
gender nvarchar(6),
city nvarchar(15),
cid int)

create table eduDetails(
sid int primary key identity(1,1),
id int,
ten_percent nvarchar(5),
ten_yop int,
ten_inst nvarchar(25),
twel_percent nvarchar(5),
twel_yop int,
twel_inst nvarchar(25),
curr_CGPA nvarchar(5),
curr_sem int,
)

create table branch(
bid int primary key,
b_name nvarchar(15))

create table company(
cid int primary key,
cname nvarchar(40))

create table result(
sid int primary key identity(1,1),
id int,
m1 int,
m2 int,
m3 int, 
total int,
grade nvarchar(3))

create table roll(
id int primary key identity(1,1),
roles nvarchar(20))

create table userrollmap(
id int primary key identity(1,1),
rid int,
signupid int)

alter table userrollmap
add foreign key (rid) references roll(id)

alter table userrollmap
add foreign key (signupid) references signup(signid)

alter table result
add foreign key (id) references stuDetails(sid)

alter table stuDetails
add foreign key (cid) references company(cid)

alter table stuDetails
add foreign key (branchId) references branch(bid)

alter table eduDetails
add foreign key (id) references stuDetails(sid)

insert into roll values ('Admin')
insert into roll values ('Teacher')
insert into roll values ('Student')
insert into roll values ('PO')

insert into signup values('admin@gmail.com','admin','admin123','admin123')
insert into signup values('teacher@gmail.com','teacher','teacher123','teacher123')
insert into signup values('PO@gmail.com','PO','PO123','PO123')

insert into userrollmap values (1,1)
insert into userrollmap values (2,2)
insert into userrollmap values (4,3)

insert into branch values(1,'CSE')
insert into branch values(2,'ISE')
insert into branch values(3,'ECE')
insert into branch values(4,'Mechanical')
insert into branch values(5,'Civil')

insert into company values(1,'KPMG')
insert into company values(2,'WIPRO')
insert into company values(3,'PAYTM')
insert into company values(4,'APPLE')
insert into company values(5,'GOOGLE')
insert into company values(6,'L&T')
insert into company values(7,'Infosys')
insert into company values(8,'Accenture')
insert into company values(9,'Dell')
insert into company values(10,'NotPlaced')

alter table stuDetails 
alter column  rollno nvarchar(10)
