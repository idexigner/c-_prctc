using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("\n\n\nEnter the Respective Number");
            Console.WriteLine("1-Even/Odd\t\t2-break num and sum\t3-Reverse Number");
            Console.WriteLine("4-String to Char array\t5-Num of Time\t\t6-Reverse String");
            Console.WriteLine("7-Upper and Lower Case\t8-Prime or Not\t\t9-reating file");
            Console.WriteLine("10-Reading From file/t11-writing in file");
            int input = Convert.ToInt32(Console.ReadLine());

            //EVEN ODD
            if(input==1)
            {
                Console.WriteLine("Enter Number for even odd");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 == 0) { Console.WriteLine("Even"); }
                else { Console.WriteLine("Odd"); }
            }
            //break num and sum
            else if(input==2)
            {
                int sum=0,r;
                Console.WriteLine("Enter any number");
                int num = Convert.ToInt32(Console.ReadLine());
                int result = num;
                while(num!=0)
                {
                    r = num % 10;
                    num = num / 10;
                    sum += r;
                }
                Console.WriteLine("sum of {0} is {1}", result, sum);
            }

            //Reverse Number
            else if(input==3)
            {
                int num, reverse = 0;
                Console.WriteLine("Enter any number");
                num = Convert.ToInt32(Console.ReadLine());
                int result = num;
                while(num!=0)
                {
                    reverse = reverse * 10;
                    reverse = reverse + num % 10;
                    num = num / 10;
                }
                Console.WriteLine("Reverse of {0} is {1}", result, reverse);
            }
                //String to Char Array
            else if(input==4)
            {
                string text = "Sample Array";
                char[] ch = text.ToCharArray();
                
                foreach(char c in ch)
                {
                    Console.WriteLine(c);
                }
            }
                //number of frequency occurs
            else if(input==5)
            {
                Console.WriteLine("Enter the text");
                string text = Console.ReadLine();
                int i = 0,count=0;
                while((i=text.IndexOf("the",i))!=-1)
                {
                    i += 3;
                    count++;
                }
                Console.WriteLine("{0} time appears",count);

            }
            //reverse string
            else if (input ==6)
            {
                string text = "sample";
                string reverse = "";
                for (int i = text.Length-1; i >=0; i--)
                {
                    reverse += text[i];
                }
                Console.WriteLine("Reverse is {0}", reverse);
            }
            //lower to upper
            else if(input==7)
            {
                string text = "weqweQWAQDe";
                Console.WriteLine("upper is {0}, lower is {1}", text.ToUpper(), text.ToLower());
            }

            //prime or not
            else if(input==8)
            {
                int num,i,ctr=0;

                Console.Write("\n\n");
                Console.Write("Check whether a given number is prime or not:\n");
                Console.Write("-----------------------------------------------");
                Console.Write("\n\n");

                Console.Write("Input  a number: ");
                num = Convert.ToInt32(Console.ReadLine());
                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }
                if (ctr == 0 && num != 1)
                    Console.Write("{0} is a prime number.\n", num);
                else
                    Console.Write("{0} is not a prime number\n", num);
	

            }
                //creating file
            else if (input==9)
            {
                string url = "demo1.txt";
                FileStream fs = File.Create(url);
            }
            //Reading from file
            else if(input==10)
            {

                FileStream fs=new FileStream("demo1.txt",FileMode.Open,FileAccess.Read);
                StreamReader sr=new StreamReader(fs);
                string str = sr.ReadLine();
                while(str!=null)
                {
                    Console.WriteLine("{0}",str);
                    str = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
            }
                //writing in file
            else if (input==11)
            {
                FileInfo finfo = new FileInfo("demo1.txt");
                //using (StreamWriter writer = finfo.AppendText())
                //{
                //    writer.WriteLine("New File with various Text operations");
                //}
                //finfo = new FileInfo("demo1.txt");
                using (StreamWriter writer = finfo.CreateText())
                {
                    writer.WriteLine("New File asdasdsawith various Text operations");
                }
                using (StreamReader reader = finfo.OpenText())
                {
                    Console.WriteLine(reader.ReadToEnd());
                }


                //FileInfo finfo = new FileInfo("demo1.txt");
                //StreamWriter sw = finfo.CreateText();
                //sw.WriteLine("THis will be add from the file ");
                //StreamReader reader = finfo.OpenText();
                
                //    Console.WriteLine(reader.ReadToEnd());
                
            }
            goto start;

            Console.ReadKey();
        }
    }
}
