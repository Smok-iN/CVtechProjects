SELECT 
    Books.BookID, 
    Books.Title, 
    Books.CopiesAvailable - COALESCE(COUNT(Loans.BookID), 0) AS Ratio
FROM 
    Books 
LEFT JOIN 
    Loans ON Books.BookID = Loans.BookID
GROUP BY 
    Books.BookID, 
    Books.Title, 
    Books.CopiesAvailable