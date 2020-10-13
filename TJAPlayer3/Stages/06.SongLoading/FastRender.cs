<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FDK;

namespace TJAPlayer3
{
    class FastRender
    {
        public FastRender()
        {
            
        }

        public void Render()
        {
            for (int i = 0; i < TJAPlayer3.Skin.Game_Chara_Ptn_10combo; i++)
            {
                NullCheckAndRender(ref TJAPlayer3.Tx.Chara_10Combo[i]);
            }
            for (int i = 0; i < TJAPlayer3.Skin.Game_Chara_Ptn_10combo_Max; i++)
            {
                NullCheckAndRender(ref TJAPlayer3.Tx.Chara_10Combo_Maxed[i]);
            }
            for (int i = 0; i < TJAPlayer3.Skin.Game_Chara_Ptn_GoGoStart; i++)
            {
                NullCheckAndRender(ref TJAPlayer3.Tx.Chara_GoGoStart[i]);
            }
            for (int i = 0; i < TJAPlayer3.Skin.Game_Chara_Ptn_GoGoStart_Max; i++)
            {
                NullCheckAndRender(ref TJAPlayer3.Tx.Chara_GoGoStart_Maxed[i]);
            }
            for (int i = 0; i < TJAPlayer3.Skin.Game_Chara_Ptn_Normal; i++)
            {
                NullCheckAndRender(ref TJAPlayer3.Tx.Chara_Normal[i]);
            }
            for (int i = 0; i < TJAPlayer3.Skin.Game_Chara_Ptn_Clear; i++)
            {
                NullCheckAndRender(ref TJAPlayer3.Tx.Chara_Normal_Cleared[i]);
            }
            for (int i = 0; i < TJAPlayer3.Skin.Game_Chara_Ptn_ClearIn; i++)
            {
                NullCheckAndRender(ref TJAPlayer3.Tx.Chara_Become_Cleared[i]);
            }
            for (int i = 0; i < TJAPlayer3.Skin.Game_Chara_Ptn_SoulIn; i++)
            {
                NullCheckAndRender(ref TJAPlayer3.Tx.Chara_Become_Maxed[i]);
            }
            for (int i = 0; i < TJAPlayer3.Skin.Game_Chara_Ptn_Balloon_Breaking; i++)
            {
                NullCheckAndRender(ref TJAPlayer3.Tx.Chara_Balloon_Breaking[i]);
            }
            for (int i = 0; i < TJAPlayer3.Skin.Game_Chara_Ptn_Balloon_Broke; i++)
            {
                NullCheckAndRender(ref TJAPlayer3.Tx.Chara_Balloon_Broke[i]);
            }
            for (int i = 0; i < TJAPlayer3.Skin.Game_Chara_Ptn_Balloon_Miss; i++)
            {
                NullCheckAndRender(ref TJAPlayer3.Tx.Chara_Balloon_Miss[i]);
            }

            for (int i = 0; i < 5; i++)
            {
                for (int k = 0; k < TJAPlayer3.Skin.Game_Dancer_Ptn; k++)
                {
                    NullCheckAndRender(ref TJAPlayer3.Tx.Dancer[i][k]);
                }
            }

            NullCheckAndRender(ref TJAPlayer3.Tx.Effects_GoGoSplash);
            NullCheckAndRender(ref TJAPlayer3.Tx.Runner);
            for (int i = 0; i < TJAPlayer3.Skin.Game_Mob_Ptn; i++)
            {
                NullCheckAndRender(ref TJAPlayer3.Tx.Mob[i]);
            }

            NullCheckAndRender(ref TJAPlayer3.Tx.PuchiChara);
            
        }

        private void NullCheckAndRender(ref CTexture tx)
        {
            if (tx == null) return;
            tx.Opacity = 0;
            tx.t2D描画(TJAPlayer3.app.Device, 0, 0);
            tx.Opacity = 255;
=======
﻿using FDK;

namespace TJAPlayer3
{
    internal class FastRender
    {
        public static void Render()
        {
            NullCheckAndRender(TJAPlayer3.Tx.Chara_10Combo);
            NullCheckAndRender(TJAPlayer3.Tx.Chara_10Combo_Maxed);
            NullCheckAndRender(TJAPlayer3.Tx.Chara_GoGoStart);
            NullCheckAndRender(TJAPlayer3.Tx.Chara_GoGoStart_Maxed);
            NullCheckAndRender(TJAPlayer3.Tx.Chara_Normal);
            NullCheckAndRender(TJAPlayer3.Tx.Chara_Normal_Cleared);
            NullCheckAndRender(TJAPlayer3.Tx.Chara_Become_Cleared);
            NullCheckAndRender(TJAPlayer3.Tx.Chara_Become_Maxed);
            NullCheckAndRender(TJAPlayer3.Tx.Chara_Balloon_Breaking);
            NullCheckAndRender(TJAPlayer3.Tx.Chara_Balloon_Broke);
            NullCheckAndRender(TJAPlayer3.Tx.Chara_Balloon_Miss);
            NullCheckAndRender(TJAPlayer3.Tx.Dancer);
            NullCheckAndRender(TJAPlayer3.Tx.Effects_GoGoSplash);
            NullCheckAndRender(TJAPlayer3.Tx.Runner);
            NullCheckAndRender(TJAPlayer3.Tx.Mob);
            NullCheckAndRender(TJAPlayer3.Tx.PuchiChara);
        }

        private static void NullCheckAndRender(CTexture[][] textures)
        {
            if (textures == null)
            {
                return;
            }

            foreach (var innerTextures in textures)
            {
                NullCheckAndRender(innerTextures);
            }
        }

        private static void NullCheckAndRender(CTexture[] textures)
        {
            if (textures == null)
            {
                return;
            }

            foreach (var texture in textures)
            {
                NullCheckAndRender(texture);
            }
        }

        private static void NullCheckAndRender(CTexture texture)
        {
            if (texture == null)
            {
                return;
            }

            var originalOpacity = texture.Opacity;

            texture.Opacity = 0;
            texture.t2D描画(TJAPlayer3.app.Device, 0, 0);
            texture.Opacity = originalOpacity;
>>>>>>> twopointzero/develop
        }
    }
}
