using System;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            string n1 = "";
            string n2 = "";
            string n3 = "";
            string n4 = "";
            string n5 = "";
            string n6 = "";
            string n7 = "";
            string n8 = "";
            string n9 = "";
            string nA = "";
            while (a==1) { 
                Console.WriteLine("Please choose LED to turn On/Off:");
                string num = Console.ReadLine();
                if (num == "1")
                {
                    n1 = "!";
                }
                    else {
                     n1 = "";
                     }
                if (num == "2")
                {
                    n2 = "!";
                }
                     else{
                     n2 = "";
                    }
                if (num == "3")
                {
                    n3 = "!";
                }
                    else {
                         n3 = "";
                     }
                if (num == "4")
                {
                    n4 = "!";
                }
                    else {
                    n4 = "";
                     }
                if (num == "5")
                {
                    n5 = "!";
                }
                     else{
                    n5 = "";
                      }
                if (num == "6")
                {
                    n6 = "!";
                }
                     else{
                    n6 = "";
                       }
                if (num == "7")
                {
                    n7 = "!";
                }
                    else{
                    n7 = "";
                    }
                if (num == "8")
                {
                    n8 = "!";
                }
                    else{
                    n8 = "";
                    }
                if (num == "9")
                {
                    n9 = "!";
                }
                    else{
                    n9 = "";
                    }
                if (num == "A")
                {
                    nA = "!";
                }
                    else{
                    nA = "";
                    }
                Console.WriteLine("1[ " + n1 + " ]" + "2[" + n2 + "]" + "3[ " + n3 + "]" + "4[" + n4 + "]" + "5[" + n5 + "]" + "6[" + n6 + "]" + "7[" + n7 + "]" + "8[" + n8 + "]" + "9[" + n9 + "]" + "A[" + nA + "]");
                
            }
        }
    }
}
