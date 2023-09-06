using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4015_intro
{
    public class Solution
    {
        // konstruktor
        public Solution()
        {
        }
        public void Uppgift_1A()
        {
            Console.WriteLine("Vad heter du?");
            String namn = Console.ReadLine();
            Console.WriteLine("Hej " + namn + ". Varmt Välkommen");
            Console.WriteLine();

        }

        public void Uppgift_1B()
        {
            double bredd = 9.6;
            double höjd = 5.4;
            var area = bredd * höjd / 2;
            Console.WriteLine("Triangel");
            Console.WriteLine("bredd = " + bredd);
            Console.WriteLine("höjd = " + höjd);
            Console.WriteLine("area = " + area);
        }

        public void Uppgift_1C()
        {
            Console.WriteLine("bredd: ");
            double bredd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("höjd: ");
            double höjd = Convert.ToDouble(Console.ReadLine());
            var area = bredd * höjd / 2;
            Console.WriteLine("Triangel");
            Console.WriteLine("bredd = " + bredd);
            Console.WriteLine("höjd = " + höjd);
            Console.WriteLine("area = " + area);
        }

        public void Uppgift_1D()
        {
            Console.WriteLine("skriv in första talet");
            double tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("skriv in andra talet");
            double tal2 = Convert.ToInt32(Console.ReadLine());
            var summa = tal1 + tal2;
            Console.WriteLine("summan av talen är: " + summa);
        }

        public void Uppgift_2A()
        {
            Console.WriteLine("Gissa mitt favorittal.");
            double gissning = Convert.ToInt32(Console.ReadLine());
            if (gissning == 3)
            {
                Console.WriteLine("Du gissade rätt");
            }
            else
            {
                Console.WriteLine("Du gissade fel");
            }
        }

        public void Uppgift_2B()
        {
            Random gen = new Random();
            foreach (int value in Enumerable.Range(1, 2))
            {
                int tärningsidor = gen.Next(1, 10);
                Console.WriteLine(tärningsidor);
                if (tärningsidor % 2 == 0)
                {
                    Console.WriteLine("vinst");
                }
                else
                {
                    Console.WriteLine("förlust");
                }
            }
           
        }

        public void Uppgift_2C()
        {
            Random gen = new Random();
            int[] kast = new int[2];
            int index = 0;
            int index2 = 0;

            for(int i = 0; i < kast.Length; i++)
            {
                kast[i] = gen.Next(1, 10);
            }

            /*
            foreach (int value in Enumerable.Range(1, 2))
            {
                kast[index] = gen.Next(1, 10);
                index++;
            }
            */
            foreach (int value in Enumerable.Range(1, 2))
            {
                if (kast[index2] % 2 == 0)
                {
                    Console.WriteLine("vinst");
                }
                else if (kast[0] == kast[1])
                {
                    Console.WriteLine("stor vinst");
                }
                else
                {
                    Console.WriteLine("förlust");
                }
                index2++;
            }
            Console.WriteLine(kast[0] + " " + kast[1]);
        }


        public void Uppgift_3A()
        {
            int count = 1;
            while (count <= 5)
            {
                Console.WriteLine(count);
                count++;
            }
        }

        public void Uppgift_3B()
        {
            int count = 5;
            while (count <= 20)
            {
                Console.WriteLine(count);
                count += 3;
            }
        }

        public void Uppgift_3C()
        {
            int count = 10;
            while (count >= 0)
            {
                Console.WriteLine(count);
                count--;
            }
        }

        public void Uppgift_4A()
        {
            for (int i = 1; i < 6; i++)
                Console.WriteLine(i);
        }

        public void Uppgift_4B()
        {
            for (int i = 5; i < 21; i += 3)
                Console.WriteLine(i);
        }

        public void Uppgift_4C()
        {
            for (int i = 10; i >= 0; i--)
                Console.WriteLine(i);
        }

        public void Uppgift_5A()
        {
            bool check = true;
            var guess = 0;
            while (check)
            {
                if (guess != 15)
                {
                    Console.WriteLine("gissa ett tal");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    break;
                }
            }
                
            Console.WriteLine("du gissade rätt");

        }

        public void Uppgift_6A()
        {
            Random gen = new Random();
            int[] kast = new int[2];
            for (int i = 0; i < kast.Length; i++)
            {
                kast[i] = gen.Next(1, 10);
            }

            if (kast[0] == kast[1] & kast[0] == 6)
            {
                Console.WriteLine("stor vinst");
            }
            else if (kast[0] == kast[1])
            {
                Console.WriteLine("liten vinst");
            }
            else
            {
                Console.WriteLine("förlust");
            }
            Console.WriteLine(kast[0] + " " + kast[1]);
        }

        public void Uppgift_7A()
        {
            int[] array = new int[6];
            int count = 3;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = count;
                count += 2;
            }

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

        }

        public void Uppgift_7B()
        {
            List<int> lista = new List<int>();
            for (int i = 3; i < 14; i += 2)
            {
                lista.Add(i);
            }

            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }
        }

        public void Uppgift_8A()
        {
            int[] array = new int[6];
            int count = 3;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = count;
                count += 2;
            }

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }

        public void Uppgift_8B()
        {
            int[] array = { 3, 5, 7, 9, 11, 13 };

            for (int i = 0; i < array.Length;i++)
            {
                array[i] = array[i] + 1;
            }

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }

        public void Uppgift_9A()
        {
            ValkomnaAgent();
        }
        public void ValkomnaAgent()
        {
            Console.WriteLine("Välkommen Agent X. Ditt uppdrag är...");
        }

        public void Uppgift_9B()
        {
            Console.WriteLine("skriv in två tal");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            int tal2 = Convert.ToInt32(Console.ReadLine());
            addera(tal1, tal2);
        }

        public void addera(int tal1, int tal2)
        {
            int summa = tal1 + tal2;
            Console.WriteLine(summa);
        }

        public void Uppgift_9B3()
        {
            Console.WriteLine("skriv in tre tal");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            int tal2 = Convert.ToInt32(Console.ReadLine());
            int tal3 = Convert.ToInt32(Console.ReadLine());
            addera(tal1 + tal2, tal3);
        }

        public void Uppgift_10A()
        {
            string[] lista = new string[10];
            bool check = true;
            while (check)
            {
                for (int i = 0; i < lista.Length; i++)
                {
                    Console.WriteLine("skriv in dina varor en i taget");
                    lista[i] = (Console.ReadLine());
                    Console.WriteLine("är du klar med inköpslistan? j/n");
                    string svar = Console.ReadLine();
                    if (svar == "j")
                    {
                        check = false;
                        break;
                    }
                }
            }

            foreach (string i in lista)
            {
                Console.WriteLine(i);
            }
        }

        public void Uppgift_10B()
        {
            List<string> lista = new List<string>();
            while (true)
            {
                Console.WriteLine("skriv in dina varor en i taget");
                lista.Add(Console.ReadLine());
                Console.WriteLine("är du klar med inköpslistan? j/n");
                string svar = Console.ReadLine();
                if (svar == "j")
                {
                    break;
                }
            }
            foreach (string i in lista)
            {
                Console.WriteLine(i);
            }
        }

        public void Uppgift_10C()
        {
            Console.WriteLine();
            Console.WriteLine("Fördelarna med den första metoden med arrays är att arrays är i sig mer effektiva medans nackdelen är att arrays har en bestämd längd så man måste välja länged på arrayen i förhand");
            Console.WriteLine();
            Console.WriteLine("Fördelarna med andra metoden med en lista är att listor inte har en bestämd längd så man kan enkelt expandera listan efter behov istälelt för att behöva definiera längden innan medans nackdelen är att listor i sig är mindre effektiva");
            Console.WriteLine();

        }
    }
}
