using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DndCreator.View
{
				/// <summary>
				/// Interaction logic for CharacterPanel.xaml
				/// </summary>
				public partial class CharacterPanel : UserControl
				{
								public readonly static RoutedEvent PreviewEvent =
												EventManager.RegisterRoutedEvent(
																"PreviewEvent",
																RoutingStrategy.Tunnel,
																typeof(RoutedEventHandler),
																typeof(CharacterPanel));

								public CharacterPanel()
								{
												InitializeComponent();

												Model.Character.Instance.PropertyChanged += new PropertyChangedEventHandler(character_PropertyChanged);
								}

								private void characterRace_Click(object sender, RoutedEventArgs e)
								{
												this.RaiseEvent(new RoutedEventArgs(PreviewEvent));
								}

								private void character_PropertyChanged(object sender, PropertyChangedEventArgs e)
								{
												switch(e.PropertyName)
												{
																case "Race":
																				characterRace.Content = Model.Character.Instance.Race.Name;
																				break;
												}
								}
				}
}
