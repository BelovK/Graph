/*
 * Создано в SharpDevelop.
 * Пользователь: Кирилл
 * Дата: 23.10.2018
 * Время: 16:52
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Graphs
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
        float DrawSizeNode = 3;
        float TextPos = 5;
		Graph MainGraph;
		Graphics g;
		Pen MainPan;
		Font MainFont;
		SolidBrush MainBrush;
        Node TPositionNode;
        

        public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			MainGraph = new Graph();
			g = pictureBoxMain.CreateGraphics();
			MainPan = new Pen(Color.Black);
			MainFont = new Font("Calibri",15f);
			MainBrush = new SolidBrush(Color.Black);
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
        void PictureBoxMainMouseClick(object sender, MouseEventArgs e)
        {
            if (radioButtonAddNew.Checked == true)
                DrawNewNode(new Point(e.X, e.Y));
            if (radioButtonDelNode.Checked == true)
            {
                TPositionNode = MainGraph.Nodes.Find(x => (x.GetX() - TextPos < e.X && x.GetX() + TextPos > e.X) && (x.GetY() - TextPos < e.Y && x.GetY() + TextPos > e.Y));
                if (TPositionNode != null)
                {
                    TPositionNode.DeleteLinks();
                    MainGraph.DeleteNode(TPositionNode);
                    TPositionNode = null;
                    DrawNodes();
                }
            }
            if (radioButtonDelLine.Checked == true)
            {
                TPositionNode = MainGraph.Nodes.Find(x => (x.GetX() - TextPos < e.X && x.GetX() + TextPos > e.X) && (x.GetY() - TextPos < e.Y && x.GetY() + TextPos > e.Y));
                if (TPositionNode != null)
                {
                    TPositionNode.DeleteLinks();

                    TPositionNode = null;
                    DrawNodes();
                }
            }
        }
		void DrawNewNode(Point point){
			MainGraph.AddNewNode(new Point(point.X,point.Y));
			g.DrawEllipse(MainPan,point.X,point.Y,DrawSizeNode,DrawSizeNode);
			g.DrawString(MainGraph.GetLastNode().GetName(),MainFont,MainBrush,point.X + TextPos,point.Y + TextPos);
		}
        /// <summary>
        /// Перерисовывает все вершины графа и их дуги
        /// </summary>
        void DrawNodes()
        {
            g.Clear(Color.White);
            foreach(Node n in MainGraph.Nodes)
            {
                g.DrawEllipse(MainPan, n.GetX(), n.GetY(), DrawSizeNode, DrawSizeNode);
                foreach(Node l in n.GetLinks())
                {
                    g.DrawLine(MainPan, l.GetPos(), n.GetPos());
                }
                g.DrawString(n.GetName(), MainFont, MainBrush, n.GetX() + TextPos, n.GetY() + TextPos);
            }
        }

        private void pictureBoxMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (radioButtonTransformPosision.Checked == true)
            {
                if (TPositionNode != null)
                {
                    TPositionNode.SetPosision(new Point(e.X, e.Y));
                    DrawNodes();
                }
            }
            if (radioButtonLink.Checked == true)
            {
                if (TPositionNode != null)
                {
                    DrawNodes();
                    g.DrawLine(MainPan, TPositionNode.GetPos(), new Point(e.X, e.Y));
                }
            }
        }

        private void pictureBoxMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (radioButtonTransformPosision.Checked == true)
            {
                TPositionNode = MainGraph.Nodes.Find(x => (x.GetX() - TextPos < e.X && x.GetX() + TextPos > e.X) && (x.GetY() - TextPos < e.Y && x.GetY() + TextPos > e.Y));
            }
            if (radioButtonLink.Checked == true)
            {
                TPositionNode = MainGraph.Nodes.Find(x => (x.GetX() - TextPos < e.X && x.GetX() + TextPos > e.X) && (x.GetY() - TextPos < e.Y && x.GetY() + TextPos > e.Y));

            }
        }

        private void pictureBoxMain_MouseUp(object sender, MouseEventArgs e)
        {
            
            if (radioButtonLink.Checked == true)
            {
                Node EndLink = MainGraph.Nodes.Find(x => (x.GetX() - TextPos < e.X && x.GetX() + TextPos > e.X) && (x.GetY() - TextPos < e.Y && x.GetY() + TextPos > e.Y));
                if(EndLink != null)
                {
                    EndLink.AddNewLink(TPositionNode);
                }
                else
                {
                    DrawNodes();
                }
            }
            TPositionNode = null;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string filename = saveFileDialog.FileName;
            System.IO.File.WriteAllText(filename, MainGraph.SaveGraph());
            MessageBox.Show("Файл сохранён");
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog.FileName;
            // читаем файл в строку
            MainGraph.OpenGraph(filename);
            MainGraph.UsePatensialLinks();
            DrawNodes();
            MessageBox.Show("Файл открыт");
        }

        private void buttonLink_Click(object sender, EventArgs e)
        {
           Node LinkingNode1 = MainGraph.Nodes.Find(x => x.GetName() == textBoxLink1.Text);
           Node LinkingNode2 = MainGraph.Nodes.Find(x => x.GetName() == textBoxLink2.Text);
            if (LinkingNode1 != null && LinkingNode2 != null && LinkingNode1 != LinkingNode2)
            {
                LinkingNode1.AddNewLink(LinkingNode2);
                DrawNodes();
            }
            else MessageBox.Show("Вершины не найдены");
        }

        private void buttonLinkDel_Click(object sender, EventArgs e)
        {
            Node LinkingNode1 = MainGraph.Nodes.Find(x => x.GetName() == textBoxLink1.Text);
            Node LinkingNode2 = MainGraph.Nodes.Find(x => x.GetName() == textBoxLink2.Text);
            if (LinkingNode1 != null && LinkingNode2 != null && LinkingNode1 != LinkingNode2)
            {
                LinkingNode1.DeleteLink(LinkingNode2);
                DrawNodes();
            }
            else MessageBox.Show("Ребро не найдено");
        }
    }
}
