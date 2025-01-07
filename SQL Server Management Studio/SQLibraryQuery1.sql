CREATE DATABASE Library;
CREATE TABLE Books (
	BookID int NOT NULL, 
	Title varchar(255) NOT NULL,
	Author varchar(255),
	Genre varchar(255), 
	ISBN varchar(255),
	PublishedYear date,
	CopiesAvailable int NOT NULL,
	PRIMARY KEY (BookID)
);
CREATE TABLE Members (
	MemberID int NOT NULL,
	FirstName varchar(255) NOT NULL,
	LastName varchar(255) NOT NULL,
	Email varchar(255) NOT NULL, 
	PhoneNumber int,
	Address varchar(255),
	PRIMARY KEY (MemberID)
);
CREATE TABLE Loans (
	LoanID int NOT NULL,
	BookID int NOT NULL,
	MemberID int NOT NULL,
	LoanDate date NOT NULL, 
	ReturnDate date NOT NULL,
	PRIMARY KEY (LoanID),
	FOREIGN KEY (BookID) REFERENCES Books(BookID),
	FOREIGN KEY (MemberID) REFERENCES Members(MemberID)
);
CREATE TABLE Staff (
	StaffID int NOT NULL,
	Name varchar(255) NOT NULL,
	Role varchar(255) NOT NULL,
	Email varchar(255) NOT NULL, 
	Phone int NOT NULL,
	PRIMARY KEY (StaffID)
);
INSERT INTO Books (BookID, Title, Author, Genre, ISBN, PublishedYear, CopiesAvailable)
VALUES (1, 'Whispers in the Fog', 'Emma Hartley', 'Mystery', '978-1-63258-148-2', 2021, 5);