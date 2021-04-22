using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV11_LINQ_TO_SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolDataContext db = new SchoolDataContext();
            Tables tab = new Tables(db);

            tab.AddStudent("Karol", "Hnedy", new DateTime(1987, 2, 2), 7);
            tab.AddSubject("BPC-EL1", "Matematika 1");
            tab.AddSignedSubject(109, 7, "BPC-EL1");
            tab.AddRating(109, new DateTime(2020, 7, 8), 3.2);

            tab.db.SubmitChanges();

            tab.PrintViewOfQuantities();

            tab.PrintStudentsOfSubject("BPC-OOP");

            tab.PrintSubjectsOfStudent(1);

            Console.ReadLine();
        }
    }
}
