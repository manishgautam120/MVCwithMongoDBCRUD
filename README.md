# MVCwithMongoDBCRUD
https://www.youtube.com/watch?v=_LMWJNekQGU&amp;t=1467s

Exercise -
For better underdtanding watch youtube vedio
https://www.youtube.com/watch?v=_LMWJNekQGU&t=1467s

solution
prequesite- 
download mongodb(version any abobe to 3.0)
download mongodbbooster(no sql booster)(above version 5)
downlaod visual studia 2019

-----------------------------------------------------------------------------------------------------------------------#1
how to create database and configuration for crud operation ?
first downlaod mongobooster and then connect to the mongodb

Q-how to create database?
step-1
create database name (i taken productmanagementdb)

Q-how to insert raw data into instant created collection (collection create and sampledata insertion both will be on same time) 
step-2
In previous step databse has been created on your left panel and click on database (productmanagementdb) we will insert some test(sample-data) for veiwing purpose

On top right panel you can see "Test Data"  option click on this for inserting data(raw sample-data) 
>one panel will popup(test data generator) 
>Insert data for 3 only (name username email) for other close sign is there use that
> on the same panel below choose database "productmanagementdb" and in collection "userinfo" and Doc count "100"
collection has been created 1M> document has been inserted. i aborted script in between ,if time is taking so much you can do same as well
for security purpose you can create user (i have created user )

Q-how to create user
step-3
right click on database name (productmanagementdb) and "User and Role"> "Add User">add user 

one script file will genrate and then change "username" and "pwd"& role ""as "whatever(but this username have to put in to project web.config file)" 

username = "manish"
pwd = "gautam"
role = "readWrite"
-----------------------------------------------------------------------------------------------------------------------#1


-----------------------------------------------------------------------------------------------------------------------#2
step-1
I have created database in mongodb.Some more information already in #1 has been shared some important are here describing
DatabaseName - "ProductManagementdb"
CollectionName - "product"



step-2
created user for security i provided credential
user-"manish"
pwd-"gautam"

step-3
go to visual studio and create ASP.NET web application
appliationName - "MVCwithMongoDBCRUD"    .

after selecting application name and go for next and then select "MVC" and create .Now mvc application has been created.

step-4
open the web config file and add some database connection string like MongoDb userName and password and localHost and browser.

step-5
create Model folder and create ProductModel.cs class within Model folder and in this class write some code for fields of product like productname, product description and quantity and we using mongodb so remember which thing you going to provide as primary key [BsonId] for mongodb.

step-6
open app_start  folder and right click on that folder and add class file as name is MongoDBContext.cs   .

step-7
go to the controller and add item of "Controller" and select "MVC5 Controller with read|write action" and choose name as 

Controllername- "ProductController"  automatically .cs file will be generate
All logic for insert ,update ,delete will write here write logic according to need if you have some doubt get my code from  github search in github account as manishgautam120.

step-8
create veiw according to need , how to create view > go to ProductController.cs file and click on index right click on index and then option will come for add veiw and add according to use.

-----------------------------------------------------------------------------------------------------------------------#2
