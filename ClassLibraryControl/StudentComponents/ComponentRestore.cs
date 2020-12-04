using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace ClassLibraryControl.Components
{
    public partial class ComponentRestore : Component
    {
        public ComponentRestore()
        {
            InitializeComponent();
        }

        public ComponentRestore(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public List<T> DownloadBackUp<T>(string path)
        {
            List<T> result;
            if (!Check(typeof(T)))
                throw new Exception("Объект невозможно загрузить в формате JSON. Отсутствует атрибут DataContract");
            using (StreamReader sr = new StreamReader(path))
            {
                string text = sr.ReadToEnd();
                result = Newtonsoft.Json.JsonConvert.DeserializeObject<List<T>>(text);
            }
            return result;
        }

        private bool Check(Type type)
        {
            var attrib = type.CustomAttributes;//атрибуты класса
            foreach (var atr in attrib)
            {
                if (atr.ToString().Contains("DataContractAttribute"))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
