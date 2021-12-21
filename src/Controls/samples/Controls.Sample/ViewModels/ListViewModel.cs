using System.Collections.Generic;
using Maui.Controls.Sample.Models;
using Maui.Controls.Sample.Pages;
using Maui.Controls.Sample.Pages.ListViewGalleries;
using Maui.Controls.Sample.ViewModels.Base;

namespace Maui.Controls.Sample.ViewModels
{
	public class ListViewModel : BaseGalleryViewModel
	{
		protected override IEnumerable<SectionModel> CreateItems() => new[]
		{
			new SectionModel(typeof(CarouselViewPage), "RefreshView",
				""),
			new SectionModel(typeof(ListViewEntryCell), "Entry Cell",
				""),
			new SectionModel(typeof(CarouselViewPage), "Text Cell",
				""),
			new SectionModel(typeof(CarouselViewPage), "Image Cell",
				""),
			new SectionModel(typeof(CarouselViewPage), "Switch Cell",
				""),
			new SectionModel(typeof(CarouselViewPage), "View Cell",
				""),

		};
	}
}