using InterviewApp;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        //Hello vicky. this is eneas
        //Candidate candidates = new Candidate();
        //string picked_candidate = candidates.RandomPick();
        //Interviewer myinterviewer = new Interviewer();
        //myinterviewer.WelcomeCandidate(picked_candidate);

        //candidates.PrintCandidateNames();
        OldestorYoungest("YOUNGEST");
        Sex("Female");

    }
    public static void OldestorYoungest(string? kritirio)
    {
        Seeding s1 = new Seeding();
        Person[] arr = s1.People();
        if (kritirio?.ToUpper() == "OLDEST")
        {

            DateTime oldest = DateTime.Now;
            for (int i = 0; i < arr.Length; i++)
            {
                int compare = DateTime.Compare(oldest, arr[i].DateOfBirth);
                if (compare > 0)
                {
                    oldest = arr[i].DateOfBirth;
                }
            }
        }
        else if (kritirio?.ToUpper() == "YOUNGEST")
        {
            DateTime youngest = arr[0].DateOfBirth;
            for (int i = 0; i < arr.Length; i++)
            {
                int compare = DateTime.Compare(youngest, arr[i].DateOfBirth);
                if (compare < 0)
                {
                    youngest = arr[i].DateOfBirth;
                }
            }
            Console.WriteLine(youngest);
        }

    }
    public static List<Person> Sex(string? fulo)
    {
        Seeding s1 = new Seeding();
        Person[] arr = s1.People();
        List<Person> Men = new List<Person>();
        List<Person> Women = new List<Person>();

        for (int i = 0; i < arr.Length; i++)
        {

            if (arr[i].PersnosSex == 0)
            {
                Men.Add(arr[i]);
            }
            else
            {
                Women.Add(arr[i]);
            }



        }
        if (fulo=="Male")
        {
            return  Men;
        }
        else 
        {
            return Women;
        }



    }
}
  

