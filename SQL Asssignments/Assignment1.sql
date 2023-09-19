CREATE DATABASE ShoppingCartDb

USE ShoppingCartDb

CREATE TABLE Users(
UserId int PRIMARY KEY,
UserName Varchar(20),
Password Varchar(20),
ContactNumber BigInt,
City Varchar(20)
);

Select * from Users

CREATE TABLE PRODUCTS(
ProductId int,
ProductName Varchar(20) NOT NULL,
QuantityInStock int NOT NULL,
UnitPrice int NOT NULL,
Category varchar(20) NOT NULL,
CONSTRAINT Pk_Pro_Pid PRIMARY KEY(ProductId),
CONSTRAINT Pk_Pro_PQ CHECK(QuantityInStock>0),
CONSTRAINT Pk_Pro_PU CHECK(UnitPrice>0)
);

SELECT * FROM PRODUCTS

CREATE TABLE CART(
Id int,
CartId int NOT NULL,
ProductId int,
Quantity int NOT NULL,
CONSTRAINT Ck_Cro_Cid PRIMARY KEY(Id),
CONSTRAINT Ck_Cro_Pid FOREIGN KEY(ProductId) REFERENCES PRODUCTS(ProductId),
CONSTRAINT Ck_Cro_CQ CHECK(Quantity>0),
);

SELECT * FROM CART


CREATE TABLE Orders(
OrderId int,
CartId int,
OrderDate date,
TotalAmount int,
UserId int,
CONSTRAINT Or_Oid PRIMARY KEY(OrderId),
CONSTRAINT Or_Uid FOREIGN KEY(UserId) REFERENCES Users
);

INSERT INTO Users VALUES(1,'Nikhil','1858',9866015171,'Hyd')
INSERT INTO Users VALUES(2,'Ved','1958',98366545171,'Hyd')
INSERT INTO Users VALUES(3,'Aks','5358',9861445171,'Hyd')
INSERT INTO Users VALUES(4,'Pooj','5458',9863245171,'Hyd')
INSERT INTO Users VALUES(5,'Vens','1388',9896245171,'Hyd')

SELECT * FROM Users

INSERT INTO Products VALUES(1,'LG',290,2500,'TV')

INSERT INTO Products VALUES(2,'IPhone',4,62500,'Phone')

INSERT INTO PRODUCTS(ProductId,ProductName,UnitPrice,Category) VALUES (3,'samsung',9,105000,'Phone')

INSERT INTO Products VALUES(4,'Bullet350',9,325000,'Bike')

INSERT INTO Products VALUES(5,'KTM',9,200000,'Bike')

SELECT * FROM PRODUCTS


INSERT INTO CART VALUES(1,1,5,70)
INSERT INTO CART VALUES(2,2,2,32)
INSERT INTO CART VALUES(3,6,4,37)
INSERT INTO CART VALUES(4,3,1,29)
INSERT INTO CART VALUES(5,9,3,28)

SELECT * FROM CART

INSERT INTO Orders VALUES(1,2,'2008-11-11',25000,3)
INSERT INTO Orders VALUES(2,3,'2023-08-12',37820,5)
INSERT INTO Orders VALUES(3,5,'2001-06-19',28900,4)
INSERT INTO Orders VALUES(4,4,'2005-06-01',09272,2)
INSERT INTO Orders VALUES(5,1,'2015-03-09',49800,1)

SELECT * FROM Orders


SELECT * FROM Products
SELECT * FROM Products WHERE Category='Bike'
SELECT * FROM Products WHERE QuantityInStock=0
SELECT * FROM Products WHERE UnitPrice>=1000 AND UnitPrice<=10000
SELECT * FROM Products WHERE ProductId=3

SELECT * FROM Cart WHERE CartId=3
SELECT * FROM Cart WHERE ProductId=3

SELECT * FROM Users
SELECT * FROM Users WHERE UserName='Nikhil'
SELECT * FROM Users WHERE UserId=5

SELECT * FROM Orders WHERE OrderId=4;
SELECT * FROM Orders WHERE UserId=2;
SELECT * FROM Orders WHERE OrderDate='2008-11-11'

SELECT * FROM CART




