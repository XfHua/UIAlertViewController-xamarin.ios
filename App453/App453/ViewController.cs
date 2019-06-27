using Foundation;
using System;
using UIKit;

namespace App453
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            var alert = new UIAlertController();
            alert.Title = "My Title";
            alert.Message = "My Message";

            UIAlertAction ac1 = UIAlertAction.Create("123", UIAlertActionStyle.Cancel, null);

            alert.AddAction(ac1);

            this.PresentViewController(alert, true, addGesOnBackGround);
        }

        public void addGesOnBackGround()
        {

            UIView backView = new UIView();

            Array arrayViews = UIApplication.SharedApplication.KeyWindow.Subviews;

            if (arrayViews.Length > 0)
            {
                backView = arrayViews.GetValue(arrayViews.Length - 1) as UIView;
            }

            UITapGestureRecognizer tapGestureRecognizer = new
             UITapGestureRecognizer((gesture) =>
             {
             //I never get here
             this.DismissViewControllerAsync(true);

             });

            backView.AddGestureRecognizer(tapGestureRecognizer);
            backView.UserInteractionEnabled = true;
        }

    }
}