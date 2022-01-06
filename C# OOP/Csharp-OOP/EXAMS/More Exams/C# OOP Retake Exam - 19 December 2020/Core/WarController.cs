using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Characters;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Items;

namespace WarCroft.Core
{
	public class WarController
	{
		private IList<Character> characterParty;
		private Stack<Item> itemPool;
		public WarController()
		{
			this.characterParty = new List<Character>();
			this.itemPool = new Stack<Item>();
		}

		public string JoinParty(string[] args)
		{
			string type = args[0];
			string name = args[1];

			Character character = null;

			if(type == "Warrior")
            {
				character = new Warrior(name);
            }
			else if(type=="Priest")
            {
				character = new Priest(name);
            }
			else
            {
				throw new ArgumentException(ExceptionMessages.InvalidCharacterType);
            }

			characterParty.Add(character);
			return string.Format(SuccessMessages.JoinParty, name);

        }

		public string AddItemToPool(string[] args)
		{
			Item item = null;
			string itemName = args[0];
			if(itemName == "FirePotion")
            {
				item = new FirePotion();
            }
			else if(itemName == "HealthPotion")
            {
				item = new HealthPotion();
            }
			else
            {
				throw new ArgumentException(ExceptionMessages.InvalidItem, itemName);
            }

			itemPool.Push(item);
			return string.Format(SuccessMessages.AddItemToPool, itemName);
		}

		public string PickUpItem(string[] args)
		{
			string charName = args[0];
			Character character = this.characterParty.FirstOrDefault(x => x.Name == charName);

			if(character == null)
            {
				throw new ArgumentException(ExceptionMessages.CharacterNotInParty, charName);
            }

			if(itemPool.Count == 0)
            {
				throw new InvalidOperationException(ExceptionMessages.ItemPoolEmpty);
            }

			Item item = itemPool.Pop();
			character.Bag.AddItem(item);

			return string.Format(SuccessMessages.PickUpItem, character.Name, item.GetType().Name);
		}

		public string UseItem(string[] args)
		{
			string charName = args[0];
			string itemName = args[1];

			Character character = this.characterParty.FirstOrDefault(x => x.Name == charName);

			if (character == null)
			{
				throw new ArgumentException(ExceptionMessages.CharacterNotInParty, charName);
			}

			Item item = character.Bag.GetItem(itemName);
			character.UseItem(item);

			return string.Format(SuccessMessages.UsedItem, character.Name, item.GetType().Name);
		}

		public string GetStats()
		{
			var sb = new StringBuilder();
			var characters = characterParty.OrderByDescending(x => x.IsAlive)
				.ThenByDescending(x => x.Health);

			foreach (var item in characters)
			{
				sb.AppendLine(string.Format(SuccessMessages.CharacterStats,
					item.Name, item.Health, item.BaseHealth, item.Armor, item.BaseArmor, item.IsAlive ? "Alive" : "Dead"));
			}

			return sb.ToString().Trim();
		}

		public string Attack(string[] args)
		{
			Character attacker = characterParty.FirstOrDefault(c => c.Name == args[0]);
			Character receiver = characterParty.FirstOrDefault(x => x.Name == args[1]);

			if (attacker == null)
			{
				throw new ArgumentException(ExceptionMessages.CharacterNotInParty, args[0]);
			}

			if (receiver == null)
			{
				throw new ArgumentException(ExceptionMessages.CharacterNotInParty, args[1]);

			}

			Warrior warrior = attacker as Warrior;

			if (warrior == null)
			{
				throw new ArgumentException(ExceptionMessages.AttackFail, args[0]);
			}

			warrior.Attack(receiver);

			string output = string.Format(SuccessMessages.AttackCharacter,
				warrior.Name, receiver.Name, warrior.AbilityPoints, receiver.Name,
				receiver.Health, receiver.BaseHealth, receiver.Armor, receiver.BaseArmor);


			if (receiver.Health == 0)
			{
				string temp = string.Format(SuccessMessages.AttackKillsCharacter, receiver.Name);
				output = $"{output}\n{temp}";
			}

			return output;
		}

		public string Heal(string[] args)
		{
			Character healer = characterParty.FirstOrDefault(c => c.Name == args[0]);
			Character receiver = characterParty.FirstOrDefault(x => x.Name == args[1]);

			if (healer == null)
			{
				throw new ArgumentException(ExceptionMessages.CharacterNotInParty, args[0]);
			}

			if (receiver == null)
			{
				throw new ArgumentException(ExceptionMessages.CharacterNotInParty, args[1]);

			}

			Priest priest = healer as Priest;

			if (healer == null)
			{
				throw new ArgumentException(ExceptionMessages.HealerCannotHeal, args[0]);
			}

			return string.Format(SuccessMessages.HealCharacter,
				priest.Name, receiver.Name, priest.AbilityPoints, receiver.Name, receiver.Health);
		}
	}
}
