﻿using System;
using System.ComponentModel.DataAnnotations;
using eTickets.Models.Data.Enum;

namespace eTickets.Models
{
	public class Movie
	{

		[Key]
		public int Id { get; set; }

		public string Name { get; set; }

		public double Price { get; set; }

		public string ImageURL { get; set; }

		public DateTime StartDate { get; set; }

		public DateTime EndDate { get; set; }

		public MovieCategory MovieCategory { get; set; }
	}
}

 