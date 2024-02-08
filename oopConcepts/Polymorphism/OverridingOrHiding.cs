using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class OverridingOrHiding
    {
        public virtual void Test1()
        {
            Console.WriteLine("Parent class");
        }
        public void Test2() {

            Console.WriteLine("Parent class");
        }
    }

   internal  class class5 : OverridingOrHiding
    {
        public override void Test1()
        {
            Console.WriteLine("Child class overriding");
        }
        public new void Test2()
        {
            Console.WriteLine("Child class shadow");
        }

        public static void Main()
        {
            OverridingOrHiding P1;
            class5 c = new class5();
            P1 = c;
            //same 
            OverridingOrHiding P2 = new class5 ();

            P1.Test1 (); // child class method print but it need to be print parent class method
            P1.Test2 ();
            P2.Test1 (); // child class method print but it need to be print parent class method
            P2.Test2 ();

        }
    }

}




// A parent class reference even if created by using the child class instance can't access any members that are purely defined under the child class but can call overridden members of child class, because overridden members are not considered as pure child class members, but members which are re-implemented by using the approach of hiding are considered as pure child class members and not accessible to parent's references.
