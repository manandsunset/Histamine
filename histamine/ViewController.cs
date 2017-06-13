using System;
using System.Diagnostics;
using AppKit;
using Foundation;

namespace histamine
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();


            // Do any additional setup after loading the view.
        }

        partial void start_volt_button(Foundation.NSObject sender)
        {
            Debug.WriteLine(scan_number.StringValue);
            Debug.WriteLine(Vmin_no.StringValue);
            Debug.WriteLine(Vmax_no.StringValue);

        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
    }
}
