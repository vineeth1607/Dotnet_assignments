--3.    Create table EMP8 with the following columns and conditions. (Empid,Name,Salary,Deptno)
   -- a.    accept only 10,20,30 as deptno
   -- b.    Every employee salary must be in the range of 5000 to 50000 only

create database EMP8
use EMP8

create table EMP8
(
  EMPId int primary key,
  Name varchar(25)not null,
  salary int,
  Deptno int
)


alter table emp8
add constraint checksalary check( salary between 5000 and 50000)


alter table emp8
add constraint column check( deptno between 10 and 30)

insert into emp8
values (101,'vineeth',25000,10),
(102,'person2',30000,20),
(103,'person3',35000,30)

select * from emp8

--2. Write a query to display your age in days


select DATEDIFF(dd,'1998/07/16','2022/05/17') AS DateDiff
