﻿using System;
namespace EntitLayer.Concrete
{
	public class Writer
	{

		public int WriterId { get; set; }
		public string WriterName { get; set; }
		public string WriterAbout { get; set; }
		public string WriterImage { get; set; }
		public bool WriterStatus { get; set; }
		public string WriterEmail { get; set; }
		public string WriterPassword { get; set; }
		public Writer()
		{
		}
	}
}

