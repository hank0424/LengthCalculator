﻿using System;
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
        double douOutput; 
        private void txtCM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtCM.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtM.Text = string.Format("{0:0.##########}", douOutput / 100);
                txtKM.Text = string.Format("{0:0.##########}", douOutput / 100000);
                txtIn.Text = string.Format("{0:0.##########}", douOutput / 2.54);
                txtFt.Text = string.Format("{0:0.##########}", douOutput / 30.48);
                txtYard.Text = string.Format("{0:0.##########}", douOutput / 91.44);
            }
            else
            {

                    txtInfo.Text = "請輸入數字";
                    txtCM.Text = "";
                
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
        }
    }
}
