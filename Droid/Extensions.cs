using System;

using System.Net;
using Android.Graphics;


namespace MobileCache.Droid
{
	public static class Extensions
	{
		public static void ImageFrom(
			this Android.Widget.ImageView imageview , string url){

			imageview.SetImageBitmap (GetImageBitmapFromUrl (url));
		}

		public static Bitmap GetImageBitmapFromUrl(string url)
		{
			using (var webClient = new WebClient())
			{
				var imageBytes = webClient.DownloadData(url);
				if (imageBytes != null && imageBytes.Length > 0)
				{
					return BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
				}
			}
			return null;
		}


	}
}

