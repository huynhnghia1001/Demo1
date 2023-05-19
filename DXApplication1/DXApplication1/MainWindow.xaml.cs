using DevExpress.Xpf.Core;
using DevExpress.Xpf.Core.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DXApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        UnitWindow unitWindow;
        SuplierWindow suplierWindow;
        ObjectWindow objectWindow;
        CustomerWindow customerWindow;
        UserWindow userWindow;

        private void btnUnit(object sender, RoutedEventArgs e)
        {
            this.Main.Children.Clear();
            if(unitWindow == null)
            {
                UnitWindow uw = new UnitWindow();
                object content = uw.Content;
                uw.Content = null;
                this.Main.Children.Add(content as UIElement);
            }
            else
            {
                UnitWindow uw = new UnitWindow();
                uw.Close();
            }

        }

       

        private void btnSuplier(object sender, RoutedEventArgs e)
        {
            this.Main.Children.Clear();
            if (suplierWindow == null)
            {
                this.Main.Children.Clear();
                SuplierWindow sw = new SuplierWindow();
                object content = sw.Content;
                sw.Content = null;
                sw.Close();
                this.Main.Children.Add(content as UIElement);

            }
            else
            {
                SuplierWindow sw = new SuplierWindow();
                sw.Close();
            }
        }

        private void btnObject(object sender, RoutedEventArgs e)
        {
            this.Main.Children.Clear();
            if (objectWindow == null)
            {
                this.Main.Children.Clear();
                ObjectWindow ow = new ObjectWindow();
                object content = ow.Content;
                ow.Content = null;
                ow.Close();
                this.Main.Children.Add(content as UIElement);

            }
            else
            {
                ObjectWindow ow = new ObjectWindow();
                ow.Close();
            }
        }

        private void btnCustomer(object sender, RoutedEventArgs e)
        {
            this.Main.Children.Clear();
            if (customerWindow == null)
            {
                this.Main.Children.Clear();
                CustomerWindow cw = new CustomerWindow();
                object content = cw.Content;
                cw.Content = null;
                cw.Close();
                this.Main.Children.Add(content as UIElement);

            }
            else
            {
                CustomerWindow cw = new CustomerWindow();
                cw.Close();
            }
        }

        private void btnUserWindow(object sender, RoutedEventArgs e)
        {
            this.Main.Children.Clear();
            if (userWindow == null)
            {
                this.Main.Children.Clear();
                UserWindow uw = new UserWindow();
                object content = uw.Content;
                uw.Content = null;
                uw.Close();
                this.Main.Children.Add(content as UIElement);

            }
            else
            {
                UserWindow uw = new UserWindow();
                uw.Close();
            }
        }
    }
}
