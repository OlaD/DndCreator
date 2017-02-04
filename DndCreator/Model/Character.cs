using System.ComponentModel;

namespace DndCreator.Model
{
				class Character : INotifyPropertyChanged
				{
								private static Character instance;
								private Character() { }
								public static Character Instance
								{
												get
												{
																if (instance == null)
																{
																				instance = new Character();
																}
																return instance;
												}
								}

								private Race race;
								public Race Race
								{ 
												get { return race; } 
												set
												{
																if (race != value)
																{
																				race = value;
																				OnPropertyChanged("Race");
																}
												} 
								}

								public event PropertyChangedEventHandler PropertyChanged;

								private void OnPropertyChanged(string property)
								{
												if (PropertyChanged != null)
												{
																PropertyChanged(this, new PropertyChangedEventArgs(property));
												}
								}
				}
}
