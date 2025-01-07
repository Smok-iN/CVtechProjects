SELECT 
    Loans.BookID, 
    Books.*, 
    COUNT(Loans.BookID) AS 'Popular' 
FROM 
    Books 
JOIN 
    Loans ON Loans.BookID = Books.BookID 
GROUP BY 
	Loans.BookID,
    Books.BookID,
	Books.Title,
	Books.Author,
	Books.Genre,
	Books.ISBN,
	Books.PublishedYear,
	Books.CopiesAvailable
ORDER BY 
	'Popular' DESC
