using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCreator.Model
{
				public class SpellClass : Class
				{
								public LevelBenefits<LevelBenefits<uint?>> SpellsPerDay { get; }

								public SpellClass(
																				string name, Dictionary<ClassDescriptionType, string> description,	string abilitiesRule, string alignmentRule, uint hitDieSides, ClassStartingGold startingGold,	ClassSkills classSkills, List<ClassFeature> features, LevelBenefits<List<ClassFeature>> featuresOnLevels, BaseAttackBonusType baseAttack, BaseSaveThrowBonusType fortitude, BaseSaveThrowBonusType reflex, BaseSaveThrowBonusType will,
																				LevelBenefits<LevelBenefits<uint?>> spellsPerDay) 
																				: base (name, description, abilitiesRule, alignmentRule, hitDieSides, startingGold, classSkills, features, featuresOnLevels, baseAttack, fortitude, reflex, will)
								{
												SpellsPerDay = spellsPerDay;
								}
				}
}
