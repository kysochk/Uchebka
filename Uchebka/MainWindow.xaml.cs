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

namespace Uchebka
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LoadList LoadS = new LoadList();
        List<MainWindow> ls;
        public MainWindow()
        {
            InitializeComponent();
            BaseConnect.BaseModel = new Entities(); //БД
        }
        void info()
        {
            kol_voZap.Text = "Записей на странице: " + ls.Count + " из " + kol_voZap;
        }

        private void Filtr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Sort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SearchBarTxt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
