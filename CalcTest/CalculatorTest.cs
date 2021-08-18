using Calc;
using System;
using Xunit;

namespace CalcTest
{
    public class CalculatorTest
    {
        [Fact]
        public void ShouldAdd()
        {
            //测试的三个阶段。
            //Arrange: (序列，安排)，这里做一些先决的设定，例如创建对象实例，数据，输入等等。
            //Act ，在这里执行生产代码并返回结果，例如调用方法和设置属性。
            //Assert：（主张）在这里检测结果，测试通过或者失败。

            // Arrange
            var sut = new Calculator();// system Under Test

            // Act
            var result = sut.Add(1, 2);

            // Assert

            Assert.Equal(3, result);//结果等于3
        }

        //举例前边的，加法的测试，可以写多个 fact，但是比较麻烦，使用【Theory】+ 【InlineData】有简单的方法。
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(1, 3, 4)]
        [InlineData(2, 2, 4)]
        [InlineData(1, 9, 10)]
        [InlineData(9, 2, 11)]
        public void ShouldAddEquls(int x, int y, int expected)
        {
            var sut = new Calculator();
            var reslut = sut.Add(x, y);
            Assert.Equal(expected, reslut);
        }

    }
}
