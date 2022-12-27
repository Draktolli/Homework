﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_2.Entities
{
	internal class Director
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string SurName { get; set; }	
		public School? School { get; set; }
	}
}