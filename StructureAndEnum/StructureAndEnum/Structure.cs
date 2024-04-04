namespace Structure
{

    struct Mystruct
    {
        public int Value;

        Mystruct(int value) { this.Value = value; }
        public void show()
        {
            Console.WriteLine("Hello I am Structure");
            Console.ReadLine();
        }

        static void Main(string[] args) {
        
        
            Mystruct mystruct = new Mystruct();
            Mystruct mystruct1 = new Mystruct(10);

            mystruct1.Value = 30;
            mystruct.show();

            
        }
    }




}