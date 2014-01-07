using System;
using EverCraftLib;
using NUnit.Framework;

namespace EverCraftLibTests
{
	[TestFixture()]
	public class CharacterTest
	{
		Character character;

		[SetUp()]
		public void Setup()
		{
			character = new Character();
		}

		[Test()]
		public void HasAName()
		{
			character.Name = "Jonathan";
			Assert.AreEqual (character.Name, "Jonathan");
		}

		[TestCase(Alignment.Good, Alignment.Good)]
		[TestCase(Alignment.Evil, Alignment.Evil)]
		[TestCase(Alignment.Neutral, Alignment.Neutral)]
		public void HasAnAlignment(Alignment alignment, Alignment expected) 
		{
			character.Alignment = alignment;
			Assert.AreEqual (character.Alignment, expected);
		}

		[Test]
		public void HasArmorClassOf10ByDefault()
		{
			Assert.AreEqual(character.ArmorClass, 10);
		}

		[Test]
		public void HasHitPointsOf5ByDefault()
		{
			Assert.AreEqual(character.HitPoints, 5);
		}

		[Test]
		public void WhenAttackingWithRollOf1WithOppentArmorClassOf10()
		{
			var roll = 1;
			var opponent = new Character ();
			opponent.ArmorClass = 10; 
			Assert.AreEqual (character.Attack(roll, opponent), false);
		}

	}
}

