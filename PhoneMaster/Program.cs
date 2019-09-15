using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneMaster
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your Phones Number");


            Console.WriteLine("heloo");
            //string[] phone = Console.ReadLine().Split(',').ToArray();

            //List<string> phones = null;
            //for (int i = 0; i < phone.Length; i++)
            //{
            //    phones.Add(phone[i]);
            //}
            //Console.WriteLine("choose the number of master number ");
            List<int> phones = new List<int>();
            int cnt = 0;
            int flag = 0;
            string ans = "yes";
            do
            {
                Console.WriteLine("Do you want to add number enter yes or no");
                ans = Console.ReadLine();
                if (ans == "no")
                {
                    break;
                }
                int num = int.Parse(Console.ReadLine());
                phones.Add(num);
                Console.WriteLine("Do you want to make it your master phone yes or no");
                string res = Console.ReadLine();
                if (res == "yes")
                {
                    flag = cnt;
                    ++cnt;
                }

            } while (ans == "yes");


            int x = 1;
            string str = "";
            foreach (var item in phones)
            {
                if (x == cnt)
                {
                    str += "$" + item;
                }
                else
                {
                    str += item;
                }
                if (x < phones.Count)
                {
                    str += ',';
                }
                x++;
            }
            Console.WriteLine("your string is " +str);

            Console.ReadKey();
        }
    }
}
