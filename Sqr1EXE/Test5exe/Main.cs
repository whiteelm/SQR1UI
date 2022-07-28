using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RndSqr21
{
    public partial class Main : Form
    {
        [DllImport(@"Sqr1.dll", CharSet = CharSet.Ansi,
            CallingConvention = CallingConvention.StdCall, EntryPoint = "isqr1")]
        private static extern void IRndSqr21(double h, double d, double e, 
            ref double C, ref double L, ref double Z0, ref double em);

        private void Button1_Click(object sender, EventArgs ea)
        {
            try
            {
                Calculate();
            }
            catch
            {
                MessageBox.Show("Ошибка, проверьте ввод", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Calculate()
        {
            var d = Convert.ToDouble(DTextBox.Text);
            var h = Convert.ToDouble(HTextBox.Text);
            var er = Convert.ToDouble(ETextBox.Text);
            double L = 0;
            double C = 0;
            double Z0 = 0;
            double em = 0;
            IRndSqr21(h, d, er, ref C, ref L, ref Z0, ref em);
            CLabel.Text = C.ToString("0.0000");
            LLabel.Text = L.ToString("0.0000");
            Z0Label.Text = Z0.ToString("0.0000");
            emLabel.Text = em.ToString("0.0000");
        }

        private void ValidateDoubleTextBoxes_KeyPress(object sender,
            KeyPressEventArgs e)
        {
            e.Handled = !Regex.IsMatch(e.KeyChar.ToString(),
                @"[\d\b,]");
        }

        public Main()
        {
            InitializeComponent();
        }
    }
}
