using System;
using System.IO;
using System.ServiceProcess;
using Günlük; // Günlük namespace'ini import et
using Serilog.Events;

namespace MockService
{
    public partial class Service1 : ServiceBase
    {
        private FileSystemWatcher _fileSystemWatcher;
        private string _directoryToWatch = @"C:\İzlenecekdosyadizini"; // İzlenecek dizin

        public void savenewconfig(ServiceConfigDto newConfig)
        {
            LoggerHelper.SetLogLevel(newConfig.LogLevel);
        }
        

        protected override void OnStart(string[] args)
        {
         
            LoggerHelper.ConfigureLogger(new LoggerService("C://Logs/mock_service_log.json", LogEventLevel.Information));

            // Default log seviyesini ayarla
            LoggerHelper.SetLogLevel(LogEventLevel.Information);

            LoggerHelper.Log(LogEventLevel.Information, "Service has started.");

            _fileSystemWatcher = new FileSystemWatcher
            {
                Path = _directoryToWatch,
                NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName
            };

            _fileSystemWatcher.Created += OnChanged;
            _fileSystemWatcher.Deleted += OnChanged;
            _fileSystemWatcher.Renamed += OnRenamed;
            _fileSystemWatcher.EnableRaisingEvents = true;
        }

        protected override void OnStop()
        {
            LoggerHelper.Log(LogEventLevel.Information, "Service has stopped.");

            _fileSystemWatcher.EnableRaisingEvents = false;
            _fileSystemWatcher.Dispose();
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            string eventType = e.ChangeType == WatcherChangeTypes.Created ? "FileCreated" : "FileDeleted";
            LoggerHelper.Log(LogEventLevel.Information, $"{eventType}: {e.FullPath}");
        }

        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            LoggerHelper.Log(LogEventLevel.Information, $"FileRenamed: Renamed from {e.OldFullPath} to {e.FullPath}");
        }
    }
}
