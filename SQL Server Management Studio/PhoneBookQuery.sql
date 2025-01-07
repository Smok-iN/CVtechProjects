CREATE DATABASE PhoneBookProject
CREATE TABLE PhoneBook (FirstName VARCHAR(20), LastName VARCHAR(20), PhoneNumber BIGINT);
DELETE PhoneBook;
INSERT INTO PhoneBook (FirstName, LastName, PhoneNumber) 
VALUES ('Cameron', 'Spaulding', 4055627709);
INSERT INTO PhoneBook (FirstName, LastName, PhoneNumber) 
VALUES ('Camero', 'Spaulding', 4055627709);
INSERT INTO PhoneBook (FirstName, LastName, PhoneNumber) 
VALUES ('Camer', 'Spaulding', 4055627709);
INSERT INTO PhoneBook (FirstName, LastName, PhoneNumber) 
VALUES ('Came', 'Spaulding', 4055627709);
INSERT INTO PhoneBook (FirstName, LastName, PhoneNumber) 
VALUES ('Cam', 'Spaulding', 4055627709);
INSERT INTO PhoneBook (FirstName, LastName, PhoneNumber) 
VALUES ('Ca', 'Spaulding', 4055627709);
INSERT INTO PhoneBook (FirstName, LastName, PhoneNumber) 
VALUES ('C', 'Spaulding', 4055627709);
INSERT INTO PhoneBook (FirstName, LastName, PhoneNumber) 
VALUES ('Cameron', 'Spauldin', 4055627709);
INSERT INTO PhoneBook (FirstName, LastName, PhoneNumber) 
VALUES ('Cameron', 'Spauldi', 4055627709);
INSERT INTO PhoneBook (FirstName, LastName, PhoneNumber) 
VALUES ('Cameron', 'Spauld', 4055627709);
SELECT *
FROM PhoneBook;