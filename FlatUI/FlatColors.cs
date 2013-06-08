using System;
using MonoTouch.UIKit;

namespace FlatUI
{
	public sealed class FlatColors
	{
		private FlatColors ()
		{

		}

		public static UIColor FromHex (int bgr)
		{
			var result = UIColor.FromRGB (((bgr >> 16) & 0xFF), ((bgr >> 8) & 0xFF), (bgr & 0xFF));
			Console.WriteLine (result.ToString ());
			return result;
		}

		public static UIColor TurquoiseColor {
			get { return FromHex (0x1ABC9C);}
		}

		public static UIColor  GreenSeaColor {
			get{ return FromHex (0x16A085);}
		}

		public static UIColor  emerlandColor {
			get{ return FromHex (0x2ECC71);}
		}

		public static UIColor  nephritisColor {
			get{ return FromHex (0x27AE60);}
		}

		public static UIColor  peterRiverColor {
			get{ return FromHex (0x3498DB);}
		}

		public static UIColor  belizeHoleColor {
			get{ return FromHex (0x2980B9);}
		}

		public static UIColor  amethystColor {
			get{ return FromHex (0x9B59B6);}
		}

		public static UIColor  WisteriaColor {
			get{ return FromHex (0x8E44AD);}
		}

		public static UIColor  wetAsphaltColor {
			get{ return FromHex (0x34495E);}
		}

		public static UIColor  midnightBlueColor {
			get{ return FromHex (0x2C3E50);}
		}

		public static UIColor  sunflowerColor {
			get{ return FromHex (0xF1C40F);}
		}

		public static UIColor  tangerineColor {
			get{ return FromHex (0xF39C12);}
		}

		public static UIColor  carrotColor {
			get{ return FromHex (0xE67E22);}
		}

		public static UIColor  pumpkinColor {
			get{ return FromHex (0xD35400);}
		}

		public static UIColor  AlizarinColor {
			get{ return FromHex (0xE74C3C);}
		}

		public static UIColor  pomegranateColor {
			get{ return FromHex (0xC0392B);}
		}

		public static UIColor  CloudsColor {
			get{ return FromHex (0xECF0F1);}
		}

		public static UIColor  SilverColor {
			get{ return FromHex (0xBDC3C7);}
		}

		public static UIColor  concreteColor {
			get{ return FromHex (0x95A5A6);}
		}

		public static UIColor  asbestosColor {
			get{ return FromHex (0x7F8C8D);}
		}
	}
}

