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

namespace Homework3
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
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void btnA_Click(object sender, RoutedEventArgs e)
        {
            {
                int operation = cmbA.SelectedIndex;
                int count = 0;
                string str = tbA.Text;
                switch (operation)
                {
                    case 0:
                        char[] consonants = new char[43] { 'б', 'в', 'г', 'д', 'ж', 'з', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ь','й', 'Б', 'В', 'Г', 'Д', 'Ж', 'З', 'К', 'Л', 'М', 'Н', 'П', 'Р', 'С', 'Т', 'Ф', 'X', 'Ц', 'Ч', 'Ш','Щ','Й' };
                        for (int i = 0; i < str.Length; i++)
                        {
                            for (int j = 0; j < consonants.Length; j++)
                            {
                                if (consonants[j] == str[i]) { count++; }
                            }
                        }
                        break;
                    case 1:
                        char[] vowels = new char[20] { 'а', 'о', 'и', 'е', 'ё', 'э', 'ы', 'у', 'ю', 'я', 'А', 'О', 'И', 'Е', 'Ё', 'Э', 'Ы', 'У', 'Ю', 'Я' };                      
                        for (int i = 0; i < str.Length; i++)
                        {
                            for (int j = 0; j < vowels.Length; j++)
                            {
                                if (vowels[j] == str[i]) { count++; }
                            }
                        } 
                        break; 
                }
                tbResult.Text = String.Format("{0}", count);//выводим число
            }}
        private void tbResult_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}
