using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Graphs
{
	public class Node
	{
	    String Name;
	    Point pos;
	    Panel Obj;
	    Color StartColor = Color.DarkGray;
        List<string> PatensialLinkName;
	    
	    List<Node> Links;
	    
		public Node()
		{
			Links = new List<Node>();
            PatensialLinkName = new List<string>();
            pos.X = 0;
	        pos.Y = 0;
	        	        
		}
	    public Node(String name,int _x, int _y)
	    {
			Links = new List<Node>();
            PatensialLinkName = new List<string>();
            Name = name;
	        pos.X = _x;
	        pos.Y = _y;
	    }
	     public Node(int _x, int _y)
	    {
			Links = new List<Node>();
            PatensialLinkName = new List<string>();
            Name = DateTime.Now.ToString();
	        pos.X = _x;
	        pos.Y = _y;
	    }
	     public Node(string name, Point p)
	    {
			Links = new List<Node>();
            PatensialLinkName = new List<string>();
            Name = name;
	        pos.X = p.X;
	        pos.Y = p.Y;
	    }
        public Node(string[] args)
        {
            Links = new List<Node>();
            PatensialLinkName = new List<string>();
            Name = args[0];
            pos.X = int.Parse(args[1]);
            pos.Y = int.Parse(args[2]);
            int i = 0;
            while(args[i + 3] != "")
            {
                PatensialLinkName.Add(args[i + 3]);
                i++;
            }
        }
        public void UsePatensialLink(Graph g)
        {
            foreach (String s in PatensialLinkName) {
                AddNewLink(g.Nodes.Find(x => x.Name == s));
                }
        }
        public void AddNewLink(Node node)
	    {
	    	if(node != null){
		    	if(Links.FindLast(x => x.Name == node.Name) != node){
		        	Links.Add(node);
		    	   }
		    	if(node.Links.FindLast(x => x.Name == this.Name) != this){
		        	node.Links.Add(this);
		    	}
	    	}
	    }
	    public int GetX(){
	    	return pos.X;
	    }
	    public int GetY(){
	    	return pos.Y;
	    }
	    public Point GetPos(){
	    	return pos;
	    }
	    public void SetObj(Panel o){
	    	Obj = o;
	    	StartColor = Obj.BackColor;
	    }
	    public void ResetColor(){
	    	SetColor(StartColor);
	    }
	    public void SetColor(Color c){
	    	Obj.BackColor = c;
	    }
	    public void DeleteLinks(){
	    	foreach(Node x in Links){
	    		x.Links.Remove(this);
	    	}
	    	Links.Clear();
	    }
	    public List<Node> GetLinks(){
	    	return Links;
	    }
	    public string GetName(){
	    	return Name;
	    }
        public void SetPosision(Point point)
        {
            pos = point;
        }
        
	}
}
