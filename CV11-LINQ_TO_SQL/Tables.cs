using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV11_LINQ_TO_SQL
{
    class Tables
    {
        public SchoolDataContext db;

        public Tables(SchoolDataContext dB)
        {
            db = dB;
        }

        public void AddStudent(string firstName, string surName, DateTime dateOfBirth, int iD)
        {
            if ((from i in db.Students select i.ID).Contains(iD))
            {
                return;
            }

            Student stud = new Student()
            {
                FirstName = firstName,
                SurName = surName,
                DateOfBirth = dateOfBirth,
                ID = iD
            };

            db.Students.InsertOnSubmit(stud);
        }

        public void AddSubject(string shortage, string subName)
        {
            if ((from i in db.Subjects select i.Shortage).Contains(shortage))
            {
                return;
            }

            Subject sub = new Subject()
            {
                Shortage = shortage,
                SubName = subName
            };

            db.Subjects.InsertOnSubmit(sub);
        }

        public void AddSignedSubject(int personSub, int iD, string shortage)
        {
            if ((from i in db.SignedSubjects select i.PersonSub).Contains(personSub))
            {
                return;
            }

            if ((from i in db.Students select i.ID).Contains(iD) && (from i in db.Subjects select i.Shortage).Contains(shortage))
            {
                SignedSubject signedSub = new SignedSubject()
                {
                    PersonSub = personSub,
                    ID = iD,
                    Shortage = shortage
                };

                db.SignedSubjects.InsertOnSubmit(signedSub);
            }         
        }

        public void AddRating(int personSub, DateTime dateOfRate, double rating)
        {
            if ((from i in db.SignedSubjects select i.PersonSub).Contains(personSub) && 1 <= rating  && rating <= 5)
            {
                Rating rate = new Rating()
                {
                    PersonSub = personSub,
                    DateofRate = dateOfRate,
                    Rating1 = rating
                };

                db.Ratings.InsertOnSubmit(rate);
            }       
        }

        public void PrintViewOfQuantities()
        {
            IEnumerable<Quantity> query = db.Quantities.OrderByDescending(sub => sub.NumOfStudents);

            Console.WriteLine("\nView predmetov s poctom studentov:");
            foreach(Quantity sub in query)
            {
                Console.WriteLine(sub.Shortage + ": " + sub.NumOfStudents);
            }
            
        }

        public IEnumerable<Student> StudentsOfSubject(string subject)
        {
            return db.SignedSubjects.Where(q => q.Shortage == subject).Select(s => s.Student);
        }

        public void PrintStudentsOfSubject(string shortage)
        {
            Console.WriteLine("\nStudenti so zapisanym predmetom " + shortage + ":");
            foreach (Student stud in StudentsOfSubject(shortage))
            {
                Console.WriteLine(stud.FirstName + " " + stud.SurName);
            }
        }

        public IEnumerable<Subject> SubjectsOfStudent(int iD)
        {
            return db.SignedSubjects.Where(q => q.ID == iD).Select(s => s.Subject);
        }

        public void PrintSubjectsOfStudent(int iD)
        {
            Console.WriteLine("\nPredmety zapisane studentom s ID = " + iD + ":");
            foreach (Subject sub in SubjectsOfStudent(iD))
            {
                Console.WriteLine(sub.Shortage);
            }
        }
    }
}
