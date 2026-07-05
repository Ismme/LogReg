-- Hostel Management System Database Setup Scripts

-- 1. Create Rooms Table (Reference table, assumed structure based on foreign key)
-- CREATE TABLE rooms (
--     roomNo varchar(250) primary key,
--     roomStatus varchar(250)
-- );

-- 2. Create Students Table
CREATE TABLE Newstude1(
    id int identity(1,1) primary key,
    mobile bigint not null,
    name varchar (250) not null,
    fname varchar (250) not null,
    mnamme varchar (250) not null,
    email varchar (250) not null,
    adminNo varchar (250) not null,
    roomNo varchar (250) not null,
    foreign key (roomNo) references rooms(roomNo)
);

-- 3. Create Employees Table
CREATE TABLE Employees(
    id int identity(1,1) Primary Key,
    EmpMobile bigint not null,
    EmpName varchar (250) not null,
    EmpEmail varchar (250) not null,
    EmpAge varchar (250) not null,
    Dept varchar (250) not null
);
