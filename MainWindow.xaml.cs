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

namespace Practic2Pav
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int number = int.Parse(vod.Text);
            int firstDigit = number / 10;
            int secondDigit = number % 10;
            int sum = firstDigit + secondDigit;
            int product = firstDigit * secondDigit;

            otv.Text = ("Сумма цифр числа: " + sum);
            otv_Copy.Text = ("Произведение цифр числа: " + product);
        }




    }
}
