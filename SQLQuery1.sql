select * from salesmanreport
select * from Orderdetails
select *from  customer
--Query1*********
select salesmanreport.name,customer.cust_name ,salesmanreport.city  from salesmanreport inner join customer on salesmanreport.salesman_id=customer.salesman_id
--Query2***********8
select Orderdetails.ORD_no,Orderdetails.purch_amt,customer.cust_name, customer.city  from Orderdetails inner join customer on
   Orderdetails.customer_id= customer.customer_id   where purch_amt between 500 and 2000
  --Query3***********

  SELECT customer.cust_name AS "Customer Name", 
customer.city, salesmanreport.name AS "Salesman", salesmanreport.commission 
FROM customer
INNER JOIN  salesmanreport
ON salesmanreport.salesman_id=customer.salesman_id;
  
  --Query4*********
  select salesmanreport.name,salesmanreport.commission , customer.cust_name,customer.city from salesmanreport left join   customer 
  on salesmanreport.salesman_id=customer.salesman_id  where  commission > 0.12 
   --Query5*****
   select  customer.cust_name,customer.city, salesmanreport.name,salesmanreport.city,salesmanreport.commission from salesmanreport
  inner join customer on  customer.salesman_id =salesmanreport.salesman_id  where  salesmanreport.commission>0.12  and
  salesmanreport.city<> customer.city

  select customer.cust_name,customer.city,salesmanreport.city,salesmanreport.name,salesmanreport.commission from 
customer inner join salesmanreport on salesmanreport.salesman_id = customer.salesman_id and commission>0.12 and 
salesmanreport.city!= customer.city
