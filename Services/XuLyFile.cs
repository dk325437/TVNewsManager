using System;
using System.IO;
using System.Xml.Serialization;

namespace TVNewsManager.Services
{
    public static class XuLyFile
    {
        // Lưu dữ liệu ra file (Serialization)
        public static void Luu<T>(string filePath, T duLieu)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));
                xs.Serialize(fs, duLieu);
            }
        }

        // Đọc dữ liệu từ file (Deserialization)
        public static T Doc<T>(string filePath)
        {
            if (!File.Exists(filePath)) return default(T);

            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));
                return (T)xs.Deserialize(fs);
            }
        }
    }
}


