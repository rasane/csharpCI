namespace ClassLibrary1UnitTests
{
    using FluentAssertions;
    using NUnit.Framework;
    

    [TestFixture]
    public class Class1Tests
    {
        [Test]
        public void Degenerate_TestsCanWork_LoremIpsum()
        {
            //Arrange

            //Act
            var class1 = new ClassLibrary1.Class1();
            var returnValue = class1.Add(4, 3);

            //Assert
            returnValue.Should().Be(7);
        }

    }
}
