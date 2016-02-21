using System;

using Android.App;
using Android.Views;
using Android.Widget;

using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;

using FFImageLoading;
using FFImageLoading.Views;


[assembly:ExportRenderer(
	typeof(MobileCache.MainContent), 
	typeof(MobileCache.Droid.MainContentRenderer))]


namespace MobileCache.Droid
{

	/// <summary>
	/// ContentPage Renderer
	/// </summary>
	public class MainContentRenderer : PageRenderer	
	{
		public MainContentRenderer ()
		{
		}

		/// <summary>
		///  The OnElementChanged method is called when the corresponding Xamarin.Forms control is created.
		/// </summary>
		/// <param name="e">E.</param>
		protected override void OnElementChanged (ElementChangedEventArgs<Page> e)
		{
			base.OnElementChanged (e);
			if (e.OldElement == null &&  e.NewElement !=null
				&& e.NewElement is MobileCache.MainContent) {
				AddImage (this.ViewGroup);	
			}
		}

		Android.Widget.ImageView  PhotoView = null;

		void AddImage(ViewGroup vg)
		{
			//レイアウトパラメータはない 
			// おそらく Xamari.Formsのレイアウトマネージャーが Droid/iOSに関してともに処理する
			System.Diagnostics.Debug.Assert (vg.LayoutParameters == null);

			/// Flicker
			var url = "https://farm1.staticflickr.com/436/18556094406_99d0d38197_z.jpg";
			PhotoView = new Android.Widget.ImageView (this.Context) {};
			PhotoView.ImageFrom (url);


			vg.AddView(PhotoView);
		}

		protected override void OnLayout (bool changed, int l, int t, int r, int b)
		{
			base.OnLayout (changed, l, t, r, b);

			if (PhotoView != null) {
				PhotoView.Layout (PhotoView.Left, PhotoView.Top,r, b);
			}
		}

	}
}

