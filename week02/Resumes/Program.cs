using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Hewlett-Packard";
        job1._jobTitle = "Manufacturing Development Engineer";
        job1._startYear = 1996;
        job1._endYear = 2000;

        Job job2 = new Job();
        job2._company = "Agilent Technologies";
        job2._jobTitle = "Packaging Project Engineer";
        job2._startYear = 2000;
        job2._endYear = 2001;

        Resume resume1 = new Resume();
        resume1._name = "Pam Christison";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayResume();

    }
}