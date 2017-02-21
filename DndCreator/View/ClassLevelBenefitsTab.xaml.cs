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
								public ClassLevelBenefitsTab()
								{
												InitializeComponent();
								}

								public void RefreshLevelBenefitsTable()
								{
												LevelBenefits.Items.Refresh();		
								}
				}
}
