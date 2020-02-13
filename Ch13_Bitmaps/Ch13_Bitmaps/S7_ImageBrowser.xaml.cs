﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ch13_Bitmaps
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class S7_ImageBrowser : ContentPage
	{
       
        readonly WebRequest _request;
        JsonFlickerFeed _imageList;
        int _imageListIndex = 0;

		public S7_ImageBrowser ()
		{
			InitializeComponent ();

            Uri uri = new Uri("https://api.flickr.com/services/feeds/photos_public.gne?tags=kitten&format=json&nojsoncallback=1");
            _request = WebRequest.Create(uri);
            _request.BeginGetResponse(WebRequestCallback, null);
        }

        private void WebRequestCallback(IAsyncResult result)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                try
                {
                    Stream stream = _request.EndGetResponse(result).GetResponseStream();

                    //Deserialize the JSON into the imageList;
                    var jsonSerializer = new DataContractJsonSerializer(typeof(JsonFlickerFeed));
                    _imageList = (JsonFlickerFeed) jsonSerializer.ReadObject(stream ?? throw new InvalidOperationException());

                    if (_imageList.items.Count > 0)
                        FetchPhoto();
                }
                catch (Exception e)
                {
                    LFileName.Text = e.Message;
                }
            });
        }

        private void OnImagePropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "IsLoading")
            {
                ActivityInd1.IsRunning = ((Image) sender).IsLoading;
            }
        }

        private void OnPrevButClicked(object sender, EventArgs e)
        {
            _imageListIndex--;
            FetchPhoto();
        }

        private void OnNextButClicked(object sender, EventArgs e)
        {
            _imageListIndex++;
            FetchPhoto();

        }

        private void FetchPhoto()
        {
            // Prepare for new image.
            Image1.Source = null;
            string url = _imageList.items[_imageListIndex].link;

            //Set the filename
            LFileName.Text = url.Substring(url.LastIndexOf('/') + 1);

            // Create the UriImageSource
            UriImageSource imageSource = new UriImageSource
            {
                Uri = new Uri(url + "?Width=1080"),
                CacheValidity = TimeSpan.FromDays(30)
            };

            // Set the Image Source.
            Image1.Source = imageSource;

            // Enable or disable buttons
            PrevButton.IsEnabled = _imageListIndex > 0;
            NextButton.IsEnabled = _imageListIndex < _imageList.items.Count - 1;
        }
    }
}