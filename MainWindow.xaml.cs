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

namespace авторииз
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string loginDef = "user";
        string PassDef = "Qwerty1";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool flag = false;
            string LoginUser = LogText.Text;
            string PassUser = PasText.Password;
            if (LoginUser == loginDef && PassUser == PassDef)
            {
                flag = true;
                MessageBox.Show("Вы авторизовались!", "Поздравляем!", MessageBoxButton.OK, MessageBoxImage.Information);
                Environment.Exit(0);
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Логин или пароль не верен! Попробуем ещё раз?", "Не авторизовались!", MessageBoxButton.YesNo, MessageBoxImage.Error);
                if (result == MessageBoxResult.Yes)
                {
                    flag = false;
                    LogText.Text = "";
                    PasText.Password = "";
                }

                else
                    Environment.Exit(0);
            }

        }
    }
}