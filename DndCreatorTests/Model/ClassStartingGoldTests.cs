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
				public class ClassStartingGoldTests
				{
								[TestMethod()]
								public void MultiplierEqualOne_FormulaTest()
								{
												ClassStartingGold target = new ClassStartingGold(new Dices(5, 4), 1);
												string expected = "5k4";
												string actual = target.Formula;
												Assert.AreEqual(expected, actual);
								}

								[TestMethod()]
								public void MultiplierGreaterThanOne_FormulaTest()
								{
												ClassStartingGold target = new ClassStartingGold(new Dices(5, 4), 10);
												string expected = "5k4 x 10";
												string actual = target.Formula;
												Assert.AreEqual(expected, actual);
								}

								[TestMethod()]
								public void MultiplierEqualOne_AverageAmountTest()
								{
												ClassStartingGold target = new ClassStartingGold(new Dices(5, 4), 1);
												float expected = 12.5f;
												float actual = target.AverageAmount;
												Assert.AreEqual(expected, actual);
								}

								public void MultiplierGreaterThanOne_AverageAmountTest()
								{
												ClassStartingGold target = new ClassStartingGold(new Dices(5, 4), 10);
												float expected = 125f;
												float actual = target.AverageAmount;
												Assert.AreEqual(expected, actual);
								}
				}
}