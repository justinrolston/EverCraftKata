using System;

namespace EverCraftLib
{
	public class Character
	{
		public string Name { get; set; }
		public Alignment Alignment { get; set; }
		public int ArmorClass {get; set;}

		public Character ()
		{
			this.ArmorClass = 10;
		}
	}
}