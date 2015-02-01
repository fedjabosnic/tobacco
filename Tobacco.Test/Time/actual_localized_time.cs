using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tobacco.Test.Time
{
	[TestClass]
	public class actual_localized_time
	{
		[TestMethod]
		[Ignore]
		public void should_return_the_current_date_and_time_of_the_specified_timezone()
		{
			var time = new Tobacco.Time.Actual();

			// TODO: Figure out how to test this without rewriting the functionality...
		}

		[TestMethod]
		public void should_return_a_datetime_with_an_unspecified_kind()
		{
			var time = new Tobacco.Time.Actual();

			time.Localized("Eastern Standard Time").Kind.Should().Be(DateTimeKind.Unspecified);
		}
	}
}