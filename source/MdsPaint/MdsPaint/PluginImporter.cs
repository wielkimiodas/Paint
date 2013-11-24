using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;

namespace MdsPaint
{
    public class PluginImporter
    {
        private CompositionContainer _container;

        [ImportMany(typeof(IMdsPaintPlugin))]
        private IEnumerable<Lazy<IMdsPaintPlugin>> _plugins;

        public PluginImporter()
        {
            LoadPlugins();
        }

        private void LoadPlugins()
        {
            //An aggregate catalog that combines multiple catalogs
            var catalog = new AggregateCatalog();
            //Adds all the parts found in the same assembly as the Program class

            const string libsPath = @"C:\Users\Wojciech\Documents\studia\mgr\1 semestr\tpal\Paint\plugins";
            catalog.Catalogs.Add(new DirectoryCatalog(libsPath));

            //Create the CompositionContainer with the parts in the catalog
            _container = new CompositionContainer(catalog);

            //Fill the imports of this object
            _container.ComposeParts(this);
        }

        public string ListLoadedLibs()
        {
            string list = null;
            foreach (var plugin in _plugins)
            {
                list += plugin.Value.Name + Environment.NewLine;
            }
            return list;
        }

        public IEnumerable<IMdsPaintPlugin> GetPluginsList()
        {
            return _plugins.Select(plugin => plugin.Value).ToList();
        }
    }
}
