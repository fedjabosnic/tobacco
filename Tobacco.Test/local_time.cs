using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tobacco.Test
{
	[TestClass]
	public class local_time
	{
		[TestMethod]
		public void should_return_a_local_datetime()
		{
			var time = new Time();

			time.Local.Kind.Should().Be(DateTimeKind.Local);
		}
	}

	[TestClass]
	public class universal_time
	{
		[TestMethod]
		public void should_return_a_utc_datetime()
		{
			var time = new Time();

			time.Universal.Kind.Should().Be(DateTimeKind.Utc);
		}
	}

	[TestClass]
	public class localized_time
	{
		[TestMethod]
		public void should_return_an_unspecified_datetime()
		{
			var time = new Time();

			time.Localized(TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time")).Kind.Should().Be(DateTimeKind.Unspecified);
		}
	}
}
