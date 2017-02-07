using System;
using System.Collections.Generic;
using System.Linq;
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
								}

								private void ClassViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
								{
												switch (e.PropertyName)
												{
																case "SelectedClass":
																				//Description.Content = viewModel.ShownDescription;
																				break;
																case "SelectedDescription":
																				break;
												}
								}
				}
}
