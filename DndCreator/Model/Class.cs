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
								public string AbilitiesRule { get; }
								public string AlignmentRule { get; }
								public Dice HitDie { get; }
								public ClassStartingGold StartingGold { get; }
								public List<Skill> ClassSkills { get; }
								public uint SkillPoints { get; }

								public Class(string name,
																				Dictionary<ClassDescriptionType, string> description,
																				string abilitiesRule, string alignmentRule, uint hitDieSides,
																				ClassStartingGold startingGold,
																				List<Skill> classSkills, uint skillPoints)
								{
												Name = name;
												Description = description;
												AbilitiesRule = abilitiesRule;
												AlignmentRule = alignmentRule;
												HitDie = new Dice(hitDieSides);
												StartingGold = startingGold;
												ClassSkills = classSkills;
												SkillPoints = skillPoints;
								}
				}
}
