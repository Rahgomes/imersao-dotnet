namespace SocialBots.Data.DTOs;

public class ReadUserDTO
{
    public string Name { get; set; }
    public string Nickname { get; set; }
    public string Job { get; set; }
    public DateTime queryHour { get; set; } = DateTime.Now;
}
