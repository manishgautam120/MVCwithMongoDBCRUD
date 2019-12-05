# MVCwithMongoDBCRUD
https://www.youtube.com/watch?v=_LMWJNekQGU&amp;t=1467s




For better underdtanding watch youtube vedio
https://www.youtube.com/watch?v=_LMWJNekQGU&t=1467s


prequesite- download mongodb into your system
download mongodb booster

step-1
I have created database in mongodb.Some more information of structure
DatabaseName - "ProductManagementdb"
CollectionName - "product"



step-2
created user
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
