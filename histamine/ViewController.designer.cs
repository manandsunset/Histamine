// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace histamine
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        AppKit.NSTextField scan_number { get; set; }

        [Outlet]
        AppKit.NSTextField Vmax_no { get; set; }

        [Outlet]
        AppKit.NSTextField Vmin_no { get; set; }

        [Action ("start_volt_button:")]
        partial void start_volt_button (Foundation.NSObject sender);
        
        void ReleaseDesignerOutlets ()
        {
            if (scan_number != null) {
                scan_number.Dispose ();
                scan_number = null;
            }

            if (Vmin_no != null) {
                Vmin_no.Dispose ();
                Vmin_no = null;
            }

            if (Vmax_no != null) {
                Vmax_no.Dispose ();
                Vmax_no = null;
            }
        }
    }
}
