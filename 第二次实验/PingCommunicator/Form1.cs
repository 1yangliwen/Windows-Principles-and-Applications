namespace PingCommunicator
{
    public partial class Form1 : Form
    {
        private AsyncPing _asyncPing;
        public Form1()
        {
            InitializeComponent();
            _asyncPing = new AsyncPing();
            _asyncPing.OnPingCompleted += UpdateTextBox; // 订阅事件
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            var syncPing = new SyncPing();
            string result = syncPing.PerformPing(txtPing.Text);
            txtOutput.Text = result;
        }

        private void btnAsync_Click(object sender, EventArgs e)
        {
            _asyncPing.PerformPingAsync(txtPing.Text); // 举例
        }
        private void UpdateTextBox(string text)
        {
            if (InvokeRequired) // 确保在UI线程上操作
            {
                Invoke(new Action<string>(UpdateTextBox), text);
            }
            else
            {
                txtOutput.AppendText(text + Environment.NewLine); // 这里可以修改为你的TextBox
            }
        }
    }
}