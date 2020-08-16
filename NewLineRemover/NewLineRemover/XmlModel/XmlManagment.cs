using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NewLineRemover.XmlModel
{
    public class XmlManagment
    {
        public XmlManagment()
        {
            path = "../../XmlModel/AppConfig.xml";
            xdoc = XDocument.Load(path);

        }
        public string path { get; set; }
        public XDocument xdoc { get; set; }

        public string Get(ConfigElements element, Modules module)
        {
            var item = xdoc.Descendants(module.ToString())
                            .Elements(element.ToString())
                            .FirstOrDefault();

            var val = item.Value;
            return val;
        }

        public void Update(ConfigElements element, Modules module, string value)
        {
            var item = xdoc.Descendants(module.ToString())
                            .Elements(element.ToString())
                            .FirstOrDefault();

            item.SetValue(value);

            xdoc.Save(path);
        }
    }
}
