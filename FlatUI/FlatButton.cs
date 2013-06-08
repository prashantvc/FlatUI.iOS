using System;
using MonoTouch.UIKit;
using System.Drawing;

namespace FlatUI
{
	public class FlatButton:UIButton
	{
		UIEdgeInsets defaultEdgeInsets;
		UIEdgeInsets normalEdgeInsets;
		UIEdgeInsets highlightedEdgeInsets;
		UIColor color = FlatColors.TurquoiseColor;
		UIColor shadowColor = FlatColors.GreenSeaColor;
		float cornerRadius = 6f;
		float shadowHeight = 3f;

		public FlatButton (RectangleF frame):base(frame)
		{
			//Defaults
			this.defaultEdgeInsets = TitleEdgeInsets;
			//TODO: make custom fonts work
			TitleLabel.Font = UIFont.BoldSystemFontOfSize (16);
			SetTitleColor (FlatColors.CloudsColor, UIControlState.Normal);
			SetTitleColor (FlatColors.CloudsColor, UIControlState.Highlighted);
			CornerRadius = 6f;
			ShadowHeight = 3f;

			//Create button graphics
			ConfigureFlatButton ();
		}

		public void SetTitle(string title) {
			SetTitle (title, UIControlState.Normal);
			SetTitle (title, UIControlState.Highlighted);
		}

		public override bool Highlighted {
			get {
				return base.Highlighted;
			}
			set {
				TitleEdgeInsets = value ? highlightedEdgeInsets : normalEdgeInsets;
				base.Highlighted = value;
			}
		}

		public UIColor Color {
			get {
				return color;
			}
			set {
				color = value;
				ConfigureFlatButton ();
			}
		}

		public UIColor ShadowColor {
			get {
				return shadowColor;
			}
			set {
				shadowColor = value;
				ConfigureFlatButton ();
			}
		}

		public float CornerRadius {
			get {
				return cornerRadius;
			}
			set {
				cornerRadius = value;
				ConfigureFlatButton ();
			}
		}

		public float ShadowHeight {
			get {
				return shadowHeight;
			}
			set {
				shadowHeight = value;
				var insets = defaultEdgeInsets;
				highlightedEdgeInsets = insets;
				insets.Top -= shadowHeight;
				normalEdgeInsets = insets;
				TitleEdgeInsets = insets;

				ConfigureFlatButton ();
			}
		}

		void ConfigureFlatButton ()
		{
			UIImage normalBackgroundImage = ImageHelper.ButtonImage (Color, CornerRadius, ShadowColor,
			                                                         new UIEdgeInsets (0, 0, ShadowHeight, 0));
			UIImage highlightedBackgroundImage = ImageHelper.ButtonImage (Color, CornerRadius, UIColor.Clear,
			                                                              new UIEdgeInsets (ShadowHeight, 0, 0, 0));

			SetBackgroundImage (normalBackgroundImage, UIControlState.Normal);
			SetBackgroundImage (highlightedBackgroundImage, UIControlState.Highlighted);
		}
	}
}

