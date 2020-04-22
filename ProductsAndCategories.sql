CREATE TABLE Categories
(
  id INT PRIMARY KEY,
  name VARCHAR(20) NOT NULL
)

INSERT INTO Categories VALUES
  (1, 'milk product'),
  (2, 'meat'),
  (3, 'breakfast'),
  (4, 'dinner')
  
  CREATE TABLE Products
(
  id INT PRIMARY KEY,
  name VARCHAR(20) NOT NULL
)

INSERT INTO Products VALUES
(1, 'cheese'),
(2, 'milk'),
(3, 'meatballs'),
(4, 'cucumber')


CREATE TABLE ProdCut
(
  prodID Int,
  CatID int
)

INSERT INTO ProdCut
VALUES
(1, 1),
(1, 3),
(1, 4),
(2, 1),
(2, 3),
(3, 2),
(3, 4)

SELECT prod.name[Product Name], cat.name[Category Name]
from Products prod
LEFT JOIN ProdCut pc on prod.id = pc.prodID
LEFT JOIN Categories cat ON pc.CatID = cat.id
