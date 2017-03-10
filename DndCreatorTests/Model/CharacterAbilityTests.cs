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
				public class CharacterAbilityTests
				{
								// TODO testy:
								// - GetValueModifier z pustym Value -> błąd/null
								// - GetTotalModifier z pustym Value -> błąd/null
								// - GetTotalModifier z brakiem dodatkowych modyfikatorów -> Value

								[TestMethod()]
								public void GetTotalModifierTest()
								{
												CharacterAbility target = new CharacterAbility(new Ability("","",""));
												int abilityValue = 13;
												int[] modifiersValues = new int[] { 1, 4, 16, -10, 0 };

												target.Value = abilityValue;
												int abilityValueModifier = target.GetValueModifier();

												foreach (int value in modifiersValues)
																target.Modifiers.Add(new Modifier(value, ""));

												int expected = abilityValueModifier + modifiersValues.Sum();
												int actual = target.GetTotalModifier();

												Assert.AreEqual(expected, actual);
								}

								[TestMethod()]
								public void GetValueModifierTest()
								{
												CharacterAbility target = new CharacterAbility(new Ability("", "", ""));

												Dictionary<int, int> expected = new Dictionary<int, int>
																{ {1,-5}, {2,-4}, {3,-4}, {4,-3}, {5,-3},
																		{6,-2}, {7,-2}, {8,-1}, {9,-1}, {10,0},
																		{11,0}, {12,1}, {13,1}, {14,2}, {15,2} };

												Dictionary<int, int> actual = new Dictionary<int, int>();
												for (int i = 1; i <= 15; i++)
												{
																target.Value = i;
																actual.Add(target.Value, target.GetValueModifier());
												}

												CollectionAssert.AreEqual(expected, actual);
								}
				}
}