using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCreator.Model
{
				public class CharacterAbility
				{
								public Ability Ability { get; }
								public int Value { get; set; }
								public List<Modifier> Modifiers { get; }

								public CharacterAbility(Ability ability)
								{
												Ability = ability;
												Modifiers = new List<Modifier>();
								}

								public int GetTotalModifier()
								{
												int totalModifier = 0;
												foreach(Modifier modifier in Modifiers)
																totalModifier += modifier.Value;
												totalModifier += GetValueModifier();
												return totalModifier;
								}

								public int GetValueModifier()
								{
												return Value/2 - 5;
								}
				}
}
