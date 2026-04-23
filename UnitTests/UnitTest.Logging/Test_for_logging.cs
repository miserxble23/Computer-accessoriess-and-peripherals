using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace UnitTests.Logging
{
    [TestClass]
    public class LoggingUnitTests
    {
        private string logFilePath = "test_app.log";

        [TestInitialize]
        public void Setup()
        {
            if (File.Exists(logFilePath))
                File.Delete(logFilePath);
            Logger.Configure(logFilePath);
        }

        // Trace уровень
        [TestMethod]
        public void LogTrace_WritesCorrectly()
        {
            // Arrange
            string message = "Trace message";

            // Act
            Logger.Trace(message);
            var logContent = File.ReadAllText(logFilePath);

            // Assert
            StringAssert.Contains(logContent, "TRACE");
            StringAssert.Contains(logContent, message);
        }

        // Debug уровень
        [TestMethod]
        public void LogDebug_WritesCorrectly()
        {
            // Arrange
            string message = "Debug message";

            // Act
            Logger.Debug(message);
            var logContent = File.ReadAllText(logFilePath);

            // Assert
            StringAssert.Contains(logContent, "DEBUG");
            StringAssert.Contains(logContent, message);
        }

        // Info уровень
        [TestMethod]
        public void LogInfo_WritesCorrectly()
        {
            // Arrange
            string message = "Info message";

            // Act
            Logger.Info(message);
            var logContent = File.ReadAllText(logFilePath);

            // Assert
            StringAssert.Contains(logContent, "INFO");
            StringAssert.Contains(logContent, message);
        }

        // Warn уровень
        [TestMethod]
        public void LogWarn_WritesCorrectly()
        {
            // Arrange
            string message = "Warning message";

            // Act
            Logger.Warn(message);
            var logContent = File.ReadAllText(logFilePath);

            // Assert
            StringAssert.Contains(logContent, "WARN");
            StringAssert.Contains(logContent, message);
        }

        // Error уровень
        [TestMethod]
        public void LogError_WritesCorrectly()
        {
            // Arrange
            string message = "Error message";
            var exception = new Exception("Test exception");

            // Act
            Logger.Error(message, exception);
            var logContent = File.ReadAllText(logFilePath);

            // Assert
            StringAssert.Contains(logContent, "ERROR");
            StringAssert.Contains(logContent, message);
            StringAssert.Contains(logContent, "Test exception");
        }

        // Fatal уровень
        [TestMethod]
        public void LogFatal_WritesCorrectly()
        {
            // Arrange
            string message = "Fatal error";
            var exception = new Exception("Critical failure");

            // Act
            Logger.Fatal(message, exception);
            var logContent = File.ReadAllText(logFilePath);

            // Assert
            StringAssert.Contains(logContent, "FATAL");
            StringAssert.Contains(logContent, message);
            StringAssert.Contains(logContent, "Critical failure");
        }

        // Проверка временной метки
        [TestMethod]
        public void Log_ContainsTimestamp()
        {
            // Arrange
            var beforeLog = DateTime.Now;

            // Act
            Logger.Info("Timestamp test");

            // Assert
            var logContent = File.ReadAllText(logFilePath);
            StringAssert.Matches(logContent, new System.Text.RegularExpressions.Regex(@"\d{4}-\d{2}-\d{2} \d{2}:\d{2}:\d{2}"));
        }

        // Проверка что все уровни записываются
        [TestMethod]
        public void AllLogLevels_Recorded()
        {
            // Act
            Logger.Trace("Trace");
            Logger.Debug("Debug");
            Logger.Info("Info");
            Logger.Warn("Warn");
            Logger.Error("Error");
            Logger.Fatal("Fatal");

            var logContent = File.ReadAllText(logFilePath);

            // Assert
            StringAssert.Contains(logContent, "TRACE");
            StringAssert.Contains(logContent, "DEBUG");
            StringAssert.Contains(logContent, "INFO");
            StringAssert.Contains(logContent, "WARN");
            StringAssert.Contains(logContent, "ERROR");
            StringAssert.Contains(logContent, "FATAL");
        }
    }
}