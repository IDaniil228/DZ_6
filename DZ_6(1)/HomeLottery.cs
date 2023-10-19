using System;

namespace DZ_6_1_
{
    class HomeLottery : Lottery
    {
        public HomeLottery(string name, int price, int id)
        {
            ID = id;
            Name = name;
            Price = price;
        }

        private int changeToWinHome = 2;
        private int changeToWinMiddle = 15;

        public int ChangeToHome
        {
            get { return changeToWinHome; }
        }
        public int ChangeToMiddle
        {
            get { return changeToWinMiddle; }
        }

        public override void MainWin()
        {
            Console.WriteLine("Вы выиграли дом!!!!!!!!!");
        }
        public override void MinWin()
        {
            Console.WriteLine($"Ваш утешительный приз - {MinWinning} руб");
        }
        public override void MiddleWin()
        {
            Console.WriteLine($"Поздравляю, вы выиграли - {MinWinning} руб");
        }

    }
}
