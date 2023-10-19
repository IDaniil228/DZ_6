namespace DZ_6
{
    enum Account { Текущий, Сберегательный }
    public class BankAccount
    {
        private int numbOfAccount;
        private double balance;
        private Account accountType;
        public void Set(double balance, int type)
        {
            numbOfAccount++;
            this.balance = balance;
            accountType = (Account)type;
        }
        public double AddBalince(double balance)
        {
            this.balance += balance;
            return balance;
        }
        public double WithdrawFromBalance(double balance)
        {
            this.balance -= balance;
            return balance;
        }
        public int GetNumber()
        {
            return numbOfAccount;
        }
        public double GetBalance()
        {
            return balance;
        }
        public string GetType()
        {
            return accountType.ToString();
        }
    }

}
