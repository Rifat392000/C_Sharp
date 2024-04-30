using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class StudentDataSort : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            if (x.Marks > y.Marks)
            {

                return 1;
            }
            else if (x.Marks < y.Marks) return -1;

            return 0;
        }
    }
}
