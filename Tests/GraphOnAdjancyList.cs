using System;
using Xunit;
using MyDataStructures;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class GraphOnAdjancyList
    {
        [Fact]
        public void Test()
        {
            string a = "a";
            string b = "b";
            string c = "c";
            GraphOnAdjancyList<string> g = new GraphOnAdjancyList<string>();
            g.Add(a);
            g.Add(b);
            g.Add(c);
            g.Link(a, b);
        }



        [Fact]
        public void Test2()
        {
           
        }
    }
}
