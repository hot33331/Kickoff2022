using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;

namespace Kickoff2022.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : FormsApplicationPage
    {
        public MainWindow()
        {
            InitializeComponent();
            Forms.Init();
            LoadApplication(new Kickoff2022.App());
        }
    }
}
