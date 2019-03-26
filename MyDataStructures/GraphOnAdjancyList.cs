using MyDataStructures.Additional;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyDataStructures
{
    public class GraphOnAdjancyList<T>
        where T : IComparable<T>
    {
        public void Link(T from, T to)
        {
            Couple<int,T> cFrom = GetCouple(from);
            Couple<int, T> cTo = GetCouple(to);
            adjencyList[cFrom.Key].Add(cTo.Key);
        }

        public void UnLink(T from, T to)
        {
            Couple<int, T> cFrom = GetCouple(from);
            Couple<int, T> cTo = GetCouple(to);
            adjencyList[cFrom.Key].Remove(cTo.Key);
        }

        public void Add(T point)
        {
            Couple<int, T> newPoint = new Couple<int, T>(
                nameGenerator.Generate(),
                point);
            data.Add(newPoint);
            adjencyList.Add(new List<int>());
        }

        public void Remove(T point)
        {
            Couple<int,T> cPoint = GetCouple(point);
            adjencyList.RemoveAt(cPoint.Key);
            data.Remove(cPoint);
        }

        private Couple<int,T> GetCouple(T point)
        {
            return data.Find(p => p.Value.CompareTo(point) == 0);
        }

        public GraphOnAdjancyList()
        {
            data = new List<Couple<int, T>>();
            adjencyList = new List<List<int>>();
            nameGenerator = new NameGenerator();
        }
        private List<Couple<int,T>> data;
        private List<List<int>> adjencyList;
        private NameGenerator nameGenerator;

    }

    class NameGenerator
    {
        public int Generate()
        {
            return name++;
        }

        private int name;

        public NameGenerator()
        {
            name = 0;
        }
    }
}
