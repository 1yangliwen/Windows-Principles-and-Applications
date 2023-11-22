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
            //_express = new Express(); // ����Express�����COM���
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
                MessageBox.Show("�����ʽ������������Ч��������");
            }
            catch (Exception ex)
            {
                MessageBox.Show("��������" + ex.Message);
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
                    lblResult.Text = "��������Ϊ�㡣";
                    return;
                }
                lblResult.Text = _express.Divide(a, b);
            }
            catch (FormatException)
            {
                MessageBox.Show("�����ʽ������������Ч��������");
            }
            catch (Exception ex)
            {
                MessageBox.Show("��������" + ex.Message);
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
                MessageBox.Show("�޷�����COM���ʵ����" + ex.Message);
            }
        }
    }
}