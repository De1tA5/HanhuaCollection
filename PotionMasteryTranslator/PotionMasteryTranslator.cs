#pragma warning disable CA2255
using HanhuaCollection.Systems;
using System.Collections.Generic;
using Terraria.ModLoader;
using System.Runtime.CompilerServices;
namespace HanhuaCollection.PotionMasteryTranslator
{
	public class PotionMasteryTranslator
	{
		private class PotionMastery{}
		[ExtendsFromMod("PotionMastery"), JITWhenModsEnabled("PotionMastery")]
		private class TranslatorLoad : ForceLocalizeSystem<PotionMastery, TranslatorLoad>{}
		[ModuleInitializer]
		public static void LoadTranslator()
		{
			if(LoadModAssembly.LoadModContext.TryGetValue("PotionMastery",out _))
			{
				#region PotionMastery.PotionMasteryGlobalBuff
				TranslatorLoad.LocalizeByTypeFullName("PotionMastery.PotionMasteryGlobalBuff", "ModifyBuffText", new ()
				{
					{"% [C/F0F078:精通]","% mastery"},
				});
				#endregion PotionMastery.PotionMasteryGlobalBuff


				#region PotionMastery.PotionMasteryGlobalItem
				TranslatorLoad.LocalizeByTypeFullName("PotionMastery.PotionMasteryGlobalItem", "ModifyTooltips", new ()
				{
					{"% [C/F0F078:精通]","% mastery"},
					{" 瓶[C/C3F078:100%精通]"," until max"},
					{"无限持续时间","Infinite duration"},
				});
				#endregion PotionMastery.PotionMasteryGlobalItem


			}
		}
	}
}
