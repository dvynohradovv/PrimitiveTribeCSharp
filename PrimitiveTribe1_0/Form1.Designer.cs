namespace PrimitiveTribe1_0
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Lazy person");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Warrior");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Hunter");
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Looter");
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Lumberjack");
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Fisherman");
			System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Human", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
			this.panel1 = new System.Windows.Forms.Panel();
			this.RefreshInfoTree = new System.Windows.Forms.Button();
			this.InfoTree = new System.Windows.Forms.TreeView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.AppointButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.GenderComboBox = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.MakeNewHumanButton = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutMyTribeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.HumanIndexNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.ClassComboBox = new System.Windows.Forms.ComboBox();
			this.panel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.HumanIndexNumericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.panel1.Controls.Add(this.RefreshInfoTree);
			this.panel1.Controls.Add(this.InfoTree);
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(284, 721);
			this.panel1.TabIndex = 0;
			// 
			// RefreshInfoTree
			// 
			this.RefreshInfoTree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.RefreshInfoTree.AutoSize = true;
			this.RefreshInfoTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.RefreshInfoTree.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.RefreshInfoTree.Location = new System.Drawing.Point(116, 458);
			this.RefreshInfoTree.Name = "RefreshInfoTree";
			this.RefreshInfoTree.Size = new System.Drawing.Size(160, 35);
			this.RefreshInfoTree.TabIndex = 4;
			this.RefreshInfoTree.Text = "Refresh InfoList";
			this.RefreshInfoTree.UseVisualStyleBackColor = true;
			// 
			// InfoTree
			// 
			this.InfoTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.InfoTree.Location = new System.Drawing.Point(12, 126);
			this.InfoTree.Name = "InfoTree";
			treeNode1.Name = "NoClass";
			treeNode1.Text = "Lazy person";
			treeNode2.Name = "Warrior";
			treeNode2.Text = "Warrior";
			treeNode3.Name = "Hunter";
			treeNode3.Text = "Hunter";
			treeNode4.Name = "Looter";
			treeNode4.Text = "Looter";
			treeNode5.Name = "Lumberjack";
			treeNode5.Text = "Lumberjack";
			treeNode6.Name = "Fisherman";
			treeNode6.Text = "Fisherman";
			treeNode7.Name = "Human";
			treeNode7.Tag = "";
			treeNode7.Text = "Human";
			this.InfoTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
			this.InfoTree.Size = new System.Drawing.Size(264, 326);
			this.InfoTree.TabIndex = 3;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.ClassComboBox);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.HumanIndexNumericUpDown);
			this.groupBox2.Controls.Add(this.AppointButton);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.groupBox2.Location = new System.Drawing.Point(12, 499);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.groupBox2.Size = new System.Drawing.Size(264, 141);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Appoint as";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(199, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 25);
			this.label2.TabIndex = 5;
			this.label2.Text = "class";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(132, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 25);
			this.label1.TabIndex = 4;
			this.label1.Text = "human index";
			// 
			// AppointButton
			// 
			this.AppointButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AppointButton.AutoSize = true;
			this.AppointButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.AppointButton.Location = new System.Drawing.Point(4, 99);
			this.AppointButton.Name = "AppointButton";
			this.AppointButton.Size = new System.Drawing.Size(252, 35);
			this.AppointButton.TabIndex = 1;
			this.AppointButton.Text = "Appoint";
			this.AppointButton.UseVisualStyleBackColor = true;
			this.AppointButton.Click += new System.EventHandler(this.AppointButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.GenderComboBox);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.MakeNewHumanButton);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.groupBox1.Size = new System.Drawing.Size(264, 108);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Make New Human";
			// 
			// GenderComboBox
			// 
			this.GenderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.GenderComboBox.FormattingEnabled = true;
			this.GenderComboBox.Items.AddRange(new object[] {
            "man",
            "woman",
            "random"});
			this.GenderComboBox.Location = new System.Drawing.Point(6, 29);
			this.GenderComboBox.Name = "GenderComboBox";
			this.GenderComboBox.Size = new System.Drawing.Size(173, 33);
			this.GenderComboBox.TabIndex = 1;
			this.GenderComboBox.SelectedIndexChanged += new System.EventHandler(this.GenderComboBox_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(185, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 25);
			this.label3.TabIndex = 6;
			this.label3.Text = "gender";
			// 
			// MakeNewHumanButton
			// 
			this.MakeNewHumanButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MakeNewHumanButton.AutoSize = true;
			this.MakeNewHumanButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.MakeNewHumanButton.Location = new System.Drawing.Point(6, 64);
			this.MakeNewHumanButton.Name = "MakeNewHumanButton";
			this.MakeNewHumanButton.Size = new System.Drawing.Size(252, 35);
			this.MakeNewHumanButton.TabIndex = 1;
			this.MakeNewHumanButton.Text = "Make New Human";
			this.MakeNewHumanButton.UseVisualStyleBackColor = true;
			this.MakeNewHumanButton.Click += new System.EventHandler(this.MakeNewHumanButton_Click_1);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.AutoSize = true;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(12, 674);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(264, 35);
			this.button1.TabIndex = 0;
			this.button1.Text = "New Day";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.panel2.Controls.Add(this.menuStrip1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(284, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1064, 721);
			this.panel2.TabIndex = 1;
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.fAQToolStripMenuItem,
            this.aboutMyTribeToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1064, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
			this.menuToolStripMenuItem.Text = "Menu";
			// 
			// fAQToolStripMenuItem
			// 
			this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
			this.fAQToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
			this.fAQToolStripMenuItem.Text = "FAQ";
			// 
			// aboutMyTribeToolStripMenuItem
			// 
			this.aboutMyTribeToolStripMenuItem.Name = "aboutMyTribeToolStripMenuItem";
			this.aboutMyTribeToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
			this.aboutMyTribeToolStripMenuItem.Text = "About MyTribe";
			// 
			// HumanIndexNumericUpDown
			// 
			this.HumanIndexNumericUpDown.Location = new System.Drawing.Point(6, 29);
			this.HumanIndexNumericUpDown.Name = "HumanIndexNumericUpDown";
			this.HumanIndexNumericUpDown.Size = new System.Drawing.Size(120, 30);
			this.HumanIndexNumericUpDown.TabIndex = 3;
			this.HumanIndexNumericUpDown.ValueChanged += new System.EventHandler(this.HumanIndexNumericUpDown_ValueChanged);
			// 
			// ClassComboBox
			// 
			this.ClassComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ClassComboBox.FormattingEnabled = true;
			this.ClassComboBox.Items.AddRange(new object[] {
            "Warrior",
            "Hunter",
            "Collector",
            "Lumberjack",
            "Fisherman"});
			this.ClassComboBox.Location = new System.Drawing.Point(6, 64);
			this.ClassComboBox.Name = "ClassComboBox";
			this.ClassComboBox.Size = new System.Drawing.Size(187, 33);
			this.ClassComboBox.TabIndex = 2;
			this.ClassComboBox.SelectedIndexChanged += new System.EventHandler(this.ClassComboBox_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1348, 721);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.HumanIndexNumericUpDown)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutMyTribeToolStripMenuItem;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button MakeNewHumanButton;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button AppointButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TreeView InfoTree;
		private System.Windows.Forms.Button RefreshInfoTree;
		private System.Windows.Forms.ComboBox GenderComboBox;
		private System.Windows.Forms.NumericUpDown HumanIndexNumericUpDown;
		private System.Windows.Forms.ComboBox ClassComboBox;
	}
}

