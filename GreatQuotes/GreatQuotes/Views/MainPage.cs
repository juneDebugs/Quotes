﻿using System;
using Xamarin.Forms;
using GreatQuotes.Views;

namespace GreatQuotes.Views
{
    public class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            var listPage = new QuoteListPage();
            Master = new NavigationPage(listPage) { Title = listPage.Title, Icon = listPage.Icon };
            Detail = new NavigationPage(new QuoteDetailPage());
        }

    }
}
