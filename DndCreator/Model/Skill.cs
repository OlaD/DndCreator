namespace DndCreator.Model
{
				public class Skill
				{
								public string Name { get; }
								public Ability KeyAbility { get; }

								public string SkillWithAbility
								{
												get { return Name + " (" + KeyAbility.Abbreviation + ")"; }
								}

								public Skill(string name, Ability keyAbility)
								{
												Name = name;
												KeyAbility = keyAbility;
								}
				}
}
