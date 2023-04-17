using Restorann.ViewModels.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Restorann.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public byte count;
        public ICommand? ShowCommand { get; set; }
        public MainView()
        {
            InitializeComponent();
            DataContext = this;
            ShowCommand = new RelayCommand(ExecuteShowCommand, CanExecuteShowCommand);
            time.Text = DateTime.Now.ToString();
        }

        void ExecuteShowCommand(object? parameter) => main.Content = new MenuView();
        bool CanExecuteShowCommand(object? parameter) => true;

        private void Button_kassa(object sender, RoutedEventArgs e)
        {
            Thread.Sleep(6000);
            MS1.Background = Brushes.LightBlue;
            MS2.Background = Brushes.LightBlue;
            MS3.Background = Brushes.LightBlue;
            MS4.Background = Brushes.LightBlue;
            MS5.Background = Brushes.LightBlue;
            MS6.Background = Brushes.LightBlue;
            totalsebet.Text = " ";
            kasa.Background = Brushes.Green;
        }

        private void CheckBox_CheckedMS1(object sender, RoutedEventArgs e)
        {
            count = 1;
        }
        private void CheckBox_CheckedMS2(object sender, RoutedEventArgs e)
        {
            count = 2;
        }
        private void CheckBox_CheckedMS3(object sender, RoutedEventArgs e)
        {
            count = 3;
        }
        private void CheckBox_CheckedMS4(object sender, RoutedEventArgs e)
        {
            count = 4;
        }
        private void CheckBox_CheckedMS5(object sender, RoutedEventArgs e)
        {
            count = 5;
        }
        private void CheckBox_CheckedMS6(object sender, RoutedEventArgs e)
        {
            count = 6;
        }

        private void Button_Click_Rezerv(object sender, RoutedEventArgs e)
        {
            if (count == 1)
            {
                if (MS1.Background != Brushes.Red)
                {
                    MS1.Background = Brushes.Red;
                }
                else
                    MessageBox.Show("Sorry 1st table reserved");
            }
            else if (count == 2)
            {
                if (MS2.Background != Brushes.Red)
                {
                    MS2.Background = Brushes.Red;
                }
                else
                    MessageBox.Show("Sorry 1st table reserved");
            }
            else if (count == 3)
            {
                if (MS3.Background != Brushes.Red)
                {
                    MS3.Background = Brushes.Red;
                }
                else
                    MessageBox.Show("Sorry 1st table reserved");
            }
            else if (count == 4)
            {
                if (MS4.Background != Brushes.Red)
                {
                    MS4.Background = Brushes.Red;
                }
                else
                    MessageBox.Show("Sorry 1st table reserved");
            }
            else if (count == 5)
            {
                if (MS5.Background != Brushes.Red)
                {
                    MS5.Background = Brushes.Red;
                }
                else
                    MessageBox.Show("Sorry 1st table reserved");
            }
            else if (count == 6)
            {
                if (MS6.Background != Brushes.Red)
                {
                    MS6.Background = Brushes.Red;
                }
                else
                    MessageBox.Show("Sorry 1st table reserved");
            }
        }
    }
}

