using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
{
    public partial class MainPage : ContentPage
    {
        dynamic array;
        public MainPage()
        {
            InitializeComponent();

            comeBackButton.Clicked += comeBackButton_Clicked;

            string json;

            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString("https://raw.githubusercontent.com/kuba8705/Do_hostowania_plikow/main/jsonFile.json");
            }

            array = JsonConvert.DeserializeObject(json);

            
            foreach (var item in array)
            {

                Button myButton = new Button
                {
                    Text = item.Tytul,
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand
                };

                myButton.Clicked += MyButton_Clicked;

                myStackLayout.Children.Add(myButton);
            }

        }

        private void MyButton_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string buttonId = button.Text;

            string currentItem;

            foreach (var item in array)
            {
                if(item.Tytul == buttonId)
                {
                    
                    string Aktorzy = "Aktorzy: ";

                    foreach (var actors in item.Aktorzy)
                    {
                        Aktorzy += actors +", ";
                    }

                    Aktorzy.Substring(Aktorzy.Length - 2);

                    //plakat.Source = (Xamarin.Forms.StreamImageSource)item.url_obrazka;

                    Xamarin.Forms.FileImageSource objFileImageSource = new FileImageSource();
                    objFileImageSource.File = item.url_obrazka;

                    plakat.Source = objFileImageSource.File;

                    topLabel.Text = item.Tytul;
                    studio.Text = "Studio: " + item.Produkcja.Studio;
                    kraj.Text = "Kraj produkcji: " + item.Produkcja.Kraj;
                    aktorzy.Text = Aktorzy;
                    rezyser.Text = "Reżyser: " + item.Rezyser;
                    zdjecia.Text = "Zdjecia: " + item.Zdjecia;
                    premiera.Text = "Premiera: " + item.Premiera;
                    break;
                }

            }

            myStackLayout.IsVisible = false;
            movieStackLayout.IsVisible = true;
        }

        private void comeBackButton_Clicked(object sender, EventArgs e)
        {
            topLabel.Text = "Lista filmów";

            myStackLayout.IsVisible = true;
            movieStackLayout.IsVisible = false;
        }
    }
}
