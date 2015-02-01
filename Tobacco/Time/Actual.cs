using System;

namespace Tobacco.Time
{
	public class Actual : ITime
	{
		public DateTime Local
		{
			get
			{
				return DateTime.Now;
			}
		}

		public DateTime Universal
		{
			get
			{
				return DateTime.UtcNow;
			}
		}

		public DateTime Localized(string timezone)
		{
			return TimeZoneInfo.ConvertTimeBySystemTimeZoneId(Universal, TimeZoneInfo.Utc.Id, timezone);
		}
	}
}