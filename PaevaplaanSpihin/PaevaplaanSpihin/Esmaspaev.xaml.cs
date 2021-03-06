﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PaevaplaanSpihin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Esmaspaev : ContentPage
    {
        public Esmaspaev()
        {
                 InitializeComponent();
            //План на день
            string[] tasks = new string[] { "Учеба", "Кушаю в столовой", "Еду домой", "Играю в игры", "Ужинаю", "Иду спать" };
            ListView list = new ListView();//список для отображения планов
            list.ItemsSource = tasks;//данные из списка планов
            list.ItemSelected += List_ItemSelected1; ;
            Content = new StackLayout { Children = { list } };//отображаем список на странице
        }
        string time;
        private async void List_ItemSelected1(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                string text = e.SelectedItem.ToString();
                if (e.SelectedItemIndex == 0)//Учеба
                {
                    time = "8:30";
                }
                else if (e.SelectedItemIndex == 1)//Кушаю в столовой
                {
                    time = "16:20";
                }
                else if (e.SelectedItemIndex == 2)//Еду домой
                {
                    time = "16:30";
                }
                else if (e.SelectedItemIndex == 3)//Играю в игры
                {
                    time = "17:40";
                }
                await DisplayAlert(time, text, "jah");
            }


            InitializeComponent();
        }
    }
}