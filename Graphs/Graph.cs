using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Graphs
{
	/// <summary>
	/// Description of Graph.
	/// </summary>
	public class Graph
	{
		int CountMaxNodes;
		public List<Node> Nodes;
		public Node StartNode;
		public Node EndNode;
		public Graph()
		{
			CountMaxNodes = 0;
			Nodes = new List<Node>();
		}
		public Graph(int max)
		{
			CountMaxNodes = max;
			Nodes = new List<Node>();
			for(int i=0; i<CountMaxNodes; i++){
				for(int j=0; j<CountMaxNodes; j++){
					Nodes.Add(new Node(j.ToString()+":"+i.ToString(),j,i));
				}
			}
			LinkedAll();
		}
		public void LinkedAll(){
			for(int i=0; i<CountMaxNodes; i++){
				for(int j=0; j<CountMaxNodes; j++){
					Nodes.Find(x => x.GetX() == j && x.GetY() == i).AddNewLink(Nodes.Find(x => x.GetX() == j+1 && x.GetY() == i));
					Nodes.Find(x => x.GetX() == j && x.GetY() == i).AddNewLink(Nodes.Find(x => x.GetX() == j-1 && x.GetY() == i));
					Nodes.Find(x => x.GetX() == j && x.GetY() == i).AddNewLink(Nodes.Find(x => x.GetX() == j && x.GetY() == i+1));
					Nodes.Find(x => x.GetX() == j && x.GetY() == i).AddNewLink(Nodes.Find(x => x.GetX() == j && x.GetY() == i-1));
				}
			}
		}
		public int GetCountNodes(){
			return CountMaxNodes;
		}
		public Node GetLastNode(){
			return Nodes[Nodes.Count-1];
		}
		public void SetStartNode(Point p){
			StartNode = Nodes.Find(x => x.GetPos() == p);
			StartNode.SetColor(Color.Green);
		}
		public void SetEndNode(Point p){
			EndNode = Nodes.Find(x => x.GetPos() == p);
			EndNode.SetColor(Color.Red);
		}
        public void AddNewNode(Point p) {
            string name = Nodes.Count.ToString();
            int n = 0;
            while (Nodes.Find(x => x.GetName() == name) != null)
            {
                name = n.ToString();
                n++;
            }
			Nodes.Add(new Node(name,p.X,p.Y));
		}
        public void DeleteNode(Node node)
        {
            Nodes.Remove(node);
        }
        public string SaveGraph()
        {
            string save ="";
            foreach(Node n in Nodes)
            {
                save += n.GetName();
                save += " " + n.GetX() + " " + n.GetY();
                foreach (Node x in n.GetLinks())
                    save += " " + x.GetName();
                save += " \r\n";
            }
            return save;
        }
        public void OpenGraph(string open)
        {
            Nodes.Clear();
            using (StreamReader reader = new StreamReader(open))
            {
                int l = File.ReadAllLines(open).Length;
                for (int i = 0; i < l; i++)
                {
                    Nodes.Add(new Node(reader.ReadLine().Split(' ')));
                }
            }
                
            


        }
        public void UsePatensialLinks()
        {
            foreach(Node n in Nodes)
            {
                n.UsePatensialLink(this);
            }
        }
        
	}
}
