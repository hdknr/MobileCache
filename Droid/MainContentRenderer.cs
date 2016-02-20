using System;

using Android.App;


using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;


[assembly:ExportRenderer(
	typeof(MobileCache.MainContent), 
	typeof(MobileCache.Droid.MainContentRenderer))]


namespace MobileCache.Droid
{
	public class MainContentRenderer : PageRenderer	// ViewGroup
	{
		public MainContentRenderer ()
		{
			var activity = this.Context as Activity;
		}

		protected override void OnElementChanged (ElementChangedEventArgs<Page> e)
		{
			base.OnElementChanged (e);


			this.AddImage ();

		}
		void AddImage()
		{

		}

	}
}

