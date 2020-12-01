using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                                                         //12/1/2020
                                                                         //18:00
                                                                         //30:50
namespace Database_SqlClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------ NEED FRAMEWORK ---------------------------------------------

            string connectionString = "Data Source = tcp:s13.winhost.com; Initial Catalog = DB_128040_practice; User ID = student; Password = AdamTheGreat2020; Integrated Security = False;";

            //Making a a select statement
            string queryString = "SELECT CustomerID, FirstName, LastName, Email, Gender, Address, City, State, ZipCode " +
                                   " FROM CUSTOMER "; 

                                                 //SqlConnection is a class and we are creating an instance of it to connect to our SQL server DB
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                //our object                                  // our query , our connection
                command.Connection.Open();
                //opening our object

                
                                              //Execute our querery we wrote on the connection we have open
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // reading one row at a time
                    while (reader.Read())
                    {

                    }
                }
            }

            Console.ReadKey();
        }
    }
}
