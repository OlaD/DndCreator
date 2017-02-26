﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using DndCreator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCreator.Model.Tests
{
				[TestClass()]
				public class DicesTests
				{
								[TestMethod()]
								public void OneDice_ToStringTest()
								{
												Dices target = new Dices(1, 6);

												string expected = "k6";
												string actual = target.ToString();
												Assert.AreEqual(expected, actual);
								}

								[TestMethod()]
								public void ManyDice_ToStringTest()
								{
												Dices target = new Dices(4, 6);

												string expected = "4k6";
												string actual = target.ToString();
												Assert.AreEqual(expected, actual);
								}

								[TestMethod()]
								public void OneDice_AverageThrowTest()
								{
												Dices target = new Dices(1, 4);

												float expected = 2.5f;
												float actual = target.AverageRoll();
												Assert.AreEqual(expected, actual);
								}

								[TestMethod()]
								public void ManyDice_AverageThrowTest()
								{
												Dices target = new Dices(6, 4);

												float expected = 15;
												float actual = target.AverageRoll();
												Assert.AreEqual(expected, actual);
								}

								[TestMethod()]
								public void SumRollsTest()
								{
												Dices target = new Dices(6, 4);
												List<int> rolls = target.RollDices();

												int expected = rolls.Sum();
												int actual = target.SumRolls();
												Assert.AreEqual(expected, actual);
								}

								[TestMethod()]
								public void RemoveTheLowestRollTest()
								{
												Dices target = new Dices(6, 4);
												List<int> rolls = target.RollDices();

												rolls.Remove(rolls.Min());
												target.RemoveTheLowestRoll();

												List<int> expected = rolls;
												List<int> actual = target.Rolls;
												CollectionAssert.AreEqual(expected, actual);
								}
				}
}