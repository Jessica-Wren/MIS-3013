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
            // CustomerID = position 0, FirstName is position 1

            List<Customer> customers = new List<Customer>();



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
                    // reading one row at a time to get a value
                    while (reader.Read())
                    {
                        int customerId = reader.GetInt32(0);    //customerID is at position 0; we listed it first in the select statement
                        string firstName = reader.GetString(1);
                        string lastName = reader.GetString(2); 
                        string email = reader.GetString(3);
                        string gender = reader.GetString(4);
                        string address = reader.GetString(5);
                        string city = reader.GetString(6);
                        string state = reader.GetString(7);
                        string zipCode = reader.GetString(8);

                        Customer newCustomer = new Customer(customerId, firstName, lastName, email, gender, address, city, state, zipCode);
                        customers.Add(newCustomer);

                       // Console.WriteLine($"{firstName} {lastName} ({customerId}) - {email} {gender} \n{address} \n{city}, {state} {zipCode}\n");
                    }
                }
            }

            Console.WriteLine("All of our customers: ");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }

            Console.WriteLine("All customers from the state of oklahoma: ");
            foreach (var customer in customers)
            {
                if (customer.State.ToLower() == "oklahoma")
                {
                    Console.WriteLine(customer);
                }
                
            }

            Console.ReadKey();
        }
    }
}
