namespace DZ_6_1_
{
    abstract class Lottery
    {
        private int id;
        private string name;
        private double price;
        private double minWinning;
        private double middleWinning;

        public double MiddleWinning
        {
            get { return middleWinning; }
            set { middleWinning = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public double MinWinning
        {
            get { return minWinning; }
            set { minWinning = value; }
        }
        public abstract void MainWin();
        public abstract void MinWin();
        public abstract void MiddleWin();
    }
}
