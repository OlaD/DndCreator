using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCreator.Model
{
				class Class
				{
								public static List<Class> ClassesList { get; set; }

								public string Name { get; }
								public Dictionary<ClassDescriptionType, string> Description { get; }

								public Class(string name, Dictionary<ClassDescriptionType, string> description)
								{
												Name = name;
												Description = description;
								}
				}
}
