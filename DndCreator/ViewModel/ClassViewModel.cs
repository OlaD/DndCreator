using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndCreator.Model;
using System.ComponentModel;
using System.Windows.Data;

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

								private List<ClassLevelBenefitsRow> levelBenefitsRows;
								public ICollectionView LevelBenefitsRows { get; private set; }

								private int maxLevel = 20;

								private ClassViewModel()
								{
												CreateLevelBenefitsTable();
								}

								private void CreateLevelBenefitsTable()
								{
												levelBenefitsRows = new List<ClassLevelBenefitsRow>();
												LevelBenefitsRows = CollectionViewSource.GetDefaultView(levelBenefitsRows);

												for(uint level = 1; level <= maxLevel; level++)
												{
																ClassLevelBenefitsRow emptyRow = new ClassLevelBenefitsRow(level);
																levelBenefitsRows.Add(emptyRow);
												}
								}

								public void ChangeLevelBenefitsRows()
								{
												for (uint level = 1; level <= maxLevel; level++)
												{
																ClassLevelBenefitsRow row = levelBenefitsRows[(int)level-1];
																List<uint> baseAttack = SelectedClass.GetBaseAttackBonus(level);
																uint fortitude = SelectedClass.GetFortitudeBonus(level);
																uint reflex = SelectedClass.GetReflexeBonus(level);
																uint will = SelectedClass.GetWillBonus(level);
																List<ClassFeature> features = SelectedClass.FeaturesOnLevels[level];
																LevelBenefits<uint?> spellsPerDay;
																if (SelectedClass is SpellClass)
																{
																				SpellClass spellClass = (SpellClass)SelectedClass;
																				spellsPerDay = spellClass.SpellsPerDay[level];
																}
																else
																				spellsPerDay = null;
																				
																row.ChangeRow(baseAttack, fortitude, reflex, will, features, spellsPerDay);
												}
												LevelBenefitsRows = CollectionViewSource.GetDefaultView(levelBenefitsRows);
								}

								public event PropertyChangedEventHandler PropertyChanged;
								private void OnPropertyChanged(string property)
								{
												var handler = PropertyChanged;
												if (handler != null)
																PropertyChanged(this, new PropertyChangedEventArgs(property));
								}
				}
}
