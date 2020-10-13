using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.Text;
=======
>>>>>>> twopointzero/develop
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Drawing;
using SlimDX.DirectInput;
using FDK;
<<<<<<< HEAD
using System.Reflection;
=======
>>>>>>> twopointzero/develop

namespace TJAPlayer3
{
	internal class CStageタイトル : CStage
	{
		// コンストラクタ

		public CStageタイトル()
		{
			base.eステージID = CStage.Eステージ.タイトル;
			base.b活性化してない = true;
<<<<<<< HEAD
			base.list子Activities.Add( this.actFIfromSetup = new CActFIFOBlack() );
			base.list子Activities.Add( this.actFI = new CActFIFOBlack() );
			base.list子Activities.Add( this.actFO = new CActFIFOBlack() );
=======
			base.list子Activities.Add(this.actFIfromSetup = new CActFIFOWhite());
			base.list子Activities.Add(this.actFI = new CActFIFOWhite());
			base.list子Activities.Add(this.actFO = new CActFIFOWhite());
>>>>>>> twopointzero/develop
		}


		// CStage 実装

		public override void On活性化()
		{
<<<<<<< HEAD
			Trace.TraceInformation( "タイトルステージを活性化します。" );
			Trace.Indent();
			try
			{
				TJAPlayer3.Skin.soundタイトルスタート音.t再生する();
				for ( int i = 0; i < 4; i++ )
				{
					this.ctキー反復用[ i ] = new CCounter( 0, 0, 0, TJAPlayer3.Timer );
=======
			Trace.TraceInformation("タイトルステージを活性化します。");
			Trace.Indent();
			try
			{
				for (int i = 0; i < 4; i++)
				{
					this.ctキー反復用[i] = new CCounter(0, 0, 0, TJAPlayer3.Timer);
>>>>>>> twopointzero/develop
				}
				this.ct上移動用 = new CCounter();
				this.ct下移動用 = new CCounter();
				this.ctカーソルフラッシュ用 = new CCounter();
<<<<<<< HEAD
				TJAPlayer3.NamePlate.tNamePlateInit();
=======
>>>>>>> twopointzero/develop
				base.On活性化();
			}
			finally
			{
<<<<<<< HEAD
				Trace.TraceInformation( "タイトルステージの活性化を完了しました。" );
=======
				Trace.TraceInformation("タイトルステージの活性化を完了しました。");
>>>>>>> twopointzero/develop
				Trace.Unindent();
			}
		}
		public override void On非活性化()
		{
<<<<<<< HEAD
			Trace.TraceInformation( "タイトルステージを非活性化します。" );
			Trace.Indent();
			try
			{
				for( int i = 0; i < 4; i++ )
				{
					this.ctキー反復用[ i ] = null;
=======
			Trace.TraceInformation("タイトルステージを非活性化します。");
			Trace.Indent();
			try
			{
				for (int i = 0; i < 4; i++)
				{
					this.ctキー反復用[i] = null;
>>>>>>> twopointzero/develop
				}
				this.ct上移動用 = null;
				this.ct下移動用 = null;
				this.ctカーソルフラッシュ用 = null;
			}
			finally
			{
<<<<<<< HEAD
				Trace.TraceInformation( "タイトルステージの非活性化を完了しました。" );
=======
				Trace.TraceInformation("タイトルステージの非活性化を完了しました。");
>>>>>>> twopointzero/develop
				Trace.Unindent();
			}
			base.On非活性化();
		}
		public override void OnManagedリソースの作成()
		{
			//if( !base.b活性化してない )
			//{
			//	this.tx背景 = CDTXMania.tテクスチャの生成( CSkin.Path(@"Graphics\2_background.png"));
			//	this.txメニュー = CDTXMania.tテクスチャの生成( CSkin.Path( @"Graphics\2_menu.png" ));
			//	base.OnManagedリソースの作成();
			//}
		}
		public override void OnManagedリソースの解放()
		{
			//if( !base.b活性化してない )
			//{
			//	CDTXMania.tテクスチャの解放( ref this.tx背景 );
			//	CDTXMania.tテクスチャの解放( ref this.txメニュー );
			//	base.OnManagedリソースの解放();
			//}
		}
		public override int On進行描画()
		{
<<<<<<< HEAD
			if( !base.b活性化してない )
			{
				#region [ 初めての進行描画 ]
				//---------------------
				if( base.b初めての進行描画 )
				{
					if( TJAPlayer3.r直前のステージ == TJAPlayer3.stage起動 )
=======
			if (!base.b活性化してない)
			{
				#region [ 初めての進行描画 ]
				//---------------------
				if (base.b初めての進行描画)
				{
					if (TJAPlayer3.r直前のステージ == TJAPlayer3.stage起動)
>>>>>>> twopointzero/develop
					{
						this.actFIfromSetup.tフェードイン開始();
						base.eフェーズID = CStage.Eフェーズ.タイトル_起動画面からのフェードイン;
					}
					else
					{
						this.actFI.tフェードイン開始();
						base.eフェーズID = CStage.Eフェーズ.共通_フェードイン;
					}
<<<<<<< HEAD
					this.ctカーソルフラッシュ用.t開始( 0, 700, 5, TJAPlayer3.Timer );
					this.ctカーソルフラッシュ用.n現在の値 = 100;
					base.b初めての進行描画 = false;
                }
=======
					this.ctカーソルフラッシュ用.t開始(0, 700, 5, TJAPlayer3.Timer);
					this.ctカーソルフラッシュ用.n現在の値 = 100;
					base.b初めての進行描画 = false;
				}
>>>>>>> twopointzero/develop
				//---------------------
				#endregion

				// 進行

				#region [ カーソル上移動 ]
				//---------------------
<<<<<<< HEAD
				if( this.ct上移動用.b進行中 )
				{
					this.ct上移動用.t進行();
					if( this.ct上移動用.b終了値に達した )
=======
				if (this.ct上移動用.b進行中)
				{
					this.ct上移動用.t進行();
					if (this.ct上移動用.b終了値に達した)
>>>>>>> twopointzero/develop
					{
						this.ct上移動用.t停止();
					}
				}
				//---------------------
				#endregion
				#region [ カーソル下移動 ]
				//---------------------
<<<<<<< HEAD
				if( this.ct下移動用.b進行中 )
				{
					this.ct下移動用.t進行();
					if( this.ct下移動用.b終了値に達した )
=======
				if (this.ct下移動用.b進行中)
				{
					this.ct下移動用.t進行();
					if (this.ct下移動用.b終了値に達した)
>>>>>>> twopointzero/develop
					{
						this.ct下移動用.t停止();
					}
				}
				//---------------------
				#endregion
				#region [ カーソルフラッシュ ]
				//---------------------
				this.ctカーソルフラッシュ用.t進行Loop();
				//---------------------
				#endregion

				// キー入力

<<<<<<< HEAD
				if( base.eフェーズID == CStage.Eフェーズ.共通_通常状態		// 通常状態、かつ
					&& TJAPlayer3.act現在入力を占有中のプラグイン == null )	// プラグインの入力占有がない
				{
					if( TJAPlayer3.Input管理.Keyboard.bキーが押された( (int) Key.Escape ) )
						return (int) E戻り値.EXIT;

					this.ctキー反復用.Up.tキー反復( TJAPlayer3.Input管理.Keyboard.bキーが押されている( (int)SlimDX.DirectInput.Key.UpArrow ), new CCounter.DGキー処理( this.tカーソルを上へ移動する ) );
					this.ctキー反復用.R.tキー反復( TJAPlayer3.Pad.b押されているGB( Eパッド.HH ), new CCounter.DGキー処理( this.tカーソルを上へ移動する ) );
					if( TJAPlayer3.Pad.b押された( E楽器パート.DRUMS, Eパッド.SD ) )
						this.tカーソルを上へ移動する();

					this.ctキー反復用.Down.tキー反復( TJAPlayer3.Input管理.Keyboard.bキーが押されている( (int)SlimDX.DirectInput.Key.DownArrow ), new CCounter.DGキー処理( this.tカーソルを下へ移動する ) );
					this.ctキー反復用.B.tキー反復( TJAPlayer3.Pad.b押されているGB( Eパッド.BD ), new CCounter.DGキー処理( this.tカーソルを下へ移動する ) );
					if( TJAPlayer3.Pad.b押された( E楽器パート.DRUMS, Eパッド.LT ) )
						this.tカーソルを下へ移動する();

					if( ( TJAPlayer3.Pad.b押されたDGB( Eパッド.CY ) || TJAPlayer3.Pad.b押された( E楽器パート.DRUMS, Eパッド.RD ) ) || ( TJAPlayer3.Pad.b押された( E楽器パート.DRUMS, Eパッド.LC ) || ( TJAPlayer3.ConfigIni.bEnterがキー割り当てのどこにも使用されていない && TJAPlayer3.Input管理.Keyboard.bキーが押された( (int)SlimDX.DirectInput.Key.Return ) ) ) )
					{
						if (TJAPlayer3.stage選曲.act曲リスト.r現在選択中の曲 != null)
						{
							if ((this.n現在のカーソル行 == (int)E戻り値.GAMESTART - 1))
							{
								TJAPlayer3.Skin.soundタイトル音.t停止する();
								TJAPlayer3.Skin.soundタイトルスタート音.t停止する();
								TJAPlayer3.Skin.soundゲーム開始音.t再生する();
							}
							else
							{
								TJAPlayer3.Skin.sound決定音.t再生する();
							}
							if (this.n現在のカーソル行 == (int)E戻り値.EXIT - 1)
							{
								return (int)E戻り値.EXIT;
							}
							this.actFO.tフェードアウト開始();
							base.eフェーズID = CStage.Eフェーズ.共通_フェードアウト;
						}
					}
//					if ( CDTXMania.Input管理.Keyboard.bキーが押された( (int) Key.Space ) )
//						Trace.TraceInformation( "DTXMania Title: SPACE key registered. " + CDTXMania.ct.nシステム時刻 );
				}

				// 描画

				if (!TJAPlayer3.Skin.soundタイトルスタート音.b再生中 && (base.eフェーズID == CStage.Eフェーズ.共通_通常状態))
				{
                    if (!b曲再生)
                    {
						TJAPlayer3.Skin.soundタイトル音.t再生する();
						b曲再生 = true;
					}
				}
                else
                {
					TJAPlayer3.Skin.soundタイトル音.n位置_現在のサウンド = 0;
				}

				if (TJAPlayer3.Tx.Title_Background != null )
                    TJAPlayer3.Tx.Title_Background.t2D描画( TJAPlayer3.app.Device, 0, 0 );

                #region[ バージョン表示 ]
                //string strVersion = "KTT:J:A:I:2017072200";
                string strCreator = "https://github.com/touhourenren/TJAPlayer3-Develop";
                AssemblyName asmApp = Assembly.GetExecutingAssembly().GetName();
#if DEBUG
                TJAPlayer3.act文字コンソール.tPrint(4, 44, C文字コンソール.Eフォント種別.白, "DEBUG BUILD");
#endif
                TJAPlayer3.act文字コンソール.tPrint(4, (720 - 48), C文字コンソール.Eフォント種別.白, $"{TJAPlayer3.AppDisplayName} - Created by KabanFriends");
				TJAPlayer3.act文字コンソール.tPrint(4, (720 - 24), C文字コンソール.Eフォント種別.白, $"(An unofficial continuation of TJAPlayer3-Develop by touhou-renren)");
				#endregion

				TJAPlayer3.NamePlate.tNamePlateDraw(0, 0);

				if ( TJAPlayer3.Tx.Title_Menu != null )
				{
					int x = MENU_X;
					int y = MENU_Y + ( this.n現在のカーソル行 * MENU_H );
					if( this.ct上移動用.b進行中 )
					{
						y += (int) ( (double)MENU_H / 2 * ( Math.Cos( Math.PI * ( ( (double) this.ct上移動用.n現在の値 ) / 100.0 ) ) + 1.0 ) );
					}
					else if( this.ct下移動用.b進行中 )
					{
						y -= (int) ( (double)MENU_H / 2 * ( Math.Cos( Math.PI * ( ( (double) this.ct下移動用.n現在の値 ) / 100.0 ) ) + 1.0 ) );
					}
					if( this.ctカーソルフラッシュ用.n現在の値 <= 100 )
					{
						float nMag = (float) ( 1.0 + ( ( ( (double) this.ctカーソルフラッシュ用.n現在の値 ) / 100.0 ) * 0.5 ) );
                        TJAPlayer3.Tx.Title_Menu.vc拡大縮小倍率.X = nMag;
                        TJAPlayer3.Tx.Title_Menu.vc拡大縮小倍率.Y = nMag;
                        TJAPlayer3.Tx.Title_Menu.Opacity = (int) ( 255.0 * ( 1.0 - ( ( (double) this.ctカーソルフラッシュ用.n現在の値 ) / 100.0 ) ) );
						int x_magnified = x + ( (int) ( ( MENU_W * ( 1.0 - nMag ) ) / 2.0 ) );
						int y_magnified = y + ( (int) ( ( MENU_H * ( 1.0 - nMag ) ) / 2.0 ) );
                        TJAPlayer3.Tx.Title_Menu.t2D描画( TJAPlayer3.app.Device, x_magnified, y_magnified, new Rectangle( 0, MENU_H * 5, MENU_W, MENU_H ) );
					}
                    TJAPlayer3.Tx.Title_Menu.vc拡大縮小倍率.X = 1f;
                    TJAPlayer3.Tx.Title_Menu.vc拡大縮小倍率.Y = 1f;
                    TJAPlayer3.Tx.Title_Menu.Opacity = 0xff;
                    TJAPlayer3.Tx.Title_Menu.t2D描画( TJAPlayer3.app.Device, x, y, new Rectangle( 0, MENU_H * 4, MENU_W, MENU_H ) );
				}
				if( TJAPlayer3.Tx.Title_Menu != null )
				{
                    //this.txメニュー.t2D描画( CDTXMania.app.Device, 0xce, 0xcb, new Rectangle( 0, 0, MENU_W, MWNU_H ) );
                    // #24525 2011.3.16 yyagi: "OPTION"を省いて描画。従来スキンとの互換性確保のため。
                    TJAPlayer3.Tx.Title_Menu.t2D描画( TJAPlayer3.app.Device, MENU_X, MENU_Y, new Rectangle( 0, 0, MENU_W, MENU_H ) );
                    TJAPlayer3.Tx.Title_Menu.t2D描画( TJAPlayer3.app.Device, MENU_X, MENU_Y + MENU_H, new Rectangle( 0, MENU_H * 2, MENU_W, MENU_H * 2 ) );
				}


                //CDTXMania.act文字コンソール.tPrint(0, 80, C文字コンソール.Eフォント種別.白, point.X.ToString());
                //CDTXMania.act文字コンソール.tPrint(0, 100, C文字コンソール.Eフォント種別.白, point.Y.ToString());
                //CDTXMania.act文字コンソール.tPrint(0, 120, C文字コンソール.Eフォント種別.白, scaling.ToString());


                CStage.Eフェーズ eフェーズid = base.eフェーズID;
				switch( eフェーズid )
				{
					case CStage.Eフェーズ.共通_フェードイン:
						if( this.actFI.On進行描画() != 0 )
						{
							b曲再生 = false;
=======
				if (base.eフェーズID == CStage.Eフェーズ.共通_通常状態)   // 通常状態
				{
					if (TJAPlayer3.Input管理.Keyboard.bキーが押された((int)Key.Escape))
						return (int)E戻り値.EXIT;

					this.ctキー反復用.Up.tキー反復(TJAPlayer3.Input管理.Keyboard.bキーが押されている((int)SlimDX.DirectInput.Key.UpArrow), new CCounter.DGキー処理(this.tカーソルを上へ移動する));
					this.ctキー反復用.R.tキー反復(TJAPlayer3.Pad.b押されているGB(Eパッド.HH), new CCounter.DGキー処理(this.tカーソルを上へ移動する));
					if (TJAPlayer3.Pad.b押された(E楽器パート.DRUMS, Eパッド.SD))
						this.tカーソルを上へ移動する();

					this.ctキー反復用.Down.tキー反復(TJAPlayer3.Input管理.Keyboard.bキーが押されている((int)SlimDX.DirectInput.Key.DownArrow), new CCounter.DGキー処理(this.tカーソルを下へ移動する));
					this.ctキー反復用.B.tキー反復(TJAPlayer3.Pad.b押されているGB(Eパッド.BD), new CCounter.DGキー処理(this.tカーソルを下へ移動する));
					if (TJAPlayer3.Pad.b押された(E楽器パート.DRUMS, Eパッド.LT))
						this.tカーソルを下へ移動する();

					if ((TJAPlayer3.Pad.b押されたDGB(Eパッド.CY) || TJAPlayer3.Pad.b押された(E楽器パート.DRUMS, Eパッド.RD)) || (TJAPlayer3.Pad.b押された(E楽器パート.DRUMS, Eパッド.LC) || (TJAPlayer3.ConfigIni.bEnterがキー割り当てのどこにも使用されていない && TJAPlayer3.Input管理.Keyboard.bキーが押された((int)SlimDX.DirectInput.Key.Return))))
					{
						if ((this.n現在のカーソル行 == (int)E戻り値.GAMESTART - 1) && TJAPlayer3.Skin.soundゲーム開始音.b読み込み成功)
						{
							TJAPlayer3.Skin.soundゲーム開始音.t再生する();
						}
						else
						{
							TJAPlayer3.Skin.sound決定音.t再生する();
						}
						if (this.n現在のカーソル行 == (int)E戻り値.EXIT - 1)
						{
							return (int)E戻り値.EXIT;
						}
						this.actFO.tフェードアウト開始();
						base.eフェーズID = CStage.Eフェーズ.共通_フェードアウト;
					}
					//					if ( CDTXMania.Input管理.Keyboard.bキーが押された( (int) Key.Space ) )
					//						Trace.TraceInformation( "DTXMania Title: SPACE key registered. " + CDTXMania.ct.nシステム時刻 );
				}

				// 描画
                TJAPlayer3.Tx.Title_Background?.t2D描画( TJAPlayer3.app.Device, 0, 0 );

				#region[ バージョン表示 ]
				const string repositoryUrl = "https://github.com/KabanFriends/TJAPlayer3";
#if DEBUG
				TJAPlayer3.act文字コンソール.tPrint(4, 44, C文字コンソール.Eフォント種別.白, "DEBUG BUILD");
#endif
				TJAPlayer3.act文字コンソール.tPrint(4, 4, C文字コンソール.Eフォント種別.白, $"{TJAPlayer3.AppDisplayNameWithInformationalVersion} ({repositoryUrl};Fork of twopointzero/TJAPlayer3)");
				TJAPlayer3.act文字コンソール.tPrint(4, 24, C文字コンソール.Eフォント種別.白, "Skin:" + TJAPlayer3.Skin.Skin_Name + " Ver." + TJAPlayer3.Skin.Skin_Version + " (" + TJAPlayer3.Skin.Skin_Creator + ")");
				//CDTXMania.act文字コンソール.tPrint(4, 24, C文字コンソール.Eフォント種別.白, strSubTitle);
				TJAPlayer3.act文字コンソール.tPrint(4, (720 - 24), C文字コンソール.Eフォント種別.白, $"{TJAPlayer3.AppDisplayName} is open source software under the MIT license. See README for acknowledgments.");
				#endregion


				if (TJAPlayer3.Tx.Title_Menu != null)
				{
					int x = MENU_X;
					int y = MENU_Y + (this.n現在のカーソル行 * MENU_H);
					if (this.ct上移動用.b進行中)
					{
						y += (int)((double)MENU_H / 2 * (Math.Cos(Math.PI * (((double)this.ct上移動用.n現在の値) / 100.0)) + 1.0));
					}
					else if (this.ct下移動用.b進行中)
					{
						y -= (int)((double)MENU_H / 2 * (Math.Cos(Math.PI * (((double)this.ct下移動用.n現在の値) / 100.0)) + 1.0));
					}
					if (this.ctカーソルフラッシュ用.n現在の値 <= 100)
					{
						float nMag = (float)(1.0 + ((((double)this.ctカーソルフラッシュ用.n現在の値) / 100.0) * 0.5));
						TJAPlayer3.Tx.Title_Menu.vc拡大縮小倍率.X = nMag;
						TJAPlayer3.Tx.Title_Menu.vc拡大縮小倍率.Y = nMag;
						TJAPlayer3.Tx.Title_Menu.Opacity = (int)(255.0 * (1.0 - (((double)this.ctカーソルフラッシュ用.n現在の値) / 100.0)));
						int x_magnified = x + ((int)((MENU_W * (1.0 - nMag)) / 2.0));
						int y_magnified = y + ((int)((MENU_H * (1.0 - nMag)) / 2.0));
						TJAPlayer3.Tx.Title_Menu.t2D描画(TJAPlayer3.app.Device, x_magnified, y_magnified, new Rectangle(0, MENU_H * 5, MENU_W, MENU_H));
					}
					TJAPlayer3.Tx.Title_Menu.vc拡大縮小倍率.X = 1f;
					TJAPlayer3.Tx.Title_Menu.vc拡大縮小倍率.Y = 1f;
					TJAPlayer3.Tx.Title_Menu.Opacity = 0xff;
					TJAPlayer3.Tx.Title_Menu.t2D描画(TJAPlayer3.app.Device, x, y, new Rectangle(0, MENU_H * 4, MENU_W, MENU_H));
				}
				if (TJAPlayer3.Tx.Title_Menu != null)
				{
					//this.txメニュー.t2D描画( CDTXMania.app.Device, 0xce, 0xcb, new Rectangle( 0, 0, MENU_W, MWNU_H ) );
					// #24525 2011.3.16 yyagi: "OPTION"を省いて描画。従来スキンとの互換性確保のため。
					TJAPlayer3.Tx.Title_Menu.t2D描画(TJAPlayer3.app.Device, MENU_X, MENU_Y, new Rectangle(0, 0, MENU_W, MENU_H));
					TJAPlayer3.Tx.Title_Menu.t2D描画(TJAPlayer3.app.Device, MENU_X, MENU_Y + MENU_H, new Rectangle(0, MENU_H * 2, MENU_W, MENU_H * 2));
				}

				// URLの座標が押されたらブラウザで開いてやる 兼 マウスクリックのテスト
				// クライアント領域内のカーソル座標を取得する。
				// point.X、point.Yは負の値になることもある。
				var point = TJAPlayer3.app.Window.PointToClient(System.Windows.Forms.Cursor.Position);
				// クライアント領域の横幅を取得して、1280で割る。もちろんdouble型。
				var scaling = 1.000 * TJAPlayer3.app.Window.ClientSize.Width / 1280;
				if (TJAPlayer3.Input管理.Mouse.bキーが押された((int)MouseObject.Button1))
				{
					if (point.X >= 180 * scaling && point.X <= 490 * scaling && point.Y >= 0 && point.Y <= 20 * scaling)
						System.Diagnostics.Process.Start(repositoryUrl);
				}

				//CDTXMania.act文字コンソール.tPrint(0, 80, C文字コンソール.Eフォント種別.白, point.X.ToString());
				//CDTXMania.act文字コンソール.tPrint(0, 100, C文字コンソール.Eフォント種別.白, point.Y.ToString());
				//CDTXMania.act文字コンソール.tPrint(0, 120, C文字コンソール.Eフォント種別.白, scaling.ToString());


				CStage.Eフェーズ eフェーズid = base.eフェーズID;
				switch (eフェーズid)
				{
					case CStage.Eフェーズ.共通_フェードイン:
						if (this.actFI.On進行描画() != 0)
						{
							TJAPlayer3.Skin.soundタイトル音.t再生する();
>>>>>>> twopointzero/develop
							base.eフェーズID = CStage.Eフェーズ.共通_通常状態;
						}
						break;

					case CStage.Eフェーズ.共通_フェードアウト:
<<<<<<< HEAD
						if( this.actFO.On進行描画() == 0 )
=======
						if (this.actFO.On進行描画() == 0)
>>>>>>> twopointzero/develop
						{
							break;
						}
						base.eフェーズID = CStage.Eフェーズ.共通_終了状態;
<<<<<<< HEAD
						switch ( this.n現在のカーソル行 )
=======
						switch (this.n現在のカーソル行)
>>>>>>> twopointzero/develop
						{
							case (int)E戻り値.GAMESTART - 1:
								return (int)E戻り値.GAMESTART;

<<<<<<< HEAD
							case (int) E戻り値.CONFIG - 1:
								return (int) E戻り値.CONFIG;

							case (int)E戻り値.EXIT - 1:
								return (int) E戻り値.EXIT;
=======
							case (int)E戻り値.CONFIG - 1:
								return (int)E戻り値.CONFIG;

							case (int)E戻り値.EXIT - 1:
								return (int)E戻り値.EXIT;
>>>>>>> twopointzero/develop
								//return ( this.n現在のカーソル行 + 1 );
						}
						break;

					case CStage.Eフェーズ.タイトル_起動画面からのフェードイン:
<<<<<<< HEAD
						if( this.actFIfromSetup.On進行描画() != 0 )
						{
=======
						if (this.actFIfromSetup.On進行描画() != 0)
						{
							TJAPlayer3.Skin.soundタイトル音.t再生する();
>>>>>>> twopointzero/develop
							base.eフェーズID = CStage.Eフェーズ.共通_通常状態;
						}
						break;
				}
			}
			return 0;
		}
		public enum E戻り値
		{
			継続 = 0,
			GAMESTART,
<<<<<<< HEAD
//			OPTION,
=======
			//			OPTION,
>>>>>>> twopointzero/develop
			CONFIG,
			EXIT
		}


		// その他

		#region [ private ]
		//-----------------
<<<<<<< HEAD
		[StructLayout( LayoutKind.Sequential )]
=======
		[StructLayout(LayoutKind.Sequential)]
>>>>>>> twopointzero/develop
		private struct STキー反復用カウンタ
		{
			public CCounter Up;
			public CCounter Down;
			public CCounter R;
			public CCounter B;
<<<<<<< HEAD
			public CCounter this[ int index ]
			{
				get
				{
					switch( index )
=======
			public CCounter this[int index]
			{
				get
				{
					switch (index)
>>>>>>> twopointzero/develop
					{
						case 0:
							return this.Up;

						case 1:
							return this.Down;

						case 2:
							return this.R;

						case 3:
							return this.B;
					}
					throw new IndexOutOfRangeException();
				}
				set
				{
<<<<<<< HEAD
					switch( index )
=======
					switch (index)
>>>>>>> twopointzero/develop
					{
						case 0:
							this.Up = value;
							return;

						case 1:
							this.Down = value;
							return;

						case 2:
							this.R = value;
							return;

						case 3:
							this.B = value;
							return;
					}
					throw new IndexOutOfRangeException();
				}
			}
		}

<<<<<<< HEAD
		private bool b曲再生;

		private CActFIFOBlack actFI;
		private CActFIFOBlack actFIfromSetup;
		private CActFIFOBlack actFO;
=======
		private CActFIFOWhite actFI;
		private CActFIFOWhite actFIfromSetup;
		private CActFIFOWhite actFO;
>>>>>>> twopointzero/develop
		private CCounter ctカーソルフラッシュ用;
		private STキー反復用カウンタ ctキー反復用;
		private CCounter ct下移動用;
		private CCounter ct上移動用;
		private const int MENU_H = 39;
		private const int MENU_W = 227;
		private const int MENU_X = 506;
		private const int MENU_Y = 513;
		private int n現在のカーソル行;
<<<<<<< HEAD
	
		private void tカーソルを下へ移動する()
		{
			if ( this.n現在のカーソル行 != (int) E戻り値.EXIT - 1 )
			{
				TJAPlayer3.Skin.soundカーソル移動音.t再生する();
				this.n現在のカーソル行++;
				this.ct下移動用.t開始( 0, 100, 1, TJAPlayer3.Timer );
				if( this.ct上移動用.b進行中 )
=======

		private void tカーソルを下へ移動する()
		{
			if (this.n現在のカーソル行 != (int)E戻り値.EXIT - 1)
			{
				TJAPlayer3.Skin.soundカーソル移動音.t再生する();
				this.n現在のカーソル行++;
				this.ct下移動用.t開始(0, 100, 1, TJAPlayer3.Timer);
				if (this.ct上移動用.b進行中)
>>>>>>> twopointzero/develop
				{
					this.ct下移動用.n現在の値 = 100 - this.ct上移動用.n現在の値;
					this.ct上移動用.t停止();
				}
			}
		}
		private void tカーソルを上へ移動する()
		{
<<<<<<< HEAD
			if ( this.n現在のカーソル行 != (int) E戻り値.GAMESTART - 1 )
			{
				TJAPlayer3.Skin.soundカーソル移動音.t再生する();
				this.n現在のカーソル行--;
				this.ct上移動用.t開始( 0, 100, 1, TJAPlayer3.Timer );
				if( this.ct下移動用.b進行中 )
=======
			if (this.n現在のカーソル行 != (int)E戻り値.GAMESTART - 1)
			{
				TJAPlayer3.Skin.soundカーソル移動音.t再生する();
				this.n現在のカーソル行--;
				this.ct上移動用.t開始(0, 100, 1, TJAPlayer3.Timer);
				if (this.ct下移動用.b進行中)
>>>>>>> twopointzero/develop
				{
					this.ct上移動用.n現在の値 = 100 - this.ct下移動用.n現在の値;
					this.ct下移動用.t停止();
				}
			}
		}
		//-----------------
		#endregion
	}
<<<<<<< HEAD
}
=======
}
>>>>>>> twopointzero/develop
