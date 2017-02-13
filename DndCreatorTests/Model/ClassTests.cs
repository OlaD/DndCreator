using Microsoft.VisualStudio.TestTools.UnitTesting;
using DndCreator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCreator.Model.Tests
{
				[TestClass()]
				public class ClassTests
				{
								[TestMethod()]
								public void BaseAttackBonusTest()
								{
												BaseAttackBonusType baseAttack = BaseAttackBonusType.Good;
												uint level = 15;
												Class target = new Class(null, null, null, null, 0, null, null, null, null, baseAttack, BaseSaveBonusType.Good, BaseSaveBonusType.Good, BaseSaveBonusType.Good);

												List<uint> expected = new List<uint> { 15, 10, 5 };
												List<uint> actual = target.BaseAttackBonus(level);

												CollectionAssert.AreEqual(expected, actual);
								}
				}
}