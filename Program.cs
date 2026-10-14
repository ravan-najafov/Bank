// Main для первого и второго задания
//using BankTransaction;

//BankAccount bankAccount = new BankAccount();

//Console.WriteLine(bankAccount.getBalance());

//Thread thread1 = new Thread(() =>
//{
//    for (int i = 0; i < 100000; i++)
//    {
//        bankAccount.deposit(1);
//    }
//});

//Thread thread2 = new Thread(() =>
//{
//    for (int i = 0; i < 100000; i++)
//    {
//        bankAccount.deposit(1);
//    }
//});

//Thread thread3 = new Thread(() =>
//{
//    for (int i = 0; i < 100000; i++)
//    {
//        bankAccount.deposit(1);
//    }
//});

//Thread thread4 = new Thread(() =>
//{
//    for (int i = 0; i < 100000; i++)
//    {
//        bankAccount.deposit(1);
//    }
//});

//Thread thread5 = new Thread(() =>
//{
//    for (int i = 0; i < 100000; i++)
//    {
//        bankAccount.deposit(1);
//    }
//});

//Thread thread6 = new Thread(() =>
//{
//    for (int i = 0; i < 100000; i++)
//    {
//        bankAccount.deposit(1);
//    }
//});

//Thread thread7 = new Thread(() =>
//{
//    for (int i = 0; i < 100000; i++)
//    {
//        bankAccount.deposit(1);
//    }
//});

//Thread thread8 = new Thread(() =>
//{
//    for (int i = 0; i < 100000; i++)
//    {
//        bankAccount.deposit(1);
//    }
//});

//Thread thread9 = new Thread(() =>
//{
//    for (int i = 0; i < 100000; i++)
//    {
//        bankAccount.deposit(1);
//    }
//});

//Thread thread10 = new Thread(() =>
//{
//    for (int i = 0; i < 100000; i++)
//    {
//        bankAccount.deposit(1);
//    }
//});

//thread1.Start();
//thread2.Start();
//thread3.Start();
//thread4.Start();
//thread5.Start();
//thread6.Start();
//thread7.Start();
//thread8.Start();
//thread9.Start();
//thread10.Start();

//thread1.Join();
//thread2.Join();
//thread3.Join();
//thread4.Join();
//thread5.Join();
//thread6.Join();
//thread7.Join();
//thread8.Join();
//thread9.Join();
//thread10.Join();

//Console.WriteLine(bankAccount.getBalance());
// С 1000 и 10000 race condition не наблюдался из за этого пришлось поставить 100000. Баланс должен получится 1001000
// Баланс получается меньше так как некоторые потоки записывают одно и то же значение в balance так как += не является атомарной операцией
// Не является атомарной так как под капотом он разделен на 3 части: взять значение, обновить значение, записать значение обратно

// После того как мы установили lock пока 1 поток не завершит обновление баланса другой поток изменять не может

// main для третьего задания
using BankTransaction;

BankAccount bankAccount = new BankAccount();

Console.WriteLine(bankAccount.getBalance());

Thread thread1 = new Thread(() =>
{
    for (int i = 0; i < 100000; i++)
    {
        bankAccount.deposit();
    }
});

Thread thread2 = new Thread(() =>
{
    for (int i = 0; i < 100000; i++)
    {
        bankAccount.deposit();
    }
});

Thread thread3 = new Thread(() =>
{
    for (int i = 0; i < 100000; i++)
    {
        bankAccount.deposit();
    }
});

Thread thread4 = new Thread(() =>
{
    for (int i = 0; i < 100000; i++)
    {
        bankAccount.deposit();
    }
});

Thread thread5 = new Thread(() =>
{
    for (int i = 0; i < 100000; i++)
    {
        bankAccount.deposit();
    }
});

Thread thread6 = new Thread(() =>
{
    for (int i = 0; i < 100000; i++)
    {
        bankAccount.deposit();
    }
});

Thread thread7 = new Thread(() =>
{
    for (int i = 0; i < 100000; i++)
    {
        bankAccount.deposit();
    }
});

Thread thread8 = new Thread(() =>
{
    for (int i = 0; i < 100000; i++)
    {
        bankAccount.deposit();
    }
});

Thread thread9 = new Thread(() =>
{
    for (int i = 0; i < 100000; i++)
    {
        bankAccount.deposit();
    }
});

Thread thread10 = new Thread(() =>
{
    for (int i = 0; i < 100000; i++)
    {
        bankAccount.deposit();
    }
});

thread1.Start();
thread2.Start();
thread3.Start();
thread4.Start();
thread5.Start();
thread6.Start();
thread7.Start();
thread8.Start();
thread9.Start();
thread10.Start();

thread1.Join();
thread2.Join();
thread3.Join();
thread4.Join();
thread5.Join();
thread6.Join();
thread7.Join();
thread8.Join();
thread9.Join();
thread10.Join();

Console.WriteLine(bankAccount.getBalance());

// С помощи Interlocked мы сделали наши операции атомарными