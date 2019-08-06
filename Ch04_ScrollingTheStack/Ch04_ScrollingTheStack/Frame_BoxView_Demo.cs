using Xamarin.Forms;

namespace Ch04_ScrollingTheStack
{
	public class FrameBoxViewDemo : ContentPage
	{
        public FrameBoxViewDemo()
        {
            StackLayout tLayout = new StackLayout();
            Frame f1 = new Frame
            {
                BorderColor = Color.Accent,
                BackgroundColor = Color.Yellow,
                Content = new Label
                {
                    Text = "What a Frames for!?",
                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center
                },
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            Frame f2 = new Frame
            {
                BorderColor = Color.Accent,
                BackgroundColor = Color.PaleGreen,
                Content = new Label
                {
                    Text = "What a Frames for!?",
                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
                }
                ,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            BoxView b1 = new BoxView
            {
                Color = Color.Red,
                BackgroundColor = Color.Accent,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            BoxView b2 = new BoxView
            {
                Color = Color.Black,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            BoxView b3 = new BoxView
            {
                Color = Color.Black,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 80,
                HeightRequest = 80

            };

            tLayout.Children.Add(f1);
            tLayout.Children.Add(f2);
            tLayout.Children.Add(b1);
            tLayout.Children.Add(b2);
            tLayout.Children.Add(b3);

            Content = tLayout;
            Content.BackgroundColor = Color.Aqua;
        }
    }
}