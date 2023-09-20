ALTER PROCEDURE CART
AS
BEGIN
DECLARE cur1 CURSOR
FOR SELECT ProductName,UnitPrice,UnitsOnOrder FROM  Products;
DECLARE @ProductName VARCHAR(30), @UnitsOnOrder int, @UnitPrice int, @TotalAmt Decimal(10,2), @GrandTotal Decimal(10,2);
OPEN cur1
FETCH NEXT FROM cur1 INTO @ProductName, @UnitPrice,@UnitsOnOrder;
WHILE @@FETCH_STATUS = 0
    BEGIN
	    SELECT @TotalAmt=@UnitPrice*@UnitsOnOrder FROM Products;
		if @UnitsOnOrder>50 AND @UnitsOnOrder<=100
		 BEGIN
		   SELECT @GrandTotal=@TotalAmt-@TotalAmt*0.05; 
		 END
		else if @UnitsOnOrder>100
		   BEGIN
		   SELECT @GrandTotal=@TotalAmt-@TotalAmt*0.1; 
		   END
		else
		   SELECT @GrandTotal=@TotalAmt;
		PRINT 'ProductName is ' + @ProductName + '  Total Amount is: '+ CAST(@TotalAmt as VARCHAR) + ' and Grand Total is: ' + CAST(@GrandTotal as VARCHAR);
        FETCH NEXT FROM cur1 INTO @ProductName, @UnitPrice,@UnitsOnOrder;
    END;
	CLOSE cur1;
DEALLOCATE cur1;
End;

EXEC CART




