// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace KanaTest
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel BestScore { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Changer { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField InputText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Score { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView StatusImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Symbol { get; set; }

        [Action ("DismissKeyboard:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void DismissKeyboard (UIKit.UITextField sender);

        [Action ("EditingDidEnd:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void EditingDidEnd (UIKit.UITextField sender);

        [Action ("TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (BestScore != null) {
                BestScore.Dispose ();
                BestScore = null;
            }

            if (Changer != null) {
                Changer.Dispose ();
                Changer = null;
            }

            if (InputText != null) {
                InputText.Dispose ();
                InputText = null;
            }

            if (Score != null) {
                Score.Dispose ();
                Score = null;
            }

            if (StatusImage != null) {
                StatusImage.Dispose ();
                StatusImage = null;
            }

            if (Symbol != null) {
                Symbol.Dispose ();
                Symbol = null;
            }
        }
    }
}