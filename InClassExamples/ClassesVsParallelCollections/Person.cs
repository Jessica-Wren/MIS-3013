using System;
using System.Collections.Generic;
using System.Text;

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

        //constructor (ctor tab tab) is basically a method that has two things about it. 1: the name of the constuctor is the same name as the class (person). 2. no return type
        public Person()
        {

        }

    }
}
