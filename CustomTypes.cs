using System;
using ComplexNumber;

namespace ComplexNumber
{
    public struct RealPart //new type for real part of complex number
    {
        private Double value;

        public RealPart(Double value) //parametrized constructor
        {
            this.value = value;
        }

        public Double add(RealPart number) //method to add two real parts
        {
            return this.value + number.value;
        }

        public Double substract(RealPart number) //method to substract two real parts
        {
            return this.value - number.value;
        }

        public Double multiply(RealPart number)  //method to multiply two real parts
        {
            return this.value * number.value;
        }

        public Double multiply(ImaginityPart number)//method to multiply a real and an imaginity parts
        {
            return this.value * number.getValue();
        }

        public Double getSquare() // return square of the value
        {
            return getValue() * getValue();
        }

        public Double getValue() // return the value
        {
            return this.value;
        }
    }

    public struct ImaginityPart //new type for imaginity part of complex number
    {
        private Double value;

        public ImaginityPart(Double value)
        {
            this.value = value;
        }

        public Double add(ImaginityPart number)
        {
            return this.value + number.value;
        }

        public Double substract(ImaginityPart number)
        {
            return this.value - number.value;
        }

        public Double multiply(ImaginityPart number)
        {
            return -this.value * number.getValue();
        }

        public Double multiply(RealPart number)
        {
            return this.value * number.getValue();
        }

        public Double getSquare()
        {
            return getValue() * getValue();
        }

        public Double getValue()
        {
            return this.value;
        }

    }
}
