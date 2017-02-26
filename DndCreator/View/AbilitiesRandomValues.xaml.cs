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
using DndCreator.Model;

namespace DndCreator.View
{
				/// <summary>
				/// Interaction logic for AbilitiesRandomValues.xaml
				/// </summary>
				public partial class AbilitiesRandomValues : UserControl
				{
								int[] values;

								public AbilitiesRandomValues()
								{
												InitializeComponent();
												int numberOfValues = Ability.Abilities.Count;
												values = new int[numberOfValues];
								}

								private void Random_Click(object sender, RoutedEventArgs e)
								{
												uint numberOfDices = 4;
												uint numberOfSides = 6;
												Dices dices = new Dices(numberOfDices, numberOfSides);

												for(int i=0; i<values.Count(); i++)
												{
																dices.RollDices();
																dices.RemoveTheLowestRoll();
																values[i] = dices.SumRolls();
												}

												// todo zbindować?
												Value0.Content = values[0];
												Value1.Content = values[1];
												Value2.Content = values[2];
												Value3.Content = values[3];
												Value4.Content = values[4];
												Value5.Content = values[5];
								}
				}
}
