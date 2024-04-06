using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class Employee
    {
        int Eno;
        double Salary;
        string Ename, Job, Dname, Location;

        public Employee(int Eno, double Salary, string Ename, string Job, string Dname, string Location)
        {
            this.Eno = Eno;
            this.Salary = Salary;
            this.Ename = Ename;
            this.Job = Job;
            this.Dname = Dname;
            this.Location = Location;
        }

        public object this[int index]
        {
            get
            {

                if (index == 1)
                {
                    return Eno;
                }

                else if (index == 2)
                {
                    return Salary;

                }

                else if (index == 3)
                {
                    return Ename;
                }

                else if (index == 4)
                {
                    return Location;
                }

                else if (index == 5)
                {
                    return Job;
                }


                else if (index == 6)
                {
                    return Dname;
                }

                return null;

            }
            set {

                if (index == 1)
                {
                    Eno = (int)value;
                }

                else if (index == 2)
                {
                    Salary = (double)value;

                }

                else if (index == 3)
                {
                    Ename = (string)value;
                }


                else if (index == 6)
                {
                     Dname = (string)value;
                }


            }
        }

        public object this[string str]
        {
            get
            {

                if (str.ToUpper() == "ENO")
                {
                    return Eno;
                }

                else if (str.ToUpper() == "SALARY")
                {
                    return Salary;

                }

                else if (str.ToUpper() == "ENAME")
                {
                    return Ename;
                }

                else if (str.ToUpper() == "LOCATION")
                {
                    return Location;
                }

                else if (str.ToUpper() == "JOB")
                {
                    return Job;
                }


                else if (str.ToUpper() == "DNAME")
                {
                    return Dname;
                }

                return null;
 
            }
            set
            {

                if (str.ToLower() == "eno")
                {
                    Eno = (int)value;
                }

                else if (str.ToLower() == "salary")
                {
                    Salary = (double)value;

                }

                else if (str.ToUpper() == "ENAME")
                {
                    Ename = (string)value;
                }


                else if (str.ToUpper() == "DNAME")
                {
                    Dname = (string)value;
                }


            }
        }
    }
}
