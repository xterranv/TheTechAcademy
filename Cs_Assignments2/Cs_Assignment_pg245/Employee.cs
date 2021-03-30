using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Assignment_pg245
{
    public class Employee : Person, IQuittable
    {
        //Properties
        public int EmpID { get; set; }

        public override void SayName()
        {
            base.SayName();
        }

        public virtual void GetID()
        {
            Console.WriteLine($"Employee ID: {EmpID}");
        }

        public void Quit()
        {
            SayName();
            Console.WriteLine("Employee Quit Notice received");
        }

        //OVERLOAD THE == OPERATOR TO COMPARE EMPLOYEE ID VALUES
        public static bool operator == (Employee id1, Employee id2)
        {
            bool status = false;
            if (id1.EmpID == id2.EmpID)
            {
                status = true;
            }
            return status;
        }

        public static bool operator != (Employee id1, Employee id2)
        {
            bool status = false;
            if (id1.EmpID == id2.EmpID)
            {
                status = true;
            }
            return status;
        }
    }
}
