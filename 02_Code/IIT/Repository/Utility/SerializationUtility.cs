using System.IO;
using System.Xml.Serialization;

namespace Repository.Utility
{
    public static class SerializationUtility
    {
        public static T DeserializeXml<T>(this string toDeserialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using (StringReader textReader = new StringReader(toDeserialize))
            {
                return (T)xmlSerializer.Deserialize(textReader);
            }
        }

        public static string SerializeXml<T>(this T toSerialize)
        {
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            XmlSerializer xmlSerializer = new XmlSerializer(toSerialize?.GetType() ?? typeof(T), string.Empty);
            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, toSerialize, ns);
                return textWriter.ToString();
            }
        }
    }
}
