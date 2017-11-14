using ContosoUniversity.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUniversity.Tests
{
	[TestFixture]
	public class TestClass
	{
		[Test]
		public void TestMethod()
		{
			// TODO: Add your test code here
			Assert.Pass("Your first passing test");
		}

		[Test]
		public void TestStudentNextYearOld()
		{
			var employee = new Student();

			int i = 20;

			// TODO: Add your test code here
			Assert.AreEqual(employee.NextYearOld(), i);
		}
	}
}
