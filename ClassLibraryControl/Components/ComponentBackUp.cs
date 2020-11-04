using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace ClassLibraryControl.Components
{
    public partial class ComponentBackUp : Component
    {
        public ComponentBackUp()
        {
            InitializeComponent();
        }

        public ComponentBackUp(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        /// <summary>
        /// Создание бекапа
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="folderName"></param>
        public void CreateBackUp<T>(List<T> data, string folderName)
        {
            DataContractAttribute type = (DataContractAttribute)Attribute.GetCustomAttribute(typeof(T), typeof(DataContractAttribute));
            if (type == null)
                throw new Exception("Объект невозможно сохранить в формате JSON. Отсутствует атрибут DataContract");
            string dirTempName = $"{folderName + Path.DirectorySeparatorChar + typeof(T).Name}";
            string fileName = $"{dirTempName + Path.DirectorySeparatorChar + typeof(T).Name}.json";
            string zipName = $"{folderName + Path.DirectorySeparatorChar + typeof(T).Name}.zip";
            DirectoryInfo dirInfo = new DirectoryInfo(dirTempName);
            if (dirInfo.Exists)
                dirInfo.Delete(true);
            dirInfo.Create();
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(data.GetType());
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                jsonFormatter.WriteObject(fs, data);
            }
            FileInfo zipFile = new FileInfo(zipName);
            if (zipFile.Exists)
                zipFile.Delete();
            ZipFile.CreateFromDirectory(dirTempName, zipName);
            dirInfo.Delete(true);
        }
    }
}