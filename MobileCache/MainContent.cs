using System;

using Xamarin.Forms;

namespace MobileCache
{
	public class MainContent : ContentPage
	{
		public MainContent ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { 
						Text = "Hello ContentPage" ,
						FontSize = 30,
						TextColor =  Color.Red,
					},
				}
			};
		}
	}
}


