using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Calendar.Kata.Data
{
	public class Week
	{
		private List<Day> _days;
		public List<Day> Days
		{
			get
			{
				if (_days == null || _days.Count() == 0)
				{
					_days = new List<Day>();
					for (int i = 1; i <= 7; i++) { _days.Add(new Day(i)); };
				}
				return _days;
			}

		}
		public Week()
		{

		}
	}
}
