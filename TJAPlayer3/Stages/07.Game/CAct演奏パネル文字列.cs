using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Diagnostics;
using SlimDX;
using FDK;
=======
using System.Drawing;
using System.Diagnostics;
using FDK;
using TJAPlayer3.Common;
>>>>>>> twopointzero/develop

namespace TJAPlayer3
{
	internal class CAct演奏パネル文字列 : CActivity
	{

		// コンストラクタ

		public CAct演奏パネル文字列()
		{
			base.b活性化してない = true;
<<<<<<< HEAD
			this.Start();
=======
>>>>>>> twopointzero/develop
		}


        // メソッド

        /// <summary>
        /// 右上の曲名、曲数表示の更新を行います。
        /// </summary>
        /// <param name="songName">曲名</param>
        /// <param name="genreName">ジャンル名</param>
        /// <param name="stageText">曲数</param>
        public void SetPanelString(string songName, string genreName, string stageText = null)
		{
			if( base.b活性化してる )
			{
<<<<<<< HEAD
				TJAPlayer3.tテクスチャの解放( ref this.txPanel );
=======
				TJAPlayer3.t安全にDisposeする(ref this.txPanel);
>>>>>>> twopointzero/develop
				if( (songName != null ) && (songName.Length > 0 ) )
				{
					try
					{
					    using (var bmpSongTitle = pfMusicName.DrawPrivateFont(songName, TJAPlayer3.Skin.Game_MusicName_ForeColor, TJAPlayer3.Skin.Game_MusicName_BackColor))
					    {
					        this.txMusicName = TJAPlayer3.tテクスチャの生成( bmpSongTitle, false );
					    }
                        if (txMusicName != null)
                        {
                            this.txMusicName.vc拡大縮小倍率.X = TJAPlayer3.GetSongNameXScaling(ref txMusicName);
                        }
                    
                        Bitmap bmpDiff;
                        string strDiff = "";
                        if (TJAPlayer3.Skin.eDiffDispMode == E難易度表示タイプ.n曲目に表示)
                        {
                            switch (TJAPlayer3.stage選曲.n確定された曲の難易度)
                            {
                                case 0:
                                    strDiff = "かんたん ";
                                    break;
                                case 1:
                                    strDiff = "ふつう ";
                                    break;
                                case 2:
                                    strDiff = "むずかしい ";
                                    break;
                                case 3:
                                    strDiff = "おに ";
                                    break;
                                case 4:
                                    strDiff = "えでぃと ";
                                    break;
                                default:
                                    strDiff = "おに ";
                                    break;
                            }
                            bmpDiff = pfMusicName.DrawPrivateFont(strDiff + stageText, TJAPlayer3.Skin.Game_StageText_ForeColor, TJAPlayer3.Skin.Game_StageText_BackColor );
                        }
                        else
                        {
                            bmpDiff = pfMusicName.DrawPrivateFont(stageText, TJAPlayer3.Skin.Game_StageText_ForeColor, TJAPlayer3.Skin.Game_StageText_BackColor );
                        }
<<<<<<< HEAD
=======

                        using (bmpDiff)
                        {
                            TJAPlayer3.t安全にDisposeする(ref tx難易度とステージ数);
                            tx難易度とステージ数 = TJAPlayer3.tテクスチャの生成(bmpDiff, false);
                        }
>>>>>>> twopointzero/develop
					}
					catch( CTextureCreateFailedException e )
					{
						Trace.TraceError( e.ToString() );
						Trace.TraceError( "パネル文字列テクスチャの生成に失敗しました。" );
						this.txPanel = null;
					}
<<<<<<< HEAD
                }

                this.txSONGS = TJAPlayer3.Tx.TxCGen("Songs");

                if ( !string.IsNullOrEmpty(genreName) )
                {
                    if (genreName.Equals( "アニメ" ) )
                    {
                        this.txGENRE = TJAPlayer3.Tx.TxCGen("Anime");
                    }
                    else if(genreName.Equals( "J-POP" ) )
                    {
                        this.txGENRE = TJAPlayer3.Tx.TxCGen("J-POP");
                    }
                    else if(genreName.Equals( "ゲームミュージック" ) )
                    {
                        this.txGENRE = TJAPlayer3.Tx.TxCGen("Game");
                    }
                    else if(genreName.Equals( "ナムコオリジナル" ) )
                    {
                        this.txGENRE = TJAPlayer3.Tx.TxCGen("Namco");
                    }
                    else if(genreName.Equals( "クラシック" ) )
                    {
                        this.txGENRE = TJAPlayer3.Tx.TxCGen("Classic");
                    }
                    else if(genreName.Equals( "どうよう" ) )
                    {
                        this.txGENRE = TJAPlayer3.Tx.TxCGen("Child");
                    }
                    else if(genreName.Equals( "バラエティ" ) )
                    {
                        this.txGENRE = TJAPlayer3.Tx.TxCGen("Variety");
                    }
                    else if(genreName.Equals( "ボーカロイド" ) || genreName.Equals( "VOCALOID" ) )
                    {
                        this.txGENRE = TJAPlayer3.Tx.TxCGen("Vocaloid");
                    }
                    else
                    {
                        using (var bmpDummy = new Bitmap( 1, 1 ))
                        {
                            this.txGENRE = TJAPlayer3.tテクスチャの生成( bmpDummy, true );
                        }
                    }
                }

			    this.ct進行用 = new CCounter( 0, 2000, 2, TJAPlayer3.Timer );
				this.Start();



=======
				}

                var genreTextureFileName = CStrジャンルtoStr.ForTextureFileName( genreName );
			    this.txGENRE = genreTextureFileName == null ? null : TJAPlayer3.Tx.TxCGenre(genreTextureFileName);

			    this.ct進行用 = new CCounter( 0, 2000, 2, TJAPlayer3.Timer );
>>>>>>> twopointzero/develop
			}
		}

