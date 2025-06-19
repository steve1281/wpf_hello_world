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
using System.Xml.Linq;

namespace Hello_World
{

    enum Country { USA, UK, Pakistan  }
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Country Country { get; set; }
    }


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DisplayButton_Click(object sender, RoutedEventArgs e)
        {
            if (LinqIntTest.IsChecked == true)
            {
                LinqOnInt();
            }
            if (LinqStringTest.IsChecked == true)
            {
                LinqOnStringList();
            }
            if (LinqClassTest.IsChecked == true)
            {
                LinqOnClassList();
            }

        }

  
        public void LinqOnClassList()
        {
            StringBuilder sb = new();
            
            List<Student> sList = new List<Student>() {
                new Student() {
                    Name = "John",
                    Age = 25, 
                    Country= Country.USA
                },
                new Student() {
                    Name = "Ahmed",
                    Age = 20,
                    Country= Country.UK
                },
                new Student() {
                    Name = "Zaheer",
                    Age = 24,
                    Country= Country.Pakistan
                },


            };

            var result = from s in sList
                         where s.Age <= 24
                         orderby s.Name
                         select s;

            foreach (var item in result)
            {
                sb.AppendLine("Name: " + item.Name + "\tAge: " + item.Age + "\tCountry: " + item.Country);
            }

            sb.AppendLine();

            var resultL = sList.Where(s => s.Age <= 24).OrderBy(s => s.Name);

            foreach (var item in resultL)
            {
                sb.AppendLine("Name: " + item.Name + "\tAge: " + item.Age + "\tCountry: " + item.Country);
            }


            MessageTextBlock.Text = sb.ToString();

        }

        public void LinqOnStringList()
        {
            List<string> names = new List<string>() { 
                "John",
                "Bengston",
                "Ahmed",
                "Michael",
                "David",
                "Zeeshan"

            };

            StringBuilder sb = new();

            // linq
            IEnumerable<string> result = from n in names
                                         where n.Length <= 5
                                         orderby n
                                         select n;

            foreach (string name in result)
            {
                sb.AppendLine(name);
            }

            sb.AppendLine();

            // lambda
            IEnumerable<string> resultL = names.Where(n => n.Length <= 5).OrderBy(n => n);

            foreach (string name in resultL)
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