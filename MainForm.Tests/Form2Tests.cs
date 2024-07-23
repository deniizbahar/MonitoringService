using NUnit.Framework;
using Moq;
using System.Windows.Forms;
using Günlük;
using Serilog.Events;
using MockService;
using ControlService;
using System.ServiceProcess; // Gerekli using yönergesi

namespace MainForm.Tests
{
    [TestFixture]
    public class Form2Tests
    {
        private Mock<Service1> _mockService1;
        private Mock<MyService> _mockService2;
        private Form2 _form;

        [SetUp]
        public void SetUp()
        {
            _mockService1 = new Mock<Service1>();
            _mockService2 = new Mock<MyService>();
            _form = new Form2(_mockService1.Object, _mockService2.Object);
        }

        [Test]
        public void StartService_ShouldStartService_WhenServiceIsStopped()
        {
            // Arrange
            var serviceName = "MockService";
            var statusLabel = new Label();
            var serviceControllerMock = new Mock<ServiceController>(serviceName);
            serviceControllerMock.Setup(s => s.Status).Returns(ServiceControllerStatus.Stopped);
            serviceControllerMock.Setup(s => s.Start()).Verifiable();

            // Act
            _form.StartService(serviceName, statusLabel);

            // Assert
            serviceControllerMock.Verify(s => s.Start(), Times.Once);
            Assert.AreEqual("Başlatıldı", statusLabel.Text);
        }

        [Test]
        public void StopService_ShouldStopService_WhenServiceIsRunning()
        {
            // Arrange
            var serviceName = "MockService";
            var statusLabel = new Label();
            var serviceControllerMock = new Mock<ServiceController>(serviceName);
            serviceControllerMock.Setup(s => s.Status).Returns(ServiceControllerStatus.Running);
            serviceControllerMock.Setup(s => s.Stop()).Verifiable();

            // Act
            _form.StopService(serviceName, statusLabel);

            // Assert
            serviceControllerMock.Verify(s => s.Stop(), Times.Once);
            Assert.AreEqual("Durduruldu", statusLabel.Text);
        }

        [Test]
        public void OnConfigChanged_ShouldInvokeSaveNewConfig_OnService1()
        {
            // Arrange
            var newConfig = new ServiceConfigDto
            {
                Application = ApplicationType.MockService,
                LogLevel = LogEventLevel.Information,
                MonitoringFrequency = 10
            };

            // Act
            _form.OnConfigChanged(newConfig);

            // Assert
            _mockService1.Verify(m => m.savenewconfig(newConfig), Times.Once);
        }

        [Test]
        public void OnConfigChanged_ShouldInvokeSaveNewConfigA_OnService2()
        {
            // Arrange
            var newConfig = new ServiceConfigDto
            {
                Application = ApplicationType.ControlService,
                LogLevel = LogEventLevel.Information
            };

            // Act
            _form.OnConfigChanged(newConfig);

            // Assert
            _mockService2.Verify(m => m.savenewconfiga(newConfig), Times.Once);
        }

        [Test]
        public void GetSelectedLogLevel_ShouldReturnCorrectLogLevel()
        {
            // Arrange
            var comboBox = new ComboBox();
            comboBox.Items.AddRange(Enum.GetNames(typeof(LogEventLevel)));
            comboBox.SelectedIndex = 2; // Information

            // Act
            var logLevel = _form.GetSelectedLogLevel(comboBox);

            // Assert
            Assert.AreEqual(LogEventLevel.Information, logLevel);
        }
    }
}
