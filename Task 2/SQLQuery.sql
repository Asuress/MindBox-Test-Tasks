CREATE TABLE ProductCategory (
   Id int NOT NULL,
   Product_id int DEFAULT NULL,
   Category_id int DEFAULT NULL,
   PRIMARY KEY (Id),
   KEY category_idx (Category_id),
   KEY product_fk_idx (Product_id),
   CONSTRAINT category_FK FOREIGN KEY (Category_id) REFERENCES Category (Id),
   CONSTRAINT product_FK FOREIGN KEY (Product_id) REFERENCES Product (Id)
 )
CREATE TABLE Category (
   Id int NOT NULL AUTO_INCREMENT,
   Name varchar(45) DEFAULT NULL,
   PRIMARY KEY (Id),
   KEY category_PK (Id)
 )
CREATE TABLE Product (
   Id int NOT NULL AUTO_INCREMENT,
   Name varchar(45) NOT NULL,
   PRIMARY KEY (Id),
   KEY product_PK (Id)
 )

select Product.Name, Category.Name from ProductCategory 
right join Product on Product.Id = ProductCategory.Product_id 
left join Category on Category.Id = ProductCategory.Category_id