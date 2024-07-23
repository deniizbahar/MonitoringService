using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MonitoringService
{
    public partial class Form1 : Form
    {
        private readonly string logFilePath = @"C:\Logs\monitoring-log.json";
        private readonly string intervalFilePath = @"C:\Logs\interval.txt";
        private List<LogEntry> logEntries = new List<LogEntry>();

        public Form1()
        {
            InitializeComponent();
            LoadLogs();
            SetupComboBox();
        }

        private void SetupComboBox()
        {
            comboBoxLogLevel.Items.AddRange(Enum.GetNames(typeof(LogLevel)));
            comboBoxLogLevel.Items.Insert(0, "All"); // Add "All" option
            comboBoxLogLevel.SelectedIndex = 0; // Select "All" by default
            comboBoxLogLevel.SelectedIndexChanged += ComboBoxLogLevel_SelectedIndexChanged;
        }

        private void LoadLogs()
        {
            try
            {
                logEntries.Clear();
                var logLines = File.ReadAllLines(logFilePath);
                foreach (var line in logLines)
                {
                    try
                    {
                        var logEntry = JsonConvert.DeserializeObject<LogEntry>(line);
                        logEntries.Add(logEntry);
                    }
                    catch (JsonException jsonEx)
                    {
                        MessageBox.Show($"JSON deserialize error: {jsonEx.Message}");
                    }
                }
                dataGridViewLogs.DataSource = logEntries.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading logs: {ex.Message}");
            }
        }

        private void ComboBoxLogLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLevel = comboBoxLogLevel.SelectedItem.ToString();
            if (selectedLevel != "All" && Enum.TryParse(selectedLevel, out LogLevel logLevel))
            {
                var filteredLogs = logEntries.Where(log => log.Level == logLevel.ToString()).ToList();
                dataGridViewLogs.DataSource = filteredLogs;
            }
            else
            {
                dataGridViewLogs.DataSource = logEntries.ToList();
            }
        }

        private void buttonUpdateInterval_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxInterval.Text, out int newInterval) && newInterval > 0)
            {
                try
                {
                    File.WriteAllText(intervalFilePath, newInterval.ToString());
                    MessageBox.Show("Interval updated successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating interval: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid positive integer.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class LogEntry
    {
        public string Event { get; set; }
        public string Date { get; set; }
        public string Level { get; set; }
    }

    public enum LogLevel
    {
        TRACE,
        DEBUG,
        INFO,
        WARN,
        ERROR,
        FATAL
    }
}