        public void t歌詞テクスチャを生成する( string str歌詞 )
        {
            using (var bmpleric = this.pf歌詞フォント.DrawPrivateFont( str歌詞, TJAPlayer3.Skin.Game_Lyric_ForeColor, TJAPlayer3.Skin.Game_Lyric_BackColor ))
            {
                this.tx歌詞テクスチャ = TJAPlayer3.tテクスチャの生成( bmpleric, false );
            }
        }

        /// <summary>
        /// レイヤー管理のため、On進行描画から分離。
        /// </summary>
        public void t歌詞テクスチャを描画する()
        {
<<<<<<< HEAD
            if( this.tx歌詞テクスチャ != null )
            {
                if (TJAPlayer3.Skin.Game_Lyric_ReferencePoint == CSkin.ReferencePoint.Left)
                {
                this.tx歌詞テクスチャ.t2D描画(TJAPlayer3.app.Device, TJAPlayer3.Skin.Game_Lyric_X , TJAPlayer3.Skin.Game_Lyric_Y);
                }
                else if (TJAPlayer3.Skin.Game_Lyric_ReferencePoint == CSkin.ReferencePoint.Right)
                {
                this.tx歌詞テクスチャ.t2D描画(TJAPlayer3.app.Device, TJAPlayer3.Skin.Game_Lyric_X - this.tx歌詞テクスチャ.szテクスチャサイズ.Width, TJAPlayer3.Skin.Game_Lyric_Y);
                }
                else
                {
                this.tx歌詞テクスチャ.t2D描画(TJAPlayer3.app.Device, TJAPlayer3.Skin.Game_Lyric_X - (this.tx歌詞テクスチャ.szテクスチャサイズ.Width / 2), TJAPlayer3.Skin.Game_Lyric_Y);
                }
            }
        }

		public void Stop()
		{
			this.bMute = true;
		}
		public void Start()
		{
			this.bMute = false;
		}


=======
            tx歌詞テクスチャ?.t2D描画(TJAPlayer3.app.Device, TJAPlayer3.Skin.Game_Lyric_XY[0] , TJAPlayer3.Skin.Game_Lyric_XY[1], TJAPlayer3.Skin.GameLyricHorizontalReferencePoint);
        }

