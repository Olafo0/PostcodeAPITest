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
using System.Net.Http.Headers;
using System.Text.Json;
using System.Net.Http;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace PostcodeAPITest
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

        private async void SearchPostCodeBTN_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://uk-postcode.p.rapidapi.com/getpostcode?postcode={PostCodeTB.Text}"),
                    Headers =
                {
                    { "X-RapidAPI-Key", "x" },
                    { "X-RapidAPI-Host", "x" },
                },
                };

                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<PostCode.Rootobject>(body);
                    AddressesCB.Items.Add(data.result.streetName);
                }
            }
            catch(Exception ex)
            {
                Window window = new Window();
                window.Width = 200;
                window.Height = 200;
                window.Title = "ERROR";

                Label tt = new Label()
                {
                    Content = new TextBlock()
                    {
                        Text = ex.Message,
                        TextWrapping = TextWrapping.Wrap
                    }
                };

                StackPanel container = new StackPanel();
                container.Children.Add(tt);


                window.ResizeMode = ResizeMode.NoResize;
                window.Content = container;

                window.Show();
            }
        }
    }
}
