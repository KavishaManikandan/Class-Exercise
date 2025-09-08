using NUnit.Framework;
using Moq;
using DemoApp;
using System;

namespace DemoApp.Tests
{
    [TestFixture]
    public class BankAccountTests
    {
        private BankAccount _account;
        private Mock<INotificationService> _mockNotification;

        [SetUp]
        public void Setup()
        {
            _mockNotification = new Mock<INotificationService>();
            _account = new BankAccount(_mockNotification.Object);
        }

        [Test]
        public void Deposit_AddsMoneyAndSendsNotification()
        {
            _account.Deposit(100);

            Assert.AreEqual(100, _account.Balance);
            _mockNotification.Verify(n => n.Notify("Deposited 100"), Times.Once);
        }

        [Test]
        public void Withdraw_WithEnoughBalance_ReducesMoneyAndSendsNotification()
        {
            _account.Deposit(200);
            _account.Withdraw(50);

            Assert.AreEqual(150, _account.Balance);
            _mockNotification.Verify(n => n.Notify("Withdrew 50"), Times.Once);
        }

        [Test]
        public void Withdraw_WithoutEnoughBalance_ThrowsError()
        {
            Assert.Throws<InvalidOperationException>(() => _account.Withdraw(50));
        }
    }
}
