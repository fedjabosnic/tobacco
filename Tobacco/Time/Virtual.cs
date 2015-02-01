using System;

namespace Tobacco.Time
{
	public class Virtual : ITime
	{
		private DateTime _local;
		private DateTime _universal;

		public DateTime Local
		{
			get
			{
				return _local;
			}
			set
			{
				_local = DateTime.SpecifyKind(value, DateTimeKind.Local);
			}
		}

		public DateTime Universal
		{
			get
			{
				return _universal;
			}
			set
			{
				_universal = DateTime.SpecifyKind(value, DateTimeKind.Utc);
			}
		}

		public DateTime Localized(string timezone)
		{
			// TODO: Figure out how to expose setting up a return value per timezone
			return default(DateTime);
		}
	}
}
