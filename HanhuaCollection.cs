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

	public class HanhuaCollection : ModSystem
	{
        //HomewardRagnarok�����˹�;&����ƻ����
        public override void PostSetupContent()
        {

            TigerForceLocalizationHelper.LocalizeAll(nameof(HanhuaCollection), "HomewardRagnarok", false);
            base.PostSetupContent();
        }
    }
}
