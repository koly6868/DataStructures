using System;
using Xunit;
using MyDataStructures;

namespace Tests
{
    public class DictionaryTests
    {
        [Fact]
        public void AddElement()
        {
            int[] answ = new int[] { 1, 2, 3, 4 };
            string[] answKeys = new string[] { "first", "second", "third", "fourhts" };
            Dictionary<string, int> table = new Dictionary<string, int>(answ.Length);


            for (int i = 0; i < answ.Length; i++)
            {
                table.Add(answKeys[i], answ[i]);
            }


            for (int i = 0; i < answ.Length; i++)
            {
                Assert.True(table[answKeys[i]] == answ[i]);
            }
        }



        [Fact]
        public void RemoveElement()
        {
            int[] input = new int[] { 1, 2, 3, 4 };           
            string[] inputKeys = new string[] { "first", "second", "third", "fourhts" };
            Dictionary<string, int> table = new Dictionary<string, int>(inputKeys, input);
            int removeEl = 3;
            string removeKey = "third";

            table.Remove(removeKey);
            
            Assert.Throws<IndexOutOfRangeException>(() => table[removeKey]);
        }
    }
}
