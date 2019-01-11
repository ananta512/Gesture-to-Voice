using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Security;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Microsoft.Kinect
{
	public static class BitmapSourceExtensions
	{
        

		public static BitmapSource ToBitmapSource(this byte[] pixels, int width, int height)
		{
			return ToBitmapSource(pixels, width, height, PixelFormats.Bgr32);
		}

		private static BitmapSource ToBitmapSource(this byte[] pixels, int width, int height, System.Windows.Media.PixelFormat format)
		{
			return BitmapSource.Create(width, height, 96, 96, format, null, pixels, width * format.BitsPerPixel / 8);
		}
	}
}