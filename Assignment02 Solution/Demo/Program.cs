namespace Demo
{
    class Program
    {
        public static void Main()
        {
            int x;   // Declaration
            x = 10;  // Initialization

            int x = 10; // Declaration and Initialization

            Object o1; // Reference To Address Object In HEAP

            o1 = new Object(); // Instance and O1 reference

            Object o2 = new Object();

            o2.GetHashCode(); // Get The Address Of Object AS ID

            int x = 10;  // Impilicit Casting
            long y = x;

            float f = 1.5f;   // Explicit Casting For Fractions Numbers

            long z = 141515; // Explicit Casting
            int f = (int)z;

            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());  // Parse Function

            bool flag = int.TryParse(Console.ReadLine(), out age); // Return T or F

            int num = Convert.ToInt32(Console.ReadLine());  // Convert Class

            int nums = 100_000_000;   // For readability Using discards

            int x = 10;
            x++; // 11  Post Increment

            int y = 20;
            x += y;

            bool z = x == y;

            Console.WriteLine(true && false); // false
            Console.WriteLine(true || false); // True
            Console.WriteLine(true & false);
            Console.WriteLine(true | false);
            Console.WriteLine(!false); // True

            string temp = 10 == 20 ? "Yes" : "No";
        }
    }
}