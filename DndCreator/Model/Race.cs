using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCreator.Model
{
				public class Race
				{
								public static List<Race> RacesList;	// TODO get

								public string Name { get; }
								public Dictionary<RaceDescriptionType, string> Description { get; }

								public Race(string name, Dictionary<RaceDescriptionType, string> description)
								{
												Name = name;
												Description = description;
								}
				}
}
