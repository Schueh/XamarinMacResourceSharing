// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace ResourceSharing.Mac
{
	[Register ("MainWindow")]
	partial class MainWindow
	{
		[Outlet]
		AppKit.NSTextField HelloWorldLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (HelloWorldLabel != null) {
				HelloWorldLabel.Dispose ();
				HelloWorldLabel = null;
			}
		}
	}
}
