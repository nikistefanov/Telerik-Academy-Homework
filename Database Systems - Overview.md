Homework
Answer following questions in Markdown format (.md file)

1.	What database models do you know?
•	Hierarchial (tree) - the data is organized into a tree-like structure. 
•	Network (graph) - a database model conceived as a flexible way of representing objects and their relationships. 
•	Relational (table) - a digital database whose organization is based on the relational model of data. 
•	Object-oriented - a database management system in which information is represented in the form of objects as used in object-oriented programming.
2.	Which are the main functions performed by a Relational Database Management System (RDBMS)?
•	CRUD (CREATE, READ, UPDATE, DELETE) operations.
•	Support for using SQL language
•	Transactions(optional) 
3.	Define what is "table" in database terms.
•	A database table is combination of rows and collumns. All rows have the same structure. Columns have name and type.
4.	Explain the difference between a primary and a foreign key.
•	Primary key identifies each record (row) in a table.
•	Foreign key is an identifier of a record located in another table (usually its primary key).
5.	Explain the different kinds of relationships between tables in relational databases.
•	One-to-many - a record in one table can have many related records in another table. 
•	Many-to-many - records in both tables have matching records in the other table. Each primary key value relates to only one (or none) record in the related table. These relationships require a third table.
•	One-to-one - a single record in a table corresponds to a single record in the other table.
6.	When is a certain database schema normalized?
When there are no repeating data in the database tables. 
o	What are the advantages of normalized databases?
	The advantages are that the database needs less memory.
7.	What are database integrity constraints and when are they used?
•	Enforce data rules when creating or updating record in the database which cannot be violated. They can be used when we want the data to meet certain requirements and restrictions.
8.	Point out the pros and cons of using indexes in a database.
•	Pros - indexes allow for faster searching process.
•	Cons - take up more space as each index must be generated and stored. 
Indices should be used for big tables only (e.g. 50 000 rows)
9.	What's the main purpose of the SQL language?
•	Purpose of SQL Language is to provide a Structured way by which one can Query information in database using a standard Language.
10.	What are transactions used for?
Transactions are a sequence of database operations which are executed as a single unit. Either all of them execute successfully. Or none of them is executed at all.
11.	What is a NoSQL database?
NoSQL databases are non-relational. That means that they use document-based model (non-relational) not tables. 
12.	Explain the classical non-relational data models.

13.	Give few examples of NoSQL databases and their pros and cons.

