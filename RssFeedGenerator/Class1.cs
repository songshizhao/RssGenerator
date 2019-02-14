using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace RssFeedGenerator
{

	public class RssFeedGenerator
	{
		/// <summary>
		/// rss object to serialize
		/// </summary>
		public rss RSS_Source { get; set; }
		/// <summary>
		/// has xml string value after run SerializeRSS() method
		/// </summary>
		public string XmlString;
		public void SerializeRSS()
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
					XmlString = Encoding.UTF8.GetString(ms.ToArray());
					XmlString = "<?xml version=\"1.0\" encoding =\"UTF - 8\" ?>" + XmlString;
				}
			}

		}


	}


}