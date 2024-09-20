using Microsoft.VisualStudio.TestTools.UnitTesting;
using GUI;
using System.IO;
using System.Drawing;
using GUI_EKZ_TRBZD.MasterForm;
using System.Windows.Forms;
using System.Linq;

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
        [TestMethod]
        public void LogLoginAttempt_WritesToFile()
        {
            // Arrange
            var loginFormWindow = new Login_Form_Window();
            string filePath = "login_history.log";

            // Act
            loginFormWindow.LogLoginAttempt("testuser", true);

            // Assert
            Assert.IsTrue(File.Exists(filePath));
            string[] lines = File.ReadAllLines(filePath);
            Assert.IsTrue(lines.Length > 0);
            string lastLine = lines[lines.Length - 1];
            Assert.IsTrue(lastLine.Contains("testuser"));
            Assert.IsTrue(lastLine.Contains("True"));
        }
        [TestMethod]
        public void CreateCaptchaImage_ReturnsBitmap()
        {
            // Arrange
            var loginFormWindow = new Login_Form_Window();
            int width = 100;
            int height = 50;

            // Act
            Bitmap result = loginFormWindow.CreateCaptchaImage(width, height);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(width, result.Width);
            Assert.AreEqual(height, result.Height);
        }
        [TestMethod]
        public void LoadAllRequestsForMaster_PopulatesDataGridView()
        {
            // Arrange
            var masterForm = new Master("Test User", "Test Role", 1);
            var dataGridView = masterForm.Controls.Find("dataGridView_requests_by_master", true).FirstOrDefault() as DataGridView;
            Assert.IsNotNull(dataGridView);

            // Act
            masterForm.LoadAllRequestsForMaster();

            // Assert
            Assert.IsNotNull(dataGridView.DataSource);
            Assert.IsTrue(dataGridView.RowCount > 0);
        }

        [TestMethod]
        public void UpdateRequestCount_UpdatesLabelText()
        {
            // Arrange
            var masterForm = new Master("Test User", "Test Role", 1);
            var label = masterForm.Controls.Find("label_count_of_requests", true).FirstOrDefault() as Label;
            Assert.IsNotNull(label);

            // Act
            masterForm.UpdateRequestCount(1);

            // Assert
            Assert.IsTrue(label.Text.StartsWith("Кол-во заявок:"));
            int requestCount;
            Assert.IsTrue(int.TryParse(label.Text.Split(':')[1].Trim(), out requestCount));
            Assert.IsTrue(requestCount >= 0);
        }


    }
}
