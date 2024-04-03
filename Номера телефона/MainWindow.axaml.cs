using Avalonia.Controls;
using System;

namespace Номера_телефона
{
    public partial class MainWindow : Window
    {
        string _rndNumber = "0000000000";
        int _Click = 0;
        public MainWindow()
        { 
            InitializeComponent();

        } 
        private void rndNumberGet(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
            {
                _rndNumber = "";
                Random rnd = new Random();
                for (int i = 0; i < 10; i++)
                {
                    _rndNumber += rnd.Next(9);
                }
                randomText.Text = _rndNumber;
                rndYourNumber.Text = $"Ваш номер телефона:\n";
            }
            private void rndNumberSet(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
            {
                string yourNumber = "+7(";
                char[] rndChars = _rndNumber.ToCharArray();
                int j = 0;
                for (int i = 0; i < 14; i++)
                {
                    yourNumber = i == 3 ? yourNumber += ')' : (i == 4 || i == 8 || i == 11 ? yourNumber += '-' : yourNumber += rndChars[j]);
                    j = (i != 3 && i != 4 && i != 8 && i != 11) ? ++j : j;
                }
                rndYourNumber.Text = $"Ваш номер телефона:\n {yourNumber}";
            }

        private void Button_Click_1(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            _Click++;
            КликМобТел.Text = Convert.ToString(_Click);

        }
    }
}