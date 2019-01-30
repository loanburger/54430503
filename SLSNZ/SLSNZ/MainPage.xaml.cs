using SLSNZ.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SLSNZ
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			Initialize();
		}

		private async void Initialize()
		{
			var viewmodel = new ProfilePageViewModel();

			// await your data to load
			await viewmodel.GetProfileAsync();

			BindingContext = viewmodel;		

		}
	}
}
