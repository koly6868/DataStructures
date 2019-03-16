using System;
using Xunit;
using Hash_Table;
using System.Collections;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            
            HashTable<string, int> table = new HashTable<string, int>(4);
            table.Add("first", 1);
            table.Add("second", 2);
            table.Add("third", 3);
            table.Add("fourth", 4);

            Assert.True(table["first"] == 1);
            Assert.True(table.Get("second") == 2);
            Assert.True(table.Get("third") == 3);
            Assert.True(table.Get("fourth") == 4);
        }
    }

   
}
