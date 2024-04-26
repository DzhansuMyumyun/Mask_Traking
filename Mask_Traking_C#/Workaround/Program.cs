// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    class Program
    {

        static void Main(string[] args)
        {

            Person person = new Person();
            person.Nationality = 123;
            person.Firstname = "Zehra";
            person.Lastname = "Myumyun";
            person.DateOfBirthYear = 098789;

            Console.WriteLine(person.Firstname);

            PttManager pttManager = new PttManager(new PersonManager ());
            pttManager.GiveMask(person);

        }
        
    }

}