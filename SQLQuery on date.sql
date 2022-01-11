create database Gowthamidate
use Gowthamidate
create table sales(sales_id int,sales_date datetime)
drop  table sales
insert sales values(101,'2022-1-11 09:40:05');
select * from sales
select datename(mm,sales_date) from sales
select datename(dd,sales_date) from sales
select datename(yyyy,sales_date) from sales
select cast(getdate() as time ) [time] from sales
select datepart(hh,GETDATE())
select datepart(ms,GETDATE())
select datepart(mi,GETDATE())
select cast(Getdate() as varchar(12)) ,convert(varchar(10),sales_date,102)from sales
select datepart(mm,sales_date) from sales
select dateadd(mm,1,sales_date) from sales
select DATEDIFF(dd,sales_date,'2022-02-11') from sales


