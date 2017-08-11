using System;
using System.Windows.Input;

namespace WendysTest
{
	public class AttendeeViewModel : BaseViewModel
	{
		public AttendeeViewModel()
		{
			Title = "AttendeeList";

			OpenWebCommand = new Command(() => Plugin.Share.CrossShare.Current.OpenBrowser("https://xamarin.com/platform"));
		}

		/// <summary>
		/// Command to open browser to xamarin.com
		/// </summary>
		public ICommand OpenWebCommand { get; }
	}
}
