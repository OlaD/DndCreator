using System.Collections.Generic;

namespace DndCreator.Model
{
				public class Ability
				{
								public static Dictionary<AbilityType, Ability> Abilities { get; set; }

								public string Name { get; }
								public string Abbreviation { get; }
								public string Description { get; }

								public Ability(string name, string abbreviation, string description)
								{
												Name = name;
												Abbreviation = abbreviation;
												Description = description;
								}
				}
}
