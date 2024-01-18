drop database if exists Test_;
create database UserManager
default character set utf8
default collate utf8_general_ci;

use UserManager;


#============= Table User ============= #

drop table if exists `User`;

create table if not exists User(
id 	  int not null primary key auto_increment ,
name  nvarchar(100) not null ,
password  nvarchar(100) not null,
email  nvarchar(100) not null 
) default charset = utf8;