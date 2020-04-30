using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XaBarcodeScannerProject.Models;

namespace XaBarcodeScannerProject.ViewModels
{
    class RecieptViewModel : BaseViewModel
    {

		public RecieptViewModel()
		{
			ItemAmount = 0;
			Products = new ObservableCollection<ProductsModel>()

			{
				new ProductsModel()
				{
					Name = "Cola",
					Type = "Sodavand",
					Price = 14.95
				}
			};
		}

		private string itemName;

		public string ItemName
		{
			get { return itemName; }
			set { itemName = value; OnPropertyChanged(); }
		}

		private double itemPrice;

		public double ItemPrice
		{
			get { return itemPrice; }
			set { itemPrice = value; OnPropertyChanged(); }
		}

		private int itemAmount;

		public int ItemAmount
		{
			get { return itemAmount; }
			set { itemAmount = value; OnPropertyChanged(); }
		}

		private ObservableCollection<ProductsModel> products { get; set; }

		public ObservableCollection<ProductsModel> Products
		{
			get { return products; }
			set { products = value; OnPropertyChanged(); }
		}




	}
}
