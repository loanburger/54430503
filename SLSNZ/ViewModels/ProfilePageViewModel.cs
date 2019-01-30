using SLSNZ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SLSNZ.ViewModels
{
	public class ProfilePageViewModel : ViewModelBase
	{

		#region Properties

		public List<Person> PersonTable { get; set; }
		
		private Person _selectedPerson;
		public Person SelectedPerson
		{
			get { return _selectedPerson; }
			set { _selectedPerson = value; OnPropertyChanged(); }
		}


		#endregion Properties

		#region Commands


		public ICommand RefreshCommand { private set; get; }


		#endregion Commands

		public ProfilePageViewModel()
		{

			// Initialize our table which will hold your data
			PersonTable = new List<Person>();

			RefreshCommand = new Command(async () => await GetProfileAsync());
		
		}


		public async Task GetProfileAsync()
		{
			try
			{
				// Here you can use your own Database manager to make calls and get the data. Note this call is a Task so must be awaited


				// I am just using mock data for thsi example

				PersonTable = new List<Person>
				{
					new Person
					{
						FirstName = "John",
						LastName = "Smith"
					},
					new Person
					{
						FirstName = "He",
						LastName = "Man"
					},
					new Person
					{
						FirstName = "Donald",
						LastName = "Duck"
					}
				};


				// I am selecting the first item and we will bind to this item in the view...
				SelectedPerson = PersonTable.First();

				// Note that I am calling the OnPropertyChanged to notify the view of the changes
				OnPropertyChanged("SelectedPerson");

			}
			catch (Exception e)
			{

			}
		}		
	}
}
