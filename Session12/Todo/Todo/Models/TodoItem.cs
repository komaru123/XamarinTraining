using SQLite;
using System;

namespace Todo
{
    //[Table("sampleTabel")]
	public class TodoItem
	{
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public string Name { get; set; }

        //public DateTime TimeofTask { get; set; }
		public string Notes { get; set; }
		public bool Done { get; set; }
	}
}

