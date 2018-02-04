using System;
using ComplexNumber;

namespace ComplexNumber
{
    public struct RealPart
    {
        private Double value;

        public RealPart(Double value)
        {
            this.value = value;
        }

        public Double add(RealPart number)
        {
            return this.value + number.value;
        }

        public Double substract(RealPart number)
        {
            return this.value - number.value;
        }

        public Double multiply(RealPart number)
        {
            return this.value * number.value;
        }

        public Double multiply(ImaginityPart number)
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

    public struct ImaginityPart
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
