using System;
using UIKit;

//
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

using FFImageLoading;
using FFImageLoading.Work;


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

		/// <summary>
		/// Must be accessible by FFImageLoading functions
		/// </summary>
		UIImageView imageView =null;

		/// <summary>
		/// Image View 
		/// </summary>
		void AddImage()
		{
			System.Diagnostics.Debug.Assert (this.View != null);

			 imageView = new UIImageView {
				TranslatesAutoresizingMaskIntoConstraints = false,
			};

			/// Flicker
			var url = "https://farm1.staticflickr.com/436/18556094406_99d0d38197_z.jpg";

			// FFImageLoading
			ImageService.LoadUrl (
				url	 
				,new TimeSpan (0, 0, 1)	// Cache Time Span (1sec)(ディスクの日付を見ているっぽい)
			)	.Success (() => {
				Console.WriteLine ("Downloaded!!!!");
			})
				.Error (exception => {
					Console.WriteLine("Error!!!");
			})
				.Into (imageView);


			this.View.Add (imageView);
			View.AddConstraints (new NSLayoutConstraint[] {
				imageView.CtMiddleOn(View),
				imageView.CtCenterOn(View),
				imageView.CtWidthRate(View, 0.8f),
				imageView.CtAspect(1.0f),
			});
		}

	}
}


