using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tobacco.Test.Time
{
	[TestClass]
	public class virtual_localized_time
	{
		[TestMethod]
		public void should_return_the_minimum_date_and_time_by_default()
		{
			var time = new Tobacco.Time.Virtual();

			time.Universal.Should().Be(DateTime.MinValue);
		}

		[TestMethod]
		[Ignore]
		public void should_return_the_date_and_time_it_was_given_for_that_timezone()
		{
			var time = new Tobacco.Time.Virtual();

			// TODO: Figure out how to do this
		}

		[TestMethod]
		[Ignore]
		public void should_return_the_date_and_time_it_was_given_with_unspecified_kind()
		{
			var time = new Tobacco.Time.Virtual();

			// TODO: Figure out how to do this
		}
	}
}
