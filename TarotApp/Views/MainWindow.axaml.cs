using Avalonia.Controls;
using TarotApp.ViewModels;

namespace TarotApp.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}