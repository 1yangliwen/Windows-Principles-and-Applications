using ClassLibrary2;
using System.Runtime.InteropServices;

namespace WinFormsCom
{
    public partial class Form1 : Form
    {
        private IExpress _express;

        public Form1()
        {
            InitializeComponent();
            //_express = new Express(); // 假设Express是你的COM组件
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                string result = _express.Minus(a, b);
                lblResult.Text = result;
            }
            catch (FormatException)
            {
                MessageBox.Show("输入格式错误，请输入有效的整数。");
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误：" + ex.Message);
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                if (b == 0)
                {
                    lblResult.Text = "除数不能为零。";
                    return;
                }
                lblResult.Text = _express.Divide(a, b);
            }
            catch (FormatException)
            {
                MessageBox.Show("输入格式错误，请输入有效的整数。");
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误：" + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                _express = (IExpress)Activator.CreateInstance(Type.GetTypeFromProgID("ClassLibrary2.Express"));
            }
            catch (COMException ex)
            {
                MessageBox.Show("无法创建COM组件实例：" + ex.Message);
            }
        }
    }
}