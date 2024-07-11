namespace Clean.Architecture.Infrastructure.Email;

public class MailserverConfiguration
{
  public string Hostname { get; init; } = "localhost";
  public int Port { get; init; } = 25;
}
