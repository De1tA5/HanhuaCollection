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
    //HomewardRagnarok�����˹�;&����ƻ����
    public class HomewardRagnarok : ModSystem
	{
       
        public override void PostSetupContent()
        {
            if (ModLoader.HasMod("HomewardRagnarok"))
            {
                TigerForceLocalizationHelper.LocalizeAll("HanhuaCollection", "HomewardRagnarok", false);
                base.PostSetupContent();
            }
            
        }

    }
    //PotionMastery��ҩˮ��ͨ
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
    //AutoPotion���Զ�ҩˮ
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
}
