namespace ProducerAndConsumer
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
            textBoxConsumer1 = new TextBox();
            textBoxConsumer2 = new TextBox();
            btnProduce1 = new Button();
            btnConsume1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtProducer = new TextBox();
            btnProduce2 = new Button();
            btnStop = new Button();
            panel1 = new Panel();
            btnProduce4 = new Button();
            btnProduce3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxConsumer1
            // 
            textBoxConsumer1.BackColor = SystemColors.Info;
            textBoxConsumer1.BorderStyle = BorderStyle.FixedSingle;
            textBoxConsumer1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxConsumer1.Location = new Point(110, 499);
            textBoxConsumer1.Margin = new Padding(6, 5, 6, 5);
            textBoxConsumer1.Multiline = true;
            textBoxConsumer1.Name = "textBoxConsumer1";
            textBoxConsumer1.ScrollBars = ScrollBars.Both;
            textBoxConsumer1.Size = new Size(416, 479);
            textBoxConsumer1.TabIndex = 0;
            // 
            // textBoxConsumer2
            // 
            textBoxConsumer2.BackColor = SystemColors.Info;
            textBoxConsumer2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxConsumer2.Location = new Point(1383, 499);
            textBoxConsumer2.Margin = new Padding(6, 5, 6, 5);
            textBoxConsumer2.Multiline = true;
            textBoxConsumer2.Name = "textBoxConsumer2";
            textBoxConsumer2.ScrollBars = ScrollBars.Both;
            textBoxConsumer2.Size = new Size(421, 479);
            textBoxConsumer2.TabIndex = 1;
            // 
            // btnProduce1
            // 
            btnProduce1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProduce1.Location = new Point(66, 40);
            btnProduce1.Margin = new Padding(6, 5, 6, 5);
            btnProduce1.Name = "btnProduce1";
            btnProduce1.Size = new Size(174, 69);
            btnProduce1.TabIndex = 2;
            btnProduce1.Text = "开始生产";
            btnProduce1.UseVisualStyleBackColor = true;
            btnProduce1.Click += btnProduce1_Click;
            // 
            // btnConsume1
            // 
            btnConsume1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsume1.Location = new Point(857, 185);
            btnConsume1.Margin = new Padding(6, 5, 6, 5);
            btnConsume1.Name = "btnConsume1";
            btnConsume1.Size = new Size(174, 69);
            btnConsume1.TabIndex = 3;
            btnConsume1.Text = "开始消费";
            btnConsume1.UseVisualStyleBackColor = true;
            btnConsume1.Click += btnConsume1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 436);
            label1.Name = "label1";
            label1.Size = new Size(155, 31);
            label1.TabIndex = 4;
            label1.Text = "消费者1 记录\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1383, 436);
            label2.Name = "label2";
            label2.Size = new Size(155, 31);
            label2.TabIndex = 5;
            label2.Text = "消费者2 记录\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(730, 435);
            label3.Name = "label3";
            label3.Size = new Size(165, 31);
            label3.TabIndex = 7;
            label3.Text = "生产者 总记录\r\n";
            // 
            // txtProducer
            // 
            txtProducer.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProducer.Location = new Point(730, 498);
            txtProducer.Margin = new Padding(6, 5, 6, 5);
            txtProducer.Multiline = true;
            txtProducer.Name = "txtProducer";
            txtProducer.Size = new Size(444, 479);
            txtProducer.TabIndex = 6;
            // 
            // btnProduce2
            // 
            btnProduce2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProduce2.Location = new Point(66, 155);
            btnProduce2.Margin = new Padding(6, 5, 6, 5);
            btnProduce2.Name = "btnProduce2";
            btnProduce2.Size = new Size(174, 69);
            btnProduce2.TabIndex = 8;
            btnProduce2.Text = "开始生产";
            btnProduce2.UseVisualStyleBackColor = true;
            btnProduce2.Click += btnProduce2_Click;
            // 
            // btnStop
            // 
            btnStop.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnStop.Location = new Point(1493, 185);
            btnStop.Margin = new Padding(6, 5, 6, 5);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(174, 69);
            btnStop.TabIndex = 9;
            btnStop.Text = "停止";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnProduce4);
            panel1.Controls.Add(btnProduce3);
            panel1.Controls.Add(btnProduce2);
            panel1.Controls.Add(btnProduce1);
            panel1.Location = new Point(109, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(565, 270);
            panel1.TabIndex = 10;
            // 
            // btnProduce4
            // 
            btnProduce4.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProduce4.Location = new Point(319, 155);
            btnProduce4.Margin = new Padding(6, 5, 6, 5);
            btnProduce4.Name = "btnProduce4";
            btnProduce4.Size = new Size(174, 69);
            btnProduce4.TabIndex = 10;
            btnProduce4.Text = "开始生产";
            btnProduce4.UseVisualStyleBackColor = true;
            btnProduce4.Click += btnProduce4_Click;
            // 
            // btnProduce3
            // 
            btnProduce3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProduce3.Location = new Point(319, 40);
            btnProduce3.Margin = new Padding(6, 5, 6, 5);
            btnProduce3.Name = "btnProduce3";
            btnProduce3.Size = new Size(174, 69);
            btnProduce3.TabIndex = 9;
            btnProduce3.Text = "开始生产";
            btnProduce3.UseVisualStyleBackColor = true;
            btnProduce3.Click += btnProduce3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1862, 1092);
            Controls.Add(panel1);
            Controls.Add(btnStop);
            Controls.Add(label3);
            Controls.Add(txtProducer);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnConsume1);
            Controls.Add(textBoxConsumer2);
            Controls.Add(textBoxConsumer1);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxConsumer1;
        private TextBox textBoxConsumer2;
        private Button btnProduce1;
        private Button btnConsume1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtProducer;
        private Button btnProduce2;
        private Button btnStop;
        private Panel panel1;
        private Button btnProduce4;
        private Button btnProduce3;
    }
}