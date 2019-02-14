using RssFeedGenerator;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{


			Console.WriteLine("Hello World");




			Console.WriteLine(GetRss());





			Console.Read();



		}



		public static string GetRss()
		{

			//using RssFeedGenerator;
			var myrss = new rss();
			//在这里声明rss
			myrss.version = 2.0m;

			myrss.channel = new rssChannel
			{

				title = "开发者博客",
				description = "开发者博客最新发布",
				link = "https://www.songshizhao.com/blog/RSS/RssHandler.ashx",
				language = "zh-CN",
				copyright = "Copyright 2017 - 2020, songshizhao.com",

				docs = "https://www.songshizhao.com/blog/RSS/RssHandler.ashx",
				generator = "https://www.songshizhao.com/login.aspx",
				link1 = new link
				{
					href = "https://www.songshizhao.com/blog/RSS/RssHandler.ashx",
					rel = "self",
					type = "application/rss+xml",
				},
			};


			//DataSet MyBlogs = new DataSet();
			//string conStr = BlogHelpper.conStr;
			//using (OleDbConnection con = new OleDbConnection(conStr))
			//{
			//	string cmdStr = "select top 40 * from blog order by blogTime desc";
			//	con.Open();
			//	using (var cmd = new OleDbCommand(cmdStr, con))
			//	{
			//		using (OleDbDataAdapter s = new OleDbDataAdapter(cmdStr, conStr))
			//		{
			//			s.Fill(MyBlogs);
			//		}
			//	}
			//	con.Close();
			//}

			//var items = new List<rssChannelItem>();
			//myrss.channel.item = items;
			//for (int x = 0; x < MyBlogs.Tables[0].Rows.Count; x++)
			//{
			//	rssChannelItem blogItem = new rssChannelItem()
			//	{
			//		title = MyBlogs.Tables[0].Rows[x][2].ToString(),
			//		description = MyBlogs.Tables[0].Rows[x][4].ToString(),//, BlogHelpper.GetHtmlText(MyBlogs.Tables[0].Rows[x][4].ToString()),
			//		guid = new rssChannelItemGuid
			//		{
			//			isPermaLink = false,
			//			Value = MyBlogs.Tables[0].Rows[x][0].ToString(),
			//		},
			//		link = MyBlogs.Tables[0].Rows[x][5].ToString(),
			//		pubDate = MyBlogs.Tables[0].Rows[x][3].ToString(),

			//	};
			//	//if (blogItem.description.Length > 200)
			//	//{
			//	//	blogItem.description = blogItem.description.Substring(0, 200);
			//	//}
			//	blogItem.description = BlogHelpper.Decode(blogItem.description);
			//	items.Add(blogItem);
			//};

			//using RssFeedGenerator;
			var OutputXmlString = Generator.SerializeRSS(myrss);
			return OutputXmlString;

		}




	}
}
