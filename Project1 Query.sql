CREATE SCHEMA P1;
GO
--creating tables
CREATE TABLE P1.Customer
(
	ID INT IDENTITY NOT NULL,
	FirstName NVARCHAR(128) NOT NULL,
	LastName NVARCHAR(128) NOT NULL,
	CONSTRAINT PK_Customer_ID PRIMARY KEY (ID)
)
CREATE TABLE P1.StoreLocation
(
	ID INT IDENTITY NOT NULL,
	LocationName NVARCHAR(128) NOT NULL,
	CONSTRAINT PK_StoreLocation_ID PRIMARY KEY (ID)
)
CREATE TABLE P1.Product
(
	ID INT IDENTITY NOT NULL,
	StoreLocationID INT NOT NULL,
	Name NVARCHAR(128) NOT NULL,
	Price MONEY NOT NULL,
	Stock INT NOT NULL,
	CONSTRAINT PK_Product_ID PRIMARY KEY (ID),
	CONSTRAINT FK_StoreProduct_ID FOREIGN KEY (StoreLocationID) REFERENCES P1.StoreLocation (ID),
)
CREATE TABLE P1.Orders
(
	ID INT IDENTITY NOT NULL,
	StoreLocationID INT NOT NULL,
	CustomerID INT NOT NULL,
	ProductID INT NOT NULL,
	OrderTime NVARCHAR(128) DEFAULT GETDATE(),
	Quantity INT NOT NULL,
	CheckOut BIT,
	CONSTRAINT PK_Orders_ID PRIMARY KEY (ID),
	CONSTRAINT FK_StoreLocation_ID FOREIGN KEY (StoreLocationID) REFERENCES P1.StoreLocation (ID),
	CONSTRAINT FK_Customer_ID FOREIGN KEY (CustomerID) REFERENCES P1.Customer (ID),
	CONSTRAINT FK_Product_ID FOREIGN KEY (ProductID) REFERENCES P1.Product (ID)
)

DROP TABLE P1.Orders;
DROP TABLE Songs;

--doing some test examples
INSERT INTO P1.Customer (FirstName, LastName)
VALUES ('Nick','Escalona');

INSERT INTO P0.Customer (FirstName, LastName)
VALUES ('slim','jim');

INSERT INTO P0.StoreLocation (LocationName)
VALUES ('location example');

INSERT INTO P1.StoreLocation (LocationName)
VALUES ('Chilis');

INSERT INTO P1.Product (StoreLocationId, Name, Price, Stock)
VALUES ((SELECT ID FROM P0.StoreLocation WHERE LocationName = 'Chilis'),'Soap',15,50);
INSERT INTO P1.Product (StoreLocationId, Name, Price, Stock)
VALUES ((SELECT ID FROM P1.StoreLocation WHERE LocationName = 'Chilis'),'Salsa',10,11);

INSERT INTO P0.Product (StoreLocationId, Name, Price, Stock)
VALUES ((SELECT ID FROM P0.StoreLocation WHERE LocationName = 'location example'),'test product',10,100);
SELECT * FROM P0.Product;

INSERT INTO P1.Orders (StoreLocationId, CustomerId, ProductID, Quantity, CheckOut)
VALUES ((SELECT ID FROM P1.StoreLocation WHERE LocationName = 'Chilis'),(SELECT ID FROM P1.Customer WHERE FirstName = 'Nick'),(SELECT ID FROM P1.Product WHERE Name = 'Salsa'),11,1);

SELECT * FROM P1.Orders;
DELETE FROM P1.Orders WHERE ID = 2;
GO

CREATE TRIGGER trg_UpdateTimeEntry
ON P1.Orders
AFTER UPDATE
AS
    UPDATE P1.Orders
    SET OrderTime = GETDATE()
    WHERE ID IN (SELECT DISTINCT ID FROM Inserted)