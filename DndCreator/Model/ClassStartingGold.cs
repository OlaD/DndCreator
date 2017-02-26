using System.Text;

namespace DndCreator.Model
{
				public class ClassStartingGold
				{
								Dices dices;
								uint multiplier;

								public string Formula
								{
												get
												{
																StringBuilder formula = new StringBuilder();
																formula.Append(dices);
																if (multiplier != 1)
																{
																				formula.Append(" x ");
																				formula.Append(multiplier);
																}
																return formula.ToString();
												}
								}

								public float AverageAmount
								{
												get { return multiplier * dices.AverageRoll(); }
								}

								public string AverageAmountString
								{
												get { return AverageAmount + " sz"; }
								}

								public ClassStartingGold(Dices dices, uint multiplier)
								{
												this.dices = dices;
												this.multiplier = multiplier;
								}
				}
}
