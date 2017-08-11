using Foundation;
using System;
using UIKit;

namespace WendysTest.iOS
{
    public partial class AttendeeViewController : UINavigationController
    {
 

		public AboutViewModel ViewModel { get; set; }
		public AttendeeViewController(IntPtr handle) : base(handle)
        {
			ViewModel = new AboutViewModel();
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			Title = ViewModel.Title;

			//HeaderTitleLabel.Text = "WendysTest";
			//VersionLabel.Text = "1.0";
			//AboutTextView.Text = "This is the Wendys Fall Event App. This app is written in C# and native APIs using the Xamarin Platform. It shares code with its iOS, Android, & Windows versions.";
		}
    }
}