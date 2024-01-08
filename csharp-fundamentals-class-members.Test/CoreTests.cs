using csharp_fundamentals_class_members.Main;
using NUnit.Framework;

namespace csharp_fundamentals_class_members.Test
{
    public class CoreTests
    {
    
        [Test]
        public void shouldAnswerTheUltimateQuestion()
        {
            Core exercise = new Core();
            Assert.AreEqual(42, exercise.answerToTheUltimateQuestion);
        }

        [Test]
        public void shouldBeAged32()
        {
            Core exercise = new Core();
            Assert.AreEqual(32, exercise.age);
        }

        [Test]
        public void shouldBeNamedJane()
        {
            Core exercise = new Core();
            Assert.AreEqual("Jane", exercise.firstName);
        }

        [Test]
        public void shouldBeAProgrammer()
        {
            Core exercise = new Core();
            Assert.IsTrue(exercise.isProgrammer);
        }

        [Test]
        public void firstNumberShouldBe9182()
        {
            Core exercise = new Core();
            Assert.AreEqual(9182, exercise.firstNumber);
        }

        [Test]
        public void firstStringShouldBeSpecific()
        {
            Core exercise = new Core();
            Assert.AreEqual("Java is to Javascript what car is to carpet.", exercise.firstString);
        }

        [Test]
        public void isVisibleShouldBePublic()
        {
            Core exercise = new Core();
            Assert.IsTrue(exercise.isVisible);
        }
    }
}