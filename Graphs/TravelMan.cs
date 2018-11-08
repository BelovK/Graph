using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Graphs
{
    class TravelMan
    {
        List<Node> Way;
        int WayLength;
        public TravelMan(){
            Way = new List<Node>();
            WayLength = 0;
            }
        public List<Node> FindWay(List<Node> LN,int start = 0)
        {
            Way.Clear();
            WayLength = 0;
            List<Node> AllNodes = LN;
            foreach(Node node in AllNodes)
            {
                node.DeleteLinks();
            }
            Way.Add(LN[start]);
            AllNodes.Remove(LN[start]);
            while (AllNodes.Count != 0) {
                int MinRange = int.MaxValue;
                Node curNode = Way[Way.Count - 1];
                Node minNode = new Node();
                foreach (Node node in AllNodes)
                {
                    if (MinRange > CalcRange(curNode.GetPos(), node.GetPos()))
                    {
                        MinRange = (int)CalcRange(curNode.GetPos(), node.GetPos());
                        minNode = node;
                    }
                }
                WayLength += MinRange;
                Way.Add(minNode);
                AllNodes.Remove(minNode);
            }
            for (int i = 0; i < Way.Count - 1; i++)
            {
                Way[i].AddNewLink(Way[i + 1]);
            }
            return Way;
        }
        Double CalcRange(Point point1, Point point2)
        {
            Double Range = 0;
            Range = Math.Sqrt(Math.Pow((double)point2.X - (double)point1.X, 2) + Math.Pow((double)point2.Y - (double)point1.Y, 2));
            return Range;
        }
        public int GetLength()
        {
            return WayLength;
        }
    }
}
