DELETE FROM "OrderDetails"
WHERE "ID_OrderDetails" ='ace4944a-405c-4831-8eef-2427a51be5da';


-- 1 запрос
SELECT "SupplierName", "Email", "UnitPrice", "QuantityInStock", "WarehouseName",
	CASE
        WHEN "UnitPrice" BETWEEN 500 and 1000 THEN 'Категория A'
        WHEN "UnitPrice" BETWEEN 1000 AND 4000 THEN 'Категория B'
        WHEN "UnitPrice" > 4000 THEN 'Категория C'
        ELSE 'Категория Zero'
    END AS "Category"
FROM "Products" p
INNER JOIN 
	"Suppliers" s ON p."SupplierID" = s."ID_Supplier"
INNER JOIN 
	"Warehouses" w ON p."WarehouseID" = w."ID_Warehouse"
WHERE "UnitPrice" > 500 AND "QuantityInStock" > 80
ORDER BY "UnitPrice" ASC


-- 2 запрос
WITH "ProductsT" AS (
	SELECT "SupplierName", "Email", "ProductName", "UnitPrice", "QuantityInStock", "WarehouseName", "ID_Product" 
	FROM "Products" p
	INNER JOIN 
		"Suppliers" s ON p."SupplierID" = s."ID_Supplier"
	INNER JOIN 
		"Warehouses" w ON p."WarehouseID" = w."ID_Warehouse"
),
"CustomersT" AS (
	SELECT "ID_Order", "TotalAmount", "Status", "CustomerName", "Phone"
	FROM "Orders" o
	INNER JOIN
		"Customers" c ON o."CustomerID" = c."ID_Customer"
)
SELECT "CustomerName", "Phone", "TotalAmount", od."UnitPrice", "Status", "ProductName", "WarehouseName", "QuantityInStock"
FROM "OrderDetails" od
INNER JOIN 
	"ProductsT" pt ON od."ProductId" = pt."ID_Product"
INNER JOIN 
	"CustomersT" ct on od."OrderId" = ct."ID_Order"
WHERE "TotalAmount" > 1000
ORDER BY "TotalAmount" DESC, od."UnitPrice" ASC