using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;


namespace MobileCache.iOS
{
	public static class LayoutExtensions
	{
		public static NSLayoutConstraint CtTopOn(
			this UIView me, UIView baseview, nfloat offset )
		{
			return NSLayoutConstraint.Create(
				me, NSLayoutAttribute.Top, NSLayoutRelation.Equal,
				baseview, NSLayoutAttribute.Top,
				1, offset);	
		}	

		public static NSLayoutConstraint CtUnder(
			this UIView me, UIView baseview, int offset )
		{
			return NSLayoutConstraint.Create(
				me, NSLayoutAttribute.Top, NSLayoutRelation.Equal,
				baseview, NSLayoutAttribute.Bottom,
				1, offset);	
		}	

		public static NSLayoutConstraint CtAbove(
			this UIView me, UIView baseview, int offset )
		{
			return NSLayoutConstraint.Create(
				me, NSLayoutAttribute.Bottom, NSLayoutRelation.Equal,
				baseview, NSLayoutAttribute.Top,
				1, offset);	
		}	

		public static NSLayoutConstraint CtBottomOn(
			this UIView me, UIView baseview, int offset )
		{
			return NSLayoutConstraint.Create(
				me, NSLayoutAttribute.Bottom, NSLayoutRelation.Equal,
				baseview, NSLayoutAttribute.Bottom,
				1, offset);	
		}	

		public static NSLayoutConstraint CtWidthSame(
			this UIView me, UIView baseview 
		)
		{
			// 幅をベースに合わせる
			return NSLayoutConstraint.Create (
				me, NSLayoutAttribute.Width, NSLayoutRelation.Equal,
				baseview, NSLayoutAttribute.Width,
				1, 0);
		}

		public static NSLayoutConstraint CtWidthRate(
			this UIView me, UIView baseview , float multiply
		)
		{
			// 幅をベースに合わせる
			return NSLayoutConstraint.Create (
				me, NSLayoutAttribute.Width, NSLayoutRelation.Equal,
				baseview, NSLayoutAttribute.Width,
				multiply, 0);
		}

		public static NSLayoutConstraint CtHeightRate(
			this UIView me, UIView baseview , float multiply
		)
		{
			return NSLayoutConstraint.Create (
				me, NSLayoutAttribute.Height, NSLayoutRelation.Equal,
				baseview, NSLayoutAttribute.Height,
				multiply, 0);
		}

		public static NSLayoutConstraint CtCenterOn(
			this UIView me, UIView baseview , float multi = 1.0f, float delta = 0.0f)
		{
			return NSLayoutConstraint.Create (
				me, NSLayoutAttribute.CenterX, NSLayoutRelation.Equal,
				baseview, NSLayoutAttribute.CenterX,
				multi, delta);

		}



		public static NSLayoutConstraint CtMiddleOn(
			this UIView me, UIView baseview , float multi = 1.0f
		)
		{
			return NSLayoutConstraint.Create (
				me, NSLayoutAttribute.CenterY, NSLayoutRelation.Equal,
				baseview, NSLayoutAttribute.CenterY,
				multi, 0);

		}

		public static NSLayoutConstraint CtMiddleOn(
			this UIView me, UIView baseview , float rate, int offset)
		{
			return NSLayoutConstraint.Create (
				me, NSLayoutAttribute.CenterY, NSLayoutRelation.Equal,
				baseview, NSLayoutAttribute.CenterY,
				rate, offset);

		}

		public static NSLayoutConstraint CtHeightAbs(
			this UIView me, nfloat height)
		{
			return NSLayoutConstraint.Create (
				me, NSLayoutAttribute.Height, NSLayoutRelation.Equal,
				null, NSLayoutAttribute.NoAttribute,
				1, height);

		}

		public static NSLayoutConstraint CtWidthAbs(
			this UIView me, nfloat width)
		{
			return NSLayoutConstraint.Create (
				me, NSLayoutAttribute.Width, NSLayoutRelation.Equal,
				null, NSLayoutAttribute.NoAttribute,
				1, width);

		}

		public static NSLayoutConstraint CtLeftTo(
			this UIView me, UIView other,  nfloat marigin)
		{
			return NSLayoutConstraint.Create (
				me, NSLayoutAttribute.Left, NSLayoutRelation.Equal,
				other, NSLayoutAttribute.Left,
				1, marigin);

		}

		public static NSLayoutConstraint CtRightTo(
			this UIView me, UIView other,  nfloat marigin)
		{
			return NSLayoutConstraint.Create (
				me, NSLayoutAttribute.Right, NSLayoutRelation.Equal,
				other, NSLayoutAttribute.Right,
				1, marigin);

		}

		public static NSLayoutConstraint CtAspect(
			this UIView me, nfloat rate)
		{
			return NSLayoutConstraint.Create (
				me, NSLayoutAttribute.Height, NSLayoutRelation.Equal,
				me, NSLayoutAttribute.Width,
				rate, 0);

		}
	}
}