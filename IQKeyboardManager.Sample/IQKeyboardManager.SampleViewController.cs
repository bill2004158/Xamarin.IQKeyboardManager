﻿using System;
using System.Drawing;

using Foundation;
using UIKit;
using Xamarin;

namespace IQKeyboardManager.Sample
{
	public partial class IQKeyboardManager_SampleViewController : UIViewController
	{
		public IQKeyboardManager_SampleViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			Xamarin.IQKeyboardManager.SharedManager.EnableAutoToolbar = true;
			Xamarin.IQKeyboardManager.SharedManager.ShouldResignOnTouchOutside = true;
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		#endregion
	}
}
