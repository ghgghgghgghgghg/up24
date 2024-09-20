using Microsoft.VisualStudio.TestTools.UnitTesting;
using GUI;

namespace GUI.Tests
{
    [TestClass]
    public class LoginFormWindowTests
    {
        [TestMethod]
        public void GetRoleByStatusID_ReturnsCorrectRole()
        {
            // Arrange
            var loginFormWindow = new Login_Form_Window();

            // Act
            var result1 = loginFormWindow.GetRoleByStatusID(1);
            var result2 = loginFormWindow.GetRoleByStatusID(2);
            var result3 = loginFormWindow.GetRoleByStatusID(3);
            var result4 = loginFormWindow.GetRoleByStatusID(4);
            var result5 = loginFormWindow.GetRoleByStatusID(5);

            // Assert
            Assert.AreEqual("Менеджер", result1);
            Assert.AreEqual("Мастер", result2);
            Assert.AreEqual("Оператор", result3);
            Assert.AreEqual("Клиенет", result4);
            Assert.AreEqual("Роль не найдена", result5);
        }
    }
}
