using System.Collections.Generic;

namespace DndCreator.Model
{
				class FakeDataLoader : IDataLoader
				{
								public void LoadData()
								{
												LoadRaces();
												LoadClasses();
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
												Class.ClassesList.Add(CreateFakeClass("bard", 1));
												Class.ClassesList.Add(CreateFakeClass("czarodziej", 2));
												Class.ClassesList.Add(CreateFakeClass("wojownik", 3));
								}

								private Class CreateFakeClass(string name, uint number)
								{
												string genitiveName = name + "a";
												
												Dictionary<ClassDescriptionType, string> descr = new Dictionary<ClassDescriptionType, string>();
												descr.Add(ClassDescriptionType.GeneralDescription, "opis " + genitiveName);
												descr.Add(ClassDescriptionType.Adventures, "przygody " + genitiveName);
												descr.Add(ClassDescriptionType.Religion, "religia " + genitiveName);

												List<Skill> skillList = new List<Skill>();
												skillList.Add(new Skill("umiejętność " + genitiveName, new Ability("atut" + number, "at" + number)));
												ClassSkills skills = new ClassSkills(number, skillList);

												string abilitiesRule = "atrybuty " + genitiveName;
												string alignmentRule = "charakter " + genitiveName;

												ClassStartingGold st = new ClassStartingGold(new Dices(number, number), number);

												List<ClassFeature> features = new List<ClassFeature>();
												LevelBenefits<string> featureLevelBenefits = new LevelBenefits<string>();
												featureLevelBenefits.Add(number + "/dzień");
												featureLevelBenefits.Add("+" + number);
												features.Add(new ClassFeature("właściwość " + genitiveName, "...", featureLevelBenefits));
												features.Add(new ClassFeature("właściwość1 " + genitiveName, "...", null));
												features.Add(new ClassFeature("właściwość2 " + genitiveName, "...", null));

												LevelBenefits<List<Feature>> featuresOnLevels = new LevelBenefits<List<Feature>>();
												featuresOnLevels.Add(new List<Feature>());
												featuresOnLevels.Add(new List<Feature>());
												featuresOnLevels.Add(new List<Feature>());
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

												BaseSaveBonusType saveBonus;
												if (number % 2 == 0)
																saveBonus = BaseSaveBonusType.Good;
												else
																saveBonus = BaseSaveBonusType.Poor;

												Class c = new Class(name, descr, abilitiesRule, alignmentRule, number, st, skills, features, featuresOnLevels, baseAttack, saveBonus, saveBonus, saveBonus);
												return c;
								}
				}
}
