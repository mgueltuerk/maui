﻿using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Automation.Peers;
using NativeAutomationProperties = Microsoft.UI.Xaml.Automation.AutomationProperties;

namespace Microsoft.Maui.DeviceTests
{
	public partial class HandlerTestBase
	{
		protected bool GetIsAccessibilityElement(IViewHandler viewHandler) =>
			((AccessibilityView)((DependencyObject)viewHandler.NativeView).GetValue(NativeAutomationProperties.AccessibilityViewProperty)) 
			== AccessibilityView.Content;
	}
}
