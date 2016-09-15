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
using Test.Pages;
using WpfPageTransitions;

namespace Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static WpfPageTransitions.PageTransition pageTransitionControl = new PageTransition();
        public static LinkedList<UserControl> openedPage = new LinkedList<UserControl>();
        public static LinkedListNode<UserControl> nod;
        Bars.UpAppBar upBar;
        public MainWindow()
        {
            InitializeComponent();
            grid.Children.Add(pageTransitionControl);
            pageTransitionControl.TransitionType = PageTransitionType.Grow;

            MainPage mainPage = new MainPage();
            MainWindow.pageTransitionControl.ShowPage(mainPage);
            openedPage.AddFirst(mainPage);
            upBar = new Bars.UpAppBar();
            uPAppBar.Content = upBar;

        }


        private void appBar_MouseLeave(object sender, MouseEventArgs e)
        {

            uPAppBar.Visibility = Visibility.Visible;

        }
        private void appBar_MouseEnter(object sender, MouseEventArgs e)
        {

            uPAppBar.Visibility = Visibility.Hidden;

        }
    }
}
