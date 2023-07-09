USE ProductTest
GO
SELECT p.name, c.name FROM products AS p LEFT JOIN category AS c ON p.category_id = c.id;