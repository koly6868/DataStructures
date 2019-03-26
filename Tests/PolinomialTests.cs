using System;
using Xunit;
using MyDataStructures;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class PolinomialTests
    {
        [Fact]
        public void Test()
        {
            Polynomial p = new Polynomial(new int[] { 2 });
            double x = 2;
            double answ = 4;

            double res = p[x];


            Assert.True(Math.Abs(res - answ) < 0.000000001);
        }



        [Fact]
        public void Test2()
        {
            Polynomial p = new Polynomial(new int[] { 2 });
            double x = 2;
            double answ = 4;

            double res = p[x];


            Assert.True(Math.Abs(res - answ) < 0.000000001);
        }
    }
}
