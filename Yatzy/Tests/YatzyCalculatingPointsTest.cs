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

	}
}
