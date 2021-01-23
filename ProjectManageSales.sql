alter table tblOrders add constraint FK_tblOrders_tblCustomer foreign key (Customer_Id) references tblCustomer(ID_Customer)

-----------------------------------------------------------------
-- Login_Form
 
-- Procedure for Login
Create Procedure spLogin
@name nvarchar(25),@pass nvarchar(10)
as
	select * from tblEmployee where ID = @name And Pass = @pass
--------------------------------------------------------------------

-- AddProduct_Form ,, ProductManage_Form

-- Procedure to get all Categories
create Procedure spGetCategory
as
	select * from tblCategory


-- Procedure to insert Product
create proc spAddProduct
@id nvarchar(15),@name nvarchar(30),@qty int,@price nvarchar(20),@image image,@Catid int
as
	Insert into tblProduct values(@id,@name,@qty,@price,@image,@Catid)


-- Procedure for validate ProductId
alter Procedure spValidateProId
@id nvarchar(50) , @state int out
as
Begin
	if (Exists(select * from tblProduct where ID_Product = @id))
		set @state = 1;
	else
		set @state = 0;
End

-- after we write in the search text then delete all we write all the Products retrived from DB because
-- select * from tblProduct where {any field alone or concatenated fields} like '%'+''+'%'
-- Procedure to get Searched Products
alter Procedure spGetProductSearched
@id nvarchar(25)
as
	SELECT [ID_Product]
      ,[Name_Product]
      ,[Quantity]
      ,[Price]
	  ,Name_Category
    FROM [dbo].[tblProduct] join tblCategory on tblProduct.Cat_Id = tblCategory.ID_Category where 
				(ID_Product like '%'+@id+'%') or (Name_Product like '%'+@id+'%') or (cast(Quantity as nvarchar) like '%'+@id+'%')
				or (Price like '%'+@id+'%') or (Name_Category like '%'+@id+'%')
				


-- Procedure to get all Products
alter Procedure spGetProduct
as
SELECT [ID_Product]
      ,[Name_Product]
      ,[Quantity]
      ,[Price]
	  ,Name_Category
  FROM [dbo].[tblProduct] join tblCategory on tblProduct.Cat_Id = tblCategory.ID_Category


-- Procedure to delete Selected Products
alter Procedure spDelProduct
@id nvarchar(30)
as
	Delete from tblProduct where ID_Product = @id



-- Procedure to get image of Selected Product
create Procedure spGetImage
@id nvarchar(30)
as
	select Image from tblProduct where ID_Product = @id



-- Procedure to update a product
create procedure spUpdateProduct
@id nvarchar(30),@name nvarchar(30),@qty int,@price nvarchar(20),@image image,@Catid int
as
	UPDATE [dbo].[tblProduct]
    SET [Name_Product] = @name
      ,[Quantity] = @qty
      ,[Price] = @price
      ,[Image] = @image
      ,[Cat_Id] = @Catid
	  where ID_Product = @id



-- Procedure to get single Product
create Procedure spGetSingleProduct
@id nvarchar(30)
as
	select ID_Product,Name_Product,Quantity,Price,[Image],Name_Category from tblProduct join tblCategory on ID_Category=Cat_Id where ID_Product = @id

----------------------------------------------------------------------------------------------------------
-- CategoryManage_Form.cs

-- Procedure to get single Category
create Procedure spGetSingleCategory
@id int
as
	select * from tblCategory where ID_Category = @id

---------------------------------------------------------------------------------------------------------------

-- CutomerManage_Form


-- Procedure to insert Customer
create proc spAddCustomer
@id int,@fname nvarchar(30),@lname nvarchar(30),@tel nchar(15),@email nvarchar(20),@image nvarchar(Max)
as
	Insert into tblCustomer values(@id,@Fname,@Lname,@tel,@email,@image)



-- Procedure to get the last id from tblCustomer
create proc spGetIdCustomer
as
	select top 1 ID_Customer from tblCustomer order by ID_Customer desc


-- Procedure for validate Customer Tel
create Procedure spValidateCusTel
@tel nvarchar(15)
as
	select * from tblCustomer where Tel = @tel


-- Procedure for validate Customer Email
create Procedure spValidateCusEmail
@email nvarchar(25)
as
	select * from tblCustomer where Email = @email



-- Procedure to get all Customers
create Procedure spGetCustomers
as
	SELECT * from tblCustomer


-- Procedure to delete Selected Product
create Procedure spDelCustomer
@id int
as
	Delete from tblCustomer where ID_Customer = @id



-- Procedure to update a Customer
create procedure spUpdateCustomer
@id int,@fname nvarchar(30),@lname nvarchar(30),@tel nvarchar(15),@email nvarchar(20),@image nvarchar(MAX)
as
	UPDATE tblCustomer
    SET First_Name = @fname
      ,Last_Name = @lname
      ,Tel = @tel
      ,Email = @email
      ,[Image] = @image
	  where ID_Customer = @id



