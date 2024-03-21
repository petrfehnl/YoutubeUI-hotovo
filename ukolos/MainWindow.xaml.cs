using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace ukolos
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseEnter(object sender, MouseEventArgs e)
        {
            if (sender is Border border)
            {
                border.Background = Brushes.LightGreen; // Změna pozadí při MouseEnter
            }
        }

        private void Border_MouseLeave(object sender, MouseEventArgs e)
        {
            if (sender is Border border)
            {
                border.Background = Brushes.LightBlue; // Změna pozadí při MouseLeave
            }
        }

        private void Border_KeyDown(object sender, KeyEventArgs e)
        {
            if (sender is Border border)
            {
                double step = 10;
                switch (e.Key)
                {
                    case Key.W:
                        Canvas.SetTop(border, Canvas.GetTop(border) - step);
                        break;
                    case Key.S:
                        Canvas.SetTop(border, Canvas.GetTop(border) + step);
                        break;
                    case Key.A:
                        Canvas.SetLeft(border, Canvas.GetLeft(border) - step);
                        break;
                    case Key.D:
                        Canvas.SetLeft(border, Canvas.GetLeft(border) + step);
                        break;
                }
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                // Aktualizace textu bez použití Click události
                // Zde můžete provést jakoukoli další logiku aktualizace textu
            }
        }
    }
}
