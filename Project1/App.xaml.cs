using System.Windows;

namespace Project1
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            new MainWindow().Show();    
        }
    }
}