-- after we write in the search text then delete all we write all the customers retrived from DB because
-- select * from tblCustomer where cast(ID_Customer as nvarchar)+First_Name+Last_Name+Tel+Email{or even any field alone} like '%'+''+'%'
-- Procedure to search tblCustomer
alter procedure spSearchCustomer
@id nvarchar(30)
as
	select * from tblCustomer where cast(ID_Customer as nvarchar)+First_Name+Last_Name+Tel+Email like '%' + @id+ '%'

select * from tblCategory where Name_Category like '%'+''+'%' -- for test the comment in the up


-------------------------------------------------------------------------------------------------------------------
-- Order_Form

-- Procedure to get the last id from tblOrders
alter proc spGetIdOrder
as
	select ISNULL(MAX(ID_Order)+1,1) from tblOrders


-- Procedure to insert Order data
alter Procedure spInsertOrder
@id int,@date datetime,@idcustomer int,@description nvarchar(50),@salesman nvarchar(30)
as
INSERT INTO [dbo].[tblOrders]
           ([ID_Order]
           ,[Date]
           ,[Customer_Id]
           ,[Description]
           ,[Salesman])
     VALUES
           (@id,@date,@idcustomer,@description,@salesman)


-- Procedure to insert OrderDetails data
alter Procedure spInsertOrderDetails
@Order_Id int,@Product_Id nvarchar(30),@Qty int,@Price nvarchar(50),@Discount float,@Amount nvarchar(50),@Total_Amount nvarchar(50)
as
Begin

	INSERT INTO [dbo].[tblOrderDetails]
			   ([Order_Id]
			   ,[Product_Id]
			   ,[Qty]
			   ,[Price]
			   ,[Discount]
			   ,[Amount]
			   ,[Total_Amount])
		 VALUES
			   (@Order_Id,@Product_Id,@Qty,@Price,@Discount,@Amount,@Total_Amount)

	update tblProduct set Quantity -=  @Qty where ID_Product = @Product_Id

End


--Procedure to get all Orders
Create Procedure spGetOrders
as
	select * from tblOrders 


-- Procedure to Show Order in CrystalReport
Alter Procedure spShowOrder
@ID_Order int
as
Begin
	SELECT [ID_Order] as 'Bill Number'
      ,[Date]
      ,[First_Name] + [Last_Name] as 'Customer Name'
      ,[Description] as 'Bill Description'
      ,[Salesman]
	  ,[Product_Id]
      ,[Qty] as 'Quantity'
      ,[tblOrderDetails].Price as 'Product price'
	  ,[Name_Product]
      ,[Discount]
      ,[Amount]
      ,[Total_Amount]
	  ,[ID_Customer]
	  ,[Email]
	  ,[Tel] as 'Phone'
	  ,CONVERT(float,Total_Amount) as 'Total'
	 FROM tblOrders join tblCustomer on Customer_Id = ID_Customer 
				 join tblOrderDetails on Order_Id = ID_Order
				 join tblProduct on Product_Id = ID_Product
	where ID_Order = @ID_Order
End

------------------------------------------------------------------------------------
-- SaleManage_Form

-- Procedure to search Orders
Create Procedure spSearchSales
@criteria nvarchar(50)
as
	select ID_Order,[Date],First_Name+' '+Last_Name as 'Customer',[Description],Salesman from tblOrders join tblCustomer on tblOrders.Customer_Id = tblCustomer.ID_Customer
	where CAST(ID_Order as nvarchar)+CAST([Date] as nvarchar)+First_Name+Last_Name+[Description]+Salesman like '%'+@criteria+'%'

-------------------------------------------------------------------------------------
--- AddUser_Form ,, UserManage_Form

-- Procedure to add new user
Create Procedure spAddUser
@ID nvarchar(25),@Pass nvarchar(10),@UserType nvarchar(25)
as
	insert into tblEmployee values(@ID,@Pass,@UserType)


-- Procedure to Get All Users
Create Procedure spGetUsers
as
	select * from tblEmployee


-- Procedure to Search Users
Create Procedure spSearchUsers
@criteria nvarchar(20)
as
	select * from tblEmployee where ID+UserType like '%'+@criteria+'%'


-- Procedure to Update User
Create Procedure spUpdateUser
@ID nvarchar(25),@Pass nvarchar(10),@UserType nvarchar(25)
as
	update tblEmployee set Pass = @Pass , UserType = @UserType where ID = @ID


-- Procedure to Delete User
Create Procedure spDeleteUser
@ID nvarchar(25)
as
	delete from tblEmployee where ID = @ID

select * from tblCategory