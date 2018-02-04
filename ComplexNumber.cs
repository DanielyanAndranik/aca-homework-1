using System;

namespace ComplexNumber
{
    public class ComplexNumber
    {
        private RealPart realPart;
        private ImaginityPart imaginityPart;

        public ComplexNumber()
        {
            this.realPart= new RealPart(0);
            this.imaginityPart = new ImaginityPart(0);
        }

        public ComplexNumber(Double realPart, Double imaginityPart)
        {
            this.realPart = new RealPart(realPart);
            this.imaginityPart = new ImaginityPart(imaginityPart);
        }

        public ComplexNumber add(ComplexNumber number)
        {
            return new ComplexNumber(this.realPart.add(number.realPart), this.imaginityPart.add(number.imaginityPart));
        }

        public ComplexNumber substract(ComplexNumber number)
        {
            return new ComplexNumber(this.realPart.substract(number.realPart), this.imaginityPart.substract(number.imaginityPart));
        }
        
        public ComplexNumber multiply(ComplexNumber number)
        {
            Double realPart = this.realPart.multiply(number.realPart) + this.imaginityPart.multiply(number.imaginityPart);
            Double imaginityPart = this.realPart.multiply(number.imaginityPart) + this.imaginityPart.multiply(number.realPart);
            return new ComplexNumber(realPart, imaginityPart);
        }

        public ComplexNumber divide(ComplexNumber number)
        {
            Double realPart = this.realPart.multiply(number.realPart) - this.imaginityPart.multiply(number.imaginityPart);
            Double imaginityPart = -this.realPart.multiply(number.imaginityPart) + this.imaginityPart.multiply(number.realPart);
            Double denominator = number.realPart.getSquare() + number.imaginityPart.getSquare();
            return new ComplexNumber(realPart / denominator, imaginityPart / denominator);
        }

        public Double getAbsValue()
        {
            return Math.Sqrt(this.realPart.getSquare() + this.imaginityPart.getSquare());
        }

        public Double getPhase()
        {
            return Math.Atan(this.imaginityPart.getValue() / this.realPart.getValue());
        }

    }
}
