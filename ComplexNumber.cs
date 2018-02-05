using System;

namespace ComplexNumber
{
    public class ComplexNumber // new type for complex number
    {
        private RealPart realPart;
        private ImaginityPart imaginityPart;

        public ComplexNumber() //parameterless constructor to declare with Zero values
        {
            this.realPart= new RealPart(0);
            this.imaginityPart = new ImaginityPart(0);
        }

        public ComplexNumber(Double realPart, Double imaginityPart)//constructor with params to declare with given values
        {
            this.realPart = new RealPart(realPart);
            this.imaginityPart = new ImaginityPart(imaginityPart);
        }

        public ComplexNumber add(ComplexNumber number)// method to add two complex numbers
        {
            return new ComplexNumber(this.realPart.add(number.realPart), this.imaginityPart.add(number.imaginityPart));
        }

        public ComplexNumber substract(ComplexNumber number)// method to substract two complex numbers
        {
            return new ComplexNumber(this.realPart.substract(number.realPart), this.imaginityPart.substract(number.imaginityPart));
        }
        
        public ComplexNumber multiply(ComplexNumber number)// method to multiply two complex numbers
        {
            Double realPart = this.realPart.multiply(number.realPart) + this.imaginityPart.multiply(number.imaginityPart);
            Double imaginityPart = this.realPart.multiply(number.imaginityPart) + this.imaginityPart.multiply(number.realPart);
            return new ComplexNumber(realPart, imaginityPart);
        }

        public ComplexNumber divide(ComplexNumber number)// method to divide two complex numbers
        {
            Double realPart = this.realPart.multiply(number.realPart) - this.imaginityPart.multiply(number.imaginityPart);
            Double imaginityPart = -this.realPart.multiply(number.imaginityPart) + this.imaginityPart.multiply(number.realPart);
            Double denominator = number.realPart.getSquare() + number.imaginityPart.getSquare();
            return new ComplexNumber(realPart / denominator, imaginityPart / denominator);
        }

        public Double getAbsValue()// get absoltute value of the complex number
        {
            return Math.Sqrt(this.realPart.getSquare() + this.imaginityPart.getSquare());
        }

        public Double getPhase()// get phase of the complex number
        {
            return Math.Atan(this.imaginityPart.getValue() / this.realPart.getValue());
        }

    }
}
