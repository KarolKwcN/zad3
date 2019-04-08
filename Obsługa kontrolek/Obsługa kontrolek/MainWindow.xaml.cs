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


        private void ContentAlignmentHorizontAL(object sender, RoutedEventArgs e)
        {

            if (left_horizontal_content.IsChecked == true)
            {
                wyswietlany_tekst.HorizontalContentAlignment = HorizontalAlignment.Left;
            }
            else if (right_horizontal_content.IsChecked == true)
            {
                wyswietlany_tekst.HorizontalContentAlignment = HorizontalAlignment.Right;
            }
            else if (center_horizontal_content.IsChecked == true)
            {
                wyswietlany_tekst.HorizontalContentAlignment = HorizontalAlignment.Center;
            }
            else if (stretch_horizontal_content.IsChecked == true)
            {
                wyswietlany_tekst.HorizontalContentAlignment = HorizontalAlignment.Stretch;
            }

        }

        private void ContentAlignmentVertical(object sender, RoutedEventArgs e)
        {

            if (top_vertical_content.IsChecked == true)
            {
                wyswietlany_tekst.VerticalContentAlignment = VerticalAlignment.Top;
            }
            else if (bottom_vertical_content.IsChecked == true)
            {
                wyswietlany_tekst.VerticalContentAlignment = VerticalAlignment.Bottom;
            }
            else if (center_vertical_content.IsChecked == true)
            {
                wyswietlany_tekst.VerticalContentAlignment = VerticalAlignment.Center;
            }
            else if (stretch_horizontal_content.IsChecked == true)
            {
                wyswietlany_tekst.VerticalContentAlignment = VerticalAlignment.Stretch;
            }

        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void Slider_ValueChanged_Margin(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            wyswietlany_tekst.Margin = new Thickness(margin.Value);
        }

        private void Slider_ValueChanged_Padding(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            wyswietlany_tekst.Padding = new Thickness(padding.Value);
        }

        private void Background(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            LinearGradientBrush kolor_tla = new LinearGradientBrush();
            kolor_tla.GradientStops.Add(new GradientStop(Colors.Red, B_Red.Value));
            kolor_tla.GradientStops.Add(new GradientStop(Colors.Blue, B_Blue.Value));
            kolor_tla.GradientStops.Add(new GradientStop(Colors.Green, B_Green.Value));

            wyswietlany_tekst.Background = kolor_tla;
        }

        private void kolor(object sender, TextChangedEventArgs e)
        {
            LinearGradientBrush kolor = new LinearGradientBrush();
            double wartosc = 0;

            if (Double.TryParse(F_Red.Text, out wartosc))
                kolor.GradientStops.Add(new GradientStop(Colors.Red, wartosc));
            else
                kolor.GradientStops.Add(new GradientStop(Colors.Red, 0));

            if (Double.TryParse(F_Green.Text, out wartosc))
                kolor.GradientStops.Add(new GradientStop(Colors.Green, wartosc));
            else
                kolor.GradientStops.Add(new GradientStop(Colors.Green, 0));

            if (Double.TryParse(F_Blue.Text, out wartosc))
                kolor.GradientStops.Add(new GradientStop(Colors.Blue, wartosc));
            else
                kolor.GradientStops.Add(new GradientStop(Colors.Blue, 0));

            wyswietlany_tekst.Foreground = kolor;
        }

        private void pogrubione(object sender, RoutedEventArgs e)
        {
            if (pogrub.IsChecked == true)
            {
                wyswietlany_tekst.FontWeight = FontWeights.Bold;
            }
            else
            {
                wyswietlany_tekst.FontWeight = FontWeights.Normal;
            }
        }

        private void kursywa(object sender, RoutedEventArgs e)
        {
            if (kursywa1.IsChecked == true)
            {
                wyswietlany_tekst.FontStyle = FontStyles.Italic;
            }
            else
            {
                wyswietlany_tekst.FontStyle = FontStyles.Normal;
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SolidColorBrush wybrany_kolor = new SolidColorBrush(Colors.Black);


            if (czerwony.IsSelected)
            {
                wyswietlany_tekst.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            else if (zielony.IsSelected)
            {
                wyswietlany_tekst.BorderBrush = new SolidColorBrush(Colors.Green);
            }
            else if (niebieski.IsSelected)
            {
                wyswietlany_tekst.BorderBrush = new SolidColorBrush(Colors.Blue);
            }
            else if (cyan.IsSelected)
            {
                wyswietlany_tekst.BorderBrush = new SolidColorBrush(Colors.Cyan);
            }
            else if (zolty.IsSelected)
            {
                wyswietlany_tekst.BorderBrush = new SolidColorBrush(Colors.Yellow);
            }
            else if (magneta.IsSelected)
            {
                wyswietlany_tekst.BorderBrush = new SolidColorBrush(Colors.Magenta);
            }
            else
            {
                wyswietlany_tekst.BorderBrush = wybrany_kolor;
            }
        }

        private void Slider_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Thickness thick = new Thickness(thickens.Value);
            wyswietlany_tekst.BorderThickness = thick;
        }
    }
}
