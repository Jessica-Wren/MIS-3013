using System;
using System.Diagnostics.SymbolStore;
using System.IO;

namespace ProcessingACSVFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\jessi\Downloads\sales_data_sample.csv";

            string[] lines = File.ReadAllLines(filePath);

            //ORDERNUMBER,QUANTITYORDERED,PRICEEACH,ORDERLINENUMBER,SALES,ORDERDATE,STATUS,QTR_ID,MONTH_ID,YEAR_ID,PRODUCTLINE,MSRP,PRODUCTCODE,CUSTOMERNAME,PHONE,ADDRESSLINE1,ADDRESSLINE2,CITY,STATE,POSTALCODE,COUNTRY,TERRITORY,CONTACTLASTNAME,CONTACTFIRSTNAME,DEALSIZE
            /*
             * Sales = 4
             * Satus = 6 
             * Month = 8
             * Year = 9 
             */
            double sum = 0;
            double sumFor2003 = 0;
            double sumFor2004 = 0;
            double sumFor2005 = 0;
            double sumForJan = 0;
            double sumForFeb = 0;
            double sumForMar = 0;
            double sumForApril = 0;
            double sumForMay = 0;
            double sumForJune = 0;
            double sumForJuly = 0;
            double sumForAug = 0;
            double sumForSept = 0;
            double sumForOct = 0;
            double sumForNov = 0;
            double sumForDec = 0;

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] pieces = line.Split(',');
                // sum = sum + Convert.ToDouble(pieces[4]);
                double sale = Convert.ToDouble(pieces[4]);
                string year = pieces[9];
                string month = pieces[8];
                if (pieces[6].Trim().ToLower() == "shipped")
                {
                    if (year == "2003")
                    {
                        sumFor2003 += sale;
                    }
                    else if (year == "2004")
                    {
                        sumFor2004 += sale;
                    }
                    else
                    {
                        sumFor2005 += sale;
                    }
                    //MONTHS
                    if (month == "1")
                    {
                        sumForJan += sale;
                    }
                    else if (month == "2")
                    {
                        sumForFeb += sale;
                    }
                    else if (month == "3")
                    {
                        sumForMar += sale;
                    }
                    else if (month == "4")
                    {
                        sumForApril += sale;
                    }
                    else if (month == "5")
                    {
                        sumForMay += sale;
                    }
                    else if (month == "6")
                    {
                        sumForJune += sale;
                    }
                    else if (month == "7")
                    {
                        sumForJuly += sale;
                    }
                    else if (month == "8")
                    {
                        sumForAug += sale;
                    }
                    else if (month == "9")
                    {
                        sumForSept += sale;
                    }
                    else if (month == "10")
                    {
                        sumForOct += sale;
                    }
                    else if (month == "11")
                    {
                        sumForNov += sale;
                    }
                    else
                    {
                        sumForDec += sale;
                    }

                    sum += sale;
                }

            }

            Console.WriteLine("Total sales of shipped orders in 2003 is " + sumFor2003.ToString("C2") + ".");
            Console.WriteLine("Total sales of shipped orders in 2004 is " + sumFor2004.ToString("C2") + ".");
            Console.WriteLine("Total sales of shipped orders in 2005 is " + sumFor2005.ToString("C2") + ".");
            Console.WriteLine();
            Console.WriteLine("Total sales of shipped orders in January 2003, 2004, and 2005 is " + sumForJan.ToString("C2") + ".");
            Console.WriteLine("Total sales of shipped orders in February 2003, 2004, and 2005 is " + sumForFeb.ToString("C2") + ".");
            Console.WriteLine("Total sales of shipped orders in March 2003, 2004, and 2005 is " + sumForMar.ToString("C2") + ".");
            Console.WriteLine("Total sales of shipped orders in April 2003, 2004, and 2005 is " + sumForApril.ToString("C2") + ".");
            Console.WriteLine("Total sales of shipped orders in May 2003, 2004, and 2005 is " + sumForMay.ToString("C2") + ".");
            Console.WriteLine("Total sales of shipped orders in June 2003, 2004, and 2005 is " + sumForJune.ToString("C2") + ".");
            Console.WriteLine("Total sales of shipped orders in July 2003, 2004, and 2005 is " + sumForJuly.ToString("C2") + ".");
            Console.WriteLine("Total sales of shipped orders in August 2003, 2004, and 2005 is " + sumForAug.ToString("C2") + ".");
            Console.WriteLine("Total sales of shipped orders in September 2003, 2004, and 2005 is " + sumForSept.ToString("C2") + ".");
            Console.WriteLine("Total sales of shipped orders in October 2003, 2004, and 2005 is " + sumForOct.ToString("C2") + ".");
            Console.WriteLine("Total sales of shipped orders in Novemeber 2003, 2004, and 2005 is " + sumForNov.ToString("C2") + ".");
            Console.WriteLine("Total sales of shipped orders in December 2003, 2004, and 2005 is " + sumForDec.ToString("C2") + ".");
            Console.WriteLine();
            Console.WriteLine("Total sales of shipped orders in is " + sum.ToString("C2") + ".");


            Console.ReadKey();
        }
    }
}
