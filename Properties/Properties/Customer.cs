using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Customer
    {
        int _Cid;
        bool _Status;
        string _Name;
        double _Balance;
        string _State;
        

      internal  Customer(int Cid, bool Status, string Name, double Balance, Cities City, string State)
        {
            _Cid = Cid;
            _Status = Status;
            _Name = Name;
            _Balance = Balance;
            this.City = City;
            _State = State;
        }

        internal int Cid
        {
            get { return _Cid; }

        }

        internal string Name { get { return _Name; } }

        internal bool Status
        {
            get { return _Status; }

            set { _Status = value; 
            //value is a implicit variable that provides access to the value assign by the user
            }
        }

        internal double balance
        {
            get { return _Balance; }

            set
            {
                if (_Status == true)
                {

                    if (value > 1000)
                    {
                        _Balance = value;
                    }
                }

            }

        }

        internal Cities City { get; set; } //Auto implemented property


        public string State
        {
            get { return _State; }

           protected set { _State = value; }
        }

        public string Country
        {
            get; } = "Japan";
    }
}
