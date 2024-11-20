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
            _account = new BankAccount("123456789", "Nikita"); // ������������� ������ ����������� ����� ����� ������ ������
        }

        [Test]
        public void Deposit_ValidAmount_IncreasesBalance()
        {
            _account.Deposit(100); // �������� 100 �� ����
            Assert.AreEqual(100, _account.Balance); // ��������, ��� ������ ���������� �� 100
        }

        [Test]
        public void Deposit_InvalidAmount_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _account.Deposit(-50)); // ��������, ��� ��� �������� ������������� ����� ������������� ����������
        }

        [Test]
        public void Deposit_StringAmount_ValidFormat_IncreasesBalance()
        {
            _account.Deposit("150"); // �������� 150 ����� ������
            Assert.AreEqual(150, _account.Balance); // ��������, ��� ������ ���������� �� 150
        }

        [Test]
        public void Deposit_StringAmount_InvalidFormat_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _account.Deposit("invalid")); // ��������, ��� ��� ������������ ������� ������ ������������� ����������
        }

        [Test]
        public void Withdraw_ValidAmount_DecreasesBalance()
        {
          _account.Deposit(200); // �������� 200 �� ����
                _account.Withdraw(100); // ������ 100
            Assert.AreEqual(100, _account.Balance); // ��������, ��� ������ ���������� �� 100
        }

        [Test]
        public void Withdraw_InsufficientFunds_ThrowsInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => _account.Withdraw(100)); // ��������, ��� ��� ���������� ������� ������������� ����������
        }

        [Test]
        public void Withdraw_NegativeAmount_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _account.Withdraw(-50)); // ��������, ��� ��� ������ ������������� ����� ������������� ����������
        }

        [Test]
        public void AccountHolder_SetToNull_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => _account.AccountHolder = null); // ��������, ��� ��� ��������� ��������� ����� � null ������������� ����������
        }
    }
}
