using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    public class LibraryUser : People
    {
        private int ticket;
        private String issueDate;
        private int monthlyPayment;

        public LibraryUser() 
        {
        }

        public LibraryUser(Student student, int ticket, String issueDate, int monthlyPayment) 
            : base(student.getName(), student.getLastName(), student.getBirthday())
        {
            this.ticket = ticket;
            this.issueDate = issueDate;
            this.monthlyPayment = monthlyPayment;
        }

        public LibraryUser(String name, String lastName, String birthday, int ticket, String issueDate, int monthlyPayment) 
            : base(name, lastName, birthday)
        {
            this.ticket = ticket;
            this.issueDate = issueDate;
            this.monthlyPayment = monthlyPayment;
        }

        public LibraryUser(LibraryUser prevLibraryUser) 
        {
            this.ticket = prevLibraryUser.getTicket();
            this.issueDate = prevLibraryUser.getIssueDate();
            this.monthlyPayment = prevLibraryUser.getMonthlyPayment();   
        }


        public override void showInfo() 
        {
            Console.WriteLine(ticket);
            Console.WriteLine(issueDate);
            Console.WriteLine(monthlyPayment);
        }


        // Getters
        public int getTicket() 
        {
            return ticket;
        }

        public String getIssueDate() 
        {
            return issueDate;
        }

        public int getMonthlyPayment() 
        {
            return monthlyPayment;
        }

        // Setters
        public void setTicket(int ticket) 
        {
            this.ticket = ticket;
        }

        public void setIssueDate(String issueDate) 
        {
            this.issueDate = issueDate;
        }

        public void setMonthlyPayment(int monthlyPayment) 
        {
            this.monthlyPayment = monthlyPayment;
        }
    }
}
