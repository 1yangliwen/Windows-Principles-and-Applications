using FireEvent.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireEvent
{
    public partial class Form1 : Form
    {
        private FireAlarm fireAlarm = new FireAlarm();
        private FireHandler fireHandler = new FireHandler();  // Move this line to class level

        public Form1()
        {
            InitializeComponent();
        }

        private void bindBtn1_Click(object sender, EventArgs e)
        {
            fireAlarm.FireEvent += fireHandler.HandleFire1;
            fireAlarm.FireEvent += HandleFireRecord;  // 绑定到当前类的HandleFire1
        }

        private void bindBtn2_Click(object sender, EventArgs e)
        {

            fireAlarm.FireEvent += fireHandler.HandleFire2;
            fireAlarm.FireEvent += HandleFireRecord;  // 绑定到当前类的HandleFire1
        }

        private void unbindBtn1_Click(object sender, EventArgs e)
        {
            fireAlarm.FireEvent -= fireHandler.HandleFire1;
            fireAlarm.FireEvent -= HandleFireRecord;
        }


        private void unbindBtn2_Click(object sender, EventArgs e)
        {

            fireAlarm.FireEvent -= fireHandler.HandleFire2;
            fireAlarm.FireEvent -= HandleFireRecord;
        }

        private void triggerBtn_Click(object sender, EventArgs e)
        {
            string message = "Fire in the kitchen!";
            string level = levelTxt.Text;  // 这里你可以从一个UI控件读取
            string location = locationTxt.Text;  // 这里你也可以从一个UI控件读取

            fireAlarm.RaiseFireEvent(message, level, location);
        }

        public void HandleFireRecord(object sender, FireEventArgs e)
        {
            string displayMessage = $"Handler received fire event: Message = {e.Message}, Level = {e.Level}, Location = {e.Location}";
            EventHistoryListBox.Items.Add($"Handler received fire event: {displayMessage}");
            // 或者使用DataGrid
            // EventHistoryDataGrid.Items.Add(new { Handler = "Handler 1", Message = e.Message });
        }

    }
}
