using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calendar.Kata.Data
{
	public class Day
	{
		public int Order { get; set; }
		public eActivity Activity { get; set; }
		public Day()
		{
			Order = 1;
			Activity = eActivity.Unallocated;
		}
		public Day(int order)
		{
			Order = order;
			Activity = eActivity.Unallocated;
		}
	}
}
