using System;
using System.Collections.Generic;
using System.Text;

namespace MyDataStructures
{
    public class Polynomial
    {
        public Polynomial(int[] powers)
        {
            polinomial = new List<Variable>(powers.Length);
            foreach (int power in powers)
            {
                polinomial.Add(new Variable(power));
            }
        }



        //public Polynomial(string polinomial)
        //{
        //    this.polinomial = new List<Variable>();
        //    polinomial = polinomial.Replace(" ","");
            
        //}



        public double this[double x]
        {
            get { return Calculate(x); }
        }



        public double Calculate(double x)
        {
            double res = 0;
            foreach(Variable el in polinomial)
            {
                res += Math.Pow(x, el.Power);
            }

            return res;
        }



        private List<Variable> polinomial;

        static private string pow = @"^";
    }



    struct Variable
    {
        public Variable(int power, double k = 1) : this()
        {
            Power = power;
            K = k;
        }

        public int Power { get; set; }
        public double K { get; set; }
    }
}
