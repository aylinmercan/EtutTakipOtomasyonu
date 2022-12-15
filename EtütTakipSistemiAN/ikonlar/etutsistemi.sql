create database etüttakipsistemi 
use etüttakipsistemi

create table user_table(
User_ID int identity(1,1),
User_Name varchar(50) UNIQUE,
User_Pass varchar(50),
User_Pho varchar(15),
User_CNIC varchar(15) UNIQUE,
User_DOB varchar(10),
User_Gender varchar(6),
User_Email varchar(40),
User_Role varchar(5),
User_Add varchar(150),
CONSTRAINT user_table_PK PRIMARY KEY (User_ID)

);
Insert Into user_table Values (
'Büsra Aylin Mercan', '123','+905455945395','11111111111','15/08/2002','female','aylin@gmail.com','User','Turkey'

)
Insert Into user_table Values (
'user', '1234','+905455945396','11111111112','15/08/2002','female','aylin1@gmail.com','User','Turkey'

)