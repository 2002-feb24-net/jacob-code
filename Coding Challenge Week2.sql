CREATE SCHEMA CC;
GO
--creating tables
CREATE TABLE CC.Products
(
	ID INT IDENTITY NOT NULL,
	Name NVARCHAR(128) NOT NULL,
	Price MONEY NOT NULL,
	CONSTRAINT PK_Products_ID PRIMARY KEY (ID)
)
CREATE TABLE CC.Customers
(
	ID INT IDENTITY NOT NULL,
	Firstname NVARCHAR(128) NOT NULL,
	Lastname NVARCHAR(128) NOT NULL,
	CardNumber BIGINT NOT NULL,
	CONSTRAINT PK_Customers_ID PRIMARY KEY (ID)
)

CREATE TABLE CC.Orders
(
	ID INT IDENTITY NOT NULL,
	ProductID INT NOT NULL,
	CustomerID INT NOT NULL,
	CONSTRAINT PK_Order_ID PRIMARY KEY (ID),
	CONSTRAINT FK_Products_ID FOREIGN KEY (ProductID) REFERENCES CC.Products (ID),
	CONSTRAINT FK_Customer_ID FOREIGN KEY (CustomerID) REFERENCES CC.Customers (ID)
)
INSERT INTO CC.Products(Name, Price)
VALUES ('Soap',10);
INSERT INTO CC.Products(Name, Price)
VALUES ('Toilet Paper',15);
INSERT INTO CC.Products(Name, Price)
VALUES ('Sanitizer',20);

INSERT INTO CC.Customers( Firstname, Lastname, CardNumber)
VALUES ('Bob','Bobberson',1234455);
INSERT INTO CC.Customers( Firstname, Lastname, CardNumber)
VALUES ('Sarah','Parker',41525455);
INSERT INTO CC.Customers(Firstname, Lastname, CardNumber)
VALUES ('Terry','Cruise',999999);

--adding 3 records into each table
INSERT INTO CC.Orders (ProductID, CustomerID)
VALUES (1,1);
INSERT INTO CC.Orders (ProductID, CustomerID)
VALUES (2,2);
INSERT INTO CC.Orders (ProductID, CustomerID)
VALUES (3,3);


--adding iphone
INSERT INTO CC.Products(ID, Name, Price)
VALUES ((SELECT Max(ID) FROM CC.Products) ,'IPhone',200);
--adding Tina Smith
INSERT INTO CC.Customers(Firstname, Lastname, CardNumber)
VALUES ('Tina','Smith',42190571350);
--Tina orders IPhone
INSERT INTO CC.Orders (ProductID, CustomerID)
VALUES (4,4);
--Report all orders for Tina Smith
SELECT o.* FROM CC.Orders as o INNER JOIN CC.Customers as c ON o.CustomerID = c.ID
		WHERE Firstname = 'Tina' AND Lastname = 'Smith';
--Report all revenue from Iphone
SELECT COUNT((SELECT ID FROM CC.Products WHERE Name = 'IPhone'))*(SELECT Price FROM CC.Products WHERE Name = 'IPhone') FROM CC.Orders;
INSERT INTO CC.Products(ID, Name, Price)
--increase price of IPhone
VALUES ((SELECT ID FROM CC.Products WHERE Name = 'IPhone') ,'IPhone',250);