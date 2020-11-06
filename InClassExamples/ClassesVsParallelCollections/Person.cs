using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;

namespace ClassesVsParallelCollections
{
    public class Person
    {

        public string FirstName { get; set; }
        public string LastName {get; set;}
        public string DateOfBirth {get; set;}
        public string FavoriteFood {get; set;}
        public double AccountBalance {get; set;}
        //if its private then you do not need get and set

        //constructor (ctor tab tab) basically sets all the starting values. 
        //It is basically a method that has two things about it. 
        //1: the name of the constuctor is the same name as the class (person). 2. no return type
        public Person()
        {
            //Bones Way
            //This is like building a foundation for house. We build rooms and walls, but we arent choosing colors are finishes.
            FirstName = string.Empty;
            LastName = string.Empty;
            DateOfBirth = string.Empty;
            FavoriteFood = string.Empty;
            AccountBalance = 0;
        }

            //Short way (when you know the imputs)

           public Person (string fname, string lname, string dob, string food, double bal) 
           {
            FirstName = fname;
            LastName = lname;
            DateOfBirth = dob;
            FavoriteFood = food;
            AccountBalance = bal;
            }


        //We are doing this one bc otherwise the console looks weird. 
        //So we are telling the console that these conplex data types are all strings even tho there is a double in there.
        public override string ToString()
        {
            string output = (FirstName +  " " + LastName + " " + DateOfBirth + " likes " + FavoriteFood + " and has an account balance of " + AccountBalance.ToString("C"));
            return output;
        }


    }  

    }

