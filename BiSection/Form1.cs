using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiSection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HeaderLine.Width = Width;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            BisectionMethod Bis = new BisectionMethod();

            double.TryParse(Val1.Text, out double XL);
            double.TryParse(Val2.Text, out double XU);

            var Results = Bis.Calculation(XL, XU);

            DBGrid.Rows.Clear();
            LblAnswer.Text = $"Hasil untuk nilai {XL} dan {XU} adalah {Bis.Answer} setelah {Results.Count} iterasi.";

            foreach (var Result in Results)
            {
                DBGrid.Rows.Add(Result.No, Result.XL, Result.XU, Result.FXL, Result.FXU, Result.XM, Result.FXM, Result.FXL_FXM, Result.Es ? "Ya" : "Tidak");
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            DBGrid.Rows.Clear();
            LblAnswer.Text = "-";
            Val1.Text = "";
            Val2.Text = "";
            Val1.Focus();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            HeaderLine.Width = Width;
        }
    }
}
