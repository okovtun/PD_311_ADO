using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Group
	{
		public int ID { get; set; }
		public string GroupName { get; set; }
		public DateTime StartDate { get; set; }
		public TimeSpan LearningTime { get; set; }
		public int Direction { get; set; }
		public int LearningForm { get; set; }
		public byte LearningDays { get; set; }

		public Group()
		{

		}
		public Group(Group other)
		{
			this.ID = other.ID;
			this.GroupName = other.GroupName;
			this.StartDate = other.StartDate;
			this.LearningTime = other.LearningTime;
			this.Direction = other.Direction;
			this.LearningForm = other.LearningForm;
			this.LearningDays = other.LearningDays;
		}
	}
}
