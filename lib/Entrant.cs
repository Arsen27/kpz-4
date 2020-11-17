using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    public class Entrant : People
    {
        private int ZNOPoints;
        private int documentPoints;
        private String schoolName;

        public Entrant() 
        {
        }

        public Entrant(People people, int ZNOPoints, int documentPoints, String schoolName) 
            : base(people.getName(), people.getLastName(), people.getBirthday())
        {
            this.ZNOPoints = ZNOPoints;
            this.documentPoints = documentPoints;
            this.schoolName = schoolName;
        }

        public Entrant(String name, String lastName, string birthday, int ZNOPoints, int documentPoints, String schoolName) 
            : base(name, lastName, birthday)
        {
            this.ZNOPoints = ZNOPoints;
            this.documentPoints = documentPoints;
            this.schoolName = schoolName;
        }

        public Entrant(Entrant prevEntrant) 
        {
            this.ZNOPoints = prevEntrant.getZNOPoints();
            this.documentPoints = prevEntrant.getDocumentPoints();
            this.schoolName = prevEntrant.getSchoolName();
        }


        public override void showInfo() 
        {
            Console.WriteLine(ZNOPoints);
            Console.WriteLine(documentPoints);
            Console.WriteLine(schoolName);
        }


        // Getters
        public int getZNOPoints() 
        {
            return ZNOPoints;
        }

        public int getDocumentPoints() 
        {
            return documentPoints;
        }

        public String getSchoolName() 
        {
            return schoolName;
        }


        // Setters
        public void setZNOPoints(int ZNOPoints) {
            this.ZNOPoints = ZNOPoints;
        }

        public void setDocumentPoints(int documentPoints) {
            this.documentPoints = documentPoints;
        }

        public void setZNOPoints(String schoolName) {
            this.schoolName = schoolName;
        }
    }
}
