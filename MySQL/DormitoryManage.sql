DROP DATABASE IF EXISTS DormitoryManage;
CREATE DATABASE DormitoryManage CHARACTER SET GB2312;
USE DormitoryManage;

/***************************
创建寝室信息表
表名：room_info
日期：2020.6.8
版本：2.1
描述：保存寝室信息
具体内容：
dormitoryNumber INT  公寓号
roomNumber INT  寝室号
***************************/
CREATE TABLE room_info(
dormitoryNumber INT NOT NULL,
roomNumber INT NOT NULL,
CONSTRAINT pk_drNumber PRIMARY KEY(dormitoryNumber,roomNumber)
);

/***************************
创建学生信息表
表名：student_info
日期：2020.6.8
版本：2.1
描述：保存学生信息
具体内容：
studentNumber INT  学号
dormitoryNumber INT  公寓号
roomNumber INT  寝室号
studentName VARCHAR(20)  姓名
studentGender ENUM('男','女')  性别
studentAge INT  年龄
studentMajor VARCHAR(20)  专业
studentPhone VARCHAR(20)  联系方式
studentPassword VARCHAR(30)  密码
***************************/
CREATE TABLE student_info(
studentNumber INT NOT NULL,
dormitoryNumber INT NOT NULL,
roomNumber INT NOT NULL,
studentName VARCHAR(20) NOT NULL,
studentGender ENUM('男','女') DEFAULT '男',
studentAge INT NOT NULL,
studentMajor VARCHAR(20) NOT NULL,
studentPhone VARCHAR(30) NOT NULL,
studentPassword VARCHAR(30) NOT NULL, 
CONSTRAINT pk_studentNumber PRIMARY KEY(studentNumber),
CONSTRAINT ck_studentAge CHECK(studentAge > 0)
);

/***************************
创建公寓管理员信息表
表名：manager_info
日期：2020.6.8
版本：2.1
描述：保存公寓管理员信息
具体内容：
managerNumber INT  职工号
dormitoryNumber INT  公寓号
managerName VARCHAR(20)  姓名
managerGender ENUM('男','女')  性别
managerAge INT  年龄
managerPhone VARCHAR(20)  联系方式
managerPosition VARCHAR(20)  职位
managerPassword VARCHAR(30)  密码
***************************/
CREATE TABLE manager_info(
managerNumber INT NOT NULL,
dormitoryNumber INT NOT NULL,
managerName VARCHAR(20) NOT NULL,
managerGender ENUM('男','女') DEFAULT '男',
managerAge INT NOT NULL,
managerPhone VARCHAR(30) NOT NULL,
managerPosition VARCHAR(20) NOT NULL,
managerPassword VARCHAR(30) NOT NULL,
CONSTRAINT pk_managerNumber PRIMARY KEY(managerNumber),
CONSTRAINT fk_dormitoryNumber FOREIGN KEY(dormitoryNumber) REFERENCES room_info(dormitoryNumber),
CONSTRAINT uq_managerPhone UNIQUE(managerPhone),
CONSTRAINT ck_managerAge CHECK(managerAge > 0)
);

/***************************
创建入住信息表
表名： check_in
日期：2020.6.8
版本：2.1
描述：保存入住信息
具体内容：
studentNumber INT  学号
dormitoryNumber INT  公寓号
roomNumber INT  寝室号
checkInTime DATA  入住时间
isChangeRoom ENUM(‘是’,’否’)  是否换过寝
***************************/
CREATE TABLE check_in(
studentNumber INT NOT NULL,
dormitoryNumber INT NOT NULL,
roomNumber INT NOT NULL,
checkInTime DATE DEFAULT NULL,
isChangeRoom ENUM('是','否') DEFAULT '否',
CONSTRAINT pk_ci_sdrNumber PRIMARY KEY(studentNumber),
CONSTRAINT fk_ci_studentNumber FOREIGN KEY(studentNumber) REFERENCES student_info(studentNumber),
CONSTRAINT fk_ci_drNumber FOREIGN KEY(dormitoryNumber,roomNumber) REFERENCES room_info(dormitoryNumber,roomNumber)
);

/***************************
创建晚归信息表
表名： late_return
日期：2020.6.8
版本：2.1
描述：保存晚归信息
具体内容：
studentNumber INT  学号
dormitoryNumber INT  公寓号
roomNumber INT  寝室号
lateReturnTime DATETIME  晚归时间
***************************/
CREATE TABLE late_return(
studentNumber INT NOT NULL,
dormitoryNumber INT NOT NULL,
roomNumber INT NOT NULL,
lateReturnTime DATETIME NOT NULL,
CONSTRAINT pk_lr_sdrNumber PRIMARY KEY(studentNumber,lateReturnTime),
CONSTRAINT fk_lr_studentNumber FOREIGN KEY(studentNumber) REFERENCES student_info(studentNumber),
CONSTRAINT fk_lr_drNumber FOREIGN KEY(dormitoryNumber,roomNumber) REFERENCES room_info(dormitoryNumber,roomNumber)
);

/***************************
创建水电信息表
表名： water_electricity
日期：2020.6.8
版本：2.1
描述：保存水电信息
具体内容：
dormitoryNumber INT  公寓号
roomNumber INT  寝室号
studentNumber INT  学号
checkMonth DATE  月份
electricityConsumption FLOAT  用电量
electricityBill FLOAT  电费
waterConsumption FLOAT  用水量
waterBill FLOAT  水费
***************************/
CREATE TABLE water_electricity(
dormitoryNumber INT NOT NULL,
roomNumber INT NOT NULL,
studentNumber INT NOT NULL, 
checkMonth DATE NOT NULL,
electricityConsumption FLOAT NOT NULL,
electricityBill FLOAT NOT NULL,
waterConsumption FLOAT NOT NULL,
waterBill FLOAT NOT NULL,
CONSTRAINT pk_we_drNumber PRIMARY KEY(dormitoryNumber,roomNumber,studentNumber,checkMonth),
CONSTRAINT fk_we_drNumber FOREIGN KEY(dormitoryNumber,roomNumber) REFERENCES room_info(dormitoryNumber,roomNumber)
);

DESCRIBE room_info;
DESCRIBE student_info;
DESCRIBE manager_info;
DESCRIBE check_in;
DESCRIBE late_return;
DESCRIBE water_electricity;
