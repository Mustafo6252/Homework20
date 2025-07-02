/*
 
create table Categoties(
id integer Primary Key Not Null,
name varchar(50)  Not Null,
description varchar(250),
created_at Date ,
update_at Date
);

create table Products(
id integer Not Null,
name Varchar(100) Not null,
description varchar(255),
price money Not Null,
stock integer ,
sku varchar(50) Not Null,
PRIMARY KEY (id,sku),
supplier varchar(100) Not Null,
categories varchar (50),
create_at Date,
update_at date
);

create table Sales(
id integer Primary Key Not Null,
product Varchar(100) Not Null,
quantity integer Not null,
sale_date Date Not Null,
costomer_name Varchar(100) Not Null,
costomer_email varchar(100),
total_price Money Not Null,
create_at Date
);

--  #############################  Task 1  ########################

Insert Into Categoties(id,name,description, created_at,update_at)
Values
(1,'Electotexnika','har bitta uy uchun zarur','2021-01-01','2025-01-01'),
(2,'Kiyim-Kechak','har bitta inson uchun zarur','2022-01-01','2024-01-01'),
(3,'Maishiy-Texnika','har bittta uyda kamida 4-5 ta boladi','2022-12-01','2024-12-01'),
(4,'Kitoblar','har bitta inson oqishi kerak,shuning uchun sotuvi tez','2021-12-01','2023-01-01'),
(5,'Oyinchoqlar','deyarli har bitta uyda bola bor va ular oyinchoq xohlaydi','2023-01-01','2025-04-01');

--  #############################  Task 2  ########################

Insert into Products(id,name,description,price,stock,sku,supplier,categories,create_at,update_at)
Values
(1, 'Smartfon Samsung A34', '6.6" AMOLED, 128GB', 3400000, 25, 'SKU001', 'Samsung Uzbekistan', 'Elektronika', '2025-07-01', '2025-07-01'),
(2, 'Erkaklar uchun futbolka', '100% paxta, XL o‘lcham', 120000, 100, 'SKU002', 'Textile Group', 'Kiyim-kechak', '2025-07-01', '2025-07-02'),
(3, 'Kitob: "Alkimyogar"', 'Paulo Koelho muallifligida, o‘zbek tilida', 45000, 50, 'SKU003', 'Kitoblar Markazi', 'Kitoblar', '2025-06-30', '2025-07-01'),
(4, 'Changyutkich LG', '1600W, chang idishi bilan', 980000, 15, 'SKU004', 'LG Distributors', 'Maishiy texnika', '2025-07-01', '2025-07-01'),
(5, 'Konstruktorga o‘yinchoq', 'LEGO Classic 11005, 900 dona', 350000, 30, 'SKU005', 'Toy House', 'O‘yinchoqlar', '2025-06-29', '2025-07-01'),
(6, 'Noutbuk Lenovo IdeaPad 3', 'Intel i5, 8GB RAM, 256GB SSD', 7800000, 10, 'SKU006', 'Lenovo Uzbekistan', 'Elektronika', '2025-07-02', '2025-07-02'),
(7, 'Ayollar sumkasi', 'Charm, qora rangda, universal model', 250000, 40, 'SKU007', 'Moda Style LLC', 'Kiyim-kechak', '2025-07-01', '2025-07-02'),
(8, 'Kitob: "Boy ota, kambagʻal ota"', 'Robert Kiyosaki, bestseller', 60000, 70, 'SKU008', 'Bookzone', 'Kitoblar', '2025-07-02', '2025-07-02'),
(9, 'Mikroto‘lqinli pech Samsung', '23L, 800W, qora rang', 890000, 12, 'SKU009', 'Samsung Uzbekistan', 'Maishiy texnika', '2025-07-01', '2025-07-02'),
(10, 'Kichkintoy uchun yumshoq ayiqcha', '30 cm, yumshoq plyush, oq rang', 145000, 60, 'SKU010', 'Toy House', 'O‘yinchoqlar', '2025-06-30', '2025-07-01');


--  #############################  Task 3  ########################

INSERT INTO Sales (id, product, quantity, sale_date, costomer_name, costomer_email, total_price, create_at) 
VALUES
(1, 'Smartfon Samsung A34', 1, '2022-07-01', 'Alijon Karimov', 'alijon@example.com', 3400000, '2025-07-01'),
(2, 'Erkaklar uchun futbolka', 2, '2025-07-01', 'Diyorbek Nurmatov', 'diyorbek@gmail.com', 240000, '2025-07-01'),
(3, 'Kitob: "Alkimyogar"', 1, '2022-07-02', 'Shahzoda Yuldasheva', 'shahzoda@mail.com', 45000, '2025-07-02'),
(4, 'Changyutkich LG', 1, '2022-07-02', 'Bekzod Maxmudov', 'bekzodm@example.com', 980000, '2025-07-02'),
(5, 'Konstruktorga o‘yinchoq', 3, '2025-07-03', 'Malika Azizova', 'malika.azizova@gmail.com', 1050000, '2025-07-03'),
(6, 'Noutbuk Lenovo IdeaPad 3', 1, '2025-07-03', 'Dilshod Ergashev', 'dilshod.e@mail.com', 7800000, '2025-07-03'),
(7, 'Ayollar sumkasi', 2, '2023-07-04', 'Gulnoza Mamatova', 'gulnoza22@mail.com', 500000, '2025-07-04'),
(8, 'Kitob: "Boy ota, kambagʻal ota"', 1, '2025-07-04', 'Farruh Salimov', NULL, 60000, '2025-07-04'),
(9, 'Mikroto‘lqinli pech Samsung', 1, '2022-07-05', 'Otabek Tursunov', 'otabek.tursunov@example.com', 890000, '2025-07-05'),
(10, 'Kichkintoy uchun yumshoq ayiqcha', 2, '2025-07-05', 'Rayhona Askarova', NULL, 290000, '2025-07-05');


--  #############################  Task 4  ########################

Select * from Products;


--  #############################  Task 5  ########################


Select * from Products where price::numeric>50000 And stock>20;

--  #############################  Task 6  ########################

select price, price*1.15 AS new_price from Products;

--  #############################  Task 7  ########################

delete from Products where stock=0;

--  #############################  Task 8  ########################

UPDATE products
SET description = 'Yangi, to‘liq yangilangan tavsif',
    update_at = CURRENT_DATE;
	
Select update_at from Products;

--  #############################  Task 9  ########################

Select create_at from Products where create_at<'2025-07-01';

--  #############################  Task 10  ########################

select sale_date from Sales where sale_date>'2023-01-01';

*/