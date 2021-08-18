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
            //���Ե������׶Ρ�
            //Arrange: (���У�����)��������һЩ�Ⱦ����趨�����紴������ʵ�������ݣ�����ȵȡ�
            //Act ��������ִ���������벢���ؽ����������÷������������ԡ�
            //Assert�������ţ�����������������ͨ������ʧ�ܡ�

            // Arrange
            var sut = new Calculator();// system Under Test

            // Act
            var result = sut.Add(1, 2);

            // Assert

            Assert.Equal(3, result);//�������3
        }

        //����ǰ�ߵģ��ӷ��Ĳ��ԣ�����д��� fact�����ǱȽ��鷳��ʹ�á�Theory��+ ��InlineData���м򵥵ķ�����
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
