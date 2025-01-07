CREATE DATABASE Library;
CREATE TABLE Books (
	BookID int NOT NULL, 
	Title varchar(255) NOT NULL,
	Author varchar(255),
	Genre varchar(255), 
	ISBN varchar(255),
	PublishedYear varchar(255),
	CopiesAvailable int NOT NULL,
	PRIMARY KEY (BookID)
);
CREATE TABLE Members (
	MemberID int NOT NULL,
	FirstName varchar(255) NOT NULL,
	LastName varchar(255) NOT NULL,
	Email varchar(255) NOT NULL, 
	PhoneNumber BIGINT,
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
	Phone BIGINT NOT NULL,
	PRIMARY KEY (StaffID)
);

INSERT INTO Books (BookID, Title, Author, Genre, ISBN, PublishedYear, CopiesAvailable)
VALUES (1, 'Whispers in the Fog', 'Emma Hartley', 'Mystery', '978-1-63258-148-2', '2021', 5),
(1, 'The Last Horizon', 'Samuel Drake', 'Science Fiction', '978-0-45123-876-3', '2019', 3),
(1, 'The Crimson Tree', 'Olivia Montgomery', 'Fiction', '978-0-74328-194-0', '2018', 4),
(1, 'Shadows of the Past', 'David Leclair', 'Thriller', '978-1-55823-676-1', '2020', 6),
(1, 'Echoes in the Void', 'Natasha Ruiz', 'Fantasy', '978-0-69876-245-7', '2022', 2),
(1, 'Beneath the Silver Moon', 'Harper Blackwell', 'Romance', '978-1-42692-809-5', '2023', 1),
(1, 'The Silent City', 'Mark Reed', 'Dystopian', '978-0-45125-183-4', '2017', 4),
(1, 'Journeys of the Heart', 'Isabelle Walker', 'Fiction', '978-1-79146-220-8', '2020', 3),
(1, 'Rising Tide', 'Daniel Pierce', 'Adventure', '978-0-80756-400-5', '2021', 5),
(1, 'Frosted Memories', 'Carla Winters', 'Young Adult', '978-0-54589-203-3', '2022', 2),
(1, 'The Clockmakers Secret', 'George Finch', 'Steampunk', '978-0-37453-497-2', '2021', 1),
(1, 'Vows of the Fallen', 'Derek Stone', 'Fantasy', '978-1-56619-909-7', '2020', 3),
(1, 'The Forbidden Garden', 'Amelia Thatcher', 'Romance', '978-0-98372-755-6', '2019', 6),
(1, 'The Sound of Silence', 'Nora Fitzgerald', 'Thriller', '978-0-87524-798-6', '2023', 4),
(1, 'Into the Abyss', 'Jack Williams', 'Horror', '978-1-94765-102-3', '2021', 3),
(1, 'Beneath the Ashes', 'Laura Green', 'Post-Apocalyptic', '978-1-50951-200-7', '202020', 2),
(1, 'City of Dreams', 'Alex Rivers', 'Fantasy', '978-1-60801-245-4', '2022', 3),
(1, 'Unbroken Wings', 'Sophia Winters', 'Romance', '978-0-99123-117-6', '2018', 5),
(1, 'The Invisible Thread', 'Timothy Lane', 'Drama', '978-1-40631-277-1', '2024', 3),
(1, 'Reign of the Fallen King', 'Kenneth Moore', 'Fantasy', '978-0-77495-039-1', '2019', 1);
SELECT * 
FROM Books;