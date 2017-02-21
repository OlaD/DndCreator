using System.Windows.Controls;
using DndCreator.ViewModel;

namespace DndCreator.View
{
				/// <summary>
				/// Interaction logic for ClassLevelBenefitsTab.xaml
				/// </summary>
				/// 
				public partial class ClassLevelBenefitsTab : UserControl
				{
								System.Windows.Visibility spellColumnsVisibility;
								public bool IsSpellColumnsVisible 
								{
												set 
												{
																if (value == true)
																				spellColumnsVisibility = System.Windows.Visibility.Visible;
																else
																				spellColumnsVisibility = System.Windows.Visibility.Hidden;
												}
								}

								public ClassLevelBenefitsTab()
								{
												InitializeComponent();
								}

								public void RefreshLevelBenefitsTable()
								{
												LevelBenefits.Items.Refresh();

												SpellsPerDay0.Visibility = spellColumnsVisibility;
												SpellsPerDay1.Visibility = spellColumnsVisibility;
												SpellsPerDay2.Visibility = spellColumnsVisibility;
												SpellsPerDay3.Visibility = spellColumnsVisibility;
												SpellsPerDay4.Visibility = spellColumnsVisibility;
												SpellsPerDay5.Visibility = spellColumnsVisibility;
												SpellsPerDay6.Visibility = spellColumnsVisibility;
												SpellsPerDay7.Visibility = spellColumnsVisibility;
												SpellsPerDay8.Visibility = spellColumnsVisibility;
												SpellsPerDay9.Visibility = spellColumnsVisibility;
								}
				}
}
