using ElmSharp;
using System;
using Xamarin.Forms;

namespace BeautyMirror
{
    class Program : global::Xamarin.Forms.Platform.Tizen.FormsApplication
    {
        protected override void OnCreate()
        {
            MainWindow.IndicatorMode = IndicatorMode.Hide;
            base.OnCreate();

            LoadApplication(new App());
        }

        static void Main(string[] args)
        {
            var app = new Program();
            Forms.Init(app);
            app.Run(args);
        }
    }
}
