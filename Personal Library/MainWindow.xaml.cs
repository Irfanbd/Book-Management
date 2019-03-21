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
using System.Windows.Converters;
namespace Personal_Library
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void login(object sender, RoutedEventArgs e)
        {
            Library_Dashboard bw = new Library_Dashboard();
            if (username.Text == "" && password.Password == "")
            {
                bw.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Wrong username or password", "Login");
                username.Text = "";
                password.Password = "";
            }
            
        }

        private void exit_btn(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void reset(object sender, RoutedEventArgs e)
        {
            clear();
        }
        void clear()
        {
            username.Clear();
            password.Clear();
        }
    }
}
