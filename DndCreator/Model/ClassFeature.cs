using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCreator.Model
{
				public class ClassFeature : Feature
				{
								public LevelBenefits<string> Benefits { get; }

								public ClassFeature(string name, string description, LevelBenefits<string> benefits) : base(name, description)
								{
												Benefits = benefits;
								}
				}
}
