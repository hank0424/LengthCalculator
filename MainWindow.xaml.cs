using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LengthCalculator
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string strInput;
        string strInput2;
        double douOutput;
        double dop;
        private void caculateAnswer(int _kind, double _value)
        {
            if (_kind != 0)
                txtCM.Text = string.Format("{0:0.##########}", _value);
            if (_kind != 1)
                txtM.Text = string.Format("{0:0.##########}", _value / 100);
            if (_kind != 2)
                txtKM.Text = string.Format("{0:0.##########}", _value / 100000);
            if (_kind != 3)
                txtIn.Text = string.Format("{0:0.##########}", _value / 2.54);
            if (_kind != 4)
                txtFt.Text = string.Format("{0:0.##########}", _value / 30.48);
            if (_kind != 5)
                txtYard.Text = string.Format("{0:0.##########}", _value / 91.44);
        }
        private void wei(int _kind, double _value)
        {
            if (_kind != 6)
                txtMG.Text = string.Format("{0:0.##########}", _value);
            if (_kind != 7)
                txtG.Text = string.Format("{0:0.##########}", _value / 1000);
            if (_kind != 8)
                txtKG.Text = string.Format("{0:0.##########}", _value / 1000000);
            if (_kind != 9)
                txtT.Text = string.Format("{0:0.##########}", _value / 1000000000);
            if (_kind != 10)
                txtOZ.Text = string.Format("{0:0.##########}", _value / 500000);
            if (_kind != 11)
                txtB.Text = string.Format("{0:0.##########}", _value / 28571.42857);
        }
        
           
        private void txtCM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtCM.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(0, douOutput);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtCM.Text = "";
            }
        }
        private void txtM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtM.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(1, douOutput * 100);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtM.Text = "";
            }
        }
        private void txtKM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtKM.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(2, douOutput * 100000);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtKM.Text = "";
            }
        }

        private void txtIn_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtIn.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(3, douOutput * 2.54);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtIn.Text = "";
            }
        }
        private void txtFt_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtFt.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(4, douOutput * 30.48);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtFt.Text = "";
            }
        }
        private void txtYard_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtYard.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(5, douOutput * 91.44);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtYard.Text = "";
            }
        }
        private void txtMG_KeyUp(object sender, KeyEventArgs e)
        {
            strInput2 = txtMG.Text;
            if (double.TryParse(strInput2, out dop) == true)
            {
                wei(6, dop);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtMG.Text = "";
            }
        }
        private void txtG_KeyUp(object sender, KeyEventArgs e)
        {
            strInput2 = txtG.Text;
            if (double.TryParse(strInput2, out dop) == true)
            {
              wei(7, dop* 1000);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtG.Text = "";
            }
        }
        private void txtKG_KeyUp(object sender, KeyEventArgs e)
        {
            strInput2 = txtKG.Text;
            if (double.TryParse(strInput2, out dop) == true)
            {
               wei(8, dop*1000000);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtKG.Text = "";
            }
        }
        private void txtT_KeyUp(object sender, KeyEventArgs e)
        {
            strInput2 = txtT.Text;
            if (double.TryParse(strInput2, out dop) == true)
            {
                wei(9, dop* 1000000000);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtT.Text = "";
            }
        }
        private void txtOZ_KeyUp(object sender, KeyEventArgs e)
        {
            strInput2 = txtOZ.Text;
            if (double.TryParse(strInput2, out dop) == true)
            {
                wei(10, dop* 500000);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtOZ.Text = "";
            }
        }
        private void txtB_KeyUp(object sender, KeyEventArgs e)
        {
            strInput2 = txtB.Text;
            if (double.TryParse(strInput2, out dop) == true)
            {
                wei(11, dop* 28571.42857);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtB.Text = "";
            }
        }
        private void btnALLClear_Click(object sender, RoutedEventArgs e)
        {
            txtCM.Text = "";
            txtM.Text = "";
            txtKM.Text = "";
            txtIn.Text = "";
            txtFt.Text = "";
            txtYard.Text = "";

            txtMG.Text = "";
            txtG.Text = "";
            txtKG.Text = "";
            txtT.Text = "";
            txtOZ.Text = "";
            txtB.Text = "";
        }

    }
}

      
   
