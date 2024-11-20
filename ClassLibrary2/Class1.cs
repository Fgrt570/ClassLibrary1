using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class BankAccount
    {
        // Поля класса
        private string _accountNumber; // Номер счета
        private decimal _balance;       // Баланс счета
        private string _accountHolder;  // Владелец счета

        // Свойства
        public string AccountNumber
        {
            get => _accountNumber; // Возвращает номер счета
            set => _accountNumber = value ?? throw new ArgumentNullException(nameof(value), "Номер счета не может быть неопределенным."); // Устанавливает номер счета, выбрасывает исключение если null
        }

        public decimal Balance
        {
            get => _balance; // Возвращает баланс
            private set => _balance = value >= 0 ? value : throw new ArgumentException("Баланс не может быть отрицательным."); // Устанавливает баланс, выбрасывает исключение если отрицательный
        }

        public string AccountHolder
        {
            get => _accountHolder; // Возвращает владельца счета
            set => _accountHolder = value ?? throw new ArgumentNullException(nameof(value), "Владелец счета не может быть неопределенным."); // Устанавливает владельца счета, выбрасывает исключение если null
        }

        // Конструктор
        public BankAccount(string accountNumber, string accountHolder)
        {
            AccountNumber = accountNumber; // Инициализирует номер счета
            AccountHolder = accountHolder;   // Инициализирует владельца счета
            Balance = 0; // Начальный баланс 0
        }

        // Метод для внесения средств
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Сумма депозита должна быть положительной."); // Проверка на положительность суммы
            Balance += amount; // Увеличивает баланс на указанную сумму
        }

        // Перегруженный метод для внесения средств (принимает строку)
        public void Deposit(string amountStr)
        {
            if (decimal.TryParse(amountStr, out decimal amount)) // Пробует преобразовать строку в decimal
            {
                Deposit(amount); // Вызывает основной метод Deposit
            }
            else
            {
                throw new ArgumentException("Неверный формат суммы."); // Если преобразование не удалось, выбрасывает исключение
            }
        }

        // Метод для снятия средств
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Сумма снятия должна быть больше нуля."); // Проверка на положительность суммы
            if (amount > Balance)
                throw new InvalidOperationException("Недостаточно средств."); // Проверка на достаточность средств
            Balance -= amount; // Уменьшает баланс на указанную сумму
        }
    }
}
