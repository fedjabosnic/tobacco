using System;
using System.Globalization;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tobacco.Test.Time
{
	[TestClass]
	public class virtual_local_time
	{
		[TestMethod]
		public void should_return_the_minimum_date_and_time_by_default()
		{
			var time = new Tobacco.Time.Virtual();

			time.Local.Should().Be(DateTime.MinValue);
		}

		[TestMethod]
		public void should_return_the_date_and_time_it_was_given()
		{
			var time = new Tobacco.Time.Virtual();

			time.Local = DateTime.ParseExact("21/07/2014 15:34:29", "dd/MM/yyyy HH:mm:ss", null);

			time.Local.Should().Be(DateTime.ParseExact("21/07/2014 15:34:29", "dd/MM/yyyy HH:mm:ss", null));
		}

		[TestMethod]
		public void should_return_the_date_and_time_it_was_given_with_local_kind()
		{
			var time = new Tobacco.Time.Virtual();

			time.Local = DateTime.ParseExact("21/07/2014 15:34:29", "dd/MM/yyyy HH:mm:ss", null);

			time.Local.Kind.Should().Be(DateTimeKind.Local);
		}
	}
}
