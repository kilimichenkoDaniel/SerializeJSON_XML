using ConsoleApp1.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    public static class AlbomManager
    {
        public static string JsonSerialize(Album albom)
        {
            #region NoobCode
            //if(albom == null)
            //{
            //    throw new ArgumentNullException(nameof(albom));
            //}

            //string serializeString = JsonSerializer.Serialize(albom);

            //if(string.IsNullOrEmpty(serializeString)) 
            //{
            //    throw new JsonException("Serialize error");
            //}

            // return serializeString;
            #endregion

            ArgumentNullException.ThrowIfNull(albom); // синтаксичний цукор

            return JsonSerializer.Serialize(albom) ?? throw new JsonException("Serialize error");
        }

        public static void SaveJson(string json, string path)
        {
            ArgumentNullException.ThrowIfNull(json);

            ArgumentNullException.ThrowIfNull(path);

            byte[] bytes = Encoding.UTF8.GetBytes(json);
            using FileStream fstream = File.Create(path);
            fstream.Write(bytes, 0, bytes.Length);
        }

        public static string LoadJson(string path) 
        {
            ArgumentNullException.ThrowIfNull(path);

            if (!File.Exists(path)) 
            {
                throw new FileNotFoundException(path);
            }
            return File.ReadAllText(path);
        }

        public static Album DeserializeJson(string json) 
        {
            ArgumentNullException.ThrowIfNull(json);

            return JsonSerializer.Deserialize<Album>(json) ?? throw new JsonException("Deserialize error");
        }

        public static void SerializeXML(Album album, string path)
        {
            ArgumentNullException.ThrowIfNull(album);

            var serializer = new XmlSerializer(typeof(Album));
            using FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate);
            serializer.Serialize(fileStream, album);
        }

        public static Album DeserializeXML(string path)
        {
            ArgumentNullException.ThrowIfNull(path);

            var serializer = new XmlSerializer(typeof(Album));

            using FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate);
            return serializer.Deserialize(fileStream) as Album ?? throw new XmlException();
        }
    }
}
