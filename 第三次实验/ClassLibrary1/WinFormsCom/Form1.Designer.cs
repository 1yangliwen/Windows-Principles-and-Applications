namespace WinFormsCom
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnMinus = new Button();
            btnDivide = new Button();
            panel1 = new Panel();
            label1 = new Label();
            lblResult = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(90, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 58);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(556, 50);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(231, 58);
            textBox2.TabIndex = 1;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnMinus.Location = new Point(296, 455);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(181, 67);
            btnMinus.TabIndex = 2;
            btnMinus.Text = "Minus";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnDivide.Location = new Point(777, 455);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(181, 67);
            btnDivide.TabIndex = 3;
            btnDivide.Text = "Divide";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(183, 119);
            panel1.Name = "panel1";
            panel1.Size = new Size(911, 168);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(454, 636);
            label1.Name = "label1";
            label1.Size = new Size(141, 52);
            label1.TabIndex = 5;
            label1.Text = "Result";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.Location = new Point(653, 636);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 52);
            lblResult.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(653, 636);
            label2.Name = "label2";
            label2.Size = new Size(203, 52);
            label2.TabIndex = 7;
            label2.Text = "-1 = 1 - 2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 799);
            Controls.Add(label2);
            Controls.Add(lblResult);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btnDivide);
            Controls.Add(btnMinus);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnMinus;
        private Button btnDivide;
        private Panel panel1;
        private Label label1;
        private Label lblResult;
        private Label label2;
    }
}