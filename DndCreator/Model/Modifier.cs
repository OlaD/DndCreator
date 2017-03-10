using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCreator.Model
{
				// Modyfikator np. atrybutu
				// Value - wartość modyfikatora (dodatnia lub ujemna)
				// Source - źródło modyfikatora (np. klasa)
				public class Modifier
				{
								public int Value { get; }
								public string Source { get; }

								public Modifier(int value, string source)
								{
												Value = value;
												Source = source;
								}
				}
}
