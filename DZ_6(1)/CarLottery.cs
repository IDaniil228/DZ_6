using System;

namespace DZ_6_1_
{
    class CarLottery : Lottery
    {
        public CarLottery(string name, int price, int id)
        {
            ID = id;
            Name = name;
            Price = price;
        }

        private int changeToWinCar = 1;
        private int changeToWinMiddle = 20;

        public int ChangeToCar
        {
            get { return changeToWinCar; }
        }
        public int ChangeToMiddle
        {
            get { return changeToWinMiddle; }
        }
        public override void MainWin()
        {
            Console.WriteLine("Вы выиграли автомобиль!!!!!!!!!");
        }
        public override void MinWin()
        {
            Console.WriteLine($"Ваш утешительный приз - {MinWinning} руб");
        }
        public override void MiddleWin()
        {
            Console.WriteLine($"Поздравляю, вы выиграли - {MiddleWinning} руб");
        }

    }

}
