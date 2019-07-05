using System.Windows;

namespace TrainDesigner
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected sealed override void OnStartup(System.Windows.StartupEventArgs e)
        {
            var compositionRoot = new CompositionRoot();
            MainWindow = new MainWindow();
            MainWindow.DataContext = compositionRoot.Compose();
            MainWindow.Title = "Layout Designer";
            MainWindow.Show();
        }
    }
}
