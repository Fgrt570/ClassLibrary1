using NUnit.Framework;
using ClassLibrary2;
namespace TestProject2
{
   
    [TestFixture]
    public class BankAccountTests
    {
        private BankAccount _account;

        [SetUp]
        public void Setup()
        {
            _account = new BankAccount("123456789", "Nikita"); // Инициализация нового банковского счета перед каждым тестом
        }

        [Test]
        public void Deposit_ValidAmount_IncreasesBalance()
        {
            _account.Deposit(100); // Внесение 100 на счет
            Assert.AreEqual(100, _account.Balance); // Проверка, что баланс увеличился до 100
        }

        [Test]
        public void Deposit_InvalidAmount_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _account.Deposit(-50)); // Проверка, что при внесении отрицательной суммы выбрасывается исключение
        }

        [Test]
        public void Deposit_StringAmount_ValidFormat_IncreasesBalance()
        {
            _account.Deposit("150"); // Внесение 150 через строку
            Assert.AreEqual(150, _account.Balance); // Проверка, что баланс увеличился до 150
        }

        [Test]
        public void Deposit_StringAmount_InvalidFormat_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _account.Deposit("invalid")); // Проверка, что при неправильном формате строки выбрасывается исключение
        }

        [Test]
        public void Withdraw_ValidAmount_DecreasesBalance()
        {
          _account.Deposit(200); // Внесение 200 на счет
                _account.Withdraw(100); // Снятие 100
            Assert.AreEqual(100, _account.Balance); // Проверка, что баланс уменьшился до 100
        }

        [Test]
        public void Withdraw_InsufficientFunds_ThrowsInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => _account.Withdraw(100)); // Проверка, что при недостатке средств выбрасывается исключение
        }

        [Test]
        public void Withdraw_NegativeAmount_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _account.Withdraw(-50)); // Проверка, что при снятии отрицательной суммы выбрасывается исключение
        }

        [Test]
        public void AccountHolder_SetToNull_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => _account.AccountHolder = null); // Проверка, что при установке владельца счета в null выбрасывается исключение
        }
    }
}
