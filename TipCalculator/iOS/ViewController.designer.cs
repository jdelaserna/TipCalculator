// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace TipCalculator.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        UIKit.UIButton Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField billAmount { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel tipAmountLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider tipSlider { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel totalLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (billAmount != null) {
                billAmount.Dispose ();
                billAmount = null;
            }

            if (tipAmountLabel != null) {
                tipAmountLabel.Dispose ();
                tipAmountLabel = null;
            }

            if (tipSlider != null) {
                tipSlider.Dispose ();
                tipSlider = null;
            }

            if (totalLabel != null) {
                totalLabel.Dispose ();
                totalLabel = null;
            }
        }
    }
}