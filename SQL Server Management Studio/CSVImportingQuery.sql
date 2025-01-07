CREATE DATABASE CSVImporting
CREATE TABLE Age (FirstName VARCHAR(20), LastName VARCHAR(20), Age INT);
DELETE Age;
BULK INSERT Age
FROM 'C:\Users\cameron.spaulding\Downloads\age_csv.csv'
WITH (FIELDTERMINATOR = '|', ROWTERMINATOR = '\n')
INSERT INTO Age (FirstName, LastName, Age)
VALUES ('Cameron', 'Spaulding', 18);