<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.IO;
using FDK;
using System.Runtime.Serialization.Formatters.Binary;
=======
﻿using System.Collections.Generic;
using System.Diagnostics;
using FDK;
>>>>>>> twopointzero/develop


namespace TJAPlayer3
{
	internal class CStage起動 : CStage
	{
		// コンストラクタ

		public CStage起動()
		{
			base.eステージID = CStage.Eステージ.起動;
			base.b活性化してない = true;
		}

		public List<string> list進行文字列;

		// CStage 実装

		public override void On活性化()
		{
<<<<<<< HEAD
			Trace.TraceInformation( "起動ステージを活性化します。" );
=======
			Trace.TraceInformation("起動ステージを活性化します。");
>>>>>>> twopointzero/develop
			Trace.Indent();
			try
			{
				this.list進行文字列 = new List<string>();
				base.eフェーズID = CStage.Eフェーズ.共通_通常状態;
				base.On活性化();
<<<<<<< HEAD
				Trace.TraceInformation( "起動ステージの活性化を完了しました。" );
=======
				Trace.TraceInformation("起動ステージの活性化を完了しました。");
>>>>>>> twopointzero/develop
			}
			finally
			{
				Trace.Unindent();
			}
		}
		public override void On非活性化()
		{
<<<<<<< HEAD
			Trace.TraceInformation( "起動ステージを非活性化します。" );
=======
			Trace.TraceInformation("起動ステージを非活性化します。");
>>>>>>> twopointzero/develop
			Trace.Indent();
			try
			{
				this.list進行文字列 = null;
<<<<<<< HEAD
				if ( es != null )
				{
					if ( ( es.thDTXFileEnumerate != null ) && es.thDTXFileEnumerate.IsAlive )
					{
						Trace.TraceWarning( "リスト構築スレッドを強制停止します。" );
=======
				if (es != null)
				{
					if ((es.thDTXFileEnumerate != null) && es.thDTXFileEnumerate.IsAlive)
					{
						Trace.TraceWarning("リスト構築スレッドを強制停止します。");
>>>>>>> twopointzero/develop
						es.thDTXFileEnumerate.Abort();
						es.thDTXFileEnumerate.Join();
					}
				}
				base.On非活性化();
<<<<<<< HEAD
				Trace.TraceInformation( "起動ステージの非活性化を完了しました。" );
=======
				Trace.TraceInformation("起動ステージの非活性化を完了しました。");
>>>>>>> twopointzero/develop
			}
			finally
			{
				Trace.Unindent();
			}
		}
		public override void OnManagedリソースの作成()
		{
<<<<<<< HEAD
			if( !base.b活性化してない )
			{
				this.tx背景 = TJAPlayer3.tテクスチャの生成( CSkin.Path( @"Graphics\1_Title\Background.png" ), false );
=======
			if (!base.b活性化してない)
			{
				this.tx背景 = TJAPlayer3.tテクスチャの生成(CSkin.Path(@"Graphics\1_Title\Background.png"), false);
>>>>>>> twopointzero/develop
				base.OnManagedリソースの作成();
			}
		}
		public override void OnManagedリソースの解放()
		{
<<<<<<< HEAD
			if( !base.b活性化してない )
			{
				TJAPlayer3.tテクスチャの解放( ref this.tx背景 );
=======
			if (!base.b活性化してない)
			{
				TJAPlayer3.t安全にDisposeする(ref this.tx背景);
>>>>>>> twopointzero/develop
				base.OnManagedリソースの解放();
			}
		}
		public override int On進行描画()
		{
<<<<<<< HEAD
			if( !base.b活性化してない )
			{
				if( base.b初めての進行描画 )
				{
					this.list進行文字列.Add( "DTXManiaXG Ver.K powered by YAMAHA Silent Session Drums\n" );
					this.list進行文字列.Add( "Product by.kairera0467\n" );
					this.list進行文字列.Add( "Release: " + TJAPlayer3.VERSION + " [" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString() + "]" );

                    this.list進行文字列.Add("");
                    this.list進行文字列.Add("TJAPlayer3 forked TJAPlayer2 forPC(kairera0467)");
                    this.list進行文字列.Add("TJAPlayer3 edited by AioiLight(@aioilight)");
                    this.list進行文字列.Add("");

                    es = new CEnumSongs();
					es.StartEnumFromCache();										// 曲リスト取得(別スレッドで実行される)
=======
			if (!base.b活性化してない)
			{
				if (base.b初めての進行描画)
				{
					this.list進行文字列.Add(TJAPlayer3.AppDisplayNameWithInformationalVersion);
					this.list進行文字列.Add("");
					this.list進行文字列.Add("This is a fork of twopointzero/TJAPlayer3.");
					this.list進行文字列.Add("");
					this.list進行文字列.Add($"{TJAPlayer3.AppDisplayName} is open source software under the MIT license.");
					this.list進行文字列.Add("See README for acknowledgments.");
					this.list進行文字列.Add("");

					es = new CEnumSongs();
					es.StartEnumFromCache();                                        // 曲リスト取得(別スレッドで実行される)
>>>>>>> twopointzero/develop
					base.b初めての進行描画 = false;
					return 0;
				}

				// CSongs管理 s管理 = CDTXMania.Songs管理;

				//if( this.tx背景 != null )
				//	this.tx背景.t2D描画( CDTXMania.app.Device, 0, 0 );

				#region [ this.str現在進行中 の決定 ]
				//-----------------
<<<<<<< HEAD
				switch( base.eフェーズID )
=======
				switch (base.eフェーズID)
>>>>>>> twopointzero/develop
				{
					case CStage.Eフェーズ.起動0_システムサウンドを構築:
						this.str現在進行中 = "SYSTEM SOUND...";
						break;

					case CStage.Eフェーズ.起動00_songlistから曲リストを作成する:
						this.str現在進行中 = "SONG LIST...";
						break;

					case CStage.Eフェーズ.起動1_SongsDBからスコアキャッシュを構築:
						this.str現在進行中 = "SONG DATABASE...";
						break;

					case CStage.Eフェーズ.起動2_曲を検索してリストを作成する:
<<<<<<< HEAD
						this.str現在進行中 = string.Format( "{0} ... {1}", "Enumerating songs", es.Songs管理.n検索されたスコア数 );
						break;

					case CStage.Eフェーズ.起動3_スコアキャッシュをリストに反映する:
						this.str現在進行中 = string.Format( "{0} ... {1}/{2}", "Loading score properties from songs.db", es.Songs管理.nスコアキャッシュから反映できたスコア数, es.Songs管理.n検索されたスコア数 );
						break;

					case CStage.Eフェーズ.起動4_スコアキャッシュになかった曲をファイルから読み込んで反映する:
						this.str現在進行中 = string.Format( "{0} ... {1}/{2}", "Loading score properties from files", es.Songs管理.nファイルから反映できたスコア数, es.Songs管理.n検索されたスコア数 - es.Songs管理.nスコアキャッシュから反映できたスコア数 );
						break;

					case CStage.Eフェーズ.起動5_曲リストへ後処理を適用する:
						this.str現在進行中 = string.Format( "{0} ... ", "Building songlists" );
						break;

					case CStage.Eフェーズ.起動6_スコアキャッシュをSongsDBに出力する:
						this.str現在進行中 = string.Format( "{0} ... ", "Saving songs.db" );
=======
						this.str現在進行中 = string.Format("{0} ... {1}", "Enumerating songs", es.Songs管理.n検索されたスコア数);
						break;

					case CStage.Eフェーズ.起動3_スコアキャッシュをリストに反映する:
						this.str現在進行中 = string.Format("{0} ... {1}/{2}", "Loading score properties from songs.db", es.Songs管理.nスコアキャッシュから反映できたスコア数, es.Songs管理.n検索されたスコア数);
						break;

					case CStage.Eフェーズ.起動4_スコアキャッシュになかった曲をファイルから読み込んで反映する:
						this.str現在進行中 = string.Format("{0} ... {1}/{2}", "Loading score properties from files", es.Songs管理.nファイルから反映できたスコア数, es.Songs管理.n検索されたスコア数 - es.Songs管理.nスコアキャッシュから反映できたスコア数);
						break;

					case CStage.Eフェーズ.起動5_曲リストへ後処理を適用する:
						this.str現在進行中 = string.Format("{0} ... ", "Building songlists");
						break;

					case CStage.Eフェーズ.起動6_スコアキャッシュをSongsDBに出力する:
						this.str現在進行中 = string.Format("{0} ... ", "Saving songs.db");
>>>>>>> twopointzero/develop
						break;

					case CStage.Eフェーズ.起動7_完了:
                        this.list進行文字列.Add("LOADING TEXTURES...");
<<<<<<< HEAD
                        TJAPlayer3.Tx.LoadTexture();
=======
                        TJAPlayer3.Tx.Load();
>>>>>>> twopointzero/develop
                        this.list進行文字列.Add("LOADING TEXTURES...OK");
                        this.str現在進行中 = "Setup done.";
                        break;
				}
				//-----------------
				#endregion
				#region [ this.list進行文字列＋this.現在進行中 の表示 ]
				//-----------------
<<<<<<< HEAD
				lock( this.list進行文字列 )
				{
					int x = 320;
					int y = 20;
					foreach( string str in this.list進行文字列 )
					{
						TJAPlayer3.act文字コンソール.tPrint( x, y, C文字コンソール.Eフォント種別.白, str );
						y += 24;
					}
					TJAPlayer3.act文字コンソール.tPrint( x, y, C文字コンソール.Eフォント種別.白, this.str現在進行中 );
=======
				lock (this.list進行文字列)
				{
					int x = 320;
					int y = 20;
					foreach (string str in this.list進行文字列)
					{
						TJAPlayer3.act文字コンソール.tPrint(x, y, C文字コンソール.Eフォント種別.白, str);
						y += 24;
					}
					TJAPlayer3.act文字コンソール.tPrint(x, y, C文字コンソール.Eフォント種別.白, this.str現在進行中);
>>>>>>> twopointzero/develop
				}
				//-----------------
				#endregion

<<<<<<< HEAD
				if( es != null && es.IsSongListEnumCompletelyDone )							// 曲リスト作成が終わったら
				{
					TJAPlayer3.Songs管理 = ( es != null ) ? es.Songs管理 : null;		// 最後に、曲リストを拾い上げる
=======
				if (es != null && es.IsSongListEnumCompletelyDone)                          // 曲リスト作成が終わったら
				{
					TJAPlayer3.Songs管理 = (es != null) ? es.Songs管理 : null;      // 最後に、曲リストを拾い上げる
>>>>>>> twopointzero/develop
					return 1;
				}
			}
			return 0;
		}


		// その他

		#region [ private ]
		//-----------------
		private string str現在進行中 = "";
		private CTexture tx背景;
		private CEnumSongs es;
<<<<<<< HEAD

#if false
		private void t曲リストの構築()
		{
			// ！注意！
			// 本メソッドは別スレッドで動作するが、プラグイン側でカレントディレクトリを変更しても大丈夫なように、
			// すべてのファイルアクセスは「絶対パス」で行うこと。(2010.9.16)

			DateTime now = DateTime.Now;
			string strPathSongsDB = CDTXMania.strEXEのあるフォルダ + "songs.db";
			string strPathSongList = CDTXMania.strEXEのあるフォルダ + "songlist.db";

			try
			{
				#region [ 0) システムサウンドの構築  ]
				//-----------------------------
				base.eフェーズID = CStage.Eフェーズ.起動0_システムサウンドを構築;

				Trace.TraceInformation( "0) システムサウンドを構築します。" );
				Trace.Indent();

				try
				{
					for( int i = 0; i < CDTXMania.Skin.nシステムサウンド数; i++ )
					{
						CSkin.Cシステムサウンド cシステムサウンド = CDTXMania.Skin[ i ];
						if( !CDTXMania.bコンパクトモード || cシステムサウンド.bCompact対象 )
						{
							try
							{
								cシステムサウンド.t読み込み();
								Trace.TraceInformation( "システムサウンドを読み込みました。({0})", new object[] { cシステムサウンド.strファイル名 } );
								if( ( cシステムサウンド == CDTXMania.Skin.bgm起動画面 ) && cシステムサウンド.b読み込み成功 )
								{
									cシステムサウンド.t再生する();
								}
							}
							catch( FileNotFoundException )
							{
								Trace.TraceWarning( "システムサウンドが存在しません。({0})", new object[] { cシステムサウンド.strファイル名 } );
							}
							catch( Exception exception )
							{
								Trace.TraceError( exception.Message );
								Trace.TraceWarning( "システムサウンドの読み込みに失敗しました。({0})", new object[] { cシステムサウンド.strファイル名 } );
							}
						}
					}
					lock( this.list進行文字列 )
					{
						this.list進行文字列.Add( "Loading system sounds ... OK " );
					}
				}
				finally
				{
					Trace.Unindent();
				}
				//-----------------------------
				#endregion

				if( CDTXMania.bコンパクトモード )
				{
					Trace.TraceInformation( "コンパクトモードなので残りの起動処理は省略します。" );
					return;
				}

				#region [ 00) songlist.dbの読み込みによる曲リストの構築  ]
				//-----------------------------
				base.eフェーズID = CStage.Eフェーズ.起動00_songlistから曲リストを作成する;

				Trace.TraceInformation( "1) songlist.dbを読み込みます。" );
				Trace.Indent();

				try
				{
					if ( !CDTXMania.ConfigIni.bConfigIniがないかDTXManiaのバージョンが異なる )
					{
						try
						{
							CDTXMania.Songs管理.tSongListDBを読み込む( strPathSongList );
						}
						catch
						{
							Trace.TraceError( "songlist.db の読み込みに失敗しました。" );
						}

						int scores = ( CDTXMania.Songs管理 == null ) ? 0 : CDTXMania.Songs管理.n検索されたスコア数;		// 読み込み途中でアプリ終了した場合など、CDTXMania.Songs管理 がnullの場合があるので注意
						Trace.TraceInformation( "songlist.db の読み込みを完了しました。[{0}スコア]", scores );
						lock ( this.list進行文字列 )
						{
							this.list進行文字列.Add( "Loading songlist.db ... OK" );
						}
					}
					else
					{
						Trace.TraceInformation( "初回の起動であるかまたはDTXManiaのバージョンが上がったため、songlist.db の読み込みをスキップします。" );
						lock ( this.list進行文字列 )
						{
							this.list進行文字列.Add( "Loading songlist.db ... Skip" );
						}
					}
				}
				finally
				{
					Trace.Unindent();
				}

				#endregion

				#region [ 1) songs.db の読み込み ]
				//-----------------------------
				base.eフェーズID = CStage.Eフェーズ.起動1_SongsDBからスコアキャッシュを構築;

				Trace.TraceInformation( "2) songs.db を読み込みます。" );
				Trace.Indent();

				try
				{
					if ( !CDTXMania.ConfigIni.bConfigIniがないかDTXManiaのバージョンが異なる )
					{
						try
						{
							CDTXMania.Songs管理.tSongsDBを読み込む( strPathSongsDB );
						}
						catch
						{
							Trace.TraceError( "songs.db の読み込みに失敗しました。" );
						}

						int scores = ( CDTXMania.Songs管理 == null ) ? 0 : CDTXMania.Songs管理.nSongsDBから取得できたスコア数;	// 読み込み途中でアプリ終了した場合など、CDTXMania.Songs管理 がnullの場合があるので注意
						Trace.TraceInformation( "songs.db の読み込みを完了しました。[{0}スコア]", scores );
						lock ( this.list進行文字列 )
						{
							this.list進行文字列.Add( "Loading songs.db ... OK" );
						}
					}
					else
					{
						Trace.TraceInformation( "初回の起動であるかまたはDTXManiaのバージョンが上がったため、songs.db の読み込みをスキップします。" );
						lock ( this.list進行文字列 )
						{
							this.list進行文字列.Add( "Loading songs.db ... Skip" );
						}
					}
				}
				finally
				{
					Trace.Unindent();
				}
				//-----------------------------
				#endregion

			}
			finally
			{
				base.eフェーズID = CStage.Eフェーズ.起動7_完了;
				TimeSpan span = (TimeSpan) ( DateTime.Now - now );
				Trace.TraceInformation( "起動所要時間: {0}", new object[] { span.ToString() } );
			}
		}
#endif
		#endregion
	}
}
=======
		#endregion
	}
}
>>>>>>> twopointzero/develop
