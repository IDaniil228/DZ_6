using System;

namespace DZ_6
{

    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.Set(233213.01, 1);
            int numbOfAccount = account.GetNumber();
            double balance = account.GetBalance();
            string accountType = account.GetType();
            Console.WriteLine($"Номер счет - {numbOfAccount}\nБаланс - {balance}\nТип счета - {accountType}");
            Console.WriteLine("Введите сумму, которую хотите положить на счет:");
            if (double.TryParse(Console.ReadLine(), out double addBalance) && addBalance >= 0)
            {
                balance += account.AddBalince(addBalance);
            }
            Console.WriteLine($"Ваш баланс:{balance}");
            Console.WriteLine("Введите сумму, которую хотите снять:");
            if (double.TryParse(Console.ReadLine(), out double withdrawBalance) && balance >= withdrawBalance && withdrawBalance >= 0)
            {
                balance -= account.WithdrawFromBalance(withdrawBalance);
            }
            else
            {
                Console.WriteLine("Вы не можете снять эту сумму!");
            }
            Console.WriteLine($"Номер счет - {numbOfAccount}\nБаланс - {balance}\nТип счета - {accountType}");
            Console.ReadKey();


            Console.WriteLine("Домашнее задание 7.1 Реализовать класс для описания здания");
            Building building = new Building(20, 5, 10, 2);
            int number = building.GetNumber();
            int height = building.GetHeight();
            int floors = building.GetFloors();
            int apartments = building.GetApartments();
            int entrance = building.GetEntrance();
            Console.WriteLine($"Номер дома - {number} \nВысота - {height} \nКол-во этажей - {floors} \nКол-во квартир - {apartments} \nКол-во подъездов - {entrance}");
            Console.WriteLine($"Высота одного этажа - {building.HeightOfFloors(floors, height)}\n" +
                $"Кол-во квартир в поъезде - {building.ApartmentsInEntrance(apartments, entrance)}\n" +
                $"Кол-во квартир на этаже - {building.ApartmentsOnTheFloor(apartments, floors)}");
            Console.ReadKey();
        }
    }
}