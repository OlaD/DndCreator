using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndCreator.Model;

namespace DndCreator.ViewModel
{
				public class ClassLevelBenefitsRow
				{
								public uint Level { get; }
								public string BaseAttack { get; private set; }
								public string Fortitude { get; private set; }
								public string Reflex { get; private set; }
								public string Will { get; private set; }
								public string Features { get; private set; }
								public string[] SpellsPerDay { get; private set; }

								public ClassLevelBenefitsRow(uint level)
								{
												Level = level;
												SetDefaultValuesToProperties();
								}

								private void SetDefaultValuesToProperties()
								{
												string defaultValue = "-";
												BaseAttack = defaultValue;
												Fortitude = defaultValue;
												Reflex = defaultValue;
												Will = defaultValue;
												Features = defaultValue;
												SpellsPerDay = null;
								}

								public ClassLevelBenefitsRow(uint level, List<uint> baseAttack, uint fortitude, uint reflex, uint will, List<ClassFeature> features, LevelBenefits<uint?> spellsPerDay)
								{
												Level = level;
												ConvertDataToProperties(baseAttack, fortitude, reflex, will, features, spellsPerDay);
								}

								private void ConvertDataToProperties(List<uint> baseAttack, uint fortitude, uint reflex, uint will, List<ClassFeature> features, LevelBenefits<uint?> spellsPerDay)
								{
												BaseAttack = CreateBaseAttackString(baseAttack);
												Fortitude = CreateBonusString(fortitude);
												Reflex = CreateBonusString(reflex);
												Will = CreateBonusString(will);
												Features = CreateFeaturesString(features);
												SpellsPerDay = CreateSpellsPerDayStrings(spellsPerDay);
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
												return bonus.ToString("+0");
								}

								private string CreateFeaturesString(List<ClassFeature> classFeatures)
								{
												if (classFeatures == null)
																return "";
												List<string> featuresWithBenefits = new List<string>();
												foreach (ClassFeature classFeature in classFeatures)
												{
																string featureWithBenefit = classFeature.Name;
																if (classFeature.Benefits != null)
																				featureWithBenefit += " " + classFeature.Benefits[Level];
																featuresWithBenefits.Add(featureWithBenefit);
												}
												return String.Join(", ", featuresWithBenefits);
								}

								private string[] CreateSpellsPerDayStrings(LevelBenefits<uint?> spellsPerDay)
								{
												if (spellsPerDay == null)
																return null;

												uint maxLevel = Properties.Settings.Default.MaxSpellLevel;
												string[] spellsPerDayStrings = new string[maxLevel + 1];

												for (uint level = 0; level <= maxLevel; level++)
												{
																uint? spells = spellsPerDay[level];
																if (spells != null)
																				spellsPerDayStrings[level] = spells.ToString();
																else
																				spellsPerDayStrings[level] = "-";
												}

												return spellsPerDayStrings;
								}

								public void ChangeRow(List<uint> baseAttack, uint fortitude, uint reflex, uint will, List<ClassFeature> features, LevelBenefits<uint?> spellsPerDay)
								{
												ConvertDataToProperties(baseAttack, fortitude, reflex, will, features, spellsPerDay);
								}
				}
}
