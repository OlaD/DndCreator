using System.Windows;
using System.Windows.Controls;

namespace DndCreator.View
{
				/// <summary>
				/// Interaction logic for ClassDescriptionTab.xaml
				/// </summary>
				public partial class ClassDescriptionTab : UserControl
				{
								public string ShownDescription
								{
												get { return (string)GetValue(ShownDescriptionProperty); }
												set { SetValue(ShownDescriptionProperty, value);	}
								}

								public static readonly DependencyProperty ShownDescriptionProperty
												= DependencyProperty.Register("ShownDescription", typeof(string), 
												typeof(ClassDescriptionTab), new PropertyMetadata(""));

								public ClassDescriptionTab()
								{
												InitializeComponent();
												this.DataContext = this;
								}

								public static readonly RoutedEvent ChangeDescriptionEvent =
												EventManager.RegisterRoutedEvent("ChangeDescription", RoutingStrategy.Bubble,
												typeof(RoutedEventHandler), typeof(ClassDescriptionTab));

								public event RoutedEventHandler ChangeDescription
								{
												add { AddHandler(ChangeDescriptionEvent, value); }
												remove { RemoveHandler(ChangeDescriptionEvent, value); }
								}

								private void Description_Checked(object sender, RoutedEventArgs e)
								{
												this.RaiseEvent(new RoutedEventArgs(ChangeDescriptionEvent, sender));
								}
				}
}
