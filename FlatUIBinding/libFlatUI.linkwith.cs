using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libFlatUI.a", LinkTarget.ArmV7, Frameworks = "CoreText CoreGraphics", ForceLoad = true)]
