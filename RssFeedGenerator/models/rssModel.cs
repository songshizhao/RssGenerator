﻿using System.Collections.Generic;


namespace RssFeedGenerator
{

	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = false)]
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
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class rssChannel
	{

		private string titleField;

		private string descriptionField;

		private string linkField;

		private string languageField;

		private string copyrightField;

		private string docsField;

		private string generatorField;

		private link link1Field;

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
		public string docs
		{
			get
			{
				return this.docsField;
			}
			set
			{
				this.docsField = value;
			}
		}

		/// <remarks/>
		public string generator
		{
			get
			{
				return this.generatorField;
			}
			set
			{
				this.generatorField = value;
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
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2005/Atom", IsNullable = false)]
	public partial class link
	{

		private string hrefField;

		private string relField;

		private string typeField;

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

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class rssChannelItem
	{

		private string titleField;

		private string descriptionField;

		private string pubDateField;

		private string linkField;

		private rssChannelItemGuid guidField;

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
		public rssChannelItemGuid guid
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

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class rssChannelItemGuid
	{

		private bool isPermaLinkField;

		private string valueField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public bool isPermaLink
		{
			get
			{
				return this.isPermaLinkField;
			}
			set
			{
				this.isPermaLinkField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public string Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}
	}

}