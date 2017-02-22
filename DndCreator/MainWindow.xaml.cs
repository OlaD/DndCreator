using System;
using System.Collections.Generic;
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
using DndCreator.View;
using DndCreator.Model;

namespace DndCreator
{
				/// <summary>
				/// Interaction logic for MainWindow.xaml
				/// </summary>
				public partial class MainWindow : Window
				{
								RacePage racePage;
								ClassPage classPage;
								AbilityPage abilitiesPage;

								public MainWindow()
								{
												InitializeComponent();
												LoadData();
												InitPages();
								}

								private void LoadData()
								{
												FakeDataLoader dataLoader = new FakeDataLoader();
												dataLoader.LoadData();
								}

								private void InitPages()
								{
												racePage = new RacePage();
												classPage = new ClassPage();
												abilitiesPage = new AbilityPage();
								}

								private void CharacterPanel_RaceClick(object sender, RoutedEventArgs e)
								{
												frame.Navigate(racePage);
								}

								private void CharacterPanel_ClassClick(object sender, RoutedEventArgs e)
								{
												frame.Navigate(classPage);
								}

								private void CharacterPanel_AbilitiesClick(object sender, RoutedEventArgs e)
								{
												frame.Navigate(abilitiesPage);
								}

				}
}
