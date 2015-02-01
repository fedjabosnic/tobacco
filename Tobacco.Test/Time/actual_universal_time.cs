using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tobacco.Test.Time
{
	[TestClass]
	public class actual_universal_time
	{
		[TestMethod]
		public void should_return_the_current_date_and_time_of_the_universal_timezone()
		{
			var time = new Tobacco.Time.Actual();

			time.Universal.Should().BeCloseTo(DateTime.UtcNow, 1000);
		}

		[TestMethod]
		public void should_return_a_datetime_with_a_utc_kind()
		{
			var time = new Tobacco.Time.Actual();

			time.Universal.Kind.Should().Be(DateTimeKind.Utc);
		}
	}
}