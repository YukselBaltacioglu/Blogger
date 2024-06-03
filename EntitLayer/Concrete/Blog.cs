using System;
namespace EntitLayer.Concrete
{
	public class Blog
	{
		public int BlogId { get; set; }
		public string BlogTitle { get; set; }
		public string Content { get; set; }
		public string BlogCreateDate { get; set; }
		public bool BlogStatus { get; set; }
		public string BlogThumbNailImage { get; set; }
		public string BlogImage { get; set; }

		public Blog()
		{
		}
	}
}

