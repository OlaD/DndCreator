using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndCreator.Model;
using System.ComponentModel;

namespace DndCreator.ViewModel
{
				class ClassViewModel : INotifyPropertyChanged
				{
								private static ClassViewModel instance;
								public static ClassViewModel Instance
								{
												get
												{
																if (instance == null)
																{
																				instance = new ClassViewModel();
																}
																return instance;
												}
								}

								public List<Class> ClassesToChoose
								{
												get { return Class.ClassesList; }
								}

								private Class selectedClass;
								public Class SelectedClass
								{
												get { return selectedClass; }
												set
												{
																selectedClass = value;
																OnPropertyChanged("SelectedClass");
												}
								}

								private ClassDescriptionType selectedDescription;
								public ClassDescriptionType SelectedDescription
								{
												get { return selectedDescription; }
												set
												{
																selectedDescription = value;
																OnPropertyChanged("SelectedDescription");
												}
								}

								public string ShownDescription
								{
												get
												{
																if (SelectedClass != null && SelectedClass.Description.ContainsKey(SelectedDescription))
																	  	return SelectedClass.Description[SelectedDescription];
																else
																				return "-";
												}
								}

								private ClassViewModel() { }

								public event PropertyChangedEventHandler PropertyChanged;
								private void OnPropertyChanged(string property)
								{
												var handler = PropertyChanged;
												if (handler != null)
																PropertyChanged(this, new PropertyChangedEventArgs(property));
								}
				}
}
