using Microsoft.VisualStudio.TestTools.UnitTesting;
using DndCreator.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndCreator.Model;

namespace DndCreator.View.Tests
{
				[TestClass()]
				public class ClassLevelBenefitsRowTests
				{
								[TestMethod()]
								public void BaseAttackTest()
								{
												List<uint> baseAttack = new List<uint> { 10, 5, 0 };
												ClassLevelBenefitsRow target = new ClassLevelBenefitsRow(0, baseAttack, 0, 0, 0, null);

												string expected = "+10/+5/+0";
												string actual = target.BaseAttack;

												Assert.AreEqual(expected, actual);
								}

								[TestMethod()]
								public void EmptyFeaturesList_FeaturesTest()
								{
												ClassLevelBenefitsRow target = new ClassLevelBenefitsRow(0, null, 0, 0, 0, null);

												string expected = "";
												string actual = target.Features;

												Assert.AreEqual(expected, actual);
								}

								//[TestMethod()]
								//public void FeatureWithoutBenefit_FeaturesTest()
								//{
								//				List<ClassFeature> feature = new List<ClassFeature>();
								//				feature.Add(new ClassFeature("name", "", null));
								//				ClassLevelBenefitsRow target = new ClassLevelBenefitsRow(0, null, 0, 0, 0, null);

								//				string expected = "";
								//				string actual = target.Features;

								//				Assert.AreEqual(expected, actual);
								//}
				}
}