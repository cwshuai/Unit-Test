using Calc;
using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace CalcTest
{
    public class PatientTest
    {

        private readonly ITestOutputHelper output;
        private readonly Patient _patient;

        public PatientTest(ITestOutputHelper output)
        {
            this.output = output;
            _patient = new Patient();
           
        }


        // 对 bool 类型进行判断.
        [Fact]
        [Trait("Category", "New")]
        public void BeNewWhenCreated()
        {
            output.WriteLine("这是第一个测试");//在这里用 Console.WriteLine()是无效的;

            //arrange
            //Patient patient = new Patient();

            //Act
            bool result = _patient.IsNew;

            //Assert
            Assert.True(result);
            //Assert.False(result);
        }


        //对字符串进行判断
        //[Fact] //表明这个是个测试方法
        [Fact(Skip = "不需要跑这个测试")]
        public void HaveCorrctFullName()
        {
            // Arrange (实例化一个你要检查的类)
            Patient patient = new Patient
            {
                FirstName = "小明",
                LastName = "张"
            };
            // Act 。把需要检查的属性弄出来
            var fullName = patient.FullName;

            //Assert 。进行判断.
            Assert.Equal("张小明", fullName);
            Assert.StartsWith("张", fullName);
            Assert.EndsWith("明", fullName);
            Assert.Contains("小", fullName);
            //是小写但不是大写；
            Assert.NotEqual("李", fullName);
        }


        //对 浮点型 进行判断
        [Fact]
        public void HaveDefaultBloodSugarWhenCreate()
        {
            Patient patient = new Patient();
            float blooddar = patient.BloodSugar;
            Assert.Equal(4.9f, blooddar, 5);
            //在哪个范围内
            Assert.InRange(blooddar, 4.9f, 6.1f);
        }

        //刚开始创建的时候，名字应该是空;
        [Fact]
        public void HaveNameWhenCreated()
        {
            Patient p = new Patient();
            var a = p.FirstName;
            Assert.Null(a);
            Assert.NotNull(p);
        }


        //对集合进行测试
        [Fact]
        public void HaveHadColid()
        {
            var p = new Patient();
            p.History.Add("感冒");
            p.History.Add("发烧");
            p.History.Add("水痘");
            p.History.Add("腹泻");
            Assert.Contains("感冒", p.History);
            Assert.DoesNotContain("心脏病", p.History);

            //Predicate
            //对集合中的元素判断是否包含
            Assert.Contains(p.History, x => x.StartsWith("水"));
            //对集合内的所有元素都进行判断
            Assert.All(p.History, x => Assert.True(x.Length >= 2));


            // 判断两个集合是否相等

            var diseases = new List<string>
            {
                "感冒",
                "发烧",
                "水痘",
                "腹泻"
            };
            Assert.Equal(p.History, diseases);
        }


        // 对  object 进行测试
        [Fact]
        public void BeAPerson()
        {
            var p1 = new Patient();
            var p2 = new Patient();
            Assert.IsType<Patient>(p1);//p是否是 patient 类型.
            Assert.IsNotType<Person>(p1);//这个就会判断处所。尽管是他的子类.
            Assert.IsAssignableFrom<Person>(p1);//判断是否继承于某个类

            //判断是否是一个实例
            //same 是同一个实例
            Assert.NotSame(p1, p2);
            // Assert.Same(p1,p2);
        }

        // 判断异常
        // 判断抛出的异常是否和我们所期待的相等.
        // 对委托和事件的测试.
        // 写起来有点麻烦，用到再说吧。
    }
}
