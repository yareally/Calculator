using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Fraction
    {
        public int Num { get; private set; }
        public int Den { get; private set; }

        public Fraction(int numerator, int denominator) {
            if (denominator == 0) {
                throw new ArgumentException("Denominator cannot be zero.", nameof(denominator));
            }
            Num = numerator;
            Den = denominator;
        }

        public Fraction Add(Fraction fraction) {
            return new Fraction(Num + fraction.Num, Den + fraction.Den);
        }

        public Fraction Subtract(Fraction fraction) {
            return new Fraction(Num + (-fraction.Num) , Den + (-fraction.Den));
        }

        public Fraction Multiply(Fraction fraction) {
            return new Fraction(Num * fraction.Num, Den * fraction.Den);
        }

        public Fraction Divide(Fraction fraction) {
            if (fraction.Num == 0) {
                throw new DivideByZeroException();
            }
            return new Fraction(Num * fraction.Den, Den * fraction.Num);
        }

        /// <inheritdoc />
        public override string ToString() {
            return $"{Num}/{Den}";
        }
    }
}
