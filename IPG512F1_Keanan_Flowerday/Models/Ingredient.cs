﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IPG512F1_Keanan_Flowerday.Models
{
	public class Ingredient
	{
		[Key]
		public int ID { get; set; }
		public string Name { get; set; }
		public double Cost { get; set; }
	}
}