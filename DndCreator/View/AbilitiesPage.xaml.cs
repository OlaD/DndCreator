using System.Windows;
using System.Windows.Controls;
using DndCreator.ViewModel;

namespace DndCreator.View
{
				/// <summary>
				/// Interaction logic for AbilityPage.xaml
				/// </summary>
				public partial class AbilityPage : Page
				{
								private AbilitiesViewModel viewModel;

								public AbilityPage()
								{
												InitializeComponent();
												viewModel = new AbilitiesViewModel();
												DataContext = viewModel;
								}

								private void AbilityButton_Checked(object sender, RoutedEventArgs e)
								{
												RadioButton selectedButton = (RadioButton)sender;
												AbilityDescription.Text = viewModel.GetAbilityDescription(selectedButton.Name);
								}
				}
}
