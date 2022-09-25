# Mindbox
CREATE TABLE Product(
	product_id int PRIMARY KEY  NOT NULL,
	product_name varchar(50) NOT NULL
);

CREATE TABLE Category(
	category_id int PRIMARY KEY NOT NULL,
	category_name varchar(50) NOT NULL
);

CREATE TABLE Product_Category(
	Id int NOT NULL PRIMARY KEY,
	ProductId int NOT NULL,
	CategoryId int NOT NULL
);

ALTER TABLE Product_Category  
ADD CONSTRAINT FK_Product_Category_Product_ProductId 
FOREIGN KEY(ProductId)
REFERENCES Product(product_id);

ALTER TABLE Product_Category
ADD CONSTRAINT FK_Product_Category_Category_CategoryId 
FOREIGN KEY(CategoryId)
REFERENCES Category(category_id);

SELECT Product.product_name AS Product_Name, 
	     Category.category_name AS Category_Name
FROM Product 
LEFT JOIN Product_Category ON Product_Category.ProductId = Product.product_id
LEFT JOIN Category  ON Product_Category.CategoryId = Category.category_id
ORDER BY Product.product_name, Category.category_name;
