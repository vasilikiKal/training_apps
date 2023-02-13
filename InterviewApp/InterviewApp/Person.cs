using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewApp
{
    public class Person
    {
        public enum Sex{ Male,Female };
       
        public string Name;
        public string LastName;
        public DateTime DateOfBirth;
         
        public Sex PersnosSex;
        public double Weight;
        public double Height;
        public string Nationality;
        public Person(string name, string lastName, DateTime dateOfBirth, Sex sex, double weight, double height, string nationality)
        {
            Name = name;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            PersnosSex = sex;
            Weight = weight;
            Height = height;
            Nationality = nationality;
        }
  
      
       
    }
}
