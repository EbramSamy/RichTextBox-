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
using WpfPageTransitions;

namespace Test.Pages
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            TwitterPage twitterPage = new TwitterPage();
            MainWindow.pageTransitionControl.ShowPage(twitterPage);
            LinkedListNode<UserControl> node = MainWindow.openedPage.Find(this);
            MainWindow.openedPage.AddAfter(node, twitterPage);
            MainWindow.nod = MainWindow.openedPage.Find(twitterPage);
            MainWindow.pageTransitionControl.TransitionType = PageTransitionType.Fade;
            MainWindow.pageTransitionControl.ShowPage(twitterPage);
        }
    }
}
