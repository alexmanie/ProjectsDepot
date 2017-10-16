using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XLabs.GridView
{
    public class Item
    {
        public string Name
        {
            get;
            set;
        }

        public string BgColor
        {
            get;
            set;
        }
    }

    public partial class GridViewPage : ContentPage
    {
        public GridViewPage()
        {
            InitializeComponent();

            var vm = ((GridViewPageViewModel)this.BindingContext);

			this.GrdView.ItemSelected += Handle_ItemSelected;
			//this.GrdView.ItemWidth = this.btnLeft.Width;

			this.Focused += PageFocused;
		}

		void PageFocused(object sender, EventArgs e)
		{
			this.GrdView.ItemWidth = this.btnLeft.Width;
			
		}

        void Handle_ItemSelected(object sender, XLabs.EventArgs<object> e)
        {
            
        }

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			var vm = ((GridViewPageViewModel)this.BindingContext);
			vm.FillGrid();
		}
	}
}
