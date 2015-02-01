using System;

namespace Tobacco
{
	public interface ITime
	{
		/// <summary>
		/// Returns the current local time of the hosting machine/os (equivalent to DateTime.Now)
		/// </summary>
		DateTime Local { get; }
		/// <summary>
		/// Returns the current universal time irregardless of the hosting machine/os (equivalent to DateTime.UtcNow).
		/// </summary>
		DateTime Universal { get; }
		/// <summary>
		/// Returns the current time localized to the specified timezone.
		/// </summary>
		DateTime Localized(string timezone);
	}
}