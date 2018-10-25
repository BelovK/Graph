/*
 * Создано в SharpDevelop.
 * Пользователь: Кирилл
 * Дата: 23.10.2018
 * Время: 16:52
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace Graphs
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBoxMain;
		private System.Windows.Forms.RadioButton radioButtonAddNew;
		private System.Windows.Forms.RadioButton radioButtonTransformPosision;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.radioButtonAddNew = new System.Windows.Forms.RadioButton();
            this.radioButtonTransformPosision = new System.Windows.Forms.RadioButton();
            this.radioButtonLink = new System.Windows.Forms.RadioButton();
            this.radioButtonDelNode = new System.Windows.Forms.RadioButton();
            this.radioButtonDelLine = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.textBoxLink1 = new System.Windows.Forms.TextBox();
            this.textBoxLink2 = new System.Windows.Forms.TextBox();
            this.buttonLink = new System.Windows.Forms.Button();
            this.buttonLinkDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.Color.White;
            this.pictureBoxMain.Location = new System.Drawing.Point(12, 46);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(762, 390);
            this.pictureBoxMain.TabIndex = 0;
            this.pictureBoxMain.TabStop = false;
            this.pictureBoxMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBoxMainMouseClick);
            this.pictureBoxMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseDown);
            this.pictureBoxMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseMove);
            this.pictureBoxMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseUp);
            // 
            // radioButtonAddNew
            // 
            this.radioButtonAddNew.Location = new System.Drawing.Point(793, 46);
            this.radioButtonAddNew.Name = "radioButtonAddNew";
            this.radioButtonAddNew.Size = new System.Drawing.Size(182, 23);
            this.radioButtonAddNew.TabIndex = 1;
            this.radioButtonAddNew.TabStop = true;
            this.radioButtonAddNew.Text = "Новая вершина";
            this.radioButtonAddNew.UseVisualStyleBackColor = true;
            // 
            // radioButtonTransformPosision
            // 
            this.radioButtonTransformPosision.Location = new System.Drawing.Point(793, 75);
            this.radioButtonTransformPosision.Name = "radioButtonTransformPosision";
            this.radioButtonTransformPosision.Size = new System.Drawing.Size(182, 23);
            this.radioButtonTransformPosision.TabIndex = 2;
            this.radioButtonTransformPosision.TabStop = true;
            this.radioButtonTransformPosision.Text = "Переместить";
            this.radioButtonTransformPosision.UseVisualStyleBackColor = true;
            // 
            // radioButtonLink
            // 
            this.radioButtonLink.AutoSize = true;
            this.radioButtonLink.Location = new System.Drawing.Point(793, 105);
            this.radioButtonLink.Name = "radioButtonLink";
            this.radioButtonLink.Size = new System.Drawing.Size(145, 21);
            this.radioButtonLink.TabIndex = 3;
            this.radioButtonLink.TabStop = true;
            this.radioButtonLink.Text = "Установить связь";
            this.radioButtonLink.UseVisualStyleBackColor = true;
            // 
            // radioButtonDelNode
            // 
            this.radioButtonDelNode.AutoSize = true;
            this.radioButtonDelNode.Location = new System.Drawing.Point(793, 132);
            this.radioButtonDelNode.Name = "radioButtonDelNode";
            this.radioButtonDelNode.Size = new System.Drawing.Size(145, 21);
            this.radioButtonDelNode.TabIndex = 4;
            this.radioButtonDelNode.TabStop = true;
            this.radioButtonDelNode.Text = "Удалить вершину";
            this.radioButtonDelNode.UseVisualStyleBackColor = true;
            // 
            // radioButtonDelLine
            // 
            this.radioButtonDelLine.AutoSize = true;
            this.radioButtonDelLine.Location = new System.Drawing.Point(793, 159);
            this.radioButtonDelLine.Name = "radioButtonDelLine";
            this.radioButtonDelLine.Size = new System.Drawing.Size(128, 21);
            this.radioButtonDelLine.TabIndex = 5;
            this.radioButtonDelLine.TabStop = true;
            this.radioButtonDelLine.Text = "Удалить рёбра";
            this.radioButtonDelLine.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1076, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // textBoxLink1
            // 
            this.textBoxLink1.Location = new System.Drawing.Point(825, 258);
            this.textBoxLink1.Name = "textBoxLink1";
            this.textBoxLink1.Size = new System.Drawing.Size(39, 22);
            this.textBoxLink1.TabIndex = 7;
            // 
            // textBoxLink2
            // 
            this.textBoxLink2.Location = new System.Drawing.Point(870, 258);
            this.textBoxLink2.Name = "textBoxLink2";
            this.textBoxLink2.Size = new System.Drawing.Size(39, 22);
            this.textBoxLink2.TabIndex = 8;
            // 
            // buttonLink
            // 
            this.buttonLink.Location = new System.Drawing.Point(929, 248);
            this.buttonLink.Name = "buttonLink";
            this.buttonLink.Size = new System.Drawing.Size(84, 42);
            this.buttonLink.TabIndex = 9;
            this.buttonLink.Text = "Связать вершины";
            this.buttonLink.UseVisualStyleBackColor = true;
            this.buttonLink.Click += new System.EventHandler(this.buttonLink_Click);
            // 
            // buttonLinkDel
            // 
            this.buttonLinkDel.Location = new System.Drawing.Point(929, 296);
            this.buttonLinkDel.Name = "buttonLinkDel";
            this.buttonLinkDel.Size = new System.Drawing.Size(84, 42);
            this.buttonLinkDel.TabIndex = 10;
            this.buttonLinkDel.Text = "Убрать ребро";
            this.buttonLinkDel.UseVisualStyleBackColor = true;
            this.buttonLinkDel.Click += new System.EventHandler(this.buttonLinkDel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 510);
            this.Controls.Add(this.buttonLinkDel);
            this.Controls.Add(this.buttonLink);
            this.Controls.Add(this.textBoxLink2);
            this.Controls.Add(this.textBoxLink1);
            this.Controls.Add(this.radioButtonDelLine);
            this.Controls.Add(this.radioButtonDelNode);
            this.Controls.Add(this.radioButtonLink);
            this.Controls.Add(this.radioButtonTransformPosision);
            this.Controls.Add(this.radioButtonAddNew);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Graphs";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.RadioButton radioButtonLink;
        private System.Windows.Forms.RadioButton radioButtonDelNode;
        private System.Windows.Forms.RadioButton radioButtonDelLine;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox textBoxLink1;
        private System.Windows.Forms.TextBox textBoxLink2;
        private System.Windows.Forms.Button buttonLink;
        private System.Windows.Forms.Button buttonLinkDel;
    }
}
