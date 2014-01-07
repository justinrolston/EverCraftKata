using System;
using EverCraftLib;
using NUnit.Framework;

namespace EverCraftLibTests
{
	[TestFixture()]
	public class CharacterTest
	{
		[Test()]
		public void GivenACharaterHasAName()
		{
			var character = new Character ();
			character.Name = "Jonathan";
			Assert.AreEqual (character.Name, "Jonathan");
		}

		[TestCase(Alignment.Good, Alignment.Good)]
		[TestCase(Alignment.Evil, Alignment.Evil)]
		[TestCase(Alignment.Neutral, Alignment.Neutral)]
		//[TestCase(Alignment.Neutral)]
		//public int DivideTest(int n, int d)
		public void GivenACharaterHasAnAlignment(Alignment alignment, Alignment expected) 
		{
			var character = new Character ();
			character.Alignment = alignment;
			Assert.AreEqual (character.Alignment, expected);
		}

		[Test]
		public void CharacterHasArmorClass()
		{
			var character = new Character();
			Assert.AreEqual(character.ArmorClass, 10);
		}
	}
}

