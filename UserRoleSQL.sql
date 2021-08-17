Use Northwind;

Create Role SalesRole;
Create Role HRRole;
Create Role CEORole;

Grant Select ON dbo.Orders TO SalesRole;
Grant Select ON dbo.Orders TO CEORole;

Grant Select ON dbo.Customers TO SalesRole;
Grant Select ON dbo.Customers TO CEORole;

Grant Select ON dbo.Employees To HRRole;
Grant Select ON dbo.Employees to CEORole;

Create Login User_Sales With Password='12345678';
Create Login User_HR With Password='12345678';
Create Login User_CEO With Password='12345678';

Create User User_Sales FOR LOGIN User_Sales;
Create User User_HR FOR LOGIN User_HR;
Create User User_CEO FOR LOGIN User_CEO;

ALTER ROLE SalesRole ADD MEMBER User_Sales;
ALTER ROLE HRRole ADD MEMBER User_HR;
ALTER ROLE CEORole ADD MEMBER User_CEO;