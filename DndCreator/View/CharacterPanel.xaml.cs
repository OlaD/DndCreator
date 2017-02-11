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
								public CharacterPanel()
								{
												InitializeComponent();

												Model.Character.Instance.PropertyChanged += new PropertyChangedEventHandler(character_PropertyChanged);
								}

								public static readonly RoutedEvent RaceClickEvent =
												EventManager.RegisterRoutedEvent("RaceClick", RoutingStrategy.Bubble,
												typeof(RoutedEventHandler), typeof(CharacterPanel));

								public event RoutedEventHandler RaceClick
								{
												add { AddHandler(RaceClickEvent, value); }
												remove { RemoveHandler(RaceClickEvent, value); }
								}

								private void Race_Click(object sender, RoutedEventArgs e)
								{
												this.RaiseEvent(new RoutedEventArgs(RaceClickEvent, this));
								}

								public static readonly RoutedEvent ClassClickEvent =
												EventManager.RegisterRoutedEvent("ClassClick", RoutingStrategy.Bubble,
												typeof(RoutedEventHandler), typeof(CharacterPanel));

								public event RoutedEventHandler ClassClick
								{
												add { AddHandler(ClassClickEvent, value); }
												remove { RemoveHandler(ClassClickEvent, value); }
								}

								private void Class_Click(object sender, RoutedEventArgs e)
								{
												this.RaiseEvent(new RoutedEventArgs(ClassClickEvent, this));
								}

								private void character_PropertyChanged(object sender, PropertyChangedEventArgs e)
								{
												switch(e.PropertyName)
												{
																case "Race":
																				Race.Content = Model.Character.Instance.Race.Name;
																				break;
																case "Class":
																				Class.Content = Model.Character.Instance.Class.Name;
																				break;
												}
								}
				}
}