>>>>>>> twopointzero/develop
		// CActivity 実装

		public override void On活性化()
		{
<<<<<<< HEAD
            if( !string.IsNullOrEmpty( TJAPlayer3.ConfigIni.FontName ) )
                this.pfMusicName = new CPrivateFastFont( new FontFamily( TJAPlayer3.ConfigIni.FontName), TJAPlayer3.Skin.Game_MusicName_FontSize);
            else
                this.pfMusicName = new CPrivateFastFont( new FontFamily("MS UI Gothic"), TJAPlayer3.Skin.Game_MusicName_FontSize);

            if( !string.IsNullOrEmpty(TJAPlayer3.Skin.Game_Lyric_FontName))
            {
                this.pf歌詞フォント = new CPrivateFastFont(new FontFamily(TJAPlayer3.Skin.Game_Lyric_FontName), TJAPlayer3.Skin.Game_Lyric_FontSize);
            }
            else
            {
                this.pf歌詞フォント = new CPrivateFastFont(new FontFamily("MS UI Gothic"), TJAPlayer3.Skin.Game_Lyric_FontSize);
            }

			this.txPanel = null;
			this.ct進行用 = new CCounter();
			this.Start();
=======
            this.pfMusicName = new CPrivateFastFont(FontUtilities.GetFontFamilyOrFallback(TJAPlayer3.ConfigIni.FontName), TJAPlayer3.Skin.Game_MusicName_FontSize);
            this.pf歌詞フォント = new CPrivateFastFont(FontUtilities.GetFontFamilyOrFallback(TJAPlayer3.Skin.Game_Lyric_FontName), TJAPlayer3.Skin.Game_Lyric_FontSize);

			this.txPanel = null;
			this.ct進行用 = new CCounter();
>>>>>>> twopointzero/develop
            this.bFirst = true;
			base.On活性化();
		}
		public override void On非活性化()
		{
			this.ct進行用 = null;
			base.On非活性化();
		}
		public override void OnManagedリソースの作成()
		{
			if( !base.b活性化してない )
			{
				base.OnManagedリソースの作成();
			}
		}
<<<<<<< HEAD
		public override void OnManagedリソースの解放()
		{
			if( !base.b活性化してない )
			{
				TJAPlayer3.tテクスチャの解放( ref this.txPanel );
				TJAPlayer3.tテクスチャの解放( ref this.txMusicName );
                TJAPlayer3.tテクスチャの解放( ref this.txGENRE );
                TJAPlayer3.tテクスチャの解放( ref this.txSONGS);
                TJAPlayer3.tテクスチャの解放(ref this.txPanel);
                TJAPlayer3.tテクスチャの解放(ref this.tx歌詞テクスチャ);
                TJAPlayer3.t安全にDisposeする(ref this.pfMusicName);
                TJAPlayer3.t安全にDisposeする(ref this.pf歌詞フォント);
                base.OnManagedリソースの解放();
			}
		}
=======

        public override void OnManagedリソースの解放()
        {
            if (!b活性化してない)
            {
                TJAPlayer3.t安全にDisposeする(ref txPanel);
                TJAPlayer3.t安全にDisposeする(ref txMusicName);
                txGENRE = null;
                TJAPlayer3.t安全にDisposeする(ref txPanel);
                TJAPlayer3.t安全にDisposeする(ref tx歌詞テクスチャ);
                TJAPlayer3.t安全にDisposeする(ref pfMusicName);
                TJAPlayer3.t安全にDisposeする(ref pf歌詞フォント);
                TJAPlayer3.t安全にDisposeする(ref tx難易度とステージ数);
                base.OnManagedリソースの解放();
            }
        }

>>>>>>> twopointzero/develop
		public override int On進行描画()
		{
			throw new InvalidOperationException( "t進行描画(x,y)のほうを使用してください。" );
		}
