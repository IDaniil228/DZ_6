using System;

namespace DZ_6_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ДЗ по теме");
            Console.WriteLine("Введите лотерею, в которой хотите учавствовать (машина или дом)");
            string str = Console.ReadLine().ToLower();
            Random rand = new Random();
            if (str == "машина")
            {
                CarLottery cl = new CarLottery("CarLottery", 150, 123);
                cl.MinWinning = (double)cl.Price / 100;
                cl.MiddleWinning = cl.Price + 50;
                Console.WriteLine($"Название лотереи - {cl.Name}");
                Console.WriteLine($"Тираж - {cl.ID}");
                Console.WriteLine($"Цена билета - {cl.Price} руб");
                Console.WriteLine("Введите число от 1 до 100");
                if (int.TryParse(Console.ReadLine(), out int numb))
                {
                    bool flag = true;
                    for (int i = 0; i < cl.ChangeToCar; i++)
                    {
                        if (numb == rand.Next(1, 100))
                        {
                            cl.MainWin();
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        for (int i = 0; i < cl.ChangeToMiddle; i++)
                        {
                            if (numb == rand.Next(1, 100))
                            {
                                cl.MiddleWin();
                                flag = false;
                                break;
                            }
                        }
                    }
                    if (flag)
                    {
                        cl.MinWin();
                    }


                }
            }
            if (str == "дом")
            {
                HomeLottery hl = new HomeLottery("HomeLottery", 150, 321);
                hl.MinWinning = (double)hl.Price / 100;
                hl.MiddleWinning = hl.Price + 50;
                Console.WriteLine($"Название лотереи - {hl.Name}");
                Console.WriteLine($"Тираж - {hl.ID}");
                Console.WriteLine($"Цена билета - {hl.Price} руб");
                Console.WriteLine("Введите число от 1 до 100");
                if (int.TryParse(Console.ReadLine(), out int numb))
                {
                    bool flag = true;
                    for (int i = 0; i < hl.ChangeToHome; i++)
                    {
                        if (numb == rand.Next(1, 100))
                        {
                            hl.MainWin();
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        for (int i = 0; i < hl.ChangeToMiddle; i++)
                        {
                            if (numb == rand.Next(1, 100))
                            {
                                hl.MiddleWin();
                                flag = false;
                                break;
                            }
                        }
                    }
                    if (flag)
                    {
                        hl.MinWin();
                    }
                }

            }
            Console.ReadKey();
        }
    }
}