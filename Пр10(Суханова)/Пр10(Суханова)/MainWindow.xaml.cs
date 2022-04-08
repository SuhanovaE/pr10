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
using System.IO;

namespace Пр10_Суханова_
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

        private void btnNule_Click(object sender, RoutedEventArgs e)
        {
            lstInput.Items.Clear();
        }

        

        private void btnListFromFile_Click(object sender, RoutedEventArgs e)
        {
            lstInput.Items.Add("Практическая работа №10. Выполнила: Суханова Екатерина");
            lstInput.Items.Add("Вариант 9");
            StreamReader sr = new StreamReader(@"Строки.txt", Encoding.UTF8);

            while (!sr.EndOfStream)
            {
                lstInput.Items.Add(sr.ReadLine());
            }
        }
        private void btnRezult_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int index = lstInput.SelectedIndex;
                string str = (string)lstInput.Items[index];
                



                txtRezult.Text = "предложение без первой буквы каждого слова = " + string.Join(;
                StreamWriter sw = new StreamWriter(@"Результат.txt", false, Encoding.Default);
                sw.WriteLine($"предложение без первой буквы каждого слова =  {count.ToString()}");
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
