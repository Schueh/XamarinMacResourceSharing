using System;
using Foundation;
using AppKit;
using ResourceSharing.Localization;

namespace ResourceSharing.Mac
{
    public partial class MainWindow : NSWindow
    {
        public MainWindow(IntPtr handle)
            : base(handle)
        {
        }

        [Export("initWithCoder:")]
        public MainWindow(NSCoder coder)
            : base(coder)
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();

            HelloWorldLabel.StringValue = AppResources.HelloWorld;
        }
    }
}
