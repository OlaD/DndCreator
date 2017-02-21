using System;
using System.Windows;
using System.Windows.Controls;
using DndCreator.Model;
using DndCreator.ViewModel;
using System.ComponentModel;

namespace DndCreator.View
{
				/// <summary>
				/// Interaction logic for ClassPage.xaml
				/// </summary>
				public partial class ClassPage : Page
				{
								private ClassViewModel viewModel;

								public ClassPage()
								{
												InitializeComponent();
												viewModel = ClassViewModel.Instance;
												this.DataContext = viewModel;
												viewModel.PropertyChanged += new PropertyChangedEventHandler(ClassViewModel_PropertyChanged);

												LevelBenefitsTab.DataContext = viewModel;
								}

								private void ClassViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
								{
												switch (e.PropertyName)
												{
																case "SelectedClass":
																				DescriptionTab.ShownDescription = viewModel.ShownDescription;
																				viewModel.ChangeLevelBenefitsRows();
																				if (viewModel.SelectedClass is SpellClass)
																								LevelBenefitsTab.IsSpellColumnsVisible = true;
																				else
																								LevelBenefitsTab.IsSpellColumnsVisible = false;
																				LevelBenefitsTab.RefreshLevelBenefitsTable();
																				break;
																case "SelectedDescription":
																				DescriptionTab.ShownDescription = viewModel.ShownDescription;
																				break;
												}
								}

								private void DescriptionTab_ChangeDescription(object sender, RoutedEventArgs e)
								{
												RadioButton selectedButton = (RadioButton)e.OriginalSource;
												ClassDescriptionType selectedDescription;
												if (Enum.TryParse<ClassDescriptionType>(selectedButton.Name, out selectedDescription))
																viewModel.SelectedDescription = selectedDescription;
												else
																throw new NotImplementedException();
								}

								private void Confirm_Click(object sender, RoutedEventArgs e)
								{
												Character character = Character.Instance;
												character.Class = (Class)ClassesToChoose.SelectedItem;
								}
				}
}
