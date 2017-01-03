namespace Automata_HW_7
{
    partial class Form1
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
            this.uploadDFA1_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DFA1All_btn = new System.Windows.Forms.Button();
            this.DFA1Empt_btn = new System.Windows.Forms.Button();
            this.DFA1Cmplt_btn = new System.Windows.Forms.Button();
            this.testDFA1_btn = new System.Windows.Forms.Button();
            this.DFA1_textbox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DFA2All_btn = new System.Windows.Forms.Button();
            this.DFA2Empt_btn = new System.Windows.Forms.Button();
            this.DFA2Cmplt_btn = new System.Windows.Forms.Button();
            this.uploadDFA2_btn = new System.Windows.Forms.Button();
            this.testDFA2_btn = new System.Windows.Forms.Button();
            this.DFA2_textbox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DFAEqvlt_btn = new System.Windows.Forms.Button();
            this.DFAUnion_btn = new System.Windows.Forms.Button();
            this.DFAInter_btn = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // uploadDFA1_btn
            // 
            this.uploadDFA1_btn.Location = new System.Drawing.Point(221, 19);
            this.uploadDFA1_btn.Name = "uploadDFA1_btn";
            this.uploadDFA1_btn.Size = new System.Drawing.Size(75, 38);
            this.uploadDFA1_btn.TabIndex = 0;
            this.uploadDFA1_btn.Text = "Upload DFA File";
            this.uploadDFA1_btn.UseVisualStyleBackColor = true;
            this.uploadDFA1_btn.Click += new System.EventHandler(this.uploadDFA1_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DFA1All_btn);
            this.groupBox1.Controls.Add(this.DFA1Empt_btn);
            this.groupBox1.Controls.Add(this.DFA1Cmplt_btn);
            this.groupBox1.Controls.Add(this.testDFA1_btn);
            this.groupBox1.Controls.Add(this.DFA1_textbox);
            this.groupBox1.Controls.Add(this.uploadDFA1_btn);
            this.groupBox1.Location = new System.Drawing.Point(23, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 213);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DFA 1";
            // 
            // DFA1All_btn
            // 
            this.DFA1All_btn.Location = new System.Drawing.Point(221, 135);
            this.DFA1All_btn.Name = "DFA1All_btn";
            this.DFA1All_btn.Size = new System.Drawing.Size(75, 35);
            this.DFA1All_btn.TabIndex = 5;
            this.DFA1All_btn.Text = "L(DFA) = Sigma Star?";
            this.DFA1All_btn.UseVisualStyleBackColor = true;
            this.DFA1All_btn.Click += new System.EventHandler(this.DFA1All_btn_Click);
            // 
            // DFA1Empt_btn
            // 
            this.DFA1Empt_btn.Location = new System.Drawing.Point(120, 135);
            this.DFA1Empt_btn.Name = "DFA1Empt_btn";
            this.DFA1Empt_btn.Size = new System.Drawing.Size(75, 35);
            this.DFA1Empt_btn.TabIndex = 4;
            this.DFA1Empt_btn.Text = "Check Emptiness";
            this.DFA1Empt_btn.UseVisualStyleBackColor = true;
            this.DFA1Empt_btn.Click += new System.EventHandler(this.DFA1Empt_btn_Click);
            // 
            // DFA1Cmplt_btn
            // 
            this.DFA1Cmplt_btn.Location = new System.Drawing.Point(17, 135);
            this.DFA1Cmplt_btn.Name = "DFA1Cmplt_btn";
            this.DFA1Cmplt_btn.Size = new System.Drawing.Size(75, 35);
            this.DFA1Cmplt_btn.TabIndex = 3;
            this.DFA1Cmplt_btn.Text = "Get Complement";
            this.DFA1Cmplt_btn.UseVisualStyleBackColor = true;
            this.DFA1Cmplt_btn.Click += new System.EventHandler(this.DFA1Cmplt_btn_Click);
            // 
            // testDFA1_btn
            // 
            this.testDFA1_btn.Location = new System.Drawing.Point(221, 78);
            this.testDFA1_btn.Name = "testDFA1_btn";
            this.testDFA1_btn.Size = new System.Drawing.Size(75, 23);
            this.testDFA1_btn.TabIndex = 2;
            this.testDFA1_btn.Text = "Test String";
            this.testDFA1_btn.UseVisualStyleBackColor = true;
            this.testDFA1_btn.Click += new System.EventHandler(this.testDFA1_btn_Click);
            // 
            // DFA1_textbox
            // 
            this.DFA1_textbox.Location = new System.Drawing.Point(17, 78);
            this.DFA1_textbox.Name = "DFA1_textbox";
            this.DFA1_textbox.Size = new System.Drawing.Size(198, 20);
            this.DFA1_textbox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DFA2All_btn);
            this.groupBox2.Controls.Add(this.DFA2Empt_btn);
            this.groupBox2.Controls.Add(this.DFA2Cmplt_btn);
            this.groupBox2.Controls.Add(this.uploadDFA2_btn);
            this.groupBox2.Controls.Add(this.testDFA2_btn);
            this.groupBox2.Controls.Add(this.DFA2_textbox);
            this.groupBox2.Location = new System.Drawing.Point(23, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 213);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DFA 2";
            // 
            // DFA2All_btn
            // 
            this.DFA2All_btn.Location = new System.Drawing.Point(221, 138);
            this.DFA2All_btn.Name = "DFA2All_btn";
            this.DFA2All_btn.Size = new System.Drawing.Size(75, 36);
            this.DFA2All_btn.TabIndex = 5;
            this.DFA2All_btn.Text = "L(DFA) = Sigma Star?";
            this.DFA2All_btn.UseVisualStyleBackColor = true;
            this.DFA2All_btn.Click += new System.EventHandler(this.DFA2All_btn_Click);
            // 
            // DFA2Empt_btn
            // 
            this.DFA2Empt_btn.Location = new System.Drawing.Point(120, 138);
            this.DFA2Empt_btn.Name = "DFA2Empt_btn";
            this.DFA2Empt_btn.Size = new System.Drawing.Size(75, 36);
            this.DFA2Empt_btn.TabIndex = 4;
            this.DFA2Empt_btn.Text = "Check Emptiness";
            this.DFA2Empt_btn.UseVisualStyleBackColor = true;
            this.DFA2Empt_btn.Click += new System.EventHandler(this.DFA2Empt_btn_Click);
            // 
            // DFA2Cmplt_btn
            // 
            this.DFA2Cmplt_btn.Location = new System.Drawing.Point(17, 138);
            this.DFA2Cmplt_btn.Name = "DFA2Cmplt_btn";
            this.DFA2Cmplt_btn.Size = new System.Drawing.Size(75, 36);
            this.DFA2Cmplt_btn.TabIndex = 3;
            this.DFA2Cmplt_btn.Text = "Get Complement";
            this.DFA2Cmplt_btn.UseVisualStyleBackColor = true;
            this.DFA2Cmplt_btn.Click += new System.EventHandler(this.DFA2Cmplt_btn_Click);
            // 
            // uploadDFA2_btn
            // 
            this.uploadDFA2_btn.Location = new System.Drawing.Point(215, 19);
            this.uploadDFA2_btn.Name = "uploadDFA2_btn";
            this.uploadDFA2_btn.Size = new System.Drawing.Size(75, 36);
            this.uploadDFA2_btn.TabIndex = 2;
            this.uploadDFA2_btn.Text = "Upload DFA File";
            this.uploadDFA2_btn.UseVisualStyleBackColor = true;
            this.uploadDFA2_btn.Click += new System.EventHandler(this.uploadDFA2_btn_Click);
            // 
            // testDFA2_btn
            // 
            this.testDFA2_btn.Location = new System.Drawing.Point(215, 78);
            this.testDFA2_btn.Name = "testDFA2_btn";
            this.testDFA2_btn.Size = new System.Drawing.Size(75, 23);
            this.testDFA2_btn.TabIndex = 1;
            this.testDFA2_btn.Text = "Test String";
            this.testDFA2_btn.UseVisualStyleBackColor = true;
            this.testDFA2_btn.Click += new System.EventHandler(this.testDFA2_btn_Click);
            // 
            // DFA2_textbox
            // 
            this.DFA2_textbox.Location = new System.Drawing.Point(6, 78);
            this.DFA2_textbox.Name = "DFA2_textbox";
            this.DFA2_textbox.Size = new System.Drawing.Size(200, 20);
            this.DFA2_textbox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DFAEqvlt_btn);
            this.groupBox3.Controls.Add(this.DFAUnion_btn);
            this.groupBox3.Controls.Add(this.DFAInter_btn);
            this.groupBox3.Location = new System.Drawing.Point(418, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(158, 221);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // DFAEqvlt_btn
            // 
            this.DFAEqvlt_btn.Location = new System.Drawing.Point(36, 143);
            this.DFAEqvlt_btn.Name = "DFAEqvlt_btn";
            this.DFAEqvlt_btn.Size = new System.Drawing.Size(88, 36);
            this.DFAEqvlt_btn.TabIndex = 2;
            this.DFAEqvlt_btn.Text = "Equivalence?";
            this.DFAEqvlt_btn.UseVisualStyleBackColor = true;
            this.DFAEqvlt_btn.Click += new System.EventHandler(this.DFAEqvlt_btn_Click);
            // 
            // DFAUnion_btn
            // 
            this.DFAUnion_btn.Location = new System.Drawing.Point(36, 89);
            this.DFAUnion_btn.Name = "DFAUnion_btn";
            this.DFAUnion_btn.Size = new System.Drawing.Size(88, 33);
            this.DFAUnion_btn.TabIndex = 1;
            this.DFAUnion_btn.Text = "Union";
            this.DFAUnion_btn.UseVisualStyleBackColor = true;
            this.DFAUnion_btn.Click += new System.EventHandler(this.DFAUnion_btn_Click);
            // 
            // DFAInter_btn
            // 
            this.DFAInter_btn.Location = new System.Drawing.Point(36, 34);
            this.DFAInter_btn.Name = "DFAInter_btn";
            this.DFAInter_btn.Size = new System.Drawing.Size(88, 33);
            this.DFAInter_btn.TabIndex = 0;
            this.DFAInter_btn.Text = "Intersection";
            this.DFAInter_btn.UseVisualStyleBackColor = true;
            this.DFAInter_btn.Click += new System.EventHandler(this.DFAInter_btn_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(588, 536);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 338;
            this.lineShape2.X2 = 417;
            this.lineShape2.Y1 = 334;
            this.lineShape2.Y2 = 334;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 338;
            this.lineShape1.X2 = 417;
            this.lineShape1.Y1 = 182;
            this.lineShape1.Y2 = 182;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 536);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form1";
            this.Text = "CSE 573 HW 7";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uploadDFA1_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DFA1All_btn;
        private System.Windows.Forms.Button DFA1Empt_btn;
        private System.Windows.Forms.Button DFA1Cmplt_btn;
        private System.Windows.Forms.Button testDFA1_btn;
        private System.Windows.Forms.TextBox DFA1_textbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DFA2All_btn;
        private System.Windows.Forms.Button DFA2Empt_btn;
        private System.Windows.Forms.Button DFA2Cmplt_btn;
        private System.Windows.Forms.Button uploadDFA2_btn;
        private System.Windows.Forms.Button testDFA2_btn;
        private System.Windows.Forms.TextBox DFA2_textbox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button DFAEqvlt_btn;
        private System.Windows.Forms.Button DFAUnion_btn;
        private System.Windows.Forms.Button DFAInter_btn;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}

