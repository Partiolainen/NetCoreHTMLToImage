using System.IO;

namespace NetCoreHTMLToImage.Console
{
	internal class Program
	{
		private static void Main()
		{
			var converter = new HtmlConverter();

			var html = "<div><strong>Hello</strong> World!</div>";
			var htmlBytes = converter.FromHtmlString(html, format: ImageFormat.Png, customFlags: "--encoding 'UTF-8'");
			File.WriteAllBytes("./html.png", htmlBytes);

			// From URL
			var urlBytes = converter.FromUrl("http://google.com");
			File.WriteAllBytes("./url.png", urlBytes);
		}
	}
}
