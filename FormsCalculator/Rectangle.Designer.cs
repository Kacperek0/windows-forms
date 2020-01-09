namespace FormsCalculator
{
    partial class Rectangle
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SideA_textBox = new System.Windows.Forms.TextBox();
            this.SideB_textBox = new System.Windows.Forms.TextBox();
            this.SideA = new System.Windows.Forms.Label();
            this.SideB = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Square = new System.Windows.Forms.CheckBox();
            this.Area_textBox = new System.Windows.Forms.TextBox();
            this.Area = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Color = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.labelA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SideA_textBox
            // 
            this.SideA_textBox.Location = new System.Drawing.Point(595, 73);
            this.SideA_textBox.Name = "SideA_textBox";
            this.SideA_textBox.Size = new System.Drawing.Size(100, 20);
            this.SideA_textBox.TabIndex = 0;
            this.SideA_textBox.TextChanged += new System.EventHandler(this.SideA_textBox_TextChanged);
            // 
            // SideB_textBox
            // 
            this.SideB_textBox.Location = new System.Drawing.Point(595, 123);
            this.SideB_textBox.Name = "SideB_textBox";
            this.SideB_textBox.Size = new System.Drawing.Size(100, 20);
            this.SideB_textBox.TabIndex = 1;
            this.SideB_textBox.TextChanged += new System.EventHandler(this.SideB_textBox_TextChanged);
            // 
            // SideA
            // 
            this.SideA.AutoSize = true;
            this.SideA.Location = new System.Drawing.Point(544, 76);
            this.SideA.Name = "SideA";
            this.SideA.Size = new System.Drawing.Size(38, 13);
            this.SideA.TabIndex = 2;
            this.SideA.Text = "Side A";
            // 
            // SideB
            // 
            this.SideB.AutoSize = true;
            this.SideB.Location = new System.Drawing.Point(545, 126);
            this.SideB.Name = "SideB";
            this.SideB.Size = new System.Drawing.Size(38, 13);
            this.SideB.TabIndex = 3;
            this.SideB.Text = "Side B";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(605, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Count";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(605, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Square
            // 
            this.Square.AutoSize = true;
            this.Square.Location = new System.Drawing.Point(595, 149);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(60, 17);
            this.Square.TabIndex = 6;
            this.Square.Text = "Square";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.CheckedChanged += new System.EventHandler(this.Square_CheckedChanged);
            // 
            // Area_textBox
            // 
            this.Area_textBox.Location = new System.Drawing.Point(595, 253);
            this.Area_textBox.Name = "Area_textBox";
            this.Area_textBox.Size = new System.Drawing.Size(100, 20);
            this.Area_textBox.TabIndex = 7;
            this.Area_textBox.TextChanged += new System.EventHandler(this.Area_textBox_TextChanged);
            // 
            // Area
            // 
            this.Area.AutoSize = true;
            this.Area.Location = new System.Drawing.Point(548, 259);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(29, 13);
            this.Area.TabIndex = 8;
            this.Area.Text = "Area";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Color
            // 
            this.Color.Location = new System.Drawing.Point(595, 279);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(100, 22);
            this.Color.TabIndex = 10;
            this.Color.Text = "Change Color";
            this.Color.UseVisualStyleBackColor = true;
            this.Color.Click += new System.EventHandler(this.Color_Click);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(701, 76);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(0, 13);
            this.labelA.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(701, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 406);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(122, 406);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(605, 307);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "Show/Hide";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Rectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.Area_textBox);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SideB);
            this.Controls.Add(this.SideA);
            this.Controls.Add(this.SideB_textBox);
            this.Controls.Add(this.SideA_textBox);
            this.Name = "Rectangle";
            this.Text = "Rectangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SideA_textBox;
        private System.Windows.Forms.TextBox SideB_textBox;
        private System.Windows.Forms.Label SideA;
        private System.Windows.Forms.Label SideB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox Square;
        private System.Windows.Forms.TextBox Area_textBox;
        private System.Windows.Forms.Label Area;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Color;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}