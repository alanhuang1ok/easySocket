using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace TestServer
{
    [XmlRootAttribute("MyCity", Namespace = "abc.abc", IsNullable = false)]
    public class City
    {
        [XmlAttribute("CityName")]
        public string Name
        {
            get;
            set;
        }

        [XmlAttribute("CityId")]
        public string Id
        {
            get;
            set;
        }

        [XmlArrayAttribute("Areas")]
        public Area[] Areas
        {
            get;
            set;
        }
    }

    [XmlRootAttribute("MyArea")]
    public class Area
    {
        [XmlAttribute("AreaName")]
        public string Name
        {
            get;
            set;
        }

        [XmlElementAttribute("AreaId", IsNullable = false)]
        public string Id
        {
            get;
            set;
        }

        [XmlElementAttribute("Street", IsNullable = false)]
        public string[] Streets
        {
            get;
            set;
        }
    }
}
