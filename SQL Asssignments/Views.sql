CREATE VIEW Products_Less_Than_Average_Price AS (SELECT * FROM Products WHERE UnitPrice<(SELECT AVG(UnitPrice) FROM Products))

SELECT * FROM Products_Less_Than_Average_Price

EXEC sp_rename 'Products_Less_Than_Average_Price','Low_Cost_Products'

SELECT * FROM Low_Cost_Products

DROP VIEW Low_Cost_Products