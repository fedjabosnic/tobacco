using System;

namespace Tobacco
{
	public static class Environment
	{
		public static ITime Time { get; set; }
	}

	public interface ITime
	{
		DateTime Local { get; }
		DateTime Universal { get; }
		DateTime Localized(TimeZoneInfo timezone);
	}

	public class Time : ITime
	{
		public DateTime Local { get { return DateTime.Now; } }
		public DateTime Universal { get { return DateTime.UtcNow; } }
		public DateTime Localized(TimeZoneInfo timezone) { return TimeZoneInfo.ConvertTimeBySystemTimeZoneId(Universal, TimeZoneInfo.Utc.Id, timezone.Id); }
	}
}
