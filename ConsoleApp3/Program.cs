using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Membertest1
    {
        static void Main(string[] args)
        {
            {
                Member m1 = new Member("Joe", "Smith", 21, "1234s");
                Member m2 = new Member("Jane", "Smith", 41, "321A");
                Member m3 = new Member("Jim", "Smith", 45, "4568A");
                Member m4 = new Member("Janice", "Smith", 12, "4568C");
                Member m5 = new Member("John", "Smith", 61, "8952Snr");

                Member[] allMembers = new Member[5];
                allMembers[0] = m1;
                allMembers[1] = m2;
                allMembers[2] = m3;
                allMembers[3] = m4;
                allMembers[4] = m5;

                DisplayMembers(allMembers);

                m1.ChangeStatus();
                m3.ChangeStatus();
                Console.WriteLine();
                DisplayMembers(allMembers);
                Console.WriteLine("The total amount of members are:{0}",Member.MemberCount);
            }
            
        }
        static void DisplayMembers(Member[] allmembers)
        {
            foreach (Member m in allmembers)
            {
                Console.WriteLine(m);
            }
        }
    }
}
