using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Movie_App_v2_FINAL.Pages;

namespace TestMovie_App_v2_FINAL
{
	public class TestMovieComplex
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor();
			var componentUnderTest = ctx.RenderComponent<MovieComplex>();
			Assert.NotNull(componentUnderTest);
		}
	}
}