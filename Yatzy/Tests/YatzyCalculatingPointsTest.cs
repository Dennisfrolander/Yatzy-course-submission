using Xunit;


namespace Yatzy.Tests

{
	public class YatzyCalculatingPointsTest

	{
		[Theory]
		[InlineData(3, 1, 1, 5, 1, 3)]
		[InlineData(3, 3, 3, 6, 6, 9)]
		[InlineData(6, 6, 3, 3, 3, 12)]
		public void ettSex(int valueA, int valueB, int valueC, int valueD, int valueF, int expected)
		{
			var calculator = new YatzyCalculatingPointMethods();
			var result = calculator.ettTillSex(valueA, valueB, valueC, valueD, valueF);
			Assert.Equal(expected, result);
		}

		[Theory]
		[InlineData(5, 5, 5, 5, 5, 10)]
		[InlineData(1, 2, 1, 2, 1, 4)]
		[InlineData(4, 6, 6, 4, 5, 12)]
		public void parTest(int valueA, int valueB, int valueC, int valueD, int valueF, int expected)
		{
			var calculator = new YatzyCalculatingPointMethods();
			var result = calculator.Par(valueA, valueB, valueC, valueD, valueF);
			Assert.Equal(expected, result);
		}

		[Theory]
		[InlineData(3, 3, 4, 4, 4, 12)]
		[InlineData(5, 2, 2, 2, 5, 6)]
		[InlineData(1, 1, 1, 6, 6, 3)]
		[InlineData(6, 6, 2, 2, 5, 0)]
		public void TrissTest(int valueA, int valueB, int valueC, int valueD, int valueF, int expected)
		{
			var calculator = new YatzyCalculatingPointMethods();
			var result = calculator.Triss(valueA, valueB, valueC, valueD, valueF);
			Assert.Equal(expected, result);
		}
		[Theory]
		[InlineData(1, 1, 1, 1, 1, 4)]
		[InlineData(3, 2, 3, 3, 6, 0)]
		[InlineData(6, 6, 6, 6, 3, 24)]
		public void fyrtalTest(int valueA, int valueB, int valueC, int valueD, int valueF, int expected)
		{
			var calculator = new YatzyCalculatingPointMethods();
			var result = calculator.fyrtal(valueA, valueB, valueC, valueD, valueF);
			Assert.Equal(expected, result);
		}
		[Theory]
		[InlineData(1, 1, 1, 1, 1, 0)]
		[InlineData(2, 6, 3, 3, 6, 0)]
		[InlineData(1, 1, 1, 2, 2, 7)]
		public void kåkTest(int valueA, int valueB, int valueC, int valueD, int valueF, int expected)
		{
			var calculator = new YatzyCalculatingPointMethods();
			var result = calculator.kåk(valueA, valueB, valueC, valueD, valueF);
			Assert.Equal(expected, result);
		}
		[Theory]
		[InlineData(1, 1, 1, 2, 2, 6)]
		[InlineData(6, 2, 2, 2, 6, 16)]
		[InlineData(2, 2, 2, 2, 2, 8)]
		[InlineData(1, 2, 6, 3, 6, 0)]
		[InlineData(4, 3, 3, 4, 4, 14)]
		[InlineData(4, 4, 4, 5, 4, 16)]
		public void tvåparTest(int valueA, int valueB, int valueC, int valueD, int valueF, int expected)
		{
			var calculator = new YatzyCalculatingPointMethods();
			var result = calculator.tvåpar(valueA, valueB, valueC, valueD, valueF);
			Assert.Equal(expected, result);
		}
		[Theory]
		[InlineData(1, 3, 5, 2, 4, 15)]
		[InlineData(2, 6, 3, 3, 6, 0)]
		[InlineData(1, 2, 3, 5, 4, 15)]
		[InlineData(1, 2, 3, 6, 4, 0)]
		[InlineData(6, 5, 4, 3, 2, 0)]
		public void litenStegeTest(int valueA, int valueB, int valueC, int valueD, int valueF, int expected)
		{
			var calculator = new YatzyCalculatingPointMethods();
			var result = calculator.litenStege(valueA, valueB, valueC, valueD, valueF);
			Assert.Equal(expected, result);
		}
		[Theory]
		[InlineData(6, 3, 5, 2, 4, 20)]
		[InlineData(2, 6, 3, 3, 6, 0)]
		[InlineData(6, 2, 3, 5, 4, 20)]
		[InlineData(1, 2, 3, 6, 4, 0)]
		[InlineData(6, 5, 4, 3, 2, 20)]
		[InlineData(1, 5, 4, 3, 2, 0)]
		public void storStegeTest(int valueA, int valueB, int valueC, int valueD, int valueF, int expected)
		{
			var calculator = new YatzyCalculatingPointMethods();
			var result = calculator.storStege(valueA, valueB, valueC, valueD, valueF);
			Assert.Equal(expected, result);
		}
		[Theory]
		[InlineData(3, 3, 3, 3, 2, 0)]
		[InlineData(2, 2, 2, 2, 2, 50)]
		[InlineData(6, 6, 6, 5, 6, 0)]
		[InlineData(1, 2, 3, 6, 4, 0)]
		[InlineData(6, 6, 6, 6, 6, 50)]
		[InlineData(1, 2, 2, 2, 2, 0)]
		public void YatzyTest(int valueA, int valueB, int valueC, int valueD, int valueF, int expected)
		{
			var calculator = new YatzyCalculatingPointMethods();
			var result = calculator.yatzy(valueA, valueB, valueC, valueD, valueF);
			Assert.Equal(expected, result);
		}
	}
}
