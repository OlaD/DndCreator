using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCreator.Model
{
				class DataLoader
				{
								public void LoadData()
								{
												LoadRaces();
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
				}
}
