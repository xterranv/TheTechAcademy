using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Assignment_pg248
{
    interface IQuittable
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        void Quit();
    }
}
