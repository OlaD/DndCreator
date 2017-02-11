using System.Collections.Generic;

namespace DndCreator.Model
{
				public class Class
				{
								public static List<Class> ClassesList { get; set; }

								public string Name { get; }
								public Dictionary<ClassDescriptionType, string> Description { get; }
								public string AbilitiesRule { get; }
								public string AlignmentRule { get; }
								public Dice HitDie { get; }
								public ClassStartingGold StartingGold { get; }
								public ClassSkills ClassSkills { get; }
								public List<ClassFeature> Features { get; }
								public LevelBenefits<List<Feature>> FeaturesOnLevels { get; }

								public Class(string name,
																				Dictionary<ClassDescriptionType, string> description,
																				string abilitiesRule, string alignmentRule, uint hitDieSides,
																				ClassStartingGold startingGold,
																				ClassSkills classSkills,
																				List<ClassFeature> features, LevelBenefits<List<Feature>> featuresOnLevels)
								{
												Name = name;
												Description = description;
												AbilitiesRule = abilitiesRule;
												AlignmentRule = alignmentRule;
												HitDie = new Dice(hitDieSides);
												StartingGold = startingGold;
												ClassSkills = classSkills;
												Features = features;
												FeaturesOnLevels = featuresOnLevels;
								}
				}
}
