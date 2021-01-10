using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.GTK;


namespace Kickoff2022.GTK
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Gtk.Application.Init();
            Forms.Init();

            var app = new App();
            var window = new FormsWindow();
            window.LoadApplication(app);
            window.SetApplicationTitle("Kickoff2021");
            window.Show();

            Gtk.Application.Run();
        }
    }
}
