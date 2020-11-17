using System;

namespace Lib
{
    public class People
    {
        private String name;
        private String lastName;
        private String birthday;

        public People() 
        { 
        }

        public People(String name, String lastName) {
            this.name = name;
            this.lastName = lastName;
        }   

        public People(String name, String lastName, String birthday) 
        {
            this.name = name;
            this.lastName = lastName;
            this.birthday = birthday;
        }

        public People(People prevPeople) 
        {
            this.name = prevPeople.getName();
            this.lastName = prevPeople.getLastName();
            this.birthday = prevPeople.getBirthday();
        }


        public virtual void showInfo() 
        {
            Console.WriteLine(name);
            Console.WriteLine(lastName);    
            Console.WriteLine(birthday);    
        }

        // Getters
        public String getName() 
        {
            return name;
        }

        public String getLastName() 
        {
            return lastName;
        }

        public String getBirthday() 
        {
            return birthday;
        }

        // Setters
        public void setName(String name) 
        {
            this.name = name;
        }

        public void setLastName(String lastName)
        {
            this.lastName = lastName;
        }

        public void setBirthday(String birthday) 
        {
            this.birthday = birthday;
        }
    }
}
