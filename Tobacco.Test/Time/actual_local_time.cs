using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tobacco.Test.Time
{
	[TestClass]
	public class actual_local_time
	{
		[TestMethod]
		public void should_return_the_current_date_and_time_of_the_native_timezone()
		{
			var time = new Tobacco.Time.Actual();
			
			time.Local.Should().BeCloseTo(DateTime.Now, 1000);
		}

		[TestMethod]
		public void should_return_a_datetime_with_a_local_kind()
		{
			var time = new Tobacco.Time.Actual();

			time.Local.Kind.Should().Be(DateTimeKind.Local);
		}
	}
}
