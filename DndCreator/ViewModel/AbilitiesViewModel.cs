using System;
using DndCreator.Model;
using System.ComponentModel;

namespace DndCreator.ViewModel
{
				class AbilitiesViewModel
				{
								public string GetAbilityDescription(string selectedAbilityType)
								{
												AbilityType ability;
												if (Enum.TryParse<AbilityType>(selectedAbilityType, out ability))
												{
																return Ability.Abilities[ability].Description;
												}
												else
																return "-";
								}
				}
}
