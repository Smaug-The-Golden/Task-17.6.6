using System;

namespace Task_17._6._6
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            var normalAccount = new NormalAccount();
            var salaryAccount = new SalaryAccount();

            normalAccount.Balance = 500.00;
            salaryAccount.Balance = 500.00;

            calculator.CommonInterest(normalAccount);

            Console.WriteLine("Обычный счёт:");
            Console.WriteLine($"При балансе {normalAccount.Balance} руб. процентная ставка { normalAccount.Interest }");

            Console.WriteLine();

            calculator.CommonInterest(salaryAccount);
            Console.WriteLine("Зарплатный счёт: ");
            Console.WriteLine($"При балансе {salaryAccount.Balance} руб. процентная ставка { salaryAccount.Interest }");

            Console.ReadKey();
        }
    }
}
