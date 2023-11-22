using System.Runtime.InteropServices;

namespace CallDLL
{
    public partial class Form1 : Form
    {
        [DllImport("CreateDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern long Factorial(int number);

        [DllImport("CreateDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int Difference(int a, int b);
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFact_Click(object sender, EventArgs e)
        {
            // ���Խ������벢����׳�
            if (int.TryParse(txtFact.Text, out int num))
            {
                try
                {
                    long factorialResult = Factorial(num);
                    lblFact.Text = $"Factorial: {factorialResult}";
                }
                catch (Exception ex)
                {
                    // �쳣�������統DLLδ�ҵ���num������Чʱ
                    lblFact.Text = $"Error: {ex.Message}";
                }
            }
            else
            {
                lblFact.Text = "Invalid input";
            }
        }

        private void btnDiff_Click(object sender, EventArgs e)
        {
            // ���Խ����������벢�������ǵĲ�ֵ
            if (int.TryParse(textBoxA.Text, out int a) && int.TryParse(textBoxB.Text, out int b))
            {
                try
                {
                    int differenceResult = Difference(a, b);
                    lblDiff.Text = $"Difference: {differenceResult}";
                }
                catch (Exception ex)
                {
                    // ������ܷ������쳣
                    lblDiff.Text = $"Error: {ex.Message}";
                }
            }
            else
            {
                lblDiff.Text = "Invalid input";
            }
        }
    }
}