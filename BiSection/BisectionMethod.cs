using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiSection
{
    public class BisectionMethod
    {
        private double XL = 0;
        private double XU = 0;
        private int Index = 0;
        private bool Es = false;
        public double Answer = 0;
        private List<double> Res = new List<double>();
        private List<Item> Results = new List<Item>();

        private double F(double Value)
        {
            return (Value * Value) - 2;
        }

        private double Mid(double Value1, double Value2)
        {
            return (Value1 + Value2) / 2;
        }

        private bool AbsError()
        {
            if (Math.Abs(Res[Index - 2] - Res[Index - 3]) < 0.00001)
            {
                Es = true;
                return true;
            }
            else
            {
                Es = false;
                return false;
            }
        }

        public List<Item> Calculation(double XLVal, double XUVal)
        {
            XL = XLVal;
            XU = XUVal;

            while (Index < 30)
            {
                if (Index > 3)
                {
                    if (AbsError() == true)
                    {
                        AddItem();
                        Answer = Mid(XL, XU);
                        break;
                    }
                }

                AddItem();
            }

            return Results;
        }

        private void AddItem()
        {
            Results.Add(new Item
            {
                No = Index + 1,
                XL = XL,
                XU = XU,
                FXL = F(XL),
                FXU = F(XU),
                XM = Mid(XL, XU),
                FXM = F(Mid(XL, XU)),
                FXL_FXM = F(XL) * F(Mid(XL, XU)),
                Es = Es
            });

            Res.Add(F(XL) * F(Mid(XL, XU)));

            if ((F(XL) * F(Mid(XL, XU))) == 0)
            {
                System.Windows.Forms.MessageBox.Show(Mid(XL, XU) + " adalah root nya.");
            }

            if (F(XL) * F(Mid(XL, XU)) < 0)
            {
                XU = Mid(XL, XU);
            }
            else
            {
                XL = Mid(XL, XU);
            }

            Index++;
        }
    }
}
