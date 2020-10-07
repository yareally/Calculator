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
            return new Fraction((Num * fraction.Den) + (fraction.Num * Den), Den * fraction.Den);
        }

        public Fraction Subtract(Fraction fraction) {
            return new Fraction((Num * fraction.Den) - (fraction.Num * Den), Den * fraction.Den);
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

        public static Fraction operator +(Fraction x, Fraction y) => x.Add(y);

        public static Fraction operator -(Fraction x, Fraction y) => x.Subtract(y);
        public static Fraction operator *(Fraction x, Fraction y) => x.Multiply(y);
        public static Fraction operator /(Fraction x, Fraction y) => x.Divide(y);

        public static implicit operator Fraction(int num) => new Fraction(2, 1);

        public static implicit operator int(Fraction fraction) => fraction.Num / fraction.Den;
        /// <inheritdoc />
        public override string ToString() {
            return $"{Num}/{Den}";
        }

        /// <inheritdoc />
        public override bool Equals(object? obj) {
            if (obj == null) {
                return false;
            }
            var fraction = (Fraction)obj;

            return Num == fraction.Num && Den == fraction.Den;
        }
    }
}
