USE ProductTest
GO
INSERT INTO category(name)
VALUES ('PHONE'),('Computer'),('Notebook'),('Food'),('Cloth'),('TV')
GO
INSERT INTO products(name, category_id)
VALUES ('IPHONE', 1),('GAME COMP', 2),('LaptopUltrabook', 3),('Apple', 4),('Boots', 5),('LG', 6),
('Samsung', 1),('Just comp', 2),('Ultrabook', 3),('Chicken', 4),('T-Shirt', 5),('Samsung-TV', 6),
('Book',null);