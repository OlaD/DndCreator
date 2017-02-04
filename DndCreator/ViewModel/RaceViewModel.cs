using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndCreator.Model;
using System.ComponentModel;

namespace DndCreator.ViewModel
{
				public class RaceViewModel : INotifyPropertyChanged
				{
								private static RaceViewModel instance;
								public static RaceViewModel Instance
								{
												get
												{
																if(instance == null)
																{
																				instance = new RaceViewModel();
																}
																return instance;
												}
								}

								public List<Race> RacesToChoose { get; set; }

								private Race selectedRace;
								public Race SelectedRace 
								{ 
												get { return selectedRace; }
												set
												{
																selectedRace = value;
																UpdateDescription();
												} 
								}

								private void UpdateDescription()
								{
												if (SelectedRace != null && SelectedRace.Description.ContainsKey(SelectedDescription))
																ShownDescription = selectedRace.Description[SelectedDescription];
												else
																ShownDescription = "-";
								}

								private RaceDescriptionType selectedDescription;
								public RaceDescriptionType SelectedDescription
								{
												get { return selectedDescription; }
												set
												{
																selectedDescription = value;
																UpdateDescription();
												}
								}

								private string shownDescription;
								public string ShownDescription 
								{
												get { return shownDescription; }
												set
												{
																if (value != shownDescription)
																{
																				shownDescription = value;
																				OnPropertyChanged("ShownDescription");
																}
												}
								}

								private RaceViewModel()
								{
												RacesToChoose = Race.RacesList;
								}

								public event PropertyChangedEventHandler PropertyChanged;
								private void OnPropertyChanged(string property)
								{
												var handler = PropertyChanged;
												if (handler != null)
												{
																PropertyChanged(this, new PropertyChangedEventArgs(property));
												}
								}
				}
}
