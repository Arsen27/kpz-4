using System;
using Lib;

namespace kpz_4
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People("Arsen", "Palamarchuk", "14-06-2002");
            people.showInfo();

            Entrant entrant = new Entrant(people, 10, 10, "№4");
            entrant.showInfo();
            
            Student student = new Student(people, 4, "P-41", "Software ingeneering", "Politechnic College");
            student.showInfo();
            
            Teacher teacher = new Teacher("Petro", "Petrovych", "10-10-1970", "Teacher", "Computer Science", "Politechnic College");
            teacher.showInfo();

            LibraryUser user = new LibraryUser(student, 11012034, "11-09-2017", 100);
            user.showInfo();
        }
    }
}
