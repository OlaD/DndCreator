using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCreator.Model
{
				public class Ability
				{
								public static List<Ability> Abilities { get; set; }

								public string Name { get; }
								public string Abbreviation { get; }

								public Ability(string name, string abbreviation)
								{
												Name = name;
												Abbreviation = abbreviation;
								}
				}
}
