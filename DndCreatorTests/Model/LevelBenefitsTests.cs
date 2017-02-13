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
								public void AddTest()
								{
												LevelBenefits<int> target = new LevelBenefits<int>();
												int addedNumber = 5;
												target.Add(addedNumber);

												int expected = addedNumber;
												int actual = target[1];

												Assert.AreEqual(expected, actual);
								}

								[TestMethod()]
								public void NonExistedLevelTest()
								{
												LevelBenefits<int> target = new LevelBenefits<int>();
												int addedNumber = 5;
												target.Add(addedNumber);

												int expected = null;
												int actual = target[1];

												Assert.AreEqual(expected, actual);
								}
				}
}