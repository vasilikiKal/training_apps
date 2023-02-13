using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InterviewApp
{
    public class Seeding
    {
        public Person[] People()
        {
            Person p1 = new Person("Vasiliki", "Kalantzi", new DateTime(1993, 06, 01), Person.Sex.Female, 63.7, 1.60, "greek");
            Person p2 = new Person("Fotis", "Kalantzis", new DateTime(1957, 11, 30), Person.Sex.Male, 73.7, 1.65, "greek");
            Person p3 = new Person("Chris", "Hesmworth", new DateTime(1983, 09, 11), Person.Sex.Male, 85.700, 1.90, "australian");
            Person p4 = new Person("Emanuel", "Sentpeteri", new DateTime(1990, 07, 13), Person.Sex.Male, 63.7, 1.74, "romanian");
            Person p5 = new Person("Eleonora", "Sica", new DateTime(1997, 07, 23), Person.Sex.Female, 65.7, 1.72, "italian");
            Person p6 = new Person("Dimitra", "Kalantzi", new DateTime(1996, 03, 27), Person.Sex.Female, 53.7, 1.60, "greek");
            Person p7 = new Person("Zion", "Imaginary", new DateTime(1996, 03, 07), Person.Sex.Male, 73.8, 1.87, "american");
            Person p8 = new Person("Sara", "Mara", new DateTime(1996, 05, 17), Person.Sex.Female, 55.8, 1.7, "finish");
            Person p9 = new Person("Alex", "Macovei", new DateTime(1988, 05, 17), Person.Sex.Male, 79, 1.75, "romanian");
            Person p10 = new Person("Alexandra", "Ferentinou", new DateTime(1950, 08, 12), Person.Sex.Female, 82, 1.57, "greek");
           Person[] People = { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10 };
            return People;
        }

    }
}
