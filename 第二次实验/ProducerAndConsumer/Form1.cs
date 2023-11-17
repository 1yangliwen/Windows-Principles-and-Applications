namespace ProducerAndConsumer
{
    public partial class Form1 : Form
    {
        private ProducerConsumer _producerConsumer;
        private CancellationTokenSource _cancellationTokenSource;
        private readonly int _bufferSize = 10;
        public Form1()
        {
            InitializeComponent();
            _producerConsumer = new ProducerConsumer(_bufferSize);
            _cancellationTokenSource = new CancellationTokenSource();
        }

        // 用于在WinForms界面上更新文本框的线程安全方法
        private void UpdateUI(TextBox textBox, string message)
        {
            if (textBox.InvokeRequired)
            {
                textBox.BeginInvoke(new Action(() => textBox.AppendText(message + Environment.NewLine)));
            }
            else
            {
                textBox.AppendText(message + Environment.NewLine);
            }
        }

        // 调用示例：UpdateTextBox(textBox, item.ToString());
        private void UpdateTextBox(TextBox textBox, string text)
        {
            if (textBox.InvokeRequired)
            {
                textBox.Invoke(new Action(() => UpdateTextBox(textBox, text)));
            }
            else
            {
                textBox.AppendText(text + Environment.NewLine);
            }
        }


        private void btnConsume1_Click(object sender, EventArgs e)
        {
            var consumerTask1 = new Task(() =>
            {
                _producerConsumer.ConsumerMethod(_producerConsumer, item => UpdateTextBox(textBoxConsumer1, $"Consumed: {item}"), _cancellationTokenSource.Token);
            }, _cancellationTokenSource.Token);
            consumerTask1.Start();
            var consumerTask2 = new Task(() =>
            {
                _producerConsumer.ConsumerMethod(_producerConsumer, item => UpdateTextBox(textBoxConsumer2, $"Consumed: {item}"), _cancellationTokenSource.Token);
            }, _cancellationTokenSource.Token);
            consumerTask2.Start();
        }

        private void btnProduce2_Click(object sender, EventArgs e)
        {
            var producerTask = new Task(() =>
            {
                _producerConsumer.ProducerMethod(_producerConsumer, item => UpdateTextBox(txtProducer, $"Produced-2: {item}"), _cancellationTokenSource.Token);
            }, _cancellationTokenSource.Token);
            producerTask.Start();
        }
        private void btnProduce1_Click(object sender, EventArgs e)
        {
            var producerTask = new Task(() =>
            {
                _producerConsumer.ProducerMethod(_producerConsumer, item => UpdateTextBox(txtProducer, $"Produced-1: {item}"), _cancellationTokenSource.Token);
            }, _cancellationTokenSource.Token);
            producerTask.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource?.Cancel();
        }

        private void btnProduce3_Click(object sender, EventArgs e)
        {
            var producerTask = new Task(() =>
            {
                _producerConsumer.ProducerMethod(_producerConsumer, item => UpdateTextBox(txtProducer, $"Produced-3: {item}"), _cancellationTokenSource.Token);
            }, _cancellationTokenSource.Token);
            producerTask.Start();
        }

        private void btnProduce4_Click(object sender, EventArgs e)
        {
            var producerTask = new Task(() =>
            {
                _producerConsumer.ProducerMethod(_producerConsumer, item => UpdateTextBox(txtProducer, $"Produced-4: {item}"), _cancellationTokenSource.Token);
            }, _cancellationTokenSource.Token);
            producerTask.Start();
        }
    }
}