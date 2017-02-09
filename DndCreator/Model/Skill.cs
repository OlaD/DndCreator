namespace DndCreator.Model
{
				class Skill
				{
								public string Name { get; }
								public Ability KeyAbility { get; }

								public Skill(string name, Ability keyAbility)
								{
												Name = name;
												KeyAbility = keyAbility;
								}
				}
}
