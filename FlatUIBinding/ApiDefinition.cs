using System;
using System.Drawing;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace FlatUIBinding
{
	[BaseType (typeof (UISegmentedControl))]
	public partial interface FUISegmentedControl
	{

		[Export ("selectedColor")]
		UIColor SelectedColor { get; set; }

		[Export ("deselectedColor")]
		UIColor DeselectedColor { get; set; }

		[Export ("dividerColor")]
		UIColor DividerColor { get; set; }

		[Export ("cornerRadius")]
		float CornerRadius { get; set; }

		[Export ("selectedFont")]
		UIFont SelectedFont { get; set; }

		[Export ("deselectedFont")]
		UIFont DeselectedFont { get; set; }

		[Export ("selectedFontColor")]
		UIColor SelectedFontColor { get; set; }

		[Export ("deselectedFontColor")]
		UIColor DeselectedFontColor { get; set; }
	}

	[BaseType (typeof (UIControl))]
	public partial interface FUISwitch
	{

		[Export ("on")]
		bool On { [Bind ("isOn")] get; set; }

		[Export ("onBackgroundColor")]
		UIColor OnBackgroundColor { get; set; }

		[Export ("offBackgroundColor")]
		UIColor OffBackgroundColor { get; set; }

		[Export ("onColor")]
		UIColor OnColor { get; set; }

		[Export ("offColor")]
		UIColor OffColor { get; set; }

		[Export ("highlightedColor")]
		UIColor HighlightedColor { get; set; }

		[Export ("percentOn")]
		float PercentOn { get; set; }

		[Export ("offLabel")]
		UILabel OffLabel { get; set; }

		[Export ("onLabel")]
		UILabel OnLabel { get; set; }

		[Export ("setOn:animated:")]
		void SetOn (bool on, bool animated);
	}

	[Category, BaseType (typeof (UIColor))]
	public interface FlatUI
	{
		[Static, Export ("colorFromHexCode:")]
		UIColor ColorFromHexCode (string hexString);

		[Static,Export ("turquoiseColor")]
		UIColor TurquoiseColor { get; }

		[Static,Export ("greenSeaColor")]
		UIColor GreenSeaColor { get; }

		[Static,Export ("emerlandColor")]
		UIColor EmerlandColor { get; }

		[Static,Export ("nephritisColor")]
		UIColor NephritisColor { get; }

		[Static,Export ("peterRiverColor")]
		UIColor PeterRiverColor { get; }

		[Static,Export ("belizeHoleColor")]
		UIColor BelizeHoleColor { get; }

		[Static,Export ("amethystColor")]
		UIColor AmethystColor { get; }

		[Static,Export ("wisteriaColor")]
		UIColor WisteriaColor { get; }

		[Static,Export ("wetAsphaltColor")]
		UIColor WetAsphaltColor { get; }

		[Static,Export ("midnightBlueColor")]
		UIColor MidnightBlueColor { get; }

		[Static,Export ("sunflowerColor")]
		UIColor SunflowerColor { get; }

		[Static,Export ("tangerineColor")]
		UIColor TangerineColor { get; }

		[Static,Export ("carrotColor")]
		UIColor CarrotColor { get; }

		[Static,Export ("pumpkinColor")]
		UIColor PumpkinColor { get; }

		[Static,Export ("alizarinColor")]
		UIColor AlizarinColor { get; }

		[Static,Export ("pomegranateColor")]
		UIColor PomegranateColor { get; }

		[Static,Export ("cloudsColor")]
		UIColor CloudsColor { get; }

		[Static,Export ("silverColor")]
		UIColor SilverColor { get; }

		[Static,Export ("concreteColor")]
		UIColor ConcreteColor { get; }

		[Static,Export ("asbestosColor")]
		UIColor AsbestosColor { get; }

		[Static, Export ("blendedColorWithForegroundColor:backgroundColor:percentBlend:")]
		UIColor BlendedColorWithForegroundColor (UIColor foregroundColor, UIColor backgroundColor, float percentBlend);
	}

	[Category, BaseType (typeof (UIFont))]
	public interface FlatUIFont
	{

		[Static, Export ("flatFontOfSize:")]
		UIFont FlatFontOfSize (float size);

		[Static, Export ("boldFlatFontOfSize:")]
		UIFont BoldFlatFontOfSize (float size);

		[Static, Export ("italicFlatFontOfSize:")]
		UIFont ItalicFlatFontOfSize (float size);
	}

	[Category, BaseType (typeof (UIImage))]
	public partial interface FlatUIImage
	{

		[Static, Export ("imageWithColor:cornerRadius:")]
		UIImage ImageWithColor (UIColor color, float cornerRadius);

		[Static, Export ("buttonImageWithColor:cornerRadius:shadowColor:shadowInsets:")]
		UIImage ButtonImageWithColor (UIColor color, float cornerRadius, UIColor shadowColor, UIEdgeInsets shadowInsets);

		[Static, Export ("circularImageWithColor:size:")]
		UIImage CircularImageWithColor (UIColor color, SizeF size);

		[Export ("imageWithMinimumSize:")]
		UIImage ImageWithMinimumSize (SizeF size);

		[Static, Export ("stepperPlusImageWithColor:")]
		UIImage StepperPlusImageWithColor (UIColor color);

		[Static, Export ("stepperMinusImageWithColor:")]
		UIImage StepperMinusImageWithColor (UIColor color);

		[Static, Export ("backButtonImageWithColor:barMetrics:cornerRadius:")]
		UIImage BackButtonImageWithColor (UIColor color, UIBarMetrics metrics, float cornerRadius);
	}

	[Category, BaseType (typeof (UINavigationBar))]
	public partial interface FlatUIUinAvigationBar
	{

		[Export ("configureFlatNavigationBarWithColor:")]
		void ConfigureFlatNavigationBarWithColor (UIColor color);
	}

	[Category, BaseType (typeof (UIProgressView))]
	public partial interface FlatUIProgressView
	{

		[Export ("configureFlatProgressViewWithTrackColor:progressColor:")]
		void ConfigureFlatProgressViewWithTrackColor (UIColor trackColor, UIColor progressColor);
	}

	[Category, BaseType (typeof (UISlider))]
	public partial interface FlatUISlider
	{

		[Export ("configureFlatSliderWithTrackColor:progressColor:thumbColor:")]
		void ConfigureFlatSliderWithTrackColor (UIColor trackColor, UIColor progressColor, UIColor thumbColor);

		[Export ("configureFlatSliderWithTrackColor:progressColor:thumbColorNormal:thumbColorHighlighted:")]
		void ConfigureFlatSliderWithTrackColor (UIColor trackColor, UIColor progressColor, UIColor thumbColorNormal, UIColor highlightedThumbColor);
	}

	[Category, BaseType (typeof (UIStepper))]
	public partial interface FlatUIStepper
	{

		[Export ("configureFlatStepperWithColor:highlightedColor:disabledColor:iconColor:")]
		void ConfigureFlatStepperWithColor (UIColor color, UIColor highlightedColor, UIColor disabledColor, UIColor iconColor);
	}

	[Category, BaseType (typeof (UITabBar))]
	public partial interface FlatUITabBar
	{

		[Export ("configureFlatTabBarWithColor:selectedColor:")]
		void ConfigureFlatTabBarWithColor (UIColor color, UIColor selectedColor);
	}

	[BaseType (typeof (UIButton))]
	public partial interface FUIButton
	{
		[Export("initWithFrame:")]
		IntPtr Constructor (RectangleF frame);

		[Export ("buttonColor")]
		UIColor ButtonColor { get; set; }

		[Export ("shadowColor")]
		UIColor ShadowColor { get; set; }

		[Export ("shadowHeight")]
		float ShadowHeight { get; set; }

		[Export ("cornerRadius")]
		float CornerRadius { get; set; }
	}

	[BaseType (typeof (UIView))]
	public partial interface FUIAlertView
	{

		[Export ("initWithTitle:message:delegate:cancelButtonTitle:otherButtonTitles:")]
		IntPtr Constructor (string title, string message, [NullAllowed] FUIAertViewDelegate alertDelegate, string cancelButtonTitle, string otherButtonTitles);

		[Export ("delegate")]
		[NullAllowed]
		FUIAertViewDelegate Delegate { get; set; }

		[Export ("title")]
		string Title { get; set; }

		[Export ("message")]
		string Message { get; set; }

		[Export ("addButtonWithTitle:")]
		int AddButtonWithTitle (string title);

		[Export ("buttonTitleAtIndex:")]
		string ButtonTitleAtIndex (int buttonIndex);

		[Export ("numberOfButtons")]
		int NumberOfButtons { get; }

		[Export ("cancelButtonIndex")]
		int CancelButtonIndex { get; set; }

		[Export ("visible")]
		bool Visible { [Bind ("isVisible")] get; }

		[Export ("show")]
		void Show ();

		[Export ("dismissWithClickedButtonIndex:animated:")]
		void DismissWithClickedButtonIndex (int buttonIndex, bool animated);

		[Export ("buttons")]
		NSMutableArray Buttons { get; set; }

		[Export ("titleLabel")]
		UILabel TitleLabel { get; }

		[Export ("messageLabel")]
		UILabel MessageLabel { get; }

		[Export ("backgroundOverlay")]
		UIView BackgroundOverlay { get; }

		[Export ("alertContainer")]
		UIView AlertContainer { get; }

		[Export ("buttonSpacing")]
		float ButtonSpacing { get; set; }

		[Export ("animationDuration")]
		float AnimationDuration { get; set; }

		[Export ("defaultButtonFont")]
		UIFont DefaultButtonFont { get; set; }

		[Export ("defaultButtonTitleColor")]
		UIColor DefaultButtonTitleColor { get; set; }

		[Export ("defaultButtonColor")]
		UIColor DefaultButtonColor { get; set; }

		[Export ("defaultButtonShadowColor")]
		UIColor DefaultButtonShadowColor { get; set; }
	}

	[Model]
	[BaseType(typeof(NSObject))]
	public partial interface FUIAertViewDelegate
	{

		[Export ("alertView:clickedButtonAtIndex:")]
		void AlertViewClickedButtonAtIndex (FUIAlertView alertView, int buttonIndex);

		[Export ("willPresentAlertView:")]
		void WillPresentAlertView (FUIAlertView alertView);

		[Export ("didPresentAlertView:")]
		void DidPresentAlertView (FUIAlertView alertView);

		[Export ("alertView:willDismissWithButtonIndex:")]
		void AlertViewWillDismissWithButtonIndex (FUIAlertView alertView, int buttonIndex);

		[Export ("alertView:didDismissWithButtonIndex:")]
		void AlertViewDidDismissWithButton (FUIAlertView alertView, int buttonIndex);
	}

	[Category, BaseType (typeof (UIBarButtonItem))]
	public partial interface FlatUIBarButtonItem
	{

		[Export ("configureFlatButtonWithColor:highlightedColor:cornerRadius:")]
		void ConfigureFlatButtonWithColor (UIColor color, UIColor highlightedColor, float cornerRadius);
		//		[Static, Export ("configureFlatButtonsWithColor:highlightedColor:cornerRadius:whenContainedIn:")]
		//		void ConfigureFlatButtonsWithColor (UIColor color, UIColor highlightedColor, float cornerRadius, UIAppearanceContainer containerClass);
		[Static, Export ("configureFlatButtonsWithColor:highlightedColor:cornerRadius:")]
		void ConfigureFlatButtonsWithColor (UIColor color, UIColor highlightedColor, float cornerRadius);

		[Export ("removeTitleShadow")]
		void RemoveTitleShadow ();
	}
}

