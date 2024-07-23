using Serilog.Events;

public enum ApplicationType
{
    mywebapipool,
    MockService,
    ControlService
}

public class ServiceConfigDto
{
    public ApplicationType Application { get; set; }
    public LogEventLevel LogLevel { get; set; }
    public int? MonitoringFrequency { get; set; } // ControlService için null olabilir
}
