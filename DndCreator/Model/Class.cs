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
								public LevelBenefits<List<ClassFeature>> FeaturesOnLevels { get; }
								public BaseAttackBonusType BaseAttack { get; }
								public BaseSaveThrowBonusType Fortitude { get; }
								public BaseSaveThrowBonusType Reflex { get; }
								public BaseSaveThrowBonusType Will { get; }

								public Class(string name,
																				Dictionary<ClassDescriptionType, string> description,
																				string abilitiesRule, string alignmentRule, uint hitDieSides,
																				ClassStartingGold startingGold,
																				ClassSkills classSkills,
																				List<ClassFeature> features, LevelBenefits<List<ClassFeature>> featuresOnLevels,
																				BaseAttackBonusType baseAttack, 
																				BaseSaveThrowBonusType fortitude, BaseSaveThrowBonusType reflex, BaseSaveThrowBonusType will)
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

								public List<uint> GetBaseAttackBonus(uint classLevel)
								{
												List<uint> baseAttackBonus = new List<uint>();
												int attackNumber = 1;
												int nextAttack = (int)GetFirstBaseAttackBonus(classLevel);
												do
												{
																baseAttackBonus.Add((uint)nextAttack);
																attackNumber++;
																nextAttack -= 5;
												} while (nextAttack > 0);
												return baseAttackBonus;
								}

								private uint GetFirstBaseAttackBonus(uint classLevel)
								{
												uint bonus;
												bonus = classLevel;
												switch (BaseAttack)
												{
																case BaseAttackBonusType.Average:
																				bonus = bonus * 3 / 4;
																				break;
																case BaseAttackBonusType.Poor:
																				bonus = bonus / 2;
																				break;
												}
												return bonus;
								}

								public uint GetFortitudeBonus(uint classLevel)
								{
												return GetSaveThrowBonus(Fortitude, classLevel);
								}

								private uint GetSaveThrowBonus(BaseSaveThrowBonusType saveThrowType, uint classLevel)
								{
												uint bonus = classLevel;
												switch(saveThrowType)
												{
																case BaseSaveThrowBonusType.Good:
																				bonus = (uint)(bonus / 2) + 2;
																				break;
																case BaseSaveThrowBonusType.Poor:
																				bonus = (uint)(bonus / 3);
																				break;
												}
												return bonus;
								}

								public uint GetReflexeBonus(uint classLevel)
								{
												return GetSaveThrowBonus(Reflex, classLevel);
								}

								public uint GetWillBonus(uint classLevel)
								{
												return GetSaveThrowBonus(Will, classLevel);
								}
				}
}
