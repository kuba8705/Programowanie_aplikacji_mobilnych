using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using Microsoft.CSharp;
using Xamarin.Forms.Shapes;

namespace App4
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            //string fileName = @"C:\Users\Jakub Jakimiuk\source\repos\App4\App4\jsonFile.json";

            /*
            Console.WriteLine(File.Exists("jsonFile.json"));
            Console.WriteLine(Path.GetFullPath(Directory.GetCurrentDirectory()));
            foreach (var file in Directory.EnumerateFiles(Directory.GetCurrentDirectory()))
            {
                Console.WriteLine(file);
            }

            using (StreamReader r = new StreamReader("jsonFile.json"))
            {
                string json = r.ReadToEnd();
            }
            */
            /*

            string json;

            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString("https://raw.githubusercontent.com/kuba8705/Do_hostowania_plikow/main/jsonFile.json");
            }

            dynamic array = JsonConvert.DeserializeObject(json);
            */
            /*
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }*/

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
