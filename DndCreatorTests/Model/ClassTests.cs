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
								public void GoodBonus_GetBaseAttackBonusTest()
								{
												BaseAttackBonusType baseAttack = BaseAttackBonusType.Good;
												uint level = 15;
												Class target = new Class(null, null, null, null, 0, null, null, null, null, baseAttack, BaseSaveThrowBonusType.Good, BaseSaveThrowBonusType.Good, BaseSaveThrowBonusType.Good);

												List<uint> expected = new List<uint> { 15, 10, 5 };
												List<uint> actual = target.GetBaseAttackBonus(level);

												CollectionAssert.AreEqual(expected, actual);
								}

								[TestMethod()]
								public void AverageBonus_GetBaseAttackBonusTest()
								{
												BaseAttackBonusType baseAttack = BaseAttackBonusType.Average;
												uint level = 15;
												Class target = new Class(null, null, null, null, 0, null, null, null, null, baseAttack, BaseSaveThrowBonusType.Good, BaseSaveThrowBonusType.Good, BaseSaveThrowBonusType.Good);

												List<uint> expected = new List<uint> { 11, 6, 1 };
												List<uint> actual = target.GetBaseAttackBonus(level);

												CollectionAssert.AreEqual(expected, actual);
								}

								[TestMethod()]
								public void GetFortitudeBonusTest()
								{
												BaseSaveThrowBonusType bonusType = BaseSaveThrowBonusType.Good;
												uint level = 15;
												Class target = new Class(null, null, null, null, 0, null, null, null, null, 0, bonusType, bonusType, bonusType);

												uint expected = 9;
												uint actual = target.GetFortitudeBonus(level);

												Assert.AreEqual(expected, actual);
								}
				}
}