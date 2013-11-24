using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;

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
