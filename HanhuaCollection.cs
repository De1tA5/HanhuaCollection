using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria;
using TigerForceLocalizationLib; 

namespace HanhuaCollection
{
    public class HardCodePatch : ModSystem 
    {
        public override void PostSetupContent()
        {
            //PotionMastery—药水精通
            if (ModLoader.HasMod("PotionMastery"))
            {
                TigerForceLocalizationHelper.LocalizeAll("HanhuaCollection", "PotionMastery", false);
                
            }

            //AutoPotion—自动药水
            if (ModLoader.HasMod("AutoPotion"))
            {
                TigerForceLocalizationHelper.LocalizeAll("HanhuaCollection", "AutoPotion", false);
                
            }

            //DyeAnything—染上一切
            if (ModLoader.HasMod("DyeAnything"))
            {
                TigerForceLocalizationHelper.LocalizeAll("HanhuaCollection", "DyeAnything", false);
                
            }

            //UIEditor-UI编辑器
            if (ModLoader.HasMod("UIEditor"))
            {
                TigerForceLocalizationHelper.LocalizeAll("HanhuaCollection", "UIEditor", false);
                
            }

            //CritRework-暴击大修
            if (ModLoader.HasMod("CritRework"))
            {
                TigerForceLocalizationHelper.LocalizeAll("HanhuaCollection", "CritRework", false);
            }
           
        }
    }
}
