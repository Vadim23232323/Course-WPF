using System.Threading;
using System.Windows;

namespace HW_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private delegate void OneExecutor(string arg);
        private delegate void TwoExecutor(string arg);
        private delegate void ThreeExecutor(string arg);
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Start_work(object sender, RoutedEventArgs e)
        {
            Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new OneExecutor(OneResource), "Busy Performer 1");
            Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new TwoExecutor(OneResource), "Busy Performer 2");
            Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new ThreeExecutor(OneResource), "Busy Performer 3");
            Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new OneExecutor(TwoResource), "Busy Performer 1");
            Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new TwoExecutor(TwoResource), "Busy Performer 2");
            Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new ThreeExecutor(TwoResource), "Busy Performer 3");
            Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new OneExecutor(ThreeResource), "Busy Performer 1");
            Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new TwoExecutor(ThreeResource), "Busy Performer 2");
            Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new ThreeExecutor(ThreeResource), "Busy Performer 3");
        }

        private void OneResource(string s)
        {
            WorksTextBlock.Text = s;

            if (s == "Busy Performer 1")
            {
                
                Thread.Sleep(5000);

            }
            else
            {
                WorksTextBlock.Text = "Свободен";
            }
            if (s == "Busy Performer 2")
            {
                Thread.Sleep(3000);

            }
            else
            {
                WorksTextBlock.Text = "Свободен";
            }
            if (s == "Busy Performer 3")
            {
                Thread.Sleep(1000);
            }
            else
            {
                WorksTextBlock.Text = "Свободен";
            }

        }
        private void TwoResource(string s)
        {
            WorksTextBlock.Text = s;

            if (s == "Busy Performer 1")
            {
                Thread.Sleep(3000);
            }
            else
            {
                WorksTextBlock.Text = "Свободен";
            }
            if (s == "Busy Performer 2")
            {
                Thread.Sleep(3000);
            }
            else
            {
                WorksTextBlock.Text = "Свободен";
            }
            if (s == "Busy Performer 3")
            {
                Thread.Sleep(3000);
           

            }
            else
            {
                WorksTextBlock.Text = "Свободен";
            }

        }

        private void ThreeResource(string s)
        {
            WorksTextBlock.Text = s;

            if (s == "Busy Performer 1")
            {
                Thread.Sleep(1000);
            }
            else
            {
                WorksTextBlock.Text = "Свободен";
            }
            if (s == "Busy Performer 2")
            {
                Thread.Sleep(3000);
            }
            else
            {
                WorksTextBlock.Text = "Свободен";
            }
            if (s == "Busy Performer 3")
            {
                Thread.Sleep(5000);
            }
            else
            {
                WorksTextBlock.Text = "Свободен";
            }

        }

    }
}
