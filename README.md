# MobileAppsXF

Mobile Apps with Xamarin Forms

Example Code For Using Pages:
App()

        MainPage = new NavigationPage(new MainPage())
        {
            BarBackgroundColor = Color.Blue,
            BarTextColor = Color.Yellow
        };

MainPage()

        Title = "Main Page";
        NavigationPage.SetBackButtonTitle(this, "Back");   //iOS only....

        Button gotoModelessButton = new Button
        {
            Text = "Go to Modeless Page",
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.CenterAndExpand
        };

        gotoModelessButton.Clicked += async (sender, args) => { await Navigation.PushAsync(new ModelessPage()).ConfigureAwait(true); };
