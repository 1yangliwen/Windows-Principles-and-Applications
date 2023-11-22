namespace CallDLL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnFact = new Button();
            txtFact = new TextBox();
            lbl1 = new Label();
            lblFact = new Label();
            textBoxA = new TextBox();
            panel1 = new Panel();
            textBoxB = new TextBox();
            btnDiff = new Button();
            lbl2 = new Label();
            lblDiff = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // BtnFact
            // 
            BtnFact.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnFact.Location = new Point(509, 81);
            BtnFact.Name = "BtnFact";
            BtnFact.Size = new Size(258, 66);
            BtnFact.TabIndex = 0;
            BtnFact.Text = "计算阶乘";
            BtnFact.UseVisualStyleBackColor = true;
            BtnFact.Click += BtnFact_Click;
            // 
            // txtFact
            // 
            txtFact.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtFact.Location = new Point(96, 81);
            txtFact.Name = "txtFact";
            txtFact.Size = new Size(200, 58);
            txtFact.TabIndex = 1;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1.Location = new Point(907, 84);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(194, 52);
            lbl1.TabIndex = 2;
            lbl1.Text = "Factorial:";
            // 
            // lblFact
            // 
            lblFact.AutoSize = true;
            lblFact.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblFact.Location = new Point(1174, 88);
            lblFact.Name = "lblFact";
            lblFact.Size = new Size(0, 52);
            lblFact.TabIndex = 3;
            // 
            // textBoxA
            // 
            textBoxA.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxA.Location = new Point(64, 65);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(136, 58);
            textBoxA.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(lblFact);
            panel1.Controls.Add(lbl1);
            panel1.Controls.Add(txtFact);
            panel1.Controls.Add(BtnFact);
            panel1.Location = new Point(122, 170);
            panel1.Name = "panel1";
            panel1.Size = new Size(1475, 238);
            panel1.TabIndex = 5;
            // 
            // textBoxB
            // 
            textBoxB.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxB.Location = new Point(278, 65);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(136, 58);
            textBoxB.TabIndex = 6;
            // 
            // btnDiff
            // 
            btnDiff.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnDiff.Location = new Point(523, 61);
            btnDiff.Name = "btnDiff";
            btnDiff.Size = new Size(258, 66);
            btnDiff.TabIndex = 4;
            btnDiff.Text = "计算差值";
            btnDiff.UseVisualStyleBackColor = true;
            btnDiff.Click += btnDiff_Click;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl2.Location = new Point(868, 71);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(260, 52);
            lbl2.TabIndex = 4;
            lbl2.Text = "Difference：";
            // 
            // lblDiff
            // 
            lblDiff.AutoSize = true;
            lblDiff.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblDiff.Location = new Point(1160, 71);
            lblDiff.Name = "lblDiff";
            lblDiff.Size = new Size(0, 52);
            lblDiff.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Info;
            panel2.Controls.Add(lblDiff);
            panel2.Controls.Add(lbl2);
            panel2.Controls.Add(btnDiff);
            panel2.Controls.Add(textBoxB);
            panel2.Controls.Add(textBoxA);
            panel2.Location = new Point(136, 552);
            panel2.Name = "panel2";
            panel2.Size = new Size(1461, 213);
            panel2.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1655, 964);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnFact;
        private TextBox txtFact;
        private Label lbl1;
        private Label lblFact;
        private TextBox textBoxA;
        private Panel panel1;
        private TextBox textBoxB;
        private Button btnDiff;
        private Label lbl2;
        private Label lblDiff;
        private Panel panel2;
    }
}