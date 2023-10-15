namespace FireEvent
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.EventHistoryListBox = new System.Windows.Forms.ListBox();
            this.triggerBtn = new System.Windows.Forms.Button();
            this.unbindBtn2 = new System.Windows.Forms.Button();
            this.unbindBtn1 = new System.Windows.Forms.Button();
            this.bindBtn2 = new System.Windows.Forms.Button();
            this.bindBtn1 = new System.Windows.Forms.Button();
            this.levelLbl = new System.Windows.Forms.Label();
            this.locationLbl = new System.Windows.Forms.Label();
            this.levelTxt = new System.Windows.Forms.TextBox();
            this.locationTxt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.EventHistoryListBox);
            this.panel1.Controls.Add(this.triggerBtn);
            this.panel1.Controls.Add(this.unbindBtn2);
            this.panel1.Controls.Add(this.unbindBtn1);
            this.panel1.Controls.Add(this.bindBtn2);
            this.panel1.Controls.Add(this.bindBtn1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1395, 842);
            this.panel1.TabIndex = 0;
            // 
            // EventHistoryListBox
            // 
            this.EventHistoryListBox.FormattingEnabled = true;
            this.EventHistoryListBox.ItemHeight = 24;
            this.EventHistoryListBox.Location = new System.Drawing.Point(425, 333);
            this.EventHistoryListBox.Name = "EventHistoryListBox";
            this.EventHistoryListBox.Size = new System.Drawing.Size(573, 268);
            this.EventHistoryListBox.TabIndex = 5;
            // 
            // triggerBtn
            // 
            this.triggerBtn.BackColor = System.Drawing.SystemColors.Window;
            this.triggerBtn.Location = new System.Drawing.Point(612, 673);
            this.triggerBtn.Name = "triggerBtn";
            this.triggerBtn.Size = new System.Drawing.Size(179, 80);
            this.triggerBtn.TabIndex = 4;
            this.triggerBtn.Text = "Trigger";
            this.triggerBtn.UseVisualStyleBackColor = false;
            this.triggerBtn.Click += new System.EventHandler(this.triggerBtn_Click);
            // 
            // unbindBtn2
            // 
            this.unbindBtn2.BackColor = System.Drawing.SystemColors.Window;
            this.unbindBtn2.Location = new System.Drawing.Point(1063, 403);
            this.unbindBtn2.Name = "unbindBtn2";
            this.unbindBtn2.Size = new System.Drawing.Size(179, 80);
            this.unbindBtn2.TabIndex = 3;
            this.unbindBtn2.Text = "unbind2";
            this.unbindBtn2.UseVisualStyleBackColor = false;
            this.unbindBtn2.Click += new System.EventHandler(this.unbindBtn2_Click);
            // 
            // unbindBtn1
            // 
            this.unbindBtn1.BackColor = System.Drawing.SystemColors.Window;
            this.unbindBtn1.Location = new System.Drawing.Point(181, 403);
            this.unbindBtn1.Name = "unbindBtn1";
            this.unbindBtn1.Size = new System.Drawing.Size(179, 80);
            this.unbindBtn1.TabIndex = 2;
            this.unbindBtn1.Text = "unbind1";
            this.unbindBtn1.UseVisualStyleBackColor = false;
            this.unbindBtn1.Click += new System.EventHandler(this.unbindBtn1_Click);
            // 
            // bindBtn2
            // 
            this.bindBtn2.BackColor = System.Drawing.SystemColors.Window;
            this.bindBtn2.Location = new System.Drawing.Point(1063, 190);
            this.bindBtn2.Name = "bindBtn2";
            this.bindBtn2.Size = new System.Drawing.Size(179, 80);
            this.bindBtn2.TabIndex = 1;
            this.bindBtn2.Text = "bind2";
            this.bindBtn2.UseVisualStyleBackColor = false;
            this.bindBtn2.Click += new System.EventHandler(this.bindBtn2_Click);
            // 
            // bindBtn1
            // 
            this.bindBtn1.BackColor = System.Drawing.SystemColors.Window;
            this.bindBtn1.Location = new System.Drawing.Point(181, 190);
            this.bindBtn1.Name = "bindBtn1";
            this.bindBtn1.Size = new System.Drawing.Size(179, 80);
            this.bindBtn1.TabIndex = 0;
            this.bindBtn1.Text = "bind1";
            this.bindBtn1.UseVisualStyleBackColor = false;
            this.bindBtn1.Click += new System.EventHandler(this.bindBtn1_Click);
            // 
            // levelLbl
            // 
            this.levelLbl.AutoSize = true;
            this.levelLbl.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.levelLbl.Location = new System.Drawing.Point(36, 40);
            this.levelLbl.Name = "levelLbl";
            this.levelLbl.Size = new System.Drawing.Size(88, 30);
            this.levelLbl.TabIndex = 6;
            this.levelLbl.Text = "Level";
            // 
            // locationLbl
            // 
            this.locationLbl.AutoSize = true;
            this.locationLbl.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.locationLbl.Location = new System.Drawing.Point(40, 144);
            this.locationLbl.Name = "locationLbl";
            this.locationLbl.Size = new System.Drawing.Size(133, 30);
            this.locationLbl.TabIndex = 7;
            this.locationLbl.Text = "Location";
            // 
            // levelTxt
            // 
            this.levelTxt.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.levelTxt.Location = new System.Drawing.Point(222, 40);
            this.levelTxt.Name = "levelTxt";
            this.levelTxt.Size = new System.Drawing.Size(213, 41);
            this.levelTxt.TabIndex = 8;
            // 
            // locationTxt
            // 
            this.locationTxt.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.locationTxt.Location = new System.Drawing.Point(222, 144);
            this.locationTxt.Name = "locationTxt";
            this.locationTxt.Size = new System.Drawing.Size(213, 41);
            this.locationTxt.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.locationTxt);
            this.panel2.Controls.Add(this.levelTxt);
            this.panel2.Controls.Add(this.locationLbl);
            this.panel2.Controls.Add(this.levelLbl);
            this.panel2.Location = new System.Drawing.Point(470, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(481, 221);
            this.panel2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 842);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button triggerBtn;
        private System.Windows.Forms.Button unbindBtn2;
        private System.Windows.Forms.Button unbindBtn1;
        private System.Windows.Forms.Button bindBtn2;
        private System.Windows.Forms.Button bindBtn1;
        private System.Windows.Forms.ListBox EventHistoryListBox;
        private System.Windows.Forms.Label locationLbl;
        private System.Windows.Forms.TextBox locationTxt;
        private System.Windows.Forms.TextBox levelTxt;
        private System.Windows.Forms.Label levelLbl;
        private System.Windows.Forms.Panel panel2;
    }
}

