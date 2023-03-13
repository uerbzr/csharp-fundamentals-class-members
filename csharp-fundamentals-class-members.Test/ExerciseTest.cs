using csharp_fundamentals_class_members.Main;
using NUnit.Framework;

namespace csharp_fundamentals_class_members.Test
{
    public class ExerciseTest
    {
        Exercise _exercise;


        public ExerciseTest()
        {
            this._exercise = new Exercise();
        }

        [Test]
        public void shouldAnswerTheUltimateQuestion()
        {
            Assert.AreEqual(42, this._exercise.answerToTheUltimateQuestion);
        }

        [Test]
        public void shouldBeAged32()
        {
            Assert.AreEqual(32, this._exercise.age);
        }

        [Test]
        public void shouldBeNamedJane()
        {
            Assert.AreEqual("Jane", this._exercise.firstName);
        }

        [Test]
        public void shouldBeAProgrammer()
        {
            Assert.IsTrue(this._exercise.isProgrammer);
        }

        [Test]
        public void firstNumberShouldBe9182()
        {
            Assert.AreEqual(9182, this._exercise.firstNumber);
        }

        [Test]
        public void firstStringShouldBeSpecific()
        {
            Assert.AreEqual("Java is to Javascript what car is to carpet.", this._exercise.firstString);
        }

        [Test]
        public void isVisibleShouldBePublic()
        {
            
            Assert.IsTrue(this._exercise.isVisible);
        }
    }
}