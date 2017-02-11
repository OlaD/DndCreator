using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace DndCreator.View
{
				/// <summary>
				/// Interaction logic for ClassLevelBenefitsTab.xaml
				/// </summary>
				/// 
				public partial class ClassLevelBenefitsTab : UserControl
				{
								public List<int> Levels
								{
												get { return Enumerable.Range(1, 20).ToList(); }
								}

								public ClassLevelBenefitsTab()
								{
												InitializeComponent();
								}
				}
}
