using System.Diagnostics;
using System.Media;
using System.Threading;
using System.Windows;

namespace Error
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        bool nepal_privet = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!nepal_privet)
            {
                for (int i = 0; i < 50; i++)
                {
                    OpenError();
                    Thread.Sleep(200);
                }
                FinWin fw = new FinWin();
                fw.Show();
            }
            nepal_privet = true;

        }

        public void OpenError()
        {
            ErrWin ew = new ErrWin();
            ew.Show();

            string path = System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            SoundPlayer pl = new SoundPlayer(@$"{path}\err1.wav");
            pl.Play();
        }
    }
}
