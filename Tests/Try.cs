using System;
using Xunit;
using MyDataStructures;
using MyDataStructures;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class Try
    {
        [Fact]
        public void Test()
        {
            int count = 10000;
            int seed = 214212;
            Random r = new Random(seed);
            int[] el = new int[count];
            string[] k = new string[count];
            el = el.Select(e => r.Next()).ToArray();
            k = k.Select(e => r.Next().ToString()).ToArray();
            KeyValuePair<string, int>[] col = new KeyValuePair<string, int>[count];
            for (int i = 0; i< count; i++)
            {
                col[i] = new KeyValuePair<string, int>(k[i], el[i]);
            }

            //MyDataStructures.Dictionary<string, int> my = new MyDataStructures.Dictionary<string, int>(k,el);
            //System.Collections.Generic.Dictionary<string, int> f = new System.Collections.Generic.Dictionary<string, int>(
            //    el.Select(e => new KeyValuePair<string, int>(k, e)));
        }
    }
}
