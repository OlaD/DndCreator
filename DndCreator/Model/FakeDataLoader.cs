using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
												Class.ClassesList.Add(new Class("Bard", bardDescr));

												Dictionary<ClassDescriptionType, string> barbarianDescr = new Dictionary<ClassDescriptionType, string>();
												barbarianDescr.Add(ClassDescriptionType.GeneralDescription, "opis barbarzyńcy");
												barbarianDescr.Add(ClassDescriptionType.Adventures, "przygody barbarzyńcy");
												barbarianDescr.Add(ClassDescriptionType.Religion, "religia barbarzyńcy");
												Class.ClassesList.Add(new Class("Barbarzyńca", barbarianDescr));

												Dictionary<ClassDescriptionType, string> wizardDescr = new Dictionary<ClassDescriptionType, string>();
												wizardDescr.Add(ClassDescriptionType.GeneralDescription, "opis maga");
												wizardDescr.Add(ClassDescriptionType.Adventures, "przygody maga");
												wizardDescr.Add(ClassDescriptionType.Religion, "religia maga");
												Class.ClassesList.Add(new Class("Czarodziej", wizardDescr));
								}
				}
}
