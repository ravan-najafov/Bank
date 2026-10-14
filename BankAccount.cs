// Класс для первого задания
//namespace BankTransaction
//{
//    public class BankAccount
//    {
//        private int Balance = 1000;

//        public void deposit(int amount)
//        {
//            Balance += amount;
//        }

//        public int getBalance()
//        {
//            return this.Balance;
//        }
//    }
//}

// Класс для второго задания
//namespace BankTransaction
//{
//    public class BankAccount
//    {
//        private int Balance = 1000;
//        private readonly object _lock = new object();

//        public void deposit(int amount)
//        {
//            lock (_lock)
//            {
//                Balance += amount;
//            }
//        }

//        public int getBalance()
//        {
//            return this.Balance;
//        }
//    }
//}


// Класс для третьего задания
namespace BankTransaction
{
    public class BankAccount
    {
        private int Balance = 1000;

        public void deposit()
        {
            Interlocked.Increment(ref Balance);
        }

        public int getBalance()
        {
            return this.Balance;
        }
    }
}
