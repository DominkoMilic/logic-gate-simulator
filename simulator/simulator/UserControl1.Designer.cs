namespace simulator
{
    partial class UserControl1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.izbornik = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.increment_nor = new System.Windows.Forms.Button();
            this.increment_nand = new System.Windows.Forms.Button();
            this.increment_variable_X = new System.Windows.Forms.Button();
            this.decrement_variable_X = new System.Windows.Forms.Button();
            this.number_nand = new System.Windows.Forms.Label();
            this.number_of_nor = new System.Windows.Forms.Label();
            this.number_of_X = new System.Windows.Forms.Label();
            this.add_cabel = new System.Windows.Forms.Button();
            this.counting_point = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.light_X0 = new System.Windows.Forms.Label();
            this.light_X4 = new System.Windows.Forms.Label();
            this.light_X3 = new System.Windows.Forms.Label();
            this.light_X2 = new System.Windows.Forms.Label();
            this.light_X1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pOSTAVKEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOVOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nILIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Y_light = new simulator.CircularLabel();
            this.circularLabel1 = new simulator.CircularLabel();
            this.start = new System.Windows.Forms.Button();
            this.Screenshot = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // izbornik
            // 
            this.izbornik.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.izbornik.Location = new System.Drawing.Point(0, 370);
            this.izbornik.Name = "izbornik";
            this.izbornik.Size = new System.Drawing.Size(700, 80);
            this.izbornik.TabIndex = 0;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(650, 160);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(50, 50);
            this.exit.TabIndex = 1;
            this.exit.Text = "Y";
            this.exit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "BROJ VARIJABLI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // increment_nor
            // 
            this.increment_nor.BackColor = System.Drawing.Color.Lime;
            this.increment_nor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.increment_nor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.increment_nor.Location = new System.Drawing.Point(275, 375);
            this.increment_nor.Name = "increment_nor";
            this.increment_nor.Size = new System.Drawing.Size(30, 30);
            this.increment_nor.TabIndex = 3;
            this.increment_nor.Text = "+";
            this.increment_nor.UseVisualStyleBackColor = false;
            this.increment_nor.Click += new System.EventHandler(this.increment_nor_Click);
            // 
            // increment_nand
            // 
            this.increment_nand.BackColor = System.Drawing.Color.Lime;
            this.increment_nand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.increment_nand.ForeColor = System.Drawing.SystemColors.ControlText;
            this.increment_nand.Location = new System.Drawing.Point(275, 410);
            this.increment_nand.Name = "increment_nand";
            this.increment_nand.Size = new System.Drawing.Size(30, 30);
            this.increment_nand.TabIndex = 4;
            this.increment_nand.Text = "+";
            this.increment_nand.UseVisualStyleBackColor = false;
            this.increment_nand.Click += new System.EventHandler(this.increment_nand_Click);
            // 
            // increment_variable_X
            // 
            this.increment_variable_X.BackColor = System.Drawing.Color.Lime;
            this.increment_variable_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.increment_variable_X.ForeColor = System.Drawing.SystemColors.ControlText;
            this.increment_variable_X.Location = new System.Drawing.Point(86, 400);
            this.increment_variable_X.Name = "increment_variable_X";
            this.increment_variable_X.Size = new System.Drawing.Size(30, 30);
            this.increment_variable_X.TabIndex = 5;
            this.increment_variable_X.Text = "+";
            this.increment_variable_X.UseVisualStyleBackColor = false;
            this.increment_variable_X.Click += new System.EventHandler(this.increment_variable_X_Click);
            // 
            // decrement_variable_X
            // 
            this.decrement_variable_X.BackColor = System.Drawing.Color.Red;
            this.decrement_variable_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decrement_variable_X.ForeColor = System.Drawing.SystemColors.ControlText;
            this.decrement_variable_X.Location = new System.Drawing.Point(14, 400);
            this.decrement_variable_X.Name = "decrement_variable_X";
            this.decrement_variable_X.Size = new System.Drawing.Size(30, 30);
            this.decrement_variable_X.TabIndex = 6;
            this.decrement_variable_X.Text = "-";
            this.decrement_variable_X.UseVisualStyleBackColor = false;
            this.decrement_variable_X.Click += new System.EventHandler(this.decrement_variable_X_Click);
            // 
            // number_nand
            // 
            this.number_nand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.number_nand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_nand.Location = new System.Drawing.Point(140, 415);
            this.number_nand.Name = "number_nand";
            this.number_nand.Size = new System.Drawing.Size(125, 15);
            this.number_nand.TabIndex = 7;
            this.number_nand.Text = "DODAJ NI VRATA";
            this.number_nand.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // number_of_nor
            // 
            this.number_of_nor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.number_of_nor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_of_nor.Location = new System.Drawing.Point(140, 380);
            this.number_of_nor.Name = "number_of_nor";
            this.number_of_nor.Size = new System.Drawing.Size(125, 15);
            this.number_of_nor.TabIndex = 8;
            this.number_of_nor.Text = "DODAJ NILI VRATA";
            this.number_of_nor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // number_of_X
            // 
            this.number_of_X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.number_of_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_of_X.ForeColor = System.Drawing.Color.Black;
            this.number_of_X.Location = new System.Drawing.Point(50, 400);
            this.number_of_X.Name = "number_of_X";
            this.number_of_X.Size = new System.Drawing.Size(30, 30);
            this.number_of_X.TabIndex = 9;
            this.number_of_X.Text = "1";
            this.number_of_X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // add_cabel
            // 
            this.add_cabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_cabel.Location = new System.Drawing.Point(340, 380);
            this.add_cabel.Name = "add_cabel";
            this.add_cabel.Size = new System.Drawing.Size(90, 25);
            this.add_cabel.TabIndex = 10;
            this.add_cabel.Text = "DODAJ KABEL";
            this.add_cabel.UseVisualStyleBackColor = true;
            this.add_cabel.Click += new System.EventHandler(this.add_cabel_Click);
            // 
            // counting_point
            // 
            this.counting_point.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counting_point.Location = new System.Drawing.Point(650, 373);
            this.counting_point.Name = "counting_point";
            this.counting_point.Size = new System.Drawing.Size(35, 20);
            this.counting_point.TabIndex = 11;
            this.counting_point.Text = "CP";
            this.counting_point.UseVisualStyleBackColor = true;
            this.counting_point.Click += new System.EventHandler(this.counting_point_Click);
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(650, 400);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(35, 20);
            this.reset.TabIndex = 12;
            this.reset.Text = "R";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // light_X0
            // 
            this.light_X0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.light_X0.Location = new System.Drawing.Point(590, 375);
            this.light_X0.Name = "light_X0";
            this.light_X0.Size = new System.Drawing.Size(25, 25);
            this.light_X0.TabIndex = 15;
            this.light_X0.Text = "X0";
            this.light_X0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // light_X4
            // 
            this.light_X4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.light_X4.Location = new System.Drawing.Point(470, 375);
            this.light_X4.Name = "light_X4";
            this.light_X4.Size = new System.Drawing.Size(25, 25);
            this.light_X4.TabIndex = 16;
            this.light_X4.Text = "X4";
            this.light_X4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // light_X3
            // 
            this.light_X3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.light_X3.Location = new System.Drawing.Point(500, 375);
            this.light_X3.Name = "light_X3";
            this.light_X3.Size = new System.Drawing.Size(25, 25);
            this.light_X3.TabIndex = 17;
            this.light_X3.Text = "X3";
            this.light_X3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // light_X2
            // 
            this.light_X2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.light_X2.Location = new System.Drawing.Point(530, 375);
            this.light_X2.Name = "light_X2";
            this.light_X2.Size = new System.Drawing.Size(25, 25);
            this.light_X2.TabIndex = 18;
            this.light_X2.Text = "X2";
            this.light_X2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // light_X1
            // 
            this.light_X1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.light_X1.Location = new System.Drawing.Point(560, 375);
            this.light_X1.Name = "light_X1";
            this.light_X1.Size = new System.Drawing.Size(25, 25);
            this.light_X1.TabIndex = 19;
            this.light_X1.Text = "X1";
            this.light_X1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pOSTAVKEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(698, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pOSTAVKEToolStripMenuItem
            // 
            this.pOSTAVKEToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pOSTAVKEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nOVOToolStripMenuItem,
            this.nILIToolStripMenuItem,
            this.nIToolStripMenuItem});
            this.pOSTAVKEToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.pOSTAVKEToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pOSTAVKEToolStripMenuItem.Name = "pOSTAVKEToolStripMenuItem";
            this.pOSTAVKEToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.pOSTAVKEToolStripMenuItem.Text = "POSTAVKE";
            // 
            // nOVOToolStripMenuItem
            // 
            this.nOVOToolStripMenuItem.Name = "nOVOToolStripMenuItem";
            this.nOVOToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.nOVOToolStripMenuItem.Text = "NOVO";
            this.nOVOToolStripMenuItem.Click += new System.EventHandler(this.nOVOToolStripMenuItem_Click);
            // 
            // nILIToolStripMenuItem
            // 
            this.nILIToolStripMenuItem.Name = "nILIToolStripMenuItem";
            this.nILIToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.nILIToolStripMenuItem.Text = "NILI";
            this.nILIToolStripMenuItem.Click += new System.EventHandler(this.nILIToolStripMenuItem_Click);
            // 
            // nIToolStripMenuItem
            // 
            this.nIToolStripMenuItem.Name = "nIToolStripMenuItem";
            this.nIToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.nIToolStripMenuItem.Text = "NI";
            this.nIToolStripMenuItem.Click += new System.EventHandler(this.nIToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Y_light
            // 
            this.Y_light.BackColor = System.Drawing.Color.Red;
            this.Y_light.Location = new System.Drawing.Point(670, 185);
            this.Y_light.Name = "Y_light";
            this.Y_light.Size = new System.Drawing.Size(57, 13);
            this.Y_light.TabIndex = 14;
            this.Y_light.Text = "                      .";
            // 
            // circularLabel1
            // 
            this.circularLabel1.AutoSize = true;
            this.circularLabel1.BackColor = System.Drawing.Color.Red;
            this.circularLabel1.Location = new System.Drawing.Point(668, 188);
            this.circularLabel1.Name = "circularLabel1";
            this.circularLabel1.Size = new System.Drawing.Size(0, 13);
            this.circularLabel1.TabIndex = 13;
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(650, 426);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(35, 20);
            this.start.TabIndex = 21;
            this.start.Text = "ON";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Screenshot
            // 
            this.Screenshot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Screenshot.Location = new System.Drawing.Point(598, 2);
            this.Screenshot.Name = "Screenshot";
            this.Screenshot.Size = new System.Drawing.Size(100, 20);
            this.Screenshot.TabIndex = 22;
            this.Screenshot.Text = "SCREENSHOT";
            this.Screenshot.UseVisualStyleBackColor = true;
            this.Screenshot.Click += new System.EventHandler(this.Screenshot_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Screenshot);
            this.Controls.Add(this.start);
            this.Controls.Add(this.light_X1);
            this.Controls.Add(this.light_X2);
            this.Controls.Add(this.light_X3);
            this.Controls.Add(this.light_X4);
            this.Controls.Add(this.light_X0);
            this.Controls.Add(this.Y_light);
            this.Controls.Add(this.circularLabel1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.counting_point);
            this.Controls.Add(this.add_cabel);
            this.Controls.Add(this.number_of_X);
            this.Controls.Add(this.number_of_nor);
            this.Controls.Add(this.number_nand);
            this.Controls.Add(this.decrement_variable_X);
            this.Controls.Add(this.increment_variable_X);
            this.Controls.Add(this.increment_nand);
            this.Controls.Add(this.increment_nor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.izbornik);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(698, 448);
            this.Load += new System.EventHandler(this.UserControl1_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label izbornik;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button increment_nor;
        private System.Windows.Forms.Button increment_nand;
        private System.Windows.Forms.Button increment_variable_X;
        private System.Windows.Forms.Button decrement_variable_X;
        private System.Windows.Forms.Label number_nand;
        private System.Windows.Forms.Label number_of_nor;
        private System.Windows.Forms.Label number_of_X;
        private System.Windows.Forms.Button add_cabel;
        private System.Windows.Forms.Button counting_point;
        private System.Windows.Forms.Button reset;
        private CircularLabel circularLabel1;
        private CircularLabel Y_light;
        private System.Windows.Forms.Label light_X0;
        private System.Windows.Forms.Label light_X4;
        private System.Windows.Forms.Label light_X3;
        private System.Windows.Forms.Label light_X2;
        private System.Windows.Forms.Label light_X1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pOSTAVKEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOVOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nILIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nIToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button Screenshot;
    }
}
