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
			return result;
		}

		public static UIColor Turquoise {
			get { return FromHex (0x1ABC9C);}
		}

		public static UIColor  GreenSea {
			get{ return FromHex (0x16A085);}
		}

		public static UIColor  Emerland {
			get{ return FromHex (0x2ECC71);}
		}

		public static UIColor  Nephritis {
			get{ return FromHex (0x27AE60);}
		}

		public static UIColor  PeterRiver {
			get{ return FromHex (0x3498DB);}
		}

		public static UIColor  BelizeHole {
			get{ return FromHex (0x2980B9);}
		}

		public static UIColor  Amethyst {
			get{ return FromHex (0x9B59B6);}
		}

		public static UIColor  Wisteria {
			get{ return FromHex (0x8E44AD);}
		}

		public static UIColor  WetAsphalt {
			get{ return FromHex (0x34495E);}
		}

		public static UIColor  MidnightBlue {
			get{ return FromHex (0x2C3E50);}
		}

		public static UIColor  Sunflower {
			get{ return FromHex (0xF1C40F);}
		}

		public static UIColor  Tangerine {
			get{ return FromHex (0xF39C12);}
		}

		public static UIColor  Carrot {
			get{ return FromHex (0xE67E22);}
		}

		public static UIColor  Pumpkin {
			get{ return FromHex (0xD35400);}
		}

		public static UIColor  Alizarin {
			get{ return FromHex (0xE74C3C);}
		}

		public static UIColor  Pomegranate {
			get{ return FromHex (0xC0392B);}
		}

		public static UIColor  Clouds {
			get{ return FromHex (0xECF0F1);}
		}

		public static UIColor  Silver {
			get{ return FromHex (0xBDC3C7);}
		}

		public static UIColor  Concrete {
			get{ return FromHex (0x95A5A6);}
		}

		public static UIColor  Asbestos {
			get{ return FromHex (0x7F8C8D);}
		}
	}
}

