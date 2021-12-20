using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Handlers;

namespace Microsoft.Maui.Controls.Handlers.Items
{
	public partial class CollectionViewHandler : GroupableItemsViewHandler<GroupableItemsView>
	{
		public override Size GetDesiredSize(double widthConstraint, double heightConstraint)
		{
			return base.GetDesiredSize(widthConstraint, heightConstraint);
		}

		public override void NativeArrange(Rectangle frame)
		{
			base.NativeArrange(frame);
		}
	}
}
