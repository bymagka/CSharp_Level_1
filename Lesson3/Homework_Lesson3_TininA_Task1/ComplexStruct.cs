namespace Homework_Lesson3_TininA_Task1
{
    struct ComplexStruct
    { 
        private double im;
        private double re;
          
        public ComplexStruct(double im, double re)
        {
            this.im = im;
            this.re = re;
        }

        public ComplexStruct Plus(ComplexStruct x)
        {
            ComplexStruct y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
            
        public ComplexStruct Minus(ComplexStruct x)
        {
            ComplexStruct y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }

        public ComplexStruct Multi(ComplexStruct x)
        {
            ComplexStruct y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }

        public override string ToString()
        {
            return re + "+" + im + "i";
        }
    }   
   
}
