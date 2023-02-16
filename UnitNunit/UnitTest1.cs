using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;

namespace UnitNunit
{
	[TestFixture]
	public class UnitTest1
	{
		[SetUp]
		public void SetUp()
		{
			Console.WriteLine("I am a SetUp Method");
		}

		[OneTimeSetUp]
		public void OneTimeSetUp()
		{
			Console.WriteLine(" I am one time Setup Method");
		}
		[TearDown] public void TearDown() 
		{
			Console.WriteLine("I am tear down method"); 
		}
		[Test]
		public void TestMethod1()
		{
			Console.WriteLine(" I am Test Method");
		}
	}
}
