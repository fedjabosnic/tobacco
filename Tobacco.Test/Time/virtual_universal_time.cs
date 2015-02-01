using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tobacco.Test.Time
{
	[TestClass]
	public class virtual_universal_time
	{
		[TestMethod]
		public void should_return_the_minimum_date_and_time_by_default()
		{
			var time = new Tobacco.Time.Virtual();

			time.Universal.Should().Be(DateTime.MinValue);
		}

		[TestMethod]
		public void should_return_the_date_and_time_it_was_given()
		{
			var time = new Tobacco.Time.Virtual();

			time.Universal = DateTime.Parse("21/07/2014 15:34:29");

			time.Universal.Should().Be(DateTime.Parse("21/07/2014 15:34:29"));
		}

		[TestMethod]
		public void should_return_the_date_and_time_it_was_given_with_utc_kind()
		{
			var time = new Tobacco.Time.Virtual();

			time.Universal = DateTime.Parse("21/07/2014 15:34:29");

			time.Universal.Kind.Should().Be(DateTimeKind.Utc);
		}
	}
}
