using System.Collections.Generic;

namespace DndCreator.Model
{
				class FakeDataLoader : IDataLoader
				{
								public void LoadData()
								{
												LoadAbilities();
												LoadRaces();
												LoadClasses();
								}

								private void LoadAbilities()
								{
												Ability.Abilities = new Dictionary<AbilityType, Ability>();
												Dictionary<AbilityType, Ability> abilities = Ability.Abilities;
												abilities.Add(AbilityType.Strength, new Ability("Siła", "S", "Opis siły"));
												abilities.Add(AbilityType.Dexterity, new Ability("Zręczność", "Zr", "Opis zręczności"));
												abilities.Add(AbilityType.Constitution, new Ability("Budowa", "Bd", "Opis budowy"));
												abilities.Add(AbilityType.Intelligence, new Ability("Intelekt", "Int", "Opis intelektu"));
												abilities.Add(AbilityType.Wisdom, new Ability("Roztropność", "Rzt", "Opis roztropności"));
												abilities.Add(AbilityType.Charisma, new Ability("Charyzma", "Cha", "Opis charyzmy"));
								}

								private void LoadRaces()
								{
												Race.RacesList = new List<Race>();

												Dictionary<RaceDescriptionType, string> humanDescr = new Dictionary<RaceDescriptionType, string>();
												humanDescr.Add(RaceDescriptionType.GeneralDescription, "człowieki są fajne");
												humanDescr.Add(RaceDescriptionType.Adventurers, "przygody!");
												Race.RacesList.Add(new Race("Człowiek", humanDescr));

												Dictionary<RaceDescriptionType, string> elfDescr = new Dictionary<RaceDescriptionType, string>();
												elfDescr.Add(RaceDescriptionType.GeneralDescription, "elfy to geje");
												Race.RacesList.Add(new Race("Elf", elfDescr));

												Dictionary<RaceDescriptionType, string> dwarfDescr = new Dictionary<RaceDescriptionType, string>();
												dwarfDescr.Add(RaceDescriptionType.GeneralDescription, "krasie");
												Race.RacesList.Add(new Race("Krasnolud", dwarfDescr));
								}

								private void LoadClasses()
								{
												Class.ClassesList = new List<Class>();
												Class.ClassesList.Add(CreateFakeClass("bard", 1, true));
												Class.ClassesList.Add(CreateFakeClass("czarodziej", 2, true));
												Class.ClassesList.Add(CreateFakeClass("wojownik", 3, false));
								}

								private Class CreateFakeClass(string name, uint number, bool spellClass)
								{
												Class c;

												string genitiveName = name + "a";
												
												Dictionary<ClassDescriptionType, string> descr = new Dictionary<ClassDescriptionType, string>();
												descr.Add(ClassDescriptionType.GeneralDescription, "opis " + genitiveName);
												descr.Add(ClassDescriptionType.Adventures, "przygody " + genitiveName);
												descr.Add(ClassDescriptionType.Religion, "religia " + genitiveName);

												List<Skill> skillList = new List<Skill>();
												skillList.Add(new Skill("umiejętność " + genitiveName, Ability.Abilities[AbilityType.Strength]));
												ClassSkills skills = new ClassSkills(number, skillList);

												string abilitiesRule = "atrybuty " + genitiveName;
												string alignmentRule = "charakter " + genitiveName;

												ClassStartingGold st = new ClassStartingGold(new Dices(number, number), number);

												List<ClassFeature> features = new List<ClassFeature>();
												LevelBenefits<string> featureLevelBenefits = new LevelBenefits<string>();
												featureLevelBenefits.AddOnNextLevel(number + "/dzień");
												featureLevelBenefits.AddOnNextLevel("+" + number);
												features.Add(new ClassFeature("właściwość " + genitiveName, "...", featureLevelBenefits));
												features.Add(new ClassFeature("właściwość1 " + genitiveName, "...", null));
												features.Add(new ClassFeature("właściwość2 " + genitiveName, "...", null));
												features.Add(new ClassFeature("właściwość3 " + genitiveName, "...", null));

												LevelBenefits<List<ClassFeature>> featuresOnLevels = new LevelBenefits<List<ClassFeature>>();
												featuresOnLevels.AddOnNextLevel(new List<ClassFeature>());
												featuresOnLevels.AddOnNextLevel(new List<ClassFeature>());
												featuresOnLevels.AddOnNextLevel(new List<ClassFeature>());
												featuresOnLevels.AddOnNextLevel(new List<ClassFeature>());
												featuresOnLevels[1].Add(features[0]);
												featuresOnLevels[2].Add(features[0]);
												featuresOnLevels[2].Add(features[1]);
												featuresOnLevels[3].Add(features[2]);

												BaseAttackBonusType baseAttack;
												switch(number % 3)
												{
																case 0:
																				baseAttack = BaseAttackBonusType.Good;
																				break;
																case 1:
																				baseAttack = BaseAttackBonusType.Average;
																				break;
																default:
																				baseAttack = BaseAttackBonusType.Poor;
																				break;
												}

												BaseSaveThrowBonusType saveBonus;
												if (number % 2 == 0)
																saveBonus = BaseSaveThrowBonusType.Good;
												else
																saveBonus = BaseSaveThrowBonusType.Poor;

												if (spellClass)
												{
																LevelBenefits<LevelBenefits<uint?>> spellsPerDay = new LevelBenefits<LevelBenefits<uint?>>();
																for (uint classLevel = 1; classLevel <= 20; classLevel++)
																{
																				spellsPerDay[classLevel] = new LevelBenefits<uint?>();
																				for (uint spellLevel = 0; spellLevel <= 9; spellLevel++)
																				{
																								int spells = (int)classLevel - (int)spellLevel;
																								if (spells < 0)
																												spellsPerDay[classLevel][spellLevel] = null;
																								else
																												spellsPerDay[classLevel][spellLevel] = (uint)spells;
																				}
																}

																c = new SpellClass(name, descr, abilitiesRule, alignmentRule, number, st, skills, features, featuresOnLevels, baseAttack, saveBonus, saveBonus, saveBonus, spellsPerDay);
												}
												else
																c = new Class(name, descr, abilitiesRule, alignmentRule, number, st, skills, features, featuresOnLevels, baseAttack, saveBonus, saveBonus, saveBonus);

												return c;
								}
				}
}
