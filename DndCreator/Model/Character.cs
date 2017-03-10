using System.Collections.Generic;
using System.ComponentModel;

namespace DndCreator.Model
{
				class Character : INotifyPropertyChanged
				{
								private static Character _instance;
								public static Character Instance
								{
												get
												{
																if (_instance == null)
																{
																				_instance = new Character();
																}
																return _instance;
												}
								}

								private Race _race;
								public Race Race
								{
												get { return _race; }
												set
												{
																if (_race != value)
																{
																				_race = value;
																				OnPropertyChanged("Race");
																}
												}
								}

								private Class _class;
								public Class Class
								{
												get { return _class; }
												set
												{
																if (_class != value)
																{
																				_class = value;
																				OnPropertyChanged("Class");
																}
												}
								}

								//public Dictionary<AbilityType, CharacterAbility> Abilities { get; }

								private Character()
								{
												//foreach(AbilityType abilityType in Ability.Abilities.Keys)
												//{
												//				Ability ability = Ability.Abilities[abilityType];
												//				Abilities.Add(abilityType, new CharacterAbility(ability));
												//}
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
