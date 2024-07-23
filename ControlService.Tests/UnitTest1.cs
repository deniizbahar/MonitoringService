using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Günlük;
using ControlService;
using Serilog.Events;

namespace ControlService.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private Mock<ILoggerService> _mockLoggerService;
        private MyService _myService;

        [TestInitialize]
        public void Setup()
        {
            _mockLoggerService = new Mock<ILoggerService>();
            LoggerHelper.ConfigureLogger(_mockLoggerService.Object);
            _myService = new MyService();
        }

        [TestMethod]
        public void SaveNewConfiga_ShouldSetLogLevel()
        {
            // Arrange
            var newConfig = new ServiceConfigDto { LogLevel = LogEventLevel.Debug };

            // Act
            _myService.savenewconfiga(newConfig);

            // Assert
            _mockLoggerService.Verify(logger => logger.SetLogLevel(LogEventLevel.Debug), Times.Once);
        }

        [TestMethod]
        public void OnStart_ShouldConfigureLoggerAndLogStart()
        {
            // Arrange
            string[] args = new string[] { "arg1", "arg2" }; // Örnek argümanlar

            // Act
            _myService.PublicOnStart(args);

            // Assert
            _mockLoggerService.Verify(logger => logger.Log(LogEventLevel.Information, "Control Service started."), Times.Once);
        }

        [TestMethod]
        public void OnStop_ShouldLogStop()
        {
            // Arrange
            string[] args = new string[] { "arg1", "arg2" }; // Örnek argümanlar

            _myService.PublicOnStart(args);

            // Bekleme süresi ekleyin
            Thread.Sleep(100); // 100 milisaniye bekleme

            // Act
            _myService.PublicOnStop();

            // Assert
            _mockLoggerService.Verify(logger => logger.Log(LogEventLevel.Information, "Control Service stopped."), Times.Once);
        }
    }
}
