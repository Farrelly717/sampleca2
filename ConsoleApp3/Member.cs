using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Member
    {
        //properties(take out set to make readonly)
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string MemberID { get; set; }
        public string Membershipstatus { get; set; }
        public decimal Price { get; }

        public static int MemberCount { get; set; }
        //Constructors
        public Member(string firstname, string lastname, int age, string memberID)
        {
            FirstName = firstname;
        
            LastName = lastname;
            Age = age;
            MemberID = memberID;

            Membershipstatus = "Expired";
            if (age < 18)
                Price = 50m;
            else
                Price = 150m;
            MemberCount++;
        }

        //Methods
        public override string ToString()
        {
            return string.Format("Firstname: {0} Surname: {1} Age: {2} ID: {3} Status: {4} Price: {5}",
            FirstName, LastName,Age,MemberID,Membershipstatus, Price);
        }
        //change status of a member
        public void ChangeStatus()
        {
            //if status is expired change to current

            if (Membershipstatus == "Expired")
                Membershipstatus = "Current";
            //if current change to expired
            else
                Membershipstatus = "Expired";

           

            //end of method
        }
    }
}
