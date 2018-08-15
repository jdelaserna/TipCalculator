using System;

using UIKit;

namespace TipCalculator.iOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
            
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            billAmount.EditingChanged += Calculate;
            tipSlider.ValueChanged += Calculate;

            // Perform any additional setup after loading the view, typically from a nib.
        }
        void Calculate (object sender, EventArgs e) {
            double bill = Convert.ToInt32(billAmount.Text);
            //double tipAmountResult = bill * (Convert.ToDouble(tipPercentageTextField.Text) / 100);
            double tipAmountResult = bill * (tipSlider.Value / 100);
            double totalResult = bill + tipAmountResult;
            tipAmountLabel.Text = "Tip Amount: " + tipAmountResult.ToString();
            totalLabel.Text = "Total Amount: " + totalResult.ToString();

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }
    }
}
