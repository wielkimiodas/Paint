using System.Drawing;
using System.Reflection;

namespace MdsPaint.Utils
{
    public static class ExtensionMethods
    {
        public static Image RetrieveImageFromEmbeddedResource(this Assembly assembly, string resourceName)
        {
            Image result;
            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                result = Image.FromStream(stream);
            }
            return result;
        }
    }
}