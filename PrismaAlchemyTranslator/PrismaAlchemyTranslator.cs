#pragma warning disable CA2255
using HanhuaCollection.Systems;
using System.Collections.Generic;
using Terraria.ModLoader;
using System.Runtime.CompilerServices;
namespace HanhuaCollection.PrismaAlchemyTranslator
{
	public class PrismaAlchemyTranslator
	{
		private class PrismaAlchemy{}
		[ExtendsFromMod("PrismaAlchemy"), JITWhenModsEnabled("PrismaAlchemy")]
		private class TranslatorLoad : ForceLocalizeSystem<PrismaAlchemy, TranslatorLoad>{}
		[ModuleInitializer]
		public static void LoadTranslator()
		{
			if(LoadModAssembly.LoadModContext.TryGetValue("PrismaAlchemy",out _))
			{
				#region PrismaAlchemy.Content.Items.Curses.DungeonMirror
				TranslatorLoad.LocalizeByTypeFullName("PrismaAlchemy.Content.Items.Curses.DungeonMirror", "UseStyle", new ()
				{
					{"未找到地牢！","Dungeon not found!"},
				});
				#endregion PrismaAlchemy.Content.Items.Curses.DungeonMirror


				#region PrismaAlchemy.Content.Items.Curses.GolemMirror
				TranslatorLoad.LocalizeByTypeFullName("PrismaAlchemy.Content.Items.Curses.GolemMirror", "UseStyle", new ()
				{
					{"未找到神庙祭坛！","Altar not found!"},
				});
				#endregion PrismaAlchemy.Content.Items.Curses.GolemMirror


				#region PrismaAlchemy.Content.Items.Curses.ShadowMirror
				TranslatorLoad.LocalizeByTypeFullName("PrismaAlchemy.Content.Items.Curses.ShadowMirror", "UseStyle", new ()
				{
					{"未找到死亡点！","Death point not found!"},
				});
				#endregion PrismaAlchemy.Content.Items.Curses.ShadowMirror


				#region PrismaAlchemy.Content.Items.Curses.ShimmerMirror
				TranslatorLoad.LocalizeByTypeFullName("PrismaAlchemy.Content.Items.Curses.ShimmerMirror", "UseStyle", new ()
				{
					{"未找到微光！","Shimmer not found!"},
				});
				#endregion PrismaAlchemy.Content.Items.Curses.ShimmerMirror


				#region PrismaAlchemy.Content.NPCs.Town.Scientist.Scientist
				TranslatorLoad.LocalizeByTypeFullName("PrismaAlchemy.Content.NPCs.Town.Scientist.Scientist", "SetChatButtons", new ()
				{
					{"切换","Cycle"},
				});
				TranslatorLoad.LocalizeByTypeFullName("PrismaAlchemy.Content.NPCs.Town.Scientist.Scientist", "OnChatButtonClicked", new ()
				{
					{"实用药水","Utility Potions"},
					{"回复药水","Recovery Potions"},
				});
				TranslatorLoad.LocalizeByTypeFullName("PrismaAlchemy.Content.NPCs.Town.Scientist.Scientist", "AddShops", new ()
				{
					{"实用药水","Utility Potions"},
					{"回复药水","Recovery Potions"},
				});
				TranslatorLoad.LocalizeByTypeFullName("PrismaAlchemy.Content.NPCs.Town.Scientist.Scientist", ".ctor", new ()
				{
					{"实用药水","Utility Potions"},
				});
				#endregion PrismaAlchemy.Content.NPCs.Town.Scientist.Scientist


				#region PrismaAlchemy.Content.NPCs.Town.RegularPerson.RegularPerson
				TranslatorLoad.LocalizeByTypeFullName("PrismaAlchemy.Content.NPCs.Town.RegularPerson.RegularPerson", ".ctor", new ()
				{
					{"酒类","Alcohols"},
				});
				#endregion PrismaAlchemy.Content.NPCs.Town.RegularPerson.RegularPerson


				#region PrismaAlchemy.Content.NPCs.Town.PotionLady.PotionLady
				TranslatorLoad.LocalizeByTypeFullName("PrismaAlchemy.Content.NPCs.Town.PotionLady.PotionLady", "SetChatButtons", new ()
				{
					{"切换","Cycle"},
				});
				TranslatorLoad.LocalizeByTypeFullName("PrismaAlchemy.Content.NPCs.Town.PotionLady.PotionLady", "OnChatButtonClicked", new ()
				{
					{"战斗药水","Combat Potions"},
					{"灾厄药水","Calamity Buffs"},
					{"药剂","Flasks"},
				});
				TranslatorLoad.LocalizeByTypeFullName("PrismaAlchemy.Content.NPCs.Town.PotionLady.PotionLady", "AddShops", new ()
				{
					{"战斗药水","Combat Potions"},
					{"灾厄药水","Calamity Buffs"},
					{"药剂","Flasks"},
				});
				TranslatorLoad.LocalizeByTypeFullName("PrismaAlchemy.Content.NPCs.Town.PotionLady.PotionLady", ".ctor", new ()
				{
					{"战斗药水","Combat Potions"},
				});
				#endregion PrismaAlchemy.Content.NPCs.Town.PotionLady.PotionLady


				#region PrismaAlchemy.Content.NPCs.Town.Huntress.Huntress
				TranslatorLoad.LocalizeByTypeFullName("PrismaAlchemy.Content.NPCs.Town.Huntress.Huntress", "SetChatButtons", new ()
				{
					{"切换","Cycle"},
				});
				TranslatorLoad.LocalizeByTypeFullName("PrismaAlchemy.Content.NPCs.Town.Huntress.Huntress", "OnChatButtonClicked", new ()
				{
					{"原版宝藏袋","Vanilla Treasure Bags"},
					{"灾厄宝藏袋","Calamity Treasure Bags"},
					{"原版材料","Vanilla Materials"},
					{"灾厄材料（月亮领主前）","Calamity Materials (Pre-ML)"},
					{"灾厄材料（月亮领主后）","Calamity Materials (Post-ML)"},
				});
				TranslatorLoad.LocalizeByTypeFullName("PrismaAlchemy.Content.NPCs.Town.Huntress.Huntress", "AddShops", new ()
				{
					{"原版宝藏袋","Vanilla Treasure Bags"},
					{"灾厄宝藏袋","Calamity Treasure Bags"},
					{"原版材料","Vanilla Materials"},
					{"灾厄材料（月亮领主前）","Calamity Materials (Pre-ML)"},
					{"灾厄材料（月亮领主后）","Calamity Materials (Post-ML)"},
				});
				TranslatorLoad.LocalizeByTypeFullName("PrismaAlchemy.Content.NPCs.Town.Huntress.Huntress", ".ctor", new ()
				{
					{"原版宝藏袋","Vanilla Treasure Bags"},
				});
				#endregion PrismaAlchemy.Content.NPCs.Town.Huntress.Huntress


				#region PrismaAlchemy.Content.NPCs.Town.Combatant.Combatant
				TranslatorLoad.LocalizeByTypeFullName("PrismaAlchemy.Content.NPCs.Town.Combatant.Combatant", "SetChatButtons", new ()
				{
					{"切换","Cycle"},
				});
				TranslatorLoad.LocalizeByTypeFullName("PrismaAlchemy.Content.NPCs.Town.Combatant.Combatant", "OnChatButtonClicked", new ()
				{
					{"增益站","Buff Stations"},
					{"诅咒物品","Curses"},
					{"机动性饰品","Movement Accessories"},
					{"战斗饰品","Battle Accessories"},
					{"杂项饰品","Miscellaneous Accessories"},
					{"灾厄饰品","Calamity Accessories"},
					{"饰品","Accessories"},
				});
				TranslatorLoad.LocalizeByTypeFullName("PrismaAlchemy.Content.NPCs.Town.Combatant.Combatant", "AddShops", new ()
				{
					{"增益站","Buff Stations"},
					{"机动性饰品","Movement Accessories"},
					{"杂项饰品","Miscellaneous Accessories"},
					{"灾厄饰品","Calamity Accessories"},
					{"诅咒物品","Curses"},
				});
				#endregion PrismaAlchemy.Content.NPCs.Town.Combatant.Combatant


				#region PrismaAlchemy.Content.NPCs.Town.Builder.Builder
				TranslatorLoad.LocalizeByTypeFullName("PrismaAlchemy.Content.NPCs.Town.Builder.Builder", "AddShops", new ()
				{
					{"自动竞技场","Auto Arenas"},
				});
				TranslatorLoad.LocalizeByTypeFullName("PrismaAlchemy.Content.NPCs.Town.Builder.Builder", ".ctor", new ()
				{
					{"自动竞技场","Auto Arenas"},
				});
				#endregion PrismaAlchemy.Content.NPCs.Town.Builder.Builder


			}
		}
	}
}
