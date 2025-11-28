#pragma warning disable CA2255
using HanhuaCollection.Systems;
using System.Collections.Generic;
using Terraria.ModLoader;
using System.Runtime.CompilerServices;
namespace HanhuaCollection.UIEditorTranslator
{
	public class UIEditorTranslator
	{
		private class UIEditor{}
		[ExtendsFromMod("UIEditor"), JITWhenModsEnabled("UIEditor")]
		private class TranslatorLoad : ForceLocalizeSystem<UIEditor, TranslatorLoad>{}
		[ModuleInitializer]
		public static void LoadTranslator()
		{
			if(LoadModAssembly.LoadModContext.TryGetValue("UIEditor",out _))
			{
				#region UIEditor.Core.MainMenuEditor.UI.Sections.BackgroundSection
				TranslatorLoad.LocalizeByTypeFullName("UIEditor.Core.MainMenuEditor.UI.Sections.BackgroundSection", ".ctor", new ()
				{
					{"选择文件","Choose File"},
				});
				#endregion UIEditor.Core.MainMenuEditor.UI.Sections.BackgroundSection


				#region UIEditor.Core.MainMenuEditor.UI.Sections.DrawSection
				TranslatorLoad.LocalizeByTypeFullName("UIEditor.Core.MainMenuEditor.UI.Sections.DrawSection", ".ctor", new ()
				{
					{"绘制","Draw"},
				});
				#endregion UIEditor.Core.MainMenuEditor.UI.Sections.DrawSection


				#region UIEditor.Core.MainMenuEditor.UI.Sections.LogoSection
				TranslatorLoad.LocalizeByTypeFullName("UIEditor.Core.MainMenuEditor.UI.Sections.LogoSection", ".ctor", new ()
				{
					{"选择文件","Choose File"},
				});
				#endregion UIEditor.Core.MainMenuEditor.UI.Sections.LogoSection


				#region UIEditor.Core.MainMenuEditor.UI.Sections.TextColorSection
				TranslatorLoad.LocalizeByTypeFullName("UIEditor.Core.MainMenuEditor.UI.Sections.TextColorSection", ".ctor", new ()
				{
					{"填充","Fill"},
				});
				TranslatorLoad.LocalizeByTypeFullName("UIEditor.Core.MainMenuEditor.UI.Sections.TextColorSection", "MakeTab", new ()
				{
					{"文本颜色"," Text Color"},
				});
				#endregion UIEditor.Core.MainMenuEditor.UI.Sections.TextColorSection


				#region UIEditor.Core.IngameEditor.UI.LayoutsTab
				TranslatorLoad.LocalizeByTypeFullName("UIEditor.Core.IngameEditor.UI.LayoutsTab", ".ctor", new ()
				{
					{"布局","Layouts"},
				});
				#endregion UIEditor.Core.IngameEditor.UI.LayoutsTab


				#region UIEditor.Core.IngameEditor.UI.PositionsTab
				TranslatorLoad.LocalizeByTypeFullName("UIEditor.Core.IngameEditor.UI.PositionsTab", ".ctor", new ()
				{
					{"位置","Positions"},
				});
				#endregion UIEditor.Core.IngameEditor.UI.PositionsTab


				#region UIEditor.Core.LayersEditor.ElementsTab
				TranslatorLoad.LocalizeByTypeFullName("UIEditor.Core.LayersEditor.ElementsTab", ".ctor", new ()
				{
					{"元素","Elements"},
				});
				#endregion UIEditor.Core.LayersEditor.ElementsTab


				#region UIEditor.Core.LayersEditor.LayersTab
				TranslatorLoad.LocalizeByTypeFullName("UIEditor.Core.LayersEditor.LayersTab", ".ctor", new ()
				{
					{"图层","Layers"},
				});
				#endregion UIEditor.Core.LayersEditor.LayersTab


				#region UIEditor.Core.LayersEditor.PacksTab
				TranslatorLoad.LocalizeByTypeFullName("UIEditor.Core.LayersEditor.PacksTab", ".ctor", new ()
				{
					{"资源包","Packs"},
				});
				#endregion UIEditor.Core.LayersEditor.PacksTab


				#region UIEditor.Common.Integrations.ModReloader.ModReloaderIntegration
				TranslatorLoad.LocalizeByTypeFullName("UIEditor.Common.Integrations.ModReloader.ModReloaderIntegration", "AddButtons", new ()
				{
					{"图层","Layers"},
				});
				#endregion UIEditor.Common.Integrations.ModReloader.ModReloaderIntegration


				#region UIEditor.Common.Integrations.DragonLens.DragonLensEditTool
				TranslatorLoad.LocalizeByTypeFullName("UIEditor.Common.Integrations.DragonLens.DragonLensEditTool", "get_Name", new ()
				{
					{"UI编辑器","UI Editor"},
				});
				#endregion UIEditor.Common.Integrations.DragonLens.DragonLensEditTool


				#region UIEditor.Common.Integrations.DragonLens.DragonLensIcons
				TranslatorLoad.LocalizeByTypeFullName("UIEditor.Common.Integrations.DragonLens.DragonLensIcons", "AddIcons", new ()
				{
					{"图层","Layers"},
				});
				#endregion UIEditor.Common.Integrations.DragonLens.DragonLensIcons


			}
		}
	}
}
