﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using DndCreator.Model;
using DndCreator.ViewModel;
using System.ComponentModel;

namespace DndCreator.View
{
				public partial class RacePage : Page
				{
								private RaceViewModel viewModel;

								public RacePage()
								{
												InitializeComponent();
												viewModel = RaceViewModel.Instance;
												this.DataContext = viewModel;
												viewModel.PropertyChanged += new PropertyChangedEventHandler(shownDescription_PropertyChanged);
												GeneralDescription.IsChecked = true;
								}

								private void shownDescription_PropertyChanged(object sender, PropertyChangedEventArgs e)
								{
												switch (e.PropertyName)
												{
																case "ShownDescription":
																				Description.Content = viewModel.ShownDescription;
																				break;
												}
								}

								private void ConfirmRace_Click(object sender, RoutedEventArgs e)
								{
												Character character = Character.Instance;
												character.Race = (Race)RacesToChoose.SelectedItem;
												MessageBox.Show(viewModel.ShownDescription);
								}

								private void Description_Checked(object sender, RoutedEventArgs e)
								{
												Control selectedDescriptionButton = (Control)sender;
												setSelectedDescription(selectedDescriptionButton.Name);
								}

								private void setSelectedDescription(string selectedDescriptionButtonName)
								{
												RaceDescriptionType selectedDescription;

												if (Enum.TryParse(selectedDescriptionButtonName, out selectedDescription))
																viewModel.SelectedDescription = selectedDescription;
												else
												{
																//TODO coś sensowniejszego
																throw new NotImplementedException();
												}
								}
				}
}
