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

namespace ChildWindowExample
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ChildViewModel childVm = new ChildViewModel()
            {
                Message = "Hello, world!"
            };

            ChildWindow win = new ChildWindow()
            {
                DataContext = childVm
            };

            win.ShowDialog();

            MessageBox.Show($"입력된 메시지는 \"{childVm.Message}\" 입니다.");
        }
    }
}
