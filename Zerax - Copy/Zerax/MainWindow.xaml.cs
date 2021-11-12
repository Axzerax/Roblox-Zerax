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
using System.Net.Http;

namespace Zerax
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

        private static readonly HttpClient client = new HttpClient();

        private async void Button_Click(object sender, RoutedEventArgs e)
        {

            string API = $"https://yourdomain.com/{TextBoxMain1.Text}/Other/{TextBoxMain2.Text}";

            var values = new Dictionary<string, string>
            {
                { "username", "Other" },
                { "data", "" }
            };

            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync(API, null);
        }
    }
}

