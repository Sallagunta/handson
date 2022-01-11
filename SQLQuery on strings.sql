create database stringhandson
use stringhandson
create  table strings(class_name varchar(10),textbook_name varchar(15))
insert strings values ('8A','telugu')
insert strings values ('9A','maths')
insert strings values ('10A','english')

select 'ramanji'
--asci--
select ASCII('r') as 'r',ASCII('a') as 'a'
--char--
select char(114) as 'r'
--charindex----
select charindex('t', 'maths')
--concatination----
select CONCAT('maths',' ','ramanujan') 
                                                
---difference---
select difference('juice','banana')
---format---for chineese
select  FORMAT(cast(getdate() AS date),'d','ZH-cn')
----left--
select left ('maths',3) 
--right--
select right ('maths',2)
---length--
select len('maths')
------lower---
select lower('MAHATHMA')
-------upper--
select upper('mahathma')
--reverse-----
select reverse('mahathma')
---------Ltrim---
select ltrim('    maths')
-----rtrim----
select rtrim('mahatma       ')
-------nchar=unicode charecters
select NCHAR(65)
-----patternindex--
select patindex('%t%','maths')
----quotename----
select QUOTENAME('mahatma[ ]')
-------replace---
select replace('maths','m','n')
-----replicate-------repeate number of times a string
select replicate('maths',3)
-----------right-
select right('love india',5)
--------soundex----
select SOUNDEX('maths')
---------spaces-----
select CONCAT('maths', SPACE(12),'ramanujan')
-------str----
select str(185)
 
--------stuff----
select STUFF('mahathma',2,5,'ama')
---------substring--
select substring('i love india',8,5)

---------unicode-
select UNICODE('A')
