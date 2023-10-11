using System;
using System.Drawing.Imaging;
using System.Linq;

using Framework.Core;



namespace Framework.Graphviz
{
    internal static class ImageExtensions
    {
        public static ImageCodecInfo GetCodecInfo(this ImageFormat imageFormat)
        {
            if (imageFormat == null) throw new ArgumentNullException(nameof(imageFormat));

            return ImageCodecInfo.GetImageEncoders()
                .Where(codec => codec.FormatID == imageFormat.Guid)
                .Single(() => new Exception($"ImageCodecInfo for format \"{imageFormat}\"not found"));
        }

        public static string GetExtension(this ImageCodecInfo imageCodecInfo)
        {
            if (imageCodecInfo == null) throw new ArgumentNullException(nameof(imageCodecInfo));

            const char formatDelimiter = ';';

            if (imageCodecInfo.FilenameExtension.Contains(formatDelimiter))
            {
                return imageCodecInfo.FilenameExtension.Substring(0, imageCodecInfo.FilenameExtension.IndexOf(formatDelimiter)).Replace(@"*.", "").ToLower();
            }

            return imageCodecInfo.FilenameExtension.Replace(@"*.", "").ToLower();
        }
    }
}
