using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;

namespace XLabs.GridView
{
    public class GridViewPageViewModel : INotifyPropertyChanged
    {
        public GridViewPageViewModel()
        {
			var itemsList = new List<Item>();
			itemsList.Add(new Item() { Name = "1", BgColor = "#440000" });
			itemsList.Add(new Item() { Name = "2", BgColor = "#004400" });
			itemsList.Add(new Item() { Name = "3", BgColor = "#000044" });
			itemsList.Add(new Item() { Name = "4", BgColor = "#555555" });
			itemsList.Add(new Item() { Name = "5", BgColor = "#555555" });
			itemsList.Add(new Item() { Name = "6", BgColor = "#555555" });
			itemsList.Add(new Item() { Name = "7", BgColor = "#555555" });
			itemsList.Add(new Item() { Name = "8", BgColor = "#555555" });


			ListItems = itemsList;
        }

		public void FillGrid()
		{
			var itemsList = new List<Item>();
			itemsList.Add(new Item() { Name = "1", BgColor = "#440000" });
			itemsList.Add(new Item() { Name = "2", BgColor = "#004400" });
			itemsList.Add(new Item() { Name = "3", BgColor = "#000044" });
			itemsList.Add(new Item() { Name = "4", BgColor = "#555555" });


			ListItems = itemsList;
		}

        public event PropertyChangedEventHandler PropertyChanged;
        
		List<Item> _items = new List<Item>();

        public List<Item> ListItems
        {
            get { return _items; }
            set
            {
				if (_items != value)
				{
					_items = value;

					OnPropertyChanged("ListItems");
				}
            }
        }

		public void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this,
					new PropertyChangedEventArgs(propertyName));
			}
		}
    }
}
