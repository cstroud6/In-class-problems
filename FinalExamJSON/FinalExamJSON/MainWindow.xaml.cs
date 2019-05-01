//Chrissy Stroud
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace FinalExamJSON
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
        //On window load we want it to connect to the URL-so here I need to update to the new URL//
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //http://pcbstuou.w27.wh-2.com/webservices/3033/api/Movies?number=100

            using (HttpClient client = new HttpClient())
            {
                var response = client.GetAsync(@"http://pcbstuou.w27.wh-2.com/webservices/3033/api/Movies?number=100").Result;
                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    movieInfo m = JsonConvert.DeserializeObject<movieInfo>(content);//I think here these need to reference a class?? so i need to create that before moving on//
                    quote.Inlines.Add()
                };
            }
        }
    }
}
