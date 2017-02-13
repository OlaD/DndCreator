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
								public BaseAttackBonusType BaseAttack { get; }
								public BaseSaveBonusType Fortitude { get; }
								public BaseSaveBonusType Reflex { get; }
								public BaseSaveBonusType Will { get; }

								public Class(string name,
																				Dictionary<ClassDescriptionType, string> description,
																				string abilitiesRule, string alignmentRule, uint hitDieSides,
																				ClassStartingGold startingGold,
																				ClassSkills classSkills,
																				List<ClassFeature> features, LevelBenefits<List<Feature>> featuresOnLevels,
																				BaseAttackBonusType baseAttack, 
																				BaseSaveBonusType fortitude, BaseSaveBonusType reflex, BaseSaveBonusType will)
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
												BaseAttack = baseAttack;
												Fortitude = fortitude;
												Reflex = reflex;
												Will = will;
								}

								public List<uint> BaseAttackBonus(uint classLevel)
								{
												List<uint> baseAttackBonus = new List<uint>();
												int attackNumber = 1;
												uint nextAttack = FirstBaseAttackBonus(classLevel);
												do
												{
																baseAttackBonus.Add(nextAttack);
																attackNumber++;
																nextAttack -= 5;
												} while (nextAttack > 0);
												return baseAttackBonus;
								}

								private uint FirstBaseAttackBonus(uint classLevel)
								{
												uint bonus;
												bonus = classLevel;
												switch (BaseAttack)
												{
																case BaseAttackBonusType.Average:
																				bonus *= 3 / 4;
																				break;
																case BaseAttackBonusType.Poor:
																				bonus *= 1 / 2;
																				break;
												}
												return bonus;
								}
				}
}
