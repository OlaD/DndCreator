using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndCreator.Model;

namespace DndCreator.View
{
				public class ClassLevelBenefitsRow
				{
								public uint Level { get; }
								public string BaseAttack { get; }
								public string Fortitude { get; }
								public string Reflex { get; }
								public string Will { get; }
								public string Features { get; }

								public ClassLevelBenefitsRow(uint level, List<uint> baseAttack, uint fortitude, uint reflex, uint will, List<ClassFeature> special)
								{
												Level = level;
												BaseAttack = CreateBaseAttackString(baseAttack);
												Fortitude = CreateBonusString(fortitude);
												Reflex = CreateBonusString(reflex);
												Will = CreateBonusString(will);
												Features = CreateFeaturesString(special);
								}

								private string CreateBaseAttackString(List<uint> baseAttack)
								{
												List<string> baseAttackStrings = new List<string>();
												foreach(uint bonus in baseAttack)
												{
																string baseAttackString = CreateBonusString(bonus);
																baseAttackStrings.Add(baseAttackString);
												}
												return string.Join("/", baseAttackStrings);
								}

								private string CreateBonusString(uint bonus)
								{
												return bonus.ToString("+#; 0");
								}

								private string CreateFeaturesString(List<ClassFeature> special)
								{
												if (special == null)
																return "";
												List<string> featuresWithBenefits = new List<string>();
												foreach (ClassFeature feature in special)
												{
																string featureWithBenefit = feature.Name + " " + feature.Benefits[(int)Level];
																featuresWithBenefits.Add(featureWithBenefit);
												}
												return string.Join(", ", featuresWithBenefits);
								}
				}
}
