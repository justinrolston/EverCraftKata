using System;

namespace EverCraftLib
{
	public class Character
	{
		public string Name { get; set; }
		public Alignment Alignment { get; set; }
		public int ArmorClass {get; set;}
		public int HitPoints { get; set; }

		public Character ()
		{
			this.ArmorClass = 10;
			this.HitPoints = 5;
		}

		public bool Attack(int roll, Character opponent)
		{
			return (roll >= opponent.ArmorClass);
		}
	}
}