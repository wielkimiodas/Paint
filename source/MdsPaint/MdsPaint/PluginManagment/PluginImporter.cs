using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;

namespace MdsPaint.PluginManagment
{
    public class PluginImporter
    {
        private CompositionContainer _container;

        [ImportMany(typeof(MdsPaintPluginBase))]
        private IEnumerable<Lazy<MdsPaintPluginBase>> _plugins;
        private const string LibsPath = @"C:\Users\Wojciech\Documents\studia\mgr\1 semestr\tpal\Paint\plugins";

        public PluginImporter()
        {
            LoadPlugins();
        }

        private void LoadPlugins()
        {
            //An aggregate catalog that combines multiple catalogs
            var catalog = new AggregateCatalog();
            
            //Adds all the parts found in the same assembly as the Program class
            catalog.Catalogs.Add(new DirectoryCatalog(LibsPath));

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

        public IEnumerable<MdsPaintPluginBase> GetPluginsList()
        {
            return _plugins.Select(plugin => plugin.Value).ToList();
        }
    }
}
