using System;

using NUnit.Framework;

namespace Calculator.Test
{
    public class FractionTests {
        private Fraction x;
        private Fraction y;

        [SetUp]
        public void Setup() {
            x = new Fraction(1, 2);
            y = new Fraction(1, 4);
        }

        [Test]
        public void TriggerExceptionOnCreate() {
            bool triggeredException = false;

            try {
                new Fraction(0, 0);
            } catch (ArgumentException e) {
                triggeredException = true;
            }

            Assert.True(triggeredException, 
                "Exception was not triggered when creating the fraction with a 0 denominator");
        }

        [Test]
        public void CreateFractionTest() {
            var fraction = new Fraction(1, 3);
            Assert.NotNull(fraction);
            Assert.AreEqual(1, fraction.Num);
            Assert.AreEqual(3, fraction.Den);
        }

        [Test]
        public void TriggerExceptionWithNunit() {
            Assert.Throws<ArgumentException>(() => new Fraction(0, 0));
        }

        [Test]
        public void AddTest() {
            var expected = new Fraction(6, 8);
            var actual = x + y;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubTest()
        {
            Assert.AreEqual(new Fraction(2, 8), x - y);
        }

        [Test]
        public void MultTest()
        {
            Assert.AreEqual(new Fraction(1, 8), x * y);
        }

        [Test]
        public void DivTest() {
            var divByZero = new Fraction(0, 4);
            bool triggeredException = false;

            try {
                var result = x / divByZero;
            }
            catch (DivideByZeroException e) {
                triggeredException = true;
            }
            Assert.True(triggeredException);
            Assert.AreEqual(2, (int) (x / y ));
        }

        [Test]
        public void ToStringTest()
        {
            Assert.AreEqual("1/2", x.ToString());
            Assert.AreEqual("1/4", y.ToString());
        }
    }
}