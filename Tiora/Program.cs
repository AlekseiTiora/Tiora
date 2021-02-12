using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Tiora
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sonad = new string[7] {"a","b","c","d","e","f","z" };
            foreach (string sona in sonad)
            {
                Console.WriteLine(sona);
            }
            //for (int i=0; i< sonad.Length; i++)
            {
                Console.WriteLine(sonad[i]);
            }
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            do
            {
                Console.WriteLine("Vajuta Escape");
                    key=Console.ReadKey();
            } while (key.Key!=ConsoleKey.Escape);
            //Console.BackgroundColor = ConsoleColor.Red;
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.Clear();
            //Console.WriteLine("Hello world!");
            //Random rnd = new Random();
            //Console.WriteLine("jah-random number,ei-ise sisestan number");
            //string soov = Console.ReadLine();
            //int num=0;
            //if (soov== "jah")
            //{
            //num = rnd.Next(1, 8);
            //Console.WriteLine("Päeva number: {0} ", num.ToString());
            ////Next генерирует целое число от 1 до 8
            //}
            //else
            //{
            //try
            //{
            //num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Päeva number: {0} ", num.ToString());

            //}
            //catch (SystemException)
            //{
            //}
            //
            //}
            //зеленая строчка обозначает что ты его не где не используешь
            //string nimetus = "";
            //switch (num)
            //{
            //case 1: nimetus = "esmaspäev"; break;
            //case 2: nimetus = "teisipäev"; break;
            //case 3: nimetus = "kolmapäev"; break;
            //case 4: nimetus = "neljapäev"; break;
            //case 5: nimetus = "reede"; break;
            //case 6: nimetus = "laupäev"; break;
            //case 7: nimetus = "pühapäev"; break;
            //default:
            //nimetus = "Viga!";
            //break;
            //}
            //Console.WriteLine(nimetus);
            //// ..\..\=выше на 2 папки
            //StreamWriter filesse = new StreamWriter(@"..\..\andmed.txt", true);
            //filesse.WriteLine("Number oli {0}, päev on {1}", num.ToString(), nimetus);
            //filesse.Close();
            //StreamReader filest = new StreamReader(@"..\..\andmed.txt");
            //string a = filest.ReadToEnd();
            //Console.WriteLine("Failis oli seda: \n" + a);

            Console.ReadLine();



       }
    }
}
