using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using DndCreator.Model;
using DndCreator.ViewModel;

namespace DndCreator.ViewModel.Tests
{
				[TestClass()]
				public class ClassLevelBenefitsRowTests
				{
								[TestMethod()]
								public void BaseAttackTest()
								{
												List<uint> baseAttack = new List<uint> { 10, 5, 0 };
												ClassLevelBenefitsRow target = new ClassLevelBenefitsRow(0, baseAttack, 0, 0, 0, null, null);

												string expected = "+10/+5/+0";
												string actual = target.BaseAttack;

												Assert.AreEqual(expected, actual);
								}

								[TestMethod()]
								public void EmptyFeaturesList_FeaturesTest()
								{
												ClassLevelBenefitsRow target = new ClassLevelBenefitsRow(0, new List<uint> { 0 }, 0, 0, 0, null, null);

												string expected = "";
												string actual = target.Features;

												Assert.AreEqual(expected, actual);
								}

								[TestMethod()]
								public void FeatureWithoutBenefit_FeaturesTest()
								{
												List<ClassFeature> feature = new List<ClassFeature>();
												feature.Add(new ClassFeature("name", "", null));
												ClassLevelBenefitsRow target = new ClassLevelBenefitsRow(0, new List<uint> { 0 }, 0, 0, 0, feature, null);

												string expected = "name";
												string actual = target.Features;

												Assert.AreEqual(expected, actual);
								}

								[TestMethod()]
								public void FeatureWithBenefit_FeaturesTest()
								{
												uint level = 1;
												List<ClassFeature> feature = new List<ClassFeature>();
												LevelBenefits<string> benefit = new LevelBenefits<string>();
												benefit[level] = "benefit";
												feature.Add(new ClassFeature("name", "", benefit));
												ClassLevelBenefitsRow target = new ClassLevelBenefitsRow(level, new List<uint> { 0 }, 0, 0, 0, feature, null);

												string expected = "name benefit";
												string actual = target.Features;

												Assert.AreEqual(expected, actual);
								}

								[TestMethod()]
								public void ManyFeatures_FeaturesTest()
								{
												uint level = 1;
												List<ClassFeature> features = new List<ClassFeature>();
												LevelBenefits<string> benefit = new LevelBenefits<string>();
												benefit[level] = "benefit";
												features.Add(new ClassFeature("name1", "", null));
												features.Add(new ClassFeature("name2", "", benefit));
												features.Add(new ClassFeature("name3", "", null));
												ClassLevelBenefitsRow target = new ClassLevelBenefitsRow(level, new List<uint> { 0 }, 0, 0, 0, features, null);

												string expected = "name1, name2 benefit, name3";
												string actual = target.Features;

												Assert.AreEqual(expected, actual);
								}

								public void SpellsPerDayTest()
								{
												LevelBenefits<uint?> spellsPerDay = new LevelBenefits<uint?>();
												spellsPerDay[0] = 3;
												spellsPerDay[1] = 2;
												spellsPerDay[2] = 1;
												spellsPerDay[3] = 0;
												ClassLevelBenefitsRow target = new ClassLevelBenefitsRow(0, new System.Collections.Generic.List<uint>(), 0, 0, 0, null, spellsPerDay);

												string[] expected = new string[] { "3", "2", "1", "0", "-", "-", "-", "-", "-", "-" };
												string[] actual = target.SpellsPerDay;

												CollectionAssert.AreEqual(expected, actual);
								}

				}
}