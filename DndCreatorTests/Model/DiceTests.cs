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
				public class DiceTests
				{
								[TestMethod()]
								public void ToStringTest()
								{
												Dice target = new Dice(6);
												string expected = "k6";
												string actual = target.ToString();
												Assert.AreEqual(expected, actual);
								}

								[TestMethod()]
								public void AverageThrowTest()
								{
												Dice target = new Dice(6);
												float expected = 3.5f;
												float actual = target.AverageThrow();
												Assert.AreEqual(expected, actual);
								}
				}
}