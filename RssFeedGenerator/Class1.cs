using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace RssFeedGenerator
{

	public class Generator
	{

		/// <summary>
		/// return xml-string after run SerializeRSS()
		/// </summary>
		/// <param name="RSS_Source">rss object to serialize</param>
		/// <returns></returns>
		public static string SerializeRSS(rss RSS_Source)
		{
			using (MemoryStream ms = new MemoryStream())
			{
				var setting = new XmlWriterSettings()
				{
					Encoding = new UTF8Encoding(false),
					Indent = true,
					OmitXmlDeclaration = true,
				};
				using (XmlWriter writer = XmlWriter.Create(ms, setting))
				{
					XmlSerializer xmlSearializer = new XmlSerializer(typeof(rss));
					xmlSearializer.Serialize(writer, RSS_Source);
					var XmlString = Encoding.UTF8.GetString(ms.ToArray());
					XmlString = "<?xml version=\"1.0\" encoding =\"UTF-8\"?>" + "\n" + XmlString;

					return XmlString;

				}
			}

		}


	}


}