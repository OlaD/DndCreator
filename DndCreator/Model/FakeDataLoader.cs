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

												Dictionary<ClassDescriptionType, string> bardDescr = new Dictionary<ClassDescriptionType, string>();
												bardDescr.Add(ClassDescriptionType.GeneralDescription, "opis barda");
												bardDescr.Add(ClassDescriptionType.Adventures, "przygody barda");
												bardDescr.Add(ClassDescriptionType.Religion, "religia barda");
												List<Skill> bardSkills = new List<Skill>();
												bardSkills.Add(new Skill("Umiejętność barda", new Ability("Charyzma", "Cha")));
												Class.ClassesList.Add(
																new Class("Bard", bardDescr, "atrybuty barda", "charakter barda", 1, 
																										new ClassStartingGold(new Dices(4,4), 10),
																										bardSkills, 1));

												Dictionary<ClassDescriptionType, string> barbarianDescr = new Dictionary<ClassDescriptionType, string>();
												barbarianDescr.Add(ClassDescriptionType.GeneralDescription, "opis barbarzyńcy");
												barbarianDescr.Add(ClassDescriptionType.Adventures, "przygody barbarzyńcy");
												barbarianDescr.Add(ClassDescriptionType.Religion, "religia barbarzyńcy");
												List<Skill> barbarianSkills = new List<Skill>();
												barbarianSkills.Add(new Skill("Umiejętność barbarzyńcy", new Ability("Siła", "S")));
												Class.ClassesList.Add(
																new Class("Barbarzyńca", barbarianDescr, "atrybuty barbarzyńcy", "charakter barbarzyńcy", 2,
																										new ClassStartingGold(new Dices(4, 4), 10),
																								  barbarianSkills, 2));

												Dictionary<ClassDescriptionType, string> wizardDescr = new Dictionary<ClassDescriptionType, string>();
												wizardDescr.Add(ClassDescriptionType.GeneralDescription, "opis czarodzieja");
												wizardDescr.Add(ClassDescriptionType.Adventures, "przygody czarodzieja");
												wizardDescr.Add(ClassDescriptionType.Religion, "religia czarodzieja");
												List<Skill> wizardSkills = new List<Skill>();
												wizardSkills.Add(new Skill("Umiejętność czarodzieja", new Ability("Inteligencja", "Int")));
												Class.ClassesList.Add(
																new Class("Czarodziej", wizardDescr, "atrybuty czarodzieja", "charakter czarodzieja", 3,
																										new ClassStartingGold(new Dices(3, 4), 10),
																										wizardSkills, 3));
								}
				}
}
