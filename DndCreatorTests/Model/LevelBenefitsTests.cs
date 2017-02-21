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
				public class LevelBenefitsTests
				{
								[TestMethod()]
								public void GetExistingValueTest()
								{
												LevelBenefits<int> target = new LevelBenefits<int>();
												int addedNumber = 5;
												target[0] = addedNumber;

												int expected = addedNumber;
												int actual = target[0];

												Assert.AreEqual(expected, actual);
								}

								[TestMethod()]
								public void GetNonExistentValueTest()
								{
												LevelBenefits<int?> target = new LevelBenefits<int?>();
												
												int? expected = null;
												int? actual = target[0];

												Assert.AreEqual(expected, actual);
								}

								[TestMethod()]
								public void FirstValue_AddOnNextLevelTest()
								{
												LevelBenefits<int> target = new LevelBenefits<int>();
												int addedNumber = 5;
												target.AddOnNextLevel(5);

												int expected = addedNumber;
												int actual = target[0];

												Assert.AreEqual(expected, actual);
								}

								[TestMethod()]
								public void ManyValues_AddOnNextLevelTest()
								{
												LevelBenefits<int> target = new LevelBenefits<int>();
												int[] addedValues = new int[] { 1, 2, 3 };

												target[5] = addedValues[0];
												target.AddOnNextLevel(addedValues[1]);
												target.AddOnNextLevel(addedValues[2]);

												int[] expected = addedValues;
												int[] actual = new int[] { target[5], target[6], target[7] };

												CollectionAssert.AreEqual(expected, actual);
								}
				}
}