<<<<<<< HEAD
		public int t進行描画( int x, int y )
		{
            if (TJAPlayer3.stage演奏ドラム画面.actDan.IsAnimating) return 0;
			if( !base.b活性化してない && !this.bMute )
			{
				this.ct進行用.t進行Loop();

                if( this.txGENRE != null )
                    this.txGENRE.t2D描画( TJAPlayer3.app.Device, TJAPlayer3.Skin.Game_Genre_X, TJAPlayer3.Skin.Game_Genre_Y );

                if (this.txSONGS != null)
                    txSONGS.t2D描画(TJAPlayer3.app.Device, TJAPlayer3.Skin.Game_Genre_X, TJAPlayer3.Skin.Game_Genre_Y);

                if ( TJAPlayer3.Skin.b現在のステージ数を表示しない )
                {
=======
		public void t進行描画()
        {
            if (TJAPlayer3.stage演奏ドラム画面.actDan.IsAnimating)
            {
                return;
            }

            if (!base.b活性化してない)
            {
                if(this.b初めての進行描画)
                {
                    b初めての進行描画 = false;
                }

                this.ct進行用.t進行Loop();
                if( this.bFirst )
                {
                    this.ct進行用.n現在の値 = 300;
                }

                if( TJAPlayer3.Skin.b現在のステージ数を表示しない )
                {
                    txGENRE?.t2D描画(TJAPlayer3.app.Device, TJAPlayer3.Skin.Game_Genre_XY[0], TJAPlayer3.Skin.Game_Genre_XY[1]);

>>>>>>> twopointzero/develop
                    if( this.txMusicName != null )
                    {
                        float fRate = 660.0f / this.txMusicName.szテクスチャサイズ.Width;
                        if (this.txMusicName.szテクスチャサイズ.Width <= 660.0f)
                            fRate = 1.0f;
                        this.txMusicName.vc拡大縮小倍率.X = fRate;
<<<<<<< HEAD
                        if (TJAPlayer3.Skin.Game_MusicName_ReferencePoint == CSkin.ReferencePoint.Center)
                        {
                            this.txMusicName.t2D描画(TJAPlayer3.app.Device, TJAPlayer3.Skin.Game_MusicName_X - ((this.txMusicName.szテクスチャサイズ.Width * fRate) / 2), TJAPlayer3.Skin.Game_MusicName_Y);
                        }
                        else if (TJAPlayer3.Skin.Game_MusicName_ReferencePoint == CSkin.ReferencePoint.Left)
                        {
                            this.txMusicName.t2D描画(TJAPlayer3.app.Device, TJAPlayer3.Skin.Game_MusicName_X, TJAPlayer3.Skin.Game_MusicName_Y);
                        }
                        else
                        {
                            this.txMusicName.t2D描画(TJAPlayer3.app.Device, TJAPlayer3.Skin.Game_MusicName_X - (this.txMusicName.szテクスチャサイズ.Width * fRate), TJAPlayer3.Skin.Game_MusicName_Y);
                        }
=======
                        this.txMusicName.t2D描画(TJAPlayer3.app.Device, TJAPlayer3.Skin.Game_MusicName_XY[0], TJAPlayer3.Skin.Game_MusicName_XY[1], TJAPlayer3.Skin.GameMusicNameHorizontalReferencePoint);
>>>>>>> twopointzero/develop
                    }
                }
                else
                {
                    #region[ 透明度制御 ]

<<<<<<< HEAD
                    if (this.ct進行用.n現在の値 < 745)
                    {
                        txSONGS.Opacity = 0;
                    }
                    else if (this.ct進行用.n現在の値 >= 745 && this.ct進行用.n現在の値 < 1000)
                    {
                        txSONGS.Opacity = (this.ct進行用.n現在の値 - 745);
                    }
                    else if (this.ct進行用.n現在の値 >= 1000 && this.ct進行用.n現在の値 <= 1745)
                    {
                        txSONGS.Opacity = 255;
                    }
                    else if (this.ct進行用.n現在の値 >= 1745)
                    {
                        txSONGS.Opacity = 255 - (this.ct進行用.n現在の値 - 1745);
                    }
                    #endregion

                    if ( this.txMusicName != null )
                    {
                        if(this.b初めての進行描画)
                        {
                            b初めての進行描画 = false;
                        }
                        if (TJAPlayer3.Skin.Game_MusicName_ReferencePoint == CSkin.ReferencePoint.Center)
                        {
                            this.txMusicName.t2D描画(TJAPlayer3.app.Device, TJAPlayer3.Skin.Game_MusicName_X - ((this.txMusicName.szテクスチャサイズ.Width * txMusicName.vc拡大縮小倍率.X) / 2), TJAPlayer3.Skin.Game_MusicName_Y);
                        }
                        else if (TJAPlayer3.Skin.Game_MusicName_ReferencePoint == CSkin.ReferencePoint.Left)
                        {
                            this.txMusicName.t2D描画(TJAPlayer3.app.Device, TJAPlayer3.Skin.Game_MusicName_X, TJAPlayer3.Skin.Game_MusicName_Y);
                        }
                        else
                        {
                            this.txMusicName.t2D描画(TJAPlayer3.app.Device, TJAPlayer3.Skin.Game_MusicName_X - (this.txMusicName.szテクスチャサイズ.Width * txMusicName.vc拡大縮小倍率.X), TJAPlayer3.Skin.Game_MusicName_Y);
                        }
                    }
                }
			}
			return 0;
=======
                    if (ct進行用.n現在の値 < 745)
                    {
                        bFirst = false;
                    }

                    var opacity = 255;
                    if (ct進行用.n現在の値 < 745)
                    {
                        opacity = 255;
                    }
                    else if (ct進行用.n現在の値 >= 745 && ct進行用.n現在の値 < 1000)
                    {
                        opacity = 255 - (ct進行用.n現在の値 - 745);
                    }
                    else if (ct進行用.n現在の値 >= 1000 && ct進行用.n現在の値 <= 1745)
                    {
                        opacity = 0;
                    }
                    else if (ct進行用.n現在の値 >= 1745)
                    {
                        opacity = ct進行用.n現在の値 - 1745;
                    }

                    if (txGENRE != null)
                    {
                        txGENRE.Opacity = opacity;
                    }

                    if (txMusicName != null)
                    {
                        txMusicName.Opacity = opacity;
                    }

                    if (tx難易度とステージ数 != null)
                    {
                        tx難易度とステージ数.Opacity = 255 - opacity;
                    }

                    #endregion

                    txGENRE?.t2D描画(TJAPlayer3.app.Device, TJAPlayer3.Skin.Game_Genre_XY[0], TJAPlayer3.Skin.Game_Genre_XY[1]);

                    txMusicName?.t2D描画(TJAPlayer3.app.Device, TJAPlayer3.Skin.Game_MusicName_XY[0], TJAPlayer3.Skin.Game_MusicName_XY[1], TJAPlayer3.Skin.GameMusicNameHorizontalReferencePoint);

                    tx難易度とステージ数?.t2D描画(TJAPlayer3.app.Device, TJAPlayer3.Skin.Game_MusicName_XY[0], TJAPlayer3.Skin.Game_MusicName_XY[1], TJAPlayer3.Skin.GameMusicNameHorizontalReferencePoint);
                }
            }
>>>>>>> twopointzero/develop
		}


		// その他

		#region [ private ]
		//-----------------
		private CCounter ct進行用;

		private CTexture txPanel;
<<<<<<< HEAD
		private bool bMute;
        private bool bFirst;

        private CTexture txMusicName;
        private CTexture txGENRE;
        private CTexture txSONGS;
=======
        private bool bFirst;

        private CTexture txMusicName;
        private CTexture tx難易度とステージ数;
        private CTexture txGENRE;
>>>>>>> twopointzero/develop
        private CTexture tx歌詞テクスチャ;
        private CPrivateFastFont pfMusicName;
        private CPrivateFastFont pf歌詞フォント;
		//-----------------
		#endregion
	}
}
　
