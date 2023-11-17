namespace PingCommunicator
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
            txtOutput = new TextBox();
            btnSync = new Button();
            btnAsync = new Button();
            panel1 = new Panel();
            txtPing = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(301, 158);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(405, 450);
            txtOutput.TabIndex = 0;
            // 
            // btnSync
            // 
            btnSync.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnSync.Location = new Point(105, 328);
            btnSync.Name = "btnSync";
            btnSync.Size = new Size(123, 53);
            btnSync.TabIndex = 1;
            btnSync.Text = "SyncPing";
            btnSync.UseVisualStyleBackColor = true;
            btnSync.Click += btnSync_Click;
            // 
            // btnAsync
            // 
            btnAsync.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAsync.Location = new Point(802, 328);
            btnAsync.Name = "btnAsync";
            btnAsync.Size = new Size(123, 53);
            btnAsync.TabIndex = 3;
            btnAsync.Text = "AsyncPing";
            btnAsync.UseVisualStyleBackColor = true;
            btnAsync.Click += btnAsync_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtPing);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAsync);
            panel1.Controls.Add(btnSync);
            panel1.Controls.Add(txtOutput);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1010, 708);
            panel1.TabIndex = 4;
            // 
            // txtPing
            // 
            txtPing.Location = new Point(475, 84);
            txtPing.Name = "txtPing";
            txtPing.Size = new Size(186, 23);
            txtPing.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(351, 79);
            label1.Name = "label1";
            label1.Size = new Size(76, 27);
            label1.TabIndex = 4;
            label1.Text = "IP 地址";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 708);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtOutput;
        private Button btnSync;
        private Button btnAsync;
        private Panel panel1;
        private TextBox txtPing;
        private Label label1;
    }
}