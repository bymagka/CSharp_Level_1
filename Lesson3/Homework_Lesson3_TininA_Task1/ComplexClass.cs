using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Lesson3_TininA_Task1
{
        enum Operations
        {
            Minus,
            Multi,
            Plus
        }
 
        class ComplexClass
        {
            
            
            private double im;
           
            double re;

         

            public ComplexClass()
            {
                im = 0;
                re = 0;
            }

            public ComplexClass(double _im, double re)
            {
                           
                im = _im;
                this.re = re;
            }
            private ComplexClass Plus(ComplexClass x)
            {
                ComplexClass y = new ComplexClass();
                y.im = x.im + im;
                y.re = x.re + re;
                return y;
            }


            private ComplexClass Multi(ComplexClass x)
            {
                ComplexClass y = new ComplexClass();
                y.im = re * x.im + im * x.re;
                y.re = re * x.re - im * x.im;
                return y;
            }

            private ComplexClass Minus(ComplexClass x)
            {
                ComplexClass y = new ComplexClass();
                y.im = x.im + im;
                y.re = x.re + re;
                return y;
            }

            public ComplexClass Operation(Operations Operation, ComplexClass SecondNumber)
            {
                switch (Operation)
                {
                    case Operations.Minus:
                        return this.Minus(SecondNumber);
                    case Operations.Plus:
                        return this.Plus(SecondNumber);
                    case Operations.Multi:
                        return this.Multi(SecondNumber);
                }
                return new ComplexClass();
            }

        public double Im
            {
                get { return im; }
                set
                {
                  
                    if (value >= 0) im = value;
                }
            }
     
            public override string ToString()
            {
                return re + "+" + im + "i";
            }
        }
    }
   

