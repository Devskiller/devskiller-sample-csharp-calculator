using System;
using NUnit.Framework;
using CalculatorSample;

namespace CalculatorSample.Tests
{
	[TestFixture]
	public class CalculatorTest
	{

		[TestCase( 2,  2,  4)]
		[TestCase(-2,  2,  0)]
		[TestCase(-2, -2, -4)]
		public void ThatAddingIsWorkingCorrectly(int a, int b, int expected)
		{
			//Setup
			Calculator sut = new Calculator();
			//Act
			int actual = sut.Add(a,b);
			//Verify
			Assert.AreEqual(expected, actual, "The Add functionality is not working correctly.");
		}

		[TestCase( 2,  2,  0)]
		[TestCase(-2,  2, -4)]
		[TestCase(-2, -2, -0)]
		public void ThatSubtractingIsWorkingCorrectly(int a, int b, int expected)
		{
			//Setup
			Calculator sut = new Calculator();
			//Act
			int actual = sut.Subtract(a, b);
			//Verify
			Assert.AreEqual(expected, actual, "The Subtract functionality is not working correctly.");
		}

		[TestCase( 2, 2,  4)]
		[TestCase(-2, 2, -4)]
		[TestCase(-2, -2, 4)]
		public void ThatMultiplyIsWorkingCorrectly(int a, int b, int expected)
		{
			//Setup
			Calculator sut = new Calculator();
			//Act
			int actual = sut.Multiply(a, b);
			//Verify
			Assert.AreEqual(expected, actual, "The Multiply functionality is not working correctly.");
		}
			
		[TestCase( 2, 2,  1)]
		[TestCase(-2, 2, -1)]
		[TestCase(-2, -2, 1)]
		[TestCase(9, 3, 3)]
		[TestCase(1, 3, 0.33333)]
		public void ThatDivisionIsWorkingCorrectly(int a, int b, double expected)
		{
			//Setup
			Calculator sut = new Calculator();
			//Act
			double actual = sut.Divide(a, b);
			//Verify
			Assert.AreEqual(expected, actual, 0.001, "The Divide functionality is not working correctly.");
		}
			
	}
}