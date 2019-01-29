using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SENG8040_A1;
using NUnit.Framework;

namespace SENG8040_A1_Tests
{
	[TestFixture]
     class SENG8040_A1_Tests
    {
		[Test]
		public void GetLength_input3_expectLengthEquals3()
		{
			//Arrange
			int l = 3;
			int w = 1;
			Rectangle testRectangle = new Rectangle(l, w);

			//Act
			int length = testRectangle.Getlength();

			//Assert
			Assert.AreEqual(length, l);
		}
		[Test]
		public void SetLength_input8_expectLengthEquals8()
		{
			//Arrange
			int l = 8;
			int w = 4;
			Rectangle testRectangle = new Rectangle(l, w);

			//Act
			int length = testRectangle.Getlength();

			//Assert
			Assert.AreEqual(length, l);
		}
		[Test]
		public void GetWidth_input4_expectWidthEquals4()
		{
			//Arrange
			int l = 7;
			int w = 4;
			Rectangle testRectangle = new Rectangle(l, w);

			//Act
			int width = testRectangle.Getwidth();

			//Assert
			Assert.AreEqual(width, w);
		}
		[Test]
		public void SetWidth_input5_expectWidthEquals5()
		{
			//Arrange
			int l = 12;
			int w = 5;
			Rectangle testRectangle = new Rectangle(l, w);

			//Act
			int width = testRectangle.Getwidth();

			//Assert
			Assert.AreEqual(width, w);
		}
		[Test]
		public void GetArea_inputLength8andWidth5_expectAreaEquals40()
		{
			//Arrange
			int l = 8;
			int w = 5;
			Rectangle testRectangle = new Rectangle(l, w);

			//Act
			int area = testRectangle.Getarea();

			//Assert
			Assert.AreEqual(area,l*w);
		}
		[Test]
		public void GetPerimeter_inputLength8andWidth5_expectPerimeterEquals26()
		{
			//Arrange
			int l = 8;
			int w = 5;
			Rectangle testRectangle = new Rectangle(l, w);

			//Act
			int area = testRectangle.Getperimeter();

			//Assert
			Assert.AreEqual(area, (l*2) + (w*2));
		}




	}
}
