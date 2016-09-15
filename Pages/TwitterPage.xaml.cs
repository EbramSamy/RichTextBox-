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
using Test.Classes;

namespace Test.Pages
{
    /// <summary>
    /// Interaction logic for TwitterPage.xaml
    /// </summary>
    public partial class TwitterPage : UserControl
    {
        public TwitterPage()
        {
            InitializeComponent();
        }



        private void twitterRichTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                FormatText.format(twitterRichTextBox);
                textLength.Text = FormatText.textLength + "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FormatText.format(twitterRichTextBox);
                textLength.Text = FormatText.textLength + "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
