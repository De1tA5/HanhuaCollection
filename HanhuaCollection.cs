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

    //PotionMastery—药水精通
    public class PotionMastery : ModSystem
    {
        public override void PostSetupContent()
        {
            if (ModLoader.HasMod("PotionMastery"))
            {
                TigerForceLocalizationHelper.LocalizeAll("HanhuaCollection", "PotionMastery", false);
                base.PostSetupContent();
            }

        }
    }
    //AutoPotion—自动药水
    public class AutoPotion : ModSystem
    {
        public override void PostSetupContent()
        {
            if (ModLoader.HasMod("AutoPotion"))
            {
                TigerForceLocalizationHelper.LocalizeAll("HanhuaCollection", "AutoPotion", false);
                base.PostSetupContent();
            }

        }
    }

    //DyeAnything—染上一切
    public class DyeAnything : ModSystem 
    {
        public override void PostSetupContent()
        {
            if (ModLoader.HasMod("DyeAnything"))
            {
                TigerForceLocalizationHelper.LocalizeAll("HanhuaCollection", "DyeAnything", false);
                base.PostSetupContent();
            }
        }
    }

    //UIEditor-UI编辑器
    public class UIEditor : ModSystem
    {
        public override void PostSetupContent()
        {
            if (ModLoader.HasMod("UIEditor"))
            {
                TigerForceLocalizationHelper.LocalizeAll("HanhuaCollection", "UIEditor", false);
                base.PostSetupContent();
            }
        }
    }
}
