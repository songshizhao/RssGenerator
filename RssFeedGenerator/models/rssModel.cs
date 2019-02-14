﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RssFeedGenerator
{


	// 注意: 生成的代码可能至少需要 .NET Framework 4.5 或 .NET Core/Standard 2.0。
	/// <remarks/>
	//[System.SerializableAttribute()]
	//[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class rss
	{

		private rssChannel channelField;

		private decimal versionField;

		/// <remarks/>
		public rssChannel channel
		{
			get
			{
				return this.channelField;
			}
			set
			{
				this.channelField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public decimal version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
			}
		}
	}

	/// <remarks/>
	//[System.SerializableAttribute()]
	//[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class rssChannel
	{

		private string titleField;

		private string linkField;

		private string descriptionField;

		private link link1Field;

		private string languageField;

		private string copyrightField;

		private string lastBuildDateField;

		private byte ttlField;

		private List<rssChannelItem> itemField;

		/// <remarks/>
		public string title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
			}
		}

		/// <remarks/>
		public string link
		{
			get
			{
				return this.linkField;
			}
			set
			{
				this.linkField = value;
			}
		}

		/// <remarks/>
		public string description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("link", Namespace = "http://www.w3.org/2005/Atom")]
		public link link1
		{
			get
			{
				return this.link1Field;
			}
			set
			{
				this.link1Field = value;
			}
		}

		/// <remarks/>
		public string language
		{
			get
			{
				return this.languageField;
			}
			set
			{
				this.languageField = value;
			}
		}

		/// <remarks/>
		public string copyright
		{
			get
			{
				return this.copyrightField;
			}
			set
			{
				this.copyrightField = value;
			}
		}

		/// <remarks/>
		public string lastBuildDate
		{
			get
			{
				return this.lastBuildDateField;
			}
			set
			{
				this.lastBuildDateField = value;
			}
		}

		/// <remarks/>
		public byte ttl
		{
			get
			{
				return this.ttlField;
			}
			set
			{
				this.ttlField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("item")]
		public List<rssChannelItem> item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
			}
		}
	}

	/// <remarks/>
	//[System.SerializableAttribute()]
	//[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2005/Atom", IsNullable = false)]
	public partial class link
	{

		private string hrefField;

		private string relField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string href
		{
			get
			{
				return this.hrefField;
			}
			set
			{
				this.hrefField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string rel
		{
			get
			{
				return this.relField;
			}
			set
			{
				this.relField = value;
			}
		}
	}

	/// <remarks/>
	//[System.SerializableAttribute()]
	//[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class rssChannelItem
	{

		private string titleField;

		private string linkField;

		private string descriptionField;

		private string creatorField;

		private string pubDateField;

		private string guidField;

		/// <remarks/>
		public string title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
			}
		}

		/// <remarks/>
		public string link
		{
			get
			{
				return this.linkField;
			}
			set
			{
				this.linkField = value;
			}
		}

		/// <remarks/>
		public string description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://purl.org/dc/elements/1.1/")]
		public string creator
		{
			get
			{
				return this.creatorField;
			}
			set
			{
				this.creatorField = value;
			}
		}

		/// <remarks/>
		public string pubDate
		{
			get
			{
				return this.pubDateField;
			}
			set
			{
				this.pubDateField = value;
			}
		}

		/// <remarks/>
		public string guid
		{
			get
			{
				return this.guidField;
			}
			set
			{
				this.guidField = value;
			}
		}
	}


}