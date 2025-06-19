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

namespace Hello_World
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

        private void DisplayButton_Click(object sender, RoutedEventArgs e)
        {
            if (HelloRadio.IsChecked == true)
            {
                MessageTextBlock.Text = "Hello World";
                
            }
            if (GoodByRadio.IsChecked == true)
            {
                MessageTextBlock.Text = "GoodBye World";
                
            }
        }

        private void LinqTestsButton_Click(object sender, RoutedEventArgs e)
        {
            List<string> names = new List<string>() { 
                "John",
                "Ben",
                "Ahmed",
                "Michael",
                "David",
                "Zeeshan"

            };

            StringBuilder sb = new();

            IEnumerable<string> result = from n in names select n;
            foreach (string name in result)
            {
                sb.AppendLine(name);
            }



            MessageTextBlock.Text = sb.ToString();

        }

        public void LinqOnInt() { 
            
            int[] nums = { 3, 5, 4, 6, 7, 8, 9, 2, 4, 5, 6, 7, 822, 776, 88 };

            StringBuilder sb = new StringBuilder();

            sb.Append("");

            // typical old-style approach:
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 2 && nums[i] < 100)
                {
                    sb.Append(nums[i] + ",");
                }
            }
            sb.AppendLine("");
            sb.AppendLine("Linq:");

            // with Linq, we can: use SQL like syntax
            var result = from n in nums
                         where n > 2 && n < 100
                         orderby n descending
                         select n;

            foreach (var n in result)
            {
                sb.Append(n + ",");
            }
            sb.AppendLine();
            sb.AppendLine("Stats:");
            sb.AppendLine("Max = " + result.Max());
            sb.AppendLine("Min = " + result.Min());
            sb.AppendLine("Avg = " + result.Average());

            sb.AppendLine("");
            sb.AppendLine("Lambda:");

            // lambda notation:
            IEnumerable<int> resultL = nums
                .Where(n => n > 2 && n < 100)
                .OrderByDescending(n => n);

            foreach (var n in resultL)
            {
                sb.Append(n + ",");
            }
            sb.AppendLine();

            MessageTextBlock.Text = sb.ToString();

        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}