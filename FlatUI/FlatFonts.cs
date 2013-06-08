using System;
using MonoTouch.UIKit;

namespace FlatUI
{
	public class FlatFonts
	{
		public FlatFonts ()
		{
		}

		public static UIFont BoldFontsWithSize(int size)
		{
			var font =  UIFont.FromName ("Lato-Bold", size);
			return font;
		}
	}
}

