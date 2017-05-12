using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace VFWTest.Configuration
{
    public class AppConfiguration
    {
        private static List<SkinImage> _images = new List<SkinImage>();
        private static XmlDocument _doc;

        static AppConfiguration()
        {
            Load();
        }

        public static List<SkinImage> Images
        {
            get
            {
                return _images;
            }
        }

        private static void Load()
        {
            _doc = new XmlDocument();
            _doc.Load(Path.Combine(Application.StartupPath, "AppConfiguration.xml"));

            var root = _doc.SelectSingleNode("app");

            foreach (XmlNode eachNode in root.ChildNodes)
            {
                if (eachNode.NodeType != XmlNodeType.Element)
                {
                    continue;
                }

                var element = eachNode as XmlElement;

                string name = element.GetAttribute("name");
                string value = element.GetAttribute("value");

                if (string.IsNullOrEmpty(name))
                {
                    continue;
                }

                if (_images.Exists(p => p.Name == name) || string.IsNullOrEmpty(value))
                {
                    continue;
                }

                _images.Add(new SkinImage() {Name=name,Value=value });
            }
        }

        public static void SaveImagePath(string name, string filePath)
        {
            // 不存在则创建配置
            var existImge = _images.Find(p => p.Name == name);
            if (existImge == null)
            {
                _images.Add(new SkinImage() { Name = name, Value = filePath });

                var element = _doc.CreateElement("image");
                element.SetAttribute("name", name);
                element.SetAttribute("value", filePath);

                _doc.SelectSingleNode("app").AppendChild(element);
            }
            else
            {
                existImge.Value = filePath;

                var root = _doc.SelectSingleNode("app");

                foreach (XmlNode eachNode in root.ChildNodes)
                {
                    if (eachNode.NodeType != XmlNodeType.Element)
                    {
                        continue;
                    }

                    var element = eachNode as XmlElement;

                    if (element.GetAttribute("name") == name)
                    {
                        element.SetAttribute("value", filePath);
                        break;
                    }
                }
            }

            // 重新保存xml

            _doc.Save(Path.Combine(Application.StartupPath, "AppConfiguration.xml"));

        }
    }

    public class SkinImage
    {
        public string Name
        {
            get;
            set;
        }

        public string Value
        {
            get;
            set;
        }
    }
}
