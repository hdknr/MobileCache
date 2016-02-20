using System;
using UIKit;

//
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


[assembly:ExportRenderer(
	typeof(MobileCache.MainContent), 
	typeof(MobileCache.iOS.MainContentRenderer))]

namespace MobileCache.iOS
{
	public class MainContentRenderer : PageRenderer		// UIViewController
	{			
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			this.AddImage ();
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		void AddImage()
		{
		}
	}
}


