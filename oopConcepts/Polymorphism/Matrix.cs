using System;
namespace Polymorphism
{
    internal class Matrix : Object
    {
        int a,b,c,d;
        
        public Matrix(int a,int b,int c, int d) { 
        
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        // Overloaded + Operator
        public static Matrix operator +(Matrix obj1,Matrix obj2)
        {
            Matrix obj = new Matrix(obj1.a + obj2.a, obj1.b + obj2.b, obj1.c + obj2.c, obj1.d + obj2.d);
            return obj;
        }

        public static Matrix operator -(Matrix obj1, Matrix obj2)
        {
            Matrix obj = new Matrix(obj1.a - obj2.a, obj1.b - obj2.b, obj1.c - obj2.c, obj1.d - obj2.d);
            return obj;
        }
/*
        public static void Writeline(Object value)
        {
            string TypeName = value.ToString();

            Writeline(TypeName);
        }

*/
        //The ToString method overrides the default string representation of the Matrix class
        public override string ToString()
        {

            return a+" "+b+"\n"+c+" "+d+"\n";
        }

        public static void Main(string[] args)
        {
            Matrix m1 = new Matrix(10,30,40,60);
            Matrix m2 = new Matrix(45, 87, 44, 25);
            Matrix m3 = m1 + m2;
            Matrix m4 = m1 - m2;
            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m3);
            Console.WriteLine(m4);
        }
    }
}
