using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    public class Student : People
    {
        private int course;
        private String group;
        private String faculty;
        private String studyingPlace;

        public Student() 
        {
        }

        public Student(People people, int course, String group, String faculty, String stydyingPlace)
            : base(people.getName(), people.getLastName(), people.getBirthday())
        {    
            this.course = course;
            this.group = group;
            this.faculty = faculty;
            this.studyingPlace = studyingPlace;   
        }

        public Student(String name, String lastName, String birthday, int course, String group, String faculty, String studyingPlace) 
            : base(name, lastName, birthday)
        {
            this.course = course;
            this.group = group;
            this.faculty = faculty;
            this.studyingPlace = studyingPlace;    
        }
    
        public Student(Student prevStudent) 
        {
            this.course = prevStudent.getCourse();
            this.group = prevStudent.getGroup();
            this.faculty = prevStudent.getFaculty();
            this.studyingPlace = prevStudent.getStudyingPlace(); 
        }


        public override void showInfo() 
        {
            Console.WriteLine(course);
            Console.WriteLine(group);
            Console.WriteLine(faculty);
            Console.WriteLine(studyingPlace);
        }

        
        // Getters 
        public int getCourse() 
        {
            return course;
        }

        public String getGroup() 
        {
            return group;
        }

        public String getFaculty() 
        {
            return faculty;
        }

        public String getStudyingPlace() 
        {
            return studyingPlace;
        }

        // Setters
        public void setCourse(int course) 
        {
            this.course = course;
        }

        public void setGroup(String group) 
        {
            this.group = group;
        }

        public void setFaculty (String faculty) 
        {
            this.faculty = faculty;
        }

        public void setStudyingPlace(String studyingPlace) 
        {
            this.studyingPlace = studyingPlace;
        }
    }
}
