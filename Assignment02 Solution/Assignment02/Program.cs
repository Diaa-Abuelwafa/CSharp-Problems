using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment01
{
    class Program
    {
        public static void Main()
        {
            #region Q1

            //int num;

            //bool flag = int.TryParse(Console.ReadLine(), out num);

            //Console.WriteLine(num);

            #endregion

            #region Q2

            //string s = "Diaa";

            ////int n = Convert.ToInt32(s);

            ////Console.WriteLine(n);

            //// Error Because The Invalid Converting

            //string s1 = "Diaa";

            //int n1;

            //bool flag = int.TryParse(s1, out n1);

            //Console.WriteLine(n1);

            #endregion

            #region Q3

            //float f1 = 1.5f;
            //float f2 = 1.25f;

            //Console.WriteLine(f1+ f2);

            #endregion

            #region Q4

            //string s = "Diaa Ehab";

            //Console.WriteLine(s.Substring(1, 2));

            #endregion

            #region Q5

            //int x = 5;
            //int y = 10;

            //x = y;

            //y += 10;

            //// Then X = 10 and y = 15

            #endregion

            #region Q6

            Point P1 = new Point();
            Point P2 = new Point();

            P2 = P1; // P2 become a reference to object 2

            P1.x = 10;

            Console.WriteLine(P2.x); // 10

            #endregion

            #region Q7

            //string s1 = "Diaa";
            //string s2 = "Ehab";
            //string s3 = s1 + ' ' + s2;
            ////string s4 = String.Concat(s1, s2); 

            //Console.WriteLine(s3);

            #endregion

            #region Q8

            //int PrincipalAmount = int.Parse(Console.ReadLine());
            //int RateOfInterest = int.Parse(Console.ReadLine());
            //int Time = int.Parse(Console.ReadLine());

            //int Interest = (PrincipalAmount * RateOfInterest * Time) / 100;

            //Console.WriteLine(Interest);

            #endregion

            #region Q9

            //double Weight = double.Parse(Console.ReadLine());
            //double Height = double.Parse(Console.ReadLine());

            //double Mass = (Weight) / (Height * Height);

            //Console.WriteLine(Mass);

            #endregion

            #region Q10

            //int Temperature = int.Parse(Console.ReadLine());

            //string Result = Temperature < 10 ? "Just Cold" : (Temperature > 30 ? "Just Hot" : "Just Good");

            //Console.WriteLine(Result);

            #endregion

            #region Q11

            //int day = int.Parse(Console.ReadLine());
            //int month = int.Parse(Console.ReadLine());
            //int year = int.Parse(Console.ReadLine());

            //Console.WriteLine("Today's date : " + day + " , " + month + " , " + year);
            //Console.WriteLine("Today's date : " + day + " / " + month + "/ " + year);
            //Console.WriteLine("Today's date : " + day + " - " + month + " - " + year);

            #endregion

            #region TheLastQuestions

            // 12 - C
            // 13 - F
            // 14 - A
            // 15 - D



            #endregion
        }
    }
}