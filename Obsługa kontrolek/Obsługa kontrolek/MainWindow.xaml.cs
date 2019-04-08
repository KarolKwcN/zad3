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

namespace Obsługa_kontrolek
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            wyswietlany_tekst.Content = wpisywany_tekst.Text;
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
            try
            {
                int rozmiar = int.Parse(rozmiar_czcionki.Text);
                wyswietlany_tekst.FontSize = rozmiar;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Rozmiar czcionki musi być większy od 0 i być liczbą");
          
            }
        }

        private void AlignmentHorizontal(object sender, RoutedEventArgs e)
        {
            if (left_horizontal.IsChecked == true)
            {
                wyswietlany_tekst.HorizontalAlignment = HorizontalAlignment.Left;
            }
            else if (right_horizontal.IsChecked == true)
            {
                wyswietlany_tekst.HorizontalAlignment = HorizontalAlignment.Right;
            }
            else if (center_horizontal.IsChecked == true)
            {
                wyswietlany_tekst.HorizontalAlignment = HorizontalAlignment.Center;
            }
            else if (stretch_horizontal.IsChecked == true)
            {
                wyswietlany_tekst.HorizontalAlignment = HorizontalAlignment.Stretch;
            }
        }

        private void AlignmentVertical(object sender, RoutedEventArgs e)
        {
            if (top_vertical.IsChecked == true)
            {
                wyswietlany_tekst.VerticalAlignment = VerticalAlignment.Top;
            }
            else if (bottom_vertical.IsChecked == true)
            {
                wyswietlany_tekst.VerticalAlignment = VerticalAlignment.Bottom;
            }
            else if (center_vertical.IsChecked == true)
            {
                wyswietlany_tekst.VerticalAlignment = VerticalAlignment.Center;
            }
            else if (stretch_vertical.IsChecked == true)
            {
                wyswietlany_tekst.VerticalAlignment = VerticalAlignment.Stretch;
            }
        }

      
    }
}
