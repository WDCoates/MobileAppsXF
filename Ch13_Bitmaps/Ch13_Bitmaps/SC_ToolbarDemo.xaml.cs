using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ch13_Bitmaps
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SC_ToolbarDemo : ContentPage
	{
		public SC_ToolbarDemo ()
		{
            this.Title = "Pre InitComp...!"; //This is too soon does not override the XAML

            InitializeComponent();

            //this.Title = "Dave's Toolbar Demo!";
        }

        private void OnToolbarItemClicked(object sender, EventArgs e)
        {
            ToolbarItem tItem = (ToolbarItem)sender;
            Label1.Text = "ToolbarItem '" + tItem.Text + "' clicked!";
        }
    }
}