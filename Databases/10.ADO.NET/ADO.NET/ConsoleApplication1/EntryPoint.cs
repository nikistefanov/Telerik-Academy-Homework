namespace MSSQL
{
    using System;
    using System.Data.SqlClient;
    using System.IO;

    public class EntryPoint
    {
        internal static void Main()
        {
            const string ConnectionString = "Server=.\\SQLEXPRESS; Database = Northwind; Integrated Security=true";

            SqlConnection databaseConnection = new SqlConnection(ConnectionString);

            databaseConnection.Open();

            using (databaseConnection)
            {
                // 1.Write a program that retrieves from the Northwind sample database in MS SQL Server the number of rows in the Categories table.
                var numberOfRows = GetNumberOfRowsInCategoriesTable(databaseConnection);
                Console.WriteLine("The rows in Categories table are: {0}", numberOfRows);

                // 2.Write a program that retrieves the name and description of all categories in the Northwind DB.
                Console.WriteLine(new string('*', 30));
               GetNameAndDescriptionInCategoriesTable(databaseConnection);

                // 3.Write a program that retrieves from the Northwind database all product categories and the names of the products in each category.
                // Can you do this with a single SQL query (with table join)?
                Console.WriteLine(new string('*', 30));
                GetAllProductCategoriesAndProducts(databaseConnection);

                // 4.Write a method that adds a new product in the products table in the Northwind database.
                //  Use a parameterized SQL command.
                Console.WriteLine(new string('*', 30));
                AddProduct(ConnectionString);

                // 5.Write a program that retrieves the images for all categories in the Northwind database and stores them as JPG files in the file system.
                Console.WriteLine(new string('*', 30));
                GetImagesFromCategories(databaseConnection);
            }
        }

        private static int GetNumberOfRowsInCategoriesTable(SqlConnection databaseConn)
        {
            string sqlCommand = @"
            SELECT COUNT(*)
            FROM Categories";

            SqlCommand cmdCount = new SqlCommand(sqlCommand, databaseConn);

            return (int)cmdCount.ExecuteScalar();
        }

        private static void GetNameAndDescriptionInCategoriesTable(SqlConnection databaseConn)
        {
            string sqlCommand =
                "SELECT [CategoryName],[Description] FROM Categories";

            SqlCommand allNames = new SqlCommand(sqlCommand, databaseConn);
            SqlDataReader reader = allNames.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    string categoryName = (string)reader["CategoryName"];
                    string description = (string)reader["Description"];
                    Console.WriteLine("{0} : {1}", categoryName, description);
                }
            }
        }

        private static void GetAllProductCategoriesAndProducts(SqlConnection databaseConn)
        {
            string sqlCommand = @"
                    SELECT c.CategoryName, p.ProductName
                    FROM Categories c
                    JOIN Products p
                    ON c.CategoryID=p.CategoryID
                    ORDER BY c.CategoryName";

            SqlCommand allProductCategories = new SqlCommand(sqlCommand, databaseConn);
            SqlDataReader reader = allProductCategories.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    string categoryName = (string)reader["CategoryName"];
                    string productName = (string)reader["ProductName"];
                    Console.WriteLine("{0} : {1}", categoryName, productName);
                }
            }
        }

        private static void AddProduct(string connectionString)
        {
            SqlConnection databaseConn = new SqlConnection(connectionString);
            databaseConn.Open();

            using (databaseConn)
            {
                SqlCommand command = new SqlCommand(
                    @"INSERT INTO Products 
                    (ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued)
                    VALUES
                    (@name,@supplierId,@categoryId,@quantityPerUnit,@unitPrice,@unitInStock,@unitsOnOrder,@recordLevel,@discontinued)", 
                    databaseConn);

                command.Parameters.AddWithValue("@name", "Boza");
                command.Parameters.AddWithValue("@supplierId", 2);
                command.Parameters.AddWithValue("@categoryId", 2);
                command.Parameters.AddWithValue("@quantityPerUnit", "10 boxes");
                command.Parameters.AddWithValue("@unitPrice", 2.5);
                command.Parameters.AddWithValue("@unitInStock", 100);
                command.Parameters.AddWithValue("@unitsOnOrder", 20);
                command.Parameters.AddWithValue("@recordLevel", 13);
                command.Parameters.AddWithValue("@discontinued", 0);

                command.ExecuteNonQuery();
                Console.WriteLine("The product has been added!");
            }
        }

        private static void GetImagesFromCategories(SqlConnection databaseConnection)
        {
            string sqlStringCommand =
                "SELECT CategoryName, Picture FROM Categories";

            SqlCommand allPictures = new SqlCommand(sqlStringCommand, databaseConnection);
            SqlDataReader reader = allPictures.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    string categoryName = (string)reader["CategoryName"];
                    categoryName = categoryName.Replace('/', '_');
                    byte[] fileContent = (byte[])reader["Picture"];
                    string fileName = string.Format(@"..\..\images\{0}.jpg", categoryName);

                    WriteBinaryFile(fileName, fileContent);
                }
                Console.WriteLine("Pictures stored!");
            }
        }

        private static void WriteBinaryFile(string fileName, byte[] fileContents)
        {
            FileStream stream = File.OpenWrite(fileName);
            using (stream)
            {
                stream.Write(fileContents, 78, fileContents.Length - 78);
            }
        }
    }
}
