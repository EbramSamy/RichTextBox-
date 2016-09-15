using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace Test.Bars
{
    /// <summary>
    /// Interaction logic for uPAppBar.xaml
    /// </summary>
    public partial class UpAppBar : UserControl
    {
        public UpAppBar()
        {
            InitializeComponent();
        }
        private void close_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void minimize_Click(object sender, RoutedEventArgs e)
        {
            Window win = Window.GetWindow(this);
            win.WindowState = WindowState.Minimized;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MainWindow.nod.Previous != null)
                {
                    LinkedListNode<UserControl> before = MainWindow.nod.Previous;
                    MainWindow.nod = before;
                    MainWindow.pageTransitionControl.TransitionType = PageTransitionType.Fade;
                    MainWindow.pageTransitionControl.ShowPage(MainWindow.nod.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void forward_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MainWindow.nod.Next != null)
                {
                    LinkedListNode<UserControl> next = MainWindow.nod.Next;
                    MainWindow.nod = next;
                    MainWindow.pageTransitionControl.TransitionType = PageTransitionType.Fade;
                    MainWindow.pageTransitionControl.ShowPage(MainWindow.nod.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
