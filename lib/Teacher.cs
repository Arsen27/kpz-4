using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    public class Teacher : People
    {
        private String position;
        private String chair;
        private String teachingPlace;

        public Teacher() 
        {
        }

        public Teacher(People people, String position, String chair, String teachingPlace) 
            : base(people.getName(), people.getLastName(), people.getBirthday())
        {
            this.position = position;
            this.chair = chair;
            this.teachingPlace = teachingPlace;
        }

        public Teacher(String name, String lastName, String birthday, String position, String chir, String teachingPlace) 
            : base(name, lastName, birthday)
        {
            this.position = position;
            this.chair = chair;
            this.teachingPlace = teachingPlace;
        }

        public Teacher(Teacher prevTeacher)
        {   
            this.position = prevTeacher.getPosition();
            this.chair = prevTeacher.getChair();
            this.teachingPlace = prevTeacher.getTeachingPlace();
        }


        public override void showInfo() 
        {
            Console.WriteLine(position);
            Console.WriteLine(chair);
            Console.WriteLine(teachingPlace);
        }


        // Getters
        public String getPosition() 
        {
            return position;
        }

        public String getChair() 
        {
            return chair;
        }

        public String getTeachingPlace() 
        {
            return teachingPlace;
        }


        // Setters
        public void setPosition(String position) 
        {
            this.position = position;
        }

        public void setChair(String chair) 
        {
            this.chair = chair;
        }

        public void setTeachingPlace(String teachingPlace) 
        {
            this.teachingPlace = teachingPlace;
        }
    }
}
