using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Movie_App_v2_FINAL.Pages;
using Movie_App_v2_FINAL.MovieApp;

namespace TestMovie_App_v2_FINAL
{
	public class TestMyPurchases
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbListModule),
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule));
			var mockHttpClient = new MockHttpClient().Create();
			ctx.Services.AddSingleton(new MovieAppService(mockHttpClient));
			var componentUnderTest = ctx.RenderComponent<MyPurchases>();
			Assert.NotNull(componentUnderTest);
		}
	}
}