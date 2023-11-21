---cars

create proc carList
as begin
select*from Cars
end
go

create proc carAdd
@carModelname varchar(50),
@carCapacity int,
@carDriver varchar(50),
@carExpense money
as begin
insert into Cars(carModelname,carCapacity,carDriver,carExpense) values (@carModelname,@carCapacity,@carDriver,@carExpense)
end
go

create proc carUpdate
@carNo int,
@carModelname varchar(50),
@carCapacity int,
@carDriver varchar(50),
@carExpense money
as begin
update Cars set
carModelname=@carModelname,carCapacity=@carCapacity,carDriver=@carDriver,carExpense=@carExpense where carNo=@carNo
end
go

create proc carDel
@carNo int
as begin delete from Cars where carNo=@carNo
end
go


create proc carSearch
@carModelname varchar
as begin
select*from Cars where carModelname=@carModelname
end
go

---customers

create proc customerList
as begin
select*from Customers
end
go

create proc customerAdd
@nameSurname varchar(50),
@address varchar(50),
@phoneNumber int,
@mail varchar(50),
@paymentStatus varchar(50)
as begin
insert into Customers (nameSurname,address, phoneNumber,mail,paymentStatus) values (@nameSurname,@address,@phoneNumber,@mail,@paymentStatus)
end
go

create proc customerUpdate
@customerNo int,
@nameSurname varchar(50),
@address varchar(50),
@phoneNumber int,
@mail varchar(50),
@paymentStatus varchar(50)
as begin
update Customers set
nameSurname=@nameSurname,address=@address, phoneNumber=@phoneNumber,mail=@mail,paymentStatus=@paymentStatus where customerNo=@customerNo
end
go

create proc customerDel
@customerNo int
as begin delete from Customers where customerNo=@customerNo
end
go

create proc customerSearch
@nameSurname varchar(50)
as begin
select*from Customers where nameSurname=@nameSurname
end
go

---employees

create proc employeeList
as begin
select*from Employees
end
go

create proc employeeAdd
@nameSurname varchar(50),
@task varchar(50),
@title varchar(50),
@phoneNumber int,
@mail varchar(50),
@salary money
as begin
insert into Employees (nameSurname,task,title,phoneNumber,mail,salary) values (@nameSurname,@task,@title,@phoneNumber,@mail,@salary)
end
go

create proc employeeUpdate
@employeeNo int,
@nameSurname varchar(50),
@task varchar(50),
@title varchar(50),
@phoneNumber int,
@mail varchar(50),
@salary money
as begin
update Employees set
nameSurname=@nameSurname,task=@task,title=@title,phoneNumber=@phoneNumber,mail=@mail,salary=@salary
where employeeNo=@employeeNo
end
go

create proc employeeDel
@employeeNo int
as begin delete from Employees where employeeNo=@employeeNo
end
go

create proc employeeSearch
@nameSurname varchar(50)
as begin 
select*from Employees where nameSurname=@nameSurname
end
go

---shipment

create proc shipmentList
as begin
select*from Shipment
end 
go

create proc shipmentAdd
@shipmentName varchar(50),
@dispatchPoint varchar(50),
@transportationPoint varchar(50),
@distance int,
@price money
as begin
insert into Shipment (shipmentName,dispatchPoint,transportationPoint,distance,price) values(@shipmentName,@dispatchPoint,@transportationPoint,@distance,@price)
end
go

create proc shipmentUpdate
@shipmentNo int,
@shipmentName varchar(50),
@dispatchPoint varchar(50),
@transportationPoint varchar(50),
@distance int,
@price money
as begin
update Shipment set
shipmentName=@shipmentName,dispatchPoint=@dispatchPoint,transportationPoint=@transportationPoint,distance=@distance,price=@price where shipmentNo =@shipmentNo
end
go

create proc shipmentDel
@shipmentNo int
as begin delete from Shipment where shipmentNo=@shipmentNo
end
go

create proc shipmentSearch
@shipmentName varchar(50)
as begin
select*from Shipment where shipmentName=@shipmentName
end