﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
<<<<<<< HEAD
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
=======
using System.IO;
using System.Linq;
using System.Threading;
>>>>>>> twopointzero/develop
using SlimDX;
using SlimDX.Direct3D9;
using FDK;
using SampleFramework;
using System.Reflection;

namespace TJAPlayer3
{
	internal class TJAPlayer3 : Game
	{
<<<<<<< HEAD
		// プロパティ
		#region [ properties ]
		public static readonly string VERSION = Assembly.GetExecutingAssembly().GetName().Version.ToString();

        public static readonly string SLIMDXDLL = "c_net20x86_Jun2010";
		public static readonly string D3DXDLL = "d3dx9_43.dll";     // June 2010
																	//public static readonly string D3DXDLL = "d3dx9_42.dll";	// February 2010
																	//public static readonly string D3DXDLL = "d3dx9_41.dll";	// March 2009

		public static readonly string AppDisplayName = Assembly.GetExecutingAssembly().GetName().Name;

=======
		public const string SLIMDXDLL = "c_net20x86_Jun2010";
		public const string D3DXDLL = "d3dx9_43.dll";   // June 2010
														//public const string D3DXDLL = "d3dx9_42.dll"; // February 2010
														//public const string D3DXDLL = "d3dx9_41.dll"; // March 2009

		// プロパティ
		#region [ properties ]

		public static readonly string AppDisplayName = Assembly.GetExecutingAssembly().GetName().Name;

		public static readonly string AppDisplayThreePartVersion = GetAppDisplayThreePartVersion();
		public static readonly string AppNumericThreePartVersion = GetAppNumericThreePartVersion();

		private static string GetAppDisplayThreePartVersion()
		{
			return $"v{GetAppNumericThreePartVersion()}";
		}

		private static string GetAppNumericThreePartVersion()
		{
			var version = Assembly.GetExecutingAssembly().GetName().Version;

			return $"{version.Major}.{version.Minor}.{version.Build}";
		}

		public static readonly string AppInformationalVersion =
			Assembly
				.GetExecutingAssembly()
				.GetCustomAttributes(typeof(AssemblyInformationalVersionAttribute), false)
				.Cast<AssemblyInformationalVersionAttribute>()
				.FirstOrDefault()
				?.InformationalVersion
			?? $"{GetAppDisplayThreePartVersion()}";

		public static readonly string AppDisplayNameWithThreePartVersion = $"{AppDisplayName} {AppDisplayThreePartVersion}";
		public static readonly string AppDisplayNameWithInformationalVersion = $"{AppDisplayName} {AppInformationalVersion}";

>>>>>>> twopointzero/develop
		public static TJAPlayer3 app
		{
			get;
			private set;
		}
		public static C文字コンソール act文字コンソール
<<<<<<< HEAD
		{ 
			get;
			private set;
		}
		public static bool bコンパクトモード
=======
>>>>>>> twopointzero/develop
		{
			get;
			private set;
		}
		public static CConfigIni ConfigIni
		{
<<<<<<< HEAD
			get; 
=======
			get;
>>>>>>> twopointzero/develop
			private set;
		}
		public static CDTX DTX
		{
			get
			{
<<<<<<< HEAD
				return dtx[ 0 ];
			}
			set
			{
				if( ( dtx[ 0 ] != null ) && ( app != null ) )
				{
					dtx[ 0 ].On非活性化();
					app.listトップレベルActivities.Remove( dtx[ 0 ] );
				}
				dtx[ 0 ] = value;
				if( ( dtx[ 0 ] != null ) && ( app != null ) )
				{
					app.listトップレベルActivities.Add( dtx[ 0 ] );
=======
				return dtx[0];
			}
			set
			{
				if ((dtx[0] != null) && (app != null))
				{
					dtx[0].On非活性化();
					app.listトップレベルActivities.Remove(dtx[0]);
				}
				dtx[0] = value;
				if ((dtx[0] != null) && (app != null))
				{
					app.listトップレベルActivities.Add(dtx[0]);
>>>>>>> twopointzero/develop
				}
			}
		}
		public static CDTX DTX_2P
		{
			get
			{
<<<<<<< HEAD
				return dtx[ 1 ];
			}
			set
			{
				if( ( dtx[ 1 ] != null ) && ( app != null ) )
				{
					dtx[ 1 ].On非活性化();
					app.listトップレベルActivities.Remove( dtx[ 1 ] );
				}
				dtx[ 1 ] = value;
				if( ( dtx[ 1 ] != null ) && ( app != null ) )
				{
					app.listトップレベルActivities.Add( dtx[ 1 ] );
=======
				return dtx[1];
			}
			set
			{
				if ((dtx[1] != null) && (app != null))
				{
					dtx[1].On非活性化();
					app.listトップレベルActivities.Remove(dtx[1]);
				}
				dtx[1] = value;
				if ((dtx[1] != null) && (app != null))
				{
					app.listトップレベルActivities.Add(dtx[1]);
>>>>>>> twopointzero/develop
				}
			}
		}

<<<<<<< HEAD
	    public static bool IsPerformingCalibration;

		public static CFPS FPS
		{ 
			get; 
			private set;
		}
		public static CInput管理 Input管理 
=======
		public static bool IsPerformingCalibration;

		public static CFPS FPS
		{
			get;
			private set;
		}
		public static CInput管理 Input管理
>>>>>>> twopointzero/develop
		{
			get;
			private set;
		}
		#region [ 入力範囲ms ]
		public static int nPerfect範囲ms
		{
			get
			{
<<<<<<< HEAD
				if( stage選曲.r確定された曲 != null )
				{
					C曲リストノード c曲リストノード = stage選曲.r確定された曲.r親ノード;
					if( ( ( c曲リストノード != null ) && ( c曲リストノード.eノード種別 == C曲リストノード.Eノード種別.BOX ) ) && ( c曲リストノード.nPerfect範囲ms >= 0 ) )
=======
				if (stage選曲.r確定された曲 != null)
				{
					C曲リストノード c曲リストノード = stage選曲.r確定された曲.r親ノード;
					if (((c曲リストノード != null) && (c曲リストノード.eノード種別 == C曲リストノード.Eノード種別.BOX)) && (c曲リストノード.nPerfect範囲ms >= 0))
>>>>>>> twopointzero/develop
					{
						return c曲リストノード.nPerfect範囲ms;
					}
				}
				return ConfigIni.nヒット範囲ms.Perfect;
			}
		}
		public static int nGreat範囲ms
		{
			get
			{
<<<<<<< HEAD
				if( stage選曲.r確定された曲 != null )
				{
					C曲リストノード c曲リストノード = stage選曲.r確定された曲.r親ノード;
					if( ( ( c曲リストノード != null ) && ( c曲リストノード.eノード種別 == C曲リストノード.Eノード種別.BOX ) ) && ( c曲リストノード.nGreat範囲ms >= 0 ) )
=======
				if (stage選曲.r確定された曲 != null)
				{
					C曲リストノード c曲リストノード = stage選曲.r確定された曲.r親ノード;
					if (((c曲リストノード != null) && (c曲リストノード.eノード種別 == C曲リストノード.Eノード種別.BOX)) && (c曲リストノード.nGreat範囲ms >= 0))
>>>>>>> twopointzero/develop
					{
						return c曲リストノード.nGreat範囲ms;
					}
				}
				return ConfigIni.nヒット範囲ms.Great;
			}
		}
		public static int nGood範囲ms
		{
			get
			{
<<<<<<< HEAD
				if( stage選曲.r確定された曲 != null )
				{
					C曲リストノード c曲リストノード = stage選曲.r確定された曲.r親ノード;
					if( ( ( c曲リストノード != null ) && ( c曲リストノード.eノード種別 == C曲リストノード.Eノード種別.BOX ) ) && ( c曲リストノード.nGood範囲ms >= 0 ) )
=======
				if (stage選曲.r確定された曲 != null)
				{
					C曲リストノード c曲リストノード = stage選曲.r確定された曲.r親ノード;
					if (((c曲リストノード != null) && (c曲リストノード.eノード種別 == C曲リストノード.Eノード種別.BOX)) && (c曲リストノード.nGood範囲ms >= 0))
>>>>>>> twopointzero/develop
					{
						return c曲リストノード.nGood範囲ms;
					}
				}
				return ConfigIni.nヒット範囲ms.Good;
			}
		}
		public static int nPoor範囲ms
		{
			get
			{
<<<<<<< HEAD
				if( stage選曲.r確定された曲 != null )
				{
					C曲リストノード c曲リストノード = stage選曲.r確定された曲.r親ノード;
					if( ( ( c曲リストノード != null ) && ( c曲リストノード.eノード種別 == C曲リストノード.Eノード種別.BOX ) ) && ( c曲リストノード.nPoor範囲ms >= 0 ) )
=======
				if (stage選曲.r確定された曲 != null)
				{
					C曲リストノード c曲リストノード = stage選曲.r確定された曲.r親ノード;
					if (((c曲リストノード != null) && (c曲リストノード.eノード種別 == C曲リストノード.Eノード種別.BOX)) && (c曲リストノード.nPoor範囲ms >= 0))
>>>>>>> twopointzero/develop
					{
						return c曲リストノード.nPoor範囲ms;
					}
				}
				return ConfigIni.nヒット範囲ms.Poor;
			}
		}
		#endregion
<<<<<<< HEAD
		public static CPad Pad 
=======
		public static CPad Pad
>>>>>>> twopointzero/develop
		{
			get;
			private set;
		}
		public static Random Random
		{
			get;
			private set;
		}
		public static CSkin Skin
		{
<<<<<<< HEAD
			get; 
			private set;
		}
		public static CSongs管理 Songs管理 
		{
			get;
			set;	// 2012.1.26 yyagi private解除 CStage起動でのdesirialize読み込みのため
=======
			get;
			private set;
		}
		public static CSongs管理 Songs管理
		{
			get;
			set;    // 2012.1.26 yyagi private解除 CStage起動でのdesirialize読み込みのため
>>>>>>> twopointzero/develop
		}
		public static CEnumSongs EnumSongs
		{
			get;
			private set;
		}
		public static CActEnumSongs actEnumSongs
		{
			get;
			private set;
		}
		public static CActScanningLoudness actScanningLoudness
		{
			get;
			private set;
		}
		public static CActFlushGPU actFlushGPU
		{
			get;
			private set;
		}

		public static CSound管理 Sound管理
		{
			get;
			private set;
		}

<<<<<<< HEAD
	    public static SongGainController SongGainController
	    {
	        get;
	        private set;
	    }

	    public static SoundGroupLevelController SoundGroupLevelController
	    {
	        get;
	        private set;
	    }
		
	    public static CNamePlate NamePlate
		{
	        get;
	        private set;
	    }

		public static CStage起動 stage起動 
		{
			get; 
=======
		public static SongGainController SongGainController
		{
			get;
			private set;
		}

		public static SoundGroupLevelController SoundGroupLevelController
		{
			get;
			private set;
		}

		public static CStage起動 stage起動
		{
			get;
>>>>>>> twopointzero/develop
			private set;
		}
		public static CStageタイトル stageタイトル
		{
			get;
			private set;
		}
<<<<<<< HEAD
//		public static CStageオプション stageオプション
//		{ 
//			get;
//			private set;
//		}
		public static CStageコンフィグ stageコンフィグ 
		{ 
			get; 
=======
		//		public static CStageオプション stageオプション
		//		{ 
		//			get;
		//			private set;
		//		}
		public static CStageコンフィグ stageコンフィグ
		{
			get;
>>>>>>> twopointzero/develop
			private set;
		}
		public static CStage選曲 stage選曲
		{
			get;
			private set;
		}
		public static CStage曲読み込み stage曲読み込み
		{
			get;
			private set;
		}
		public static CStage演奏ドラム画面 stage演奏ドラム画面
		{
			get;
			private set;
		}
		public static CStage結果 stage結果
		{
			get;
			private set;
		}
		public static CStageChangeSkin stageChangeSkin
		{
			get;
			private set;
		}
		public static CStage終了 stage終了
		{
			get;
			private set;
		}
		public static CStage r現在のステージ = null;
		public static CStage r直前のステージ = null;
<<<<<<< HEAD
		public static string strEXEのあるフォルダ 
=======
		public static string strEXEのあるフォルダ
>>>>>>> twopointzero/develop
		{
			get;
			private set;
		}
<<<<<<< HEAD
		public static string strコンパクトモードファイル
		{ 
			get; 
			private set;
		}
=======
>>>>>>> twopointzero/develop
		public static CTimer Timer
		{
			get;
			private set;
		}
		public static Format TextureFormat = Format.A8R8G8B8;
<<<<<<< HEAD
		internal static IPluginActivity act現在入力を占有中のプラグイン = null;
		public bool bApplicationActive
		{
			get; 
=======
		public bool bApplicationActive
		{
			get;
>>>>>>> twopointzero/develop
			private set;
		}
		public bool b次のタイミングで垂直帰線同期切り替えを行う
		{
<<<<<<< HEAD
			get; 
=======
			get;
>>>>>>> twopointzero/develop
			set;
		}
		public bool b次のタイミングで全画面_ウィンドウ切り替えを行う
		{
			get;
			set;
		}
<<<<<<< HEAD
		public DeviceCache Device
		{
			get { return base.GraphicsDeviceManager.Direct3D9.Device; }
		}
		public CPluginHost PluginHost
		{
			get;
			private set;
		}
		public List<STPlugin> listプラグイン = new List<STPlugin>();
		public struct STPlugin
		{
			public IPluginActivity plugin;
			public string strプラグインフォルダ;
			public string strアセンブリ簡易名;
			public Version Version;
		}
		private static Size currentClientSize		// #23510 2010.10.27 add yyagi to keep current window size
=======

		public DeviceCache Device => GraphicsDeviceManager.Device;

		private static Size currentClientSize       // #23510 2010.10.27 add yyagi to keep current window size
>>>>>>> twopointzero/develop
		{
			get;
			set;
		}
		//		public static CTimer ct;
<<<<<<< HEAD
		public IntPtr WindowHandle					// 2012.10.24 yyagi; to add ASIO support
		{
			get { return base.Window.Handle; }
		}
		public static CDTXVmode DTXVmode			// #28821 2014.1.23 yyagi
		{
			get;
			set;
		}

        #endregion

        // コンストラクタ

        public TJAPlayer3()
=======
		public IntPtr WindowHandle                  // 2012.10.24 yyagi; to add ASIO support
		{
			get { return base.Window.Handle; }
		}

		#endregion

		// コンストラクタ

		public TJAPlayer3()
>>>>>>> twopointzero/develop
		{
			TJAPlayer3.app = this;
			this.t起動処理();
		}


		// メソッド

		public void t全画面_ウィンドウモード切り替え()
		{
#if WindowedFullscreen
			if ( ConfigIni != null )
#else
			DeviceSettings settings = base.GraphicsDeviceManager.CurrentSettings.Clone();
<<<<<<< HEAD
			if ( ( ConfigIni != null ) && ( ConfigIni.bウィンドウモード != settings.Windowed ) )
=======
			if ((ConfigIni != null) && (ConfigIni.bウィンドウモード != settings.Windowed))
>>>>>>> twopointzero/develop
#endif
			{
#if !WindowedFullscreen
				settings.Windowed = ConfigIni.bウィンドウモード;
#endif
<<<<<<< HEAD
				if ( ConfigIni.bウィンドウモード == false )	// #23510 2010.10.27 yyagi: backup current window size before going fullscreen mode
=======
				if (ConfigIni.bウィンドウモード == false)   // #23510 2010.10.27 yyagi: backup current window size before going fullscreen mode
>>>>>>> twopointzero/develop
				{
					currentClientSize = this.Window.ClientSize;
					ConfigIni.nウインドウwidth = this.Window.ClientSize.Width;
					ConfigIni.nウインドウheight = this.Window.ClientSize.Height;
<<<<<<< HEAD
//					FDK.CTaskBar.ShowTaskBar( false );
				}
#if !WindowedFullscreen
				base.GraphicsDeviceManager.ChangeDevice( settings );
#endif
				if ( ConfigIni.bウィンドウモード == true )	// #23510 2010.10.27 yyagi: to resume window size from backuped value
=======
					//					FDK.CTaskBar.ShowTaskBar( false );
				}
#if !WindowedFullscreen
				base.GraphicsDeviceManager.ChangeDevice(settings);
#endif
				if (ConfigIni.bウィンドウモード == true)    // #23510 2010.10.27 yyagi: to resume window size from backuped value
>>>>>>> twopointzero/develop
				{
#if WindowedFullscreen
															// #30666 2013.2.2 yyagi Don't use Fullscreen mode becasue NVIDIA GeForce is
															// tend to delay drawing on Fullscreen mode. So DTXMania uses Maximized window
															// in spite of using fullscreen mode.
					app.Window.WindowState = FormWindowState.Normal;
					app.Window.FormBorderStyle = FormBorderStyle.Sizable;
					app.Window.WindowState = FormWindowState.Normal;
#endif
					base.Window.ClientSize =
<<<<<<< HEAD
						new Size( currentClientSize.Width, currentClientSize.Height );
                    base.Window.Icon = Properties.Resources.tjap3;
//					FDK.CTaskBar.ShowTaskBar( true );
=======
						new Size(currentClientSize.Width, currentClientSize.Height);
					base.Window.Icon = Properties.Resources.tjap3;
					//					FDK.CTaskBar.ShowTaskBar( true );
>>>>>>> twopointzero/develop
				}
#if WindowedFullscreen
				else 
				{
					app.Window.WindowState = FormWindowState.Normal;
					app.Window.FormBorderStyle = FormBorderStyle.None;
					app.Window.WindowState = FormWindowState.Maximized;
				}
				if ( ConfigIni.bウィンドウモード )
				{
					if ( !this.bマウスカーソル表示中 )
					{
						Cursor.Show();
						this.bマウスカーソル表示中 = true;
					}
				}
				else if ( this.bマウスカーソル表示中 )
				{
					Cursor.Hide();
					this.bマウスカーソル表示中 = false;
				}
#endif
			}
		}

		#region [ #24609 リザルト画像をpngで保存する ]		// #24609 2011.3.14 yyagi; to save result screen in case BestRank or HiSkill.
		/// <summary>
		/// リザルト画像のキャプチャと保存。
		/// </summary>
		/// <param name="strFilename">保存するファイル名(フルパス)</param>
<<<<<<< HEAD
		public bool SaveResultScreen( string strFullPath )
		{
			string strSavePath = Path.GetDirectoryName( strFullPath );
			if ( !Directory.Exists( strSavePath ) )
			{
				try
				{
					Directory.CreateDirectory( strSavePath );
				}
				catch (Exception e)
				{
					Trace.TraceError( e.ToString() );
					Trace.TraceError( "例外が発生しましたが処理を継続します。 (0bfe6bff-2a56-4df4-9333-2df26d9b765b)" );
=======
		public bool SaveResultScreen(string strFullPath)
		{
			string strSavePath = Path.GetDirectoryName(strFullPath);
			if (!Directory.Exists(strSavePath))
			{
				try
				{
					Directory.CreateDirectory(strSavePath);
				}
				catch (Exception e)
				{
					Trace.TraceError(e.ToString());
					Trace.TraceError("例外が発生しましたが処理を継続します。 (0bfe6bff-2a56-4df4-9333-2df26d9b765b)");
>>>>>>> twopointzero/develop
					return false;
				}
			}

			// http://www.gamedev.net/topic/594369-dx9slimdxati-incorrect-saving-surface-to-file/
<<<<<<< HEAD
			using ( Surface pSurface = TJAPlayer3.app.Device.GetRenderTarget( 0 ) )
			{
				Surface.ToFile( pSurface, strFullPath, ImageFileFormat.Png );
=======
			using (Surface pSurface = TJAPlayer3.app.Device.GetRenderTarget(0))
			{
				Surface.ToFile(pSurface, strFullPath, ImageFileFormat.Png);
>>>>>>> twopointzero/develop
			}
			return true;
		}
		#endregion

		// Game 実装

		protected override void Initialize()
		{
<<<<<<< HEAD
//			new GCBeep();
=======
			//			new GCBeep();
>>>>>>> twopointzero/develop
			//sw.Start();
			//swlist1 = new List<int>( 8192 );
			//swlist2 = new List<int>( 8192 );
			//swlist3 = new List<int>( 8192 );
			//swlist4 = new List<int>( 8192 );
			//swlist5 = new List<int>( 8192 );
<<<<<<< HEAD
			if ( this.listトップレベルActivities != null )
			{
				foreach( CActivity activity in this.listトップレベルActivities )
					activity.OnManagedリソースの作成();
			}

			foreach( STPlugin st in this.listプラグイン )
			{
				Directory.SetCurrentDirectory( st.strプラグインフォルダ );
				st.plugin.OnManagedリソースの作成();
				Directory.SetCurrentDirectory( TJAPlayer3.strEXEのあるフォルダ );
			}
=======
			if (this.listトップレベルActivities != null)
			{
				foreach (CActivity activity in this.listトップレベルActivities)
					activity.OnManagedリソースの作成();
			}

>>>>>>> twopointzero/develop
#if GPUFlushAfterPresent
			FrameEnd += dtxmania_FrameEnd;
#endif
		}
#if GPUFlushAfterPresent
		void dtxmania_FrameEnd( object sender, EventArgs e )	// GraphicsDeviceManager.game_FrameEnd()後に実行される
		{														// → Present()直後にGPUをFlushする
																// → 画面のカクツキが頻発したため、ここでのFlushは行わない
			actFlushGPU.On進行描画();		// Flush GPU
		}
#endif
		protected override void LoadContent()
		{
<<<<<<< HEAD
			if ( ConfigIni.bウィンドウモード )
			{
				if( !this.bマウスカーソル表示中 )
=======
			if (ConfigIni.bウィンドウモード)
			{
				if (!this.bマウスカーソル表示中)
>>>>>>> twopointzero/develop
				{
					Cursor.Show();
					this.bマウスカーソル表示中 = true;
				}
			}
<<<<<<< HEAD
			else if( this.bマウスカーソル表示中 )
=======
			else if (this.bマウスカーソル表示中)
>>>>>>> twopointzero/develop
			{
				Cursor.Hide();
				this.bマウスカーソル表示中 = false;
			}
			this.Device.SetTransform(TransformState.View, Matrix.LookAtLH(new Vector3(0f, 0f, (float)(-SampleFramework.GameWindowSize.Height / 2 * Math.Sqrt(3.0))), new Vector3(0f, 0f, 0f), new Vector3(0f, 1f, 0f)));
			this.Device.SetTransform(TransformState.Projection, Matrix.PerspectiveFovLH(C変換.DegreeToRadian((float)60f), ((float)this.Device.Viewport.Width) / ((float)this.Device.Viewport.Height), -100f, 100f));
			this.Device.SetRenderState(RenderState.Lighting, false);
<<<<<<< HEAD
			this.Device.SetRenderState( RenderState.ZEnable, false );
			this.Device.SetRenderState( RenderState.AntialiasedLineEnable, false );
			this.Device.SetRenderState( RenderState.AlphaTestEnable, true );
			this.Device.SetRenderState( RenderState.AlphaRef, 10 );

			this.Device.SetRenderState( RenderState.MultisampleAntialias, true );
			this.Device.SetSamplerState( 0, SamplerState.MinFilter, TextureFilter.Linear );
			this.Device.SetSamplerState( 0, SamplerState.MagFilter, TextureFilter.Linear );

			this.Device.SetRenderState<Compare>( RenderState.AlphaFunc, Compare.Greater );
			this.Device.SetRenderState( RenderState.AlphaBlendEnable, true );
			this.Device.SetRenderState<Blend>( RenderState.SourceBlend, Blend.SourceAlpha );
			this.Device.SetRenderState<Blend>( RenderState.DestinationBlend, Blend.InverseSourceAlpha );
			this.Device.SetTextureStageState( 0, TextureStage.AlphaOperation, TextureOperation.Modulate );
			this.Device.SetTextureStageState( 0, TextureStage.AlphaArg1, 2 );
			this.Device.SetTextureStageState( 0, TextureStage.AlphaArg2, 1 );

			if( this.listトップレベルActivities != null )
			{
				foreach( CActivity activity in this.listトップレベルActivities )
					activity.OnUnmanagedリソースの作成();
			}

			foreach( STPlugin st in this.listプラグイン )
			{
				Directory.SetCurrentDirectory( st.strプラグインフォルダ );
				st.plugin.OnUnmanagedリソースの作成();
				Directory.SetCurrentDirectory( TJAPlayer3.strEXEのあるフォルダ );
			}
		}
		protected override void UnloadContent()
		{
			if( this.listトップレベルActivities != null )
			{
				foreach( CActivity activity in this.listトップレベルActivities )
					activity.OnUnmanagedリソースの解放();
			}

			foreach( STPlugin st in this.listプラグイン )
			{
				Directory.SetCurrentDirectory( st.strプラグインフォルダ );
				st.plugin.OnUnmanagedリソースの解放();
				Directory.SetCurrentDirectory( TJAPlayer3.strEXEのあるフォルダ );
			}
		}
		protected override void OnExiting( EventArgs e )
		{
			CPowerManagement.tEnableMonitorSuspend();		// スリープ抑止状態を解除
			this.t終了処理();
			base.OnExiting( e );
		}
		protected override void Update( GameTime gameTime )
		{
		}
		protected override void Draw( GameTime gameTime )
		{
			Sound管理?.t再生中の処理をする();
            Timer?.t更新();
            CSound管理.rc演奏用タイマ?.t更新();
            Input管理?.tポーリング( this.bApplicationActive, TJAPlayer3.ConfigIni.bバッファ入力を行う );
            FPS?.tカウンタ更新();

			if( this.Device == null )
				return;

			if ( this.bApplicationActive )	// DTXMania本体起動中の本体/モニタの省電力モード移行を抑止
=======
			this.Device.SetRenderState(RenderState.ZEnable, false);
			this.Device.SetRenderState(RenderState.AntialiasedLineEnable, false);
			this.Device.SetRenderState(RenderState.AlphaTestEnable, true);
			this.Device.SetRenderState(RenderState.AlphaRef, 10);

			this.Device.SetRenderState(RenderState.MultisampleAntialias, true);
			this.Device.SetSamplerState(0, SamplerState.MinFilter, TextureFilter.Linear);
			this.Device.SetSamplerState(0, SamplerState.MagFilter, TextureFilter.Linear);

			this.Device.SetRenderState<Compare>(RenderState.AlphaFunc, Compare.Greater);
			this.Device.SetRenderState(RenderState.AlphaBlendEnable, true);
			this.Device.SetRenderState<Blend>(RenderState.SourceBlend, Blend.SourceAlpha);
			this.Device.SetRenderState<Blend>(RenderState.DestinationBlend, Blend.InverseSourceAlpha);
			this.Device.SetTextureStageState(0, TextureStage.AlphaOperation, TextureOperation.Modulate);
			this.Device.SetTextureStageState(0, TextureStage.AlphaArg1, 2);
			this.Device.SetTextureStageState(0, TextureStage.AlphaArg2, 1);

			if (this.listトップレベルActivities != null)
			{
				foreach (CActivity activity in this.listトップレベルActivities)
					activity.OnUnmanagedリソースの作成();
			}
		}
		protected override void UnloadContent()
		{
			if (this.listトップレベルActivities != null)
			{
				foreach (CActivity activity in this.listトップレベルActivities)
					activity.OnUnmanagedリソースの解放();
			}
		}
		protected override void OnExiting(EventArgs e)
		{
			CPowerManagement.tEnableMonitorSuspend();       // スリープ抑止状態を解除
			this.t終了処理();
			base.OnExiting(e);
		}
		protected override void Update(GameTime gameTime)
		{
		}
		protected override void Draw(GameTime gameTime)
		{
			Timer?.t更新();
			CSound管理.rc演奏用タイマ?.t更新();
			Input管理?.tポーリング(this.bApplicationActive, TJAPlayer3.ConfigIni.bバッファ入力を行う);
			FPS?.tカウンタ更新();

			if (this.Device == null)
				return;

			if (this.bApplicationActive)    // DTXMania本体起動中の本体/モニタの省電力モード移行を抑止
>>>>>>> twopointzero/develop
				CPowerManagement.tDisableMonitorSuspend();

			// #xxxxx 2013.4.8 yyagi; sleepの挿入位置を、EndScnene～Present間から、BeginScene前に移動。描画遅延を小さくするため。
			#region [ スリープ ]
<<<<<<< HEAD
			if ( ConfigIni.nフレーム毎スリープms >= 0 )			// #xxxxx 2011.11.27 yyagi
			{
				Thread.Sleep( ConfigIni.nフレーム毎スリープms );
			}
			#endregion

			#region [ DTXCreatorからの指示 ]
			if ( this.Window.IsReceivedMessage )	// ウインドウメッセージで、
			{
				string strMes = this.Window.strMessage;
				this.Window.IsReceivedMessage = false;

				if ( strMes != null )
				{
					DTXVmode.ParseArguments( strMes );

					if ( DTXVmode.Enabled )
					{
						bコンパクトモード = true;
						strコンパクトモードファイル = DTXVmode.filename;
						if ( DTXVmode.Command == CDTXVmode.ECommand.Preview )
						{
							// preview soundの再生
							string strPreviewFilename = DTXVmode.previewFilename;
//Trace.TraceInformation( "Preview Filename=" + DTXVmode.previewFilename );
							try
							{
								if ( this.previewSound != null )
								{
									this.previewSound.tサウンドを停止する();
									this.previewSound.Dispose();
									this.previewSound = null;
								}
								this.previewSound = TJAPlayer3.Sound管理.tサウンドを生成する( strPreviewFilename, ESoundGroup.SongPlayback );

							    // 2018-08-23 twopointzero: DTXVmode previewVolume will always set
							    // Gain since in this mode it should override the application of
							    // SONGVOL or any other Gain source regardless of configuration.
								this.previewSound.SetGain(DTXVmode.previewVolume);

								this.previewSound.n位置 = DTXVmode.previewPan;
								this.previewSound.t再生を開始する();
								Trace.TraceInformation( "DTXCからの指示で、サウンドを生成しました。({0})", strPreviewFilename );
							}
							catch (Exception e)
							{
								Trace.TraceError( e.ToString() );
								Trace.TraceError( "DTXCからの指示での、サウンドの生成に失敗しました。({0})", strPreviewFilename );
								if ( this.previewSound != null )
								{
									this.previewSound.Dispose();
								}
								this.previewSound = null;
							}
						}
					}
				}
=======
			if (ConfigIni.nフレーム毎スリープms >= 0)            // #xxxxx 2011.11.27 yyagi
			{
				Thread.Sleep(ConfigIni.nフレーム毎スリープms);
>>>>>>> twopointzero/develop
			}
			#endregion

			this.Device.BeginScene();
<<<<<<< HEAD
			this.Device.Clear( ClearFlags.ZBuffer | ClearFlags.Target, Color.Black, 1f, 0 );

			if( r現在のステージ != null )
			{
				this.n進行描画の戻り値 = ( r現在のステージ != null ) ? r現在のステージ.On進行描画() : 0;

				#region [ プラグインの進行描画 ]
				//---------------------
				foreach( STPlugin sp in this.listプラグイン )
				{
					Directory.SetCurrentDirectory( sp.strプラグインフォルダ );

					if( TJAPlayer3.act現在入力を占有中のプラグイン == null || TJAPlayer3.act現在入力を占有中のプラグイン == sp.plugin )
						sp.plugin.On進行描画(TJAPlayer3.Pad, TJAPlayer3.Input管理.Keyboard );
					else
						sp.plugin.On進行描画( null, null );

					Directory.SetCurrentDirectory( TJAPlayer3.strEXEのあるフォルダ );
				}
				//---------------------
				#endregion


				CScoreIni scoreIni = null;

				if ( Control.IsKeyLocked( Keys.CapsLock ) )				// #30925 2013.3.11 yyagi; capslock=ON時は、EnumSongsしないようにして、起動負荷とASIOの音切れの関係を確認する
				{														// → songs.db等の書き込み時だと音切れするっぽい
=======
			this.Device.Clear(ClearFlags.ZBuffer | ClearFlags.Target, Color.Black, 1f, 0);

			if (r現在のステージ != null)
			{
				this.n進行描画の戻り値 = (r現在のステージ != null) ? r現在のステージ.On進行描画() : 0;

				CScoreIni scoreIni = null;

				if (Control.IsKeyLocked(Keys.CapsLock))             // #30925 2013.3.11 yyagi; capslock=ON時は、EnumSongsしないようにして、起動負荷とASIOの音切れの関係を確認する
				{                                                       // → songs.db等の書き込み時だと音切れするっぽい
>>>>>>> twopointzero/develop
					actEnumSongs.On非活性化();
					EnumSongs.SongListEnumCompletelyDone();
					TJAPlayer3.stage選曲.bIsEnumeratingSongs = false;
				}
<<<<<<< HEAD
				#region [ 曲検索スレッドの起動/終了 ]					// ここに"Enumerating Songs..."表示を集約
				if ( !TJAPlayer3.bコンパクトモード )
				{
					actEnumSongs.On進行描画();							// "Enumerating Songs..."アイコンの描画
				}
				switch ( r現在のステージ.eステージID )
=======

				#region [ 曲検索スレッドの起動/終了 ]					// ここに"Enumerating Songs..."表示を集約

				actEnumSongs.On進行描画();                          // "Enumerating Songs..."アイコンの描画

				switch (r現在のステージ.eステージID)
>>>>>>> twopointzero/develop
				{
					case CStage.Eステージ.タイトル:
					case CStage.Eステージ.コンフィグ:
					case CStage.Eステージ.選曲:
					case CStage.Eステージ.曲読み込み:
<<<<<<< HEAD
						if ( EnumSongs != null )
						{
							#region [ (特定条件時) 曲検索スレッドの起動_開始 ]
							if ( r現在のステージ.eステージID == CStage.Eステージ.タイトル &&
								 r直前のステージ.eステージID == CStage.Eステージ.起動 &&
								 this.n進行描画の戻り値 == (int) CStageタイトル.E戻り値.継続 &&
								 !EnumSongs.IsSongListEnumStarted )
							{
								actEnumSongs.On活性化();
								TJAPlayer3.stage選曲.bIsEnumeratingSongs = true;
								EnumSongs.Init( TJAPlayer3.Songs管理.listSongsDB, TJAPlayer3.Songs管理.nSongsDBから取得できたスコア数 );	// songs.db情報と、取得した曲数を、新インスタンスにも与える
								EnumSongs.StartEnumFromDisk();		// 曲検索スレッドの起動_開始
								if ( TJAPlayer3.Songs管理.nSongsDBから取得できたスコア数 == 0 )	// もし初回起動なら、検索スレッドのプライオリティをLowestでなくNormalにする
								{
									EnumSongs.ChangeEnumeratePriority( ThreadPriority.Normal );
								}
							}
							#endregion
							
							#region [ 曲検索の中断と再開 ]
							if ( r現在のステージ.eステージID == CStage.Eステージ.選曲 && !EnumSongs.IsSongListEnumCompletelyDone )
							{
								switch ( this.n進行描画の戻り値 )
								{
									case 0:		// 何もない
										actEnumSongs.On活性化();
										break;

									case 2:		// 曲決定
										EnumSongs.Suspend();						// #27060 バックグラウンドの曲検索を一時停止
=======
						if (EnumSongs != null)
						{
							#region [ (特定条件時) 曲検索スレッドの起動_開始 ]
							if (r現在のステージ.eステージID == CStage.Eステージ.タイトル &&
								 r直前のステージ.eステージID == CStage.Eステージ.起動 &&
								 this.n進行描画の戻り値 == (int)CStageタイトル.E戻り値.継続 &&
								 !EnumSongs.IsSongListEnumStarted)
							{
								actEnumSongs.On活性化();
								TJAPlayer3.stage選曲.bIsEnumeratingSongs = true;
								EnumSongs.Init(TJAPlayer3.Songs管理.listSongsDB, TJAPlayer3.Songs管理.nSongsDBから取得できたスコア数); // songs.db情報と、取得した曲数を、新インスタンスにも与える
								EnumSongs.StartEnumFromDisk();      // 曲検索スレッドの起動_開始
								if (TJAPlayer3.Songs管理.nSongsDBから取得できたスコア数 == 0)    // もし初回起動なら、検索スレッドのプライオリティをLowestでなくNormalにする
								{
									EnumSongs.ChangeEnumeratePriority(ThreadPriority.Normal);
								}
							}
							#endregion

							#region [ 曲検索の中断と再開 ]
							if (r現在のステージ.eステージID == CStage.Eステージ.選曲 && !EnumSongs.IsSongListEnumCompletelyDone)
							{
								switch (this.n進行描画の戻り値)
								{
									case 0:     // 何もない
												//if ( CDTXMania.stage選曲.bIsEnumeratingSongs )
										if (!TJAPlayer3.stage選曲.bIsPlayingPremovie)
										{
											EnumSongs.Resume();                     // #27060 2012.2.6 yyagi 中止していたバックグランド曲検索を再開
											EnumSongs.IsSlowdown = false;
										}
										else
										{
											// EnumSongs.Suspend();					// #27060 2012.3.2 yyagi #PREMOVIE再生中は曲検索を低速化
											EnumSongs.IsSlowdown = true;
										}
										actEnumSongs.On活性化();
										break;

									case 2:     // 曲決定
										EnumSongs.Suspend();                        // #27060 バックグラウンドの曲検索を一時停止
>>>>>>> twopointzero/develop
										actEnumSongs.On非活性化();
										break;
								}
							}
							#endregion

							#region [ 曲探索中断待ち待機 ]
<<<<<<< HEAD
							if ( r現在のステージ.eステージID == CStage.Eステージ.曲読み込み && !EnumSongs.IsSongListEnumCompletelyDone &&
								EnumSongs.thDTXFileEnumerate != null )							// #28700 2012.6.12 yyagi; at Compact mode, enumerating thread does not exist.
							{
								EnumSongs.WaitUntilSuspended();									// 念のため、曲検索が一時中断されるまで待機
=======
							if (r現在のステージ.eステージID == CStage.Eステージ.曲読み込み && !EnumSongs.IsSongListEnumCompletelyDone &&
								EnumSongs.thDTXFileEnumerate != null)                           // #28700 2012.6.12 yyagi; at Compact mode, enumerating thread does not exist.
							{
								EnumSongs.WaitUntilSuspended();                                 // 念のため、曲検索が一時中断されるまで待機
>>>>>>> twopointzero/develop
							}
							#endregion

							#region [ 曲検索が完了したら、実際の曲リストに反映する ]
							// CStage選曲.On活性化() に回した方がいいかな？
<<<<<<< HEAD
							if ( EnumSongs.IsSongListEnumerated )
=======
							if (EnumSongs.IsSongListEnumerated)
>>>>>>> twopointzero/develop
							{
								actEnumSongs.On非活性化();
								TJAPlayer3.stage選曲.bIsEnumeratingSongs = false;

<<<<<<< HEAD
								bool bRemakeSongTitleBar = ( r現在のステージ.eステージID == CStage.Eステージ.選曲 ) ? true : false;
								TJAPlayer3.stage選曲.Refresh( EnumSongs.Songs管理, bRemakeSongTitleBar );
=======
								bool bRemakeSongTitleBar = (r現在のステージ.eステージID == CStage.Eステージ.選曲) ? true : false;
								TJAPlayer3.stage選曲.Refresh(EnumSongs.Songs管理, bRemakeSongTitleBar);
>>>>>>> twopointzero/develop
								EnumSongs.SongListEnumCompletelyDone();
							}
							#endregion
						}
						break;
				}
				#endregion

<<<<<<< HEAD
				switch ( r現在のステージ.eステージID )
=======
				switch (r現在のステージ.eステージID)
>>>>>>> twopointzero/develop
				{
					case CStage.Eステージ.何もしない:
						break;

					case CStage.Eステージ.起動:
						#region [ *** ]
						//-----------------------------
<<<<<<< HEAD
						if( this.n進行描画の戻り値 != 0 )
						{
							if( !bコンパクトモード )
							{
								r現在のステージ.On非活性化();
								Trace.TraceInformation( "----------------------" );
								Trace.TraceInformation( "■ タイトル" );
								stageタイトル.On活性化();
								r直前のステージ = r現在のステージ;
								r現在のステージ = stageタイトル;
							}
							else
							{
								r現在のステージ.On非活性化();
								Trace.TraceInformation( "----------------------" );
								Trace.TraceInformation( "■ 曲読み込み" );
								stage曲読み込み.On活性化();
								r直前のステージ = r現在のステージ;
								r現在のステージ = stage曲読み込み;

							}
							foreach( STPlugin pg in this.listプラグイン )
							{
								Directory.SetCurrentDirectory( pg.strプラグインフォルダ );
								pg.plugin.Onステージ変更();
								Directory.SetCurrentDirectory( TJAPlayer3.strEXEのあるフォルダ );
							}
=======
						if (this.n進行描画の戻り値 != 0)
						{
							r現在のステージ.On非活性化();
							Trace.TraceInformation("----------------------");
							Trace.TraceInformation("■ タイトル");
							stageタイトル.On活性化();
							r直前のステージ = r現在のステージ;
							r現在のステージ = stageタイトル;
>>>>>>> twopointzero/develop

							this.tガベージコレクションを実行する();
						}
						//-----------------------------
						#endregion
						break;

					case CStage.Eステージ.タイトル:
						#region [ *** ]
						//-----------------------------
<<<<<<< HEAD
						switch( this.n進行描画の戻り値 )
=======
						switch (this.n進行描画の戻り値)
>>>>>>> twopointzero/develop
						{
							case (int)CStageタイトル.E戻り値.GAMESTART:
								#region [ 選曲処理へ ]
								//-----------------------------
								r現在のステージ.On非活性化();
<<<<<<< HEAD
								Trace.TraceInformation( "----------------------" );
								Trace.TraceInformation( "■ 選曲" );
=======
								Trace.TraceInformation("----------------------");
								Trace.TraceInformation("■ 選曲");
>>>>>>> twopointzero/develop
								stage選曲.On活性化();
								r直前のステージ = r現在のステージ;
								r現在のステージ = stage選曲;
								//-----------------------------
								#endregion
								break;

							#region [ OPTION: 廃止済 ]
<<<<<<< HEAD
//							case 2:									// #24525 OPTIONとCONFIGの統合に伴い、OPTIONは廃止
//								#region [ *** ]
//								//-----------------------------
//								r現在のステージ.On非活性化();
//								Trace.TraceInformation( "----------------------" );
//								Trace.TraceInformation( "■ オプション" );
//								stageオプション.On活性化();
//								r直前のステージ = r現在のステージ;
//								r現在のステージ = stageオプション;
//								//-----------------------------
//								#endregion
=======
							//							case 2:									// #24525 OPTIONとCONFIGの統合に伴い、OPTIONは廃止
							//								#region [ *** ]
							//								//-----------------------------
							//								r現在のステージ.On非活性化();
							//								Trace.TraceInformation( "----------------------" );
							//								Trace.TraceInformation( "■ オプション" );
							//								stageオプション.On活性化();
							//								r直前のステージ = r現在のステージ;
							//								r現在のステージ = stageオプション;
							//								//-----------------------------
							//								#endregion
>>>>>>> twopointzero/develop
							//								break;
							#endregion

							case (int)CStageタイトル.E戻り値.CONFIG:
								#region [ *** ]
								//-----------------------------
								r現在のステージ.On非活性化();
<<<<<<< HEAD
								Trace.TraceInformation( "----------------------" );
								Trace.TraceInformation( "■ コンフィグ" );
=======
								Trace.TraceInformation("----------------------");
								Trace.TraceInformation("■ コンフィグ");
>>>>>>> twopointzero/develop
								stageコンフィグ.On活性化();
								r直前のステージ = r現在のステージ;
								r現在のステージ = stageコンフィグ;
								//-----------------------------
								#endregion
								break;

							case (int)CStageタイトル.E戻り値.EXIT:
								#region [ *** ]
								//-----------------------------
								r現在のステージ.On非活性化();
<<<<<<< HEAD
								Trace.TraceInformation( "----------------------" );
								Trace.TraceInformation( "■ 終了" );
=======
								Trace.TraceInformation("----------------------");
								Trace.TraceInformation("■ 終了");
>>>>>>> twopointzero/develop
								stage終了.On活性化();
								r直前のステージ = r現在のステージ;
								r現在のステージ = stage終了;
								//-----------------------------
								#endregion
								break;
						}

<<<<<<< HEAD
						foreach( STPlugin pg in this.listプラグイン )
						{
							Directory.SetCurrentDirectory( pg.strプラグインフォルダ );
							pg.plugin.Onステージ変更();
							Directory.SetCurrentDirectory( TJAPlayer3.strEXEのあるフォルダ );
						}

=======
>>>>>>> twopointzero/develop
						//this.tガベージコレクションを実行する();		// #31980 2013.9.3 yyagi タイトル画面でだけ、毎フレームGCを実行して重くなっていた問題の修正
						//-----------------------------
						#endregion
						break;

<<<<<<< HEAD
//					case CStage.Eステージ.オプション:
						#region [ *** ]
//						//-----------------------------
//						if( this.n進行描画の戻り値 != 0 )
//						{
//							switch( r直前のステージ.eステージID )
//							{
//								case CStage.Eステージ.タイトル:
//									#region [ *** ]
//									//-----------------------------
//									r現在のステージ.On非活性化();
//									Trace.TraceInformation( "----------------------" );
//									Trace.TraceInformation( "■ タイトル" );
//									stageタイトル.On活性化();
//									r直前のステージ = r現在のステージ;
//									r現在のステージ = stageタイトル;
//						
//									foreach( STPlugin pg in this.listプラグイン )
//									{
//										Directory.SetCurrentDirectory( pg.strプラグインフォルダ );
//										pg.plugin.Onステージ変更();
//										Directory.SetCurrentDirectory( CDTXMania.strEXEのあるフォルダ );
//									}
//						
//									this.tガベージコレクションを実行する();
//									break;
//								//-----------------------------
//									#endregion
//
//								case CStage.Eステージ.選曲:
//									#region [ *** ]
//									//-----------------------------
//									r現在のステージ.On非活性化();
//									Trace.TraceInformation( "----------------------" );
//									Trace.TraceInformation( "■ 選曲" );
//									stage選曲.On活性化();
//									r直前のステージ = r現在のステージ;
//									r現在のステージ = stage選曲;
//
//									foreach( STPlugin pg in this.listプラグイン )
//									{
//										Directory.SetCurrentDirectory( pg.strプラグインフォルダ );
//										pg.plugin.Onステージ変更();
//										Directory.SetCurrentDirectory( CDTXMania.strEXEのあるフォルダ );
//									}
//
//									this.tガベージコレクションを実行する();
//									break;
//								//-----------------------------
//									#endregion
//							}
//						}
//						//-----------------------------
						#endregion
//						break;
=======
					//					case CStage.Eステージ.オプション:
					#region [ *** ]
					//						//-----------------------------
					//						if( this.n進行描画の戻り値 != 0 )
					//						{
					//							switch( r直前のステージ.eステージID )
					//							{
					//								case CStage.Eステージ.タイトル:
					//									#region [ *** ]
					//									//-----------------------------
					//									r現在のステージ.On非活性化();
					//									Trace.TraceInformation( "----------------------" );
					//									Trace.TraceInformation( "■ タイトル" );
					//									stageタイトル.On活性化();
					//									r直前のステージ = r現在のステージ;
					//									r現在のステージ = stageタイトル;
					//						
					//									this.tガベージコレクションを実行する();
					//									break;
					//								//-----------------------------
					//									#endregion
					//
					//								case CStage.Eステージ.選曲:
					//									#region [ *** ]
					//									//-----------------------------
					//									r現在のステージ.On非活性化();
					//									Trace.TraceInformation( "----------------------" );
					//									Trace.TraceInformation( "■ 選曲" );
					//									stage選曲.On活性化();
					//									r直前のステージ = r現在のステージ;
					//									r現在のステージ = stage選曲;
					//
					//									this.tガベージコレクションを実行する();
					//									break;
					//								//-----------------------------
					//									#endregion
					//							}
					//						}
					//						//-----------------------------
					#endregion
					//						break;
>>>>>>> twopointzero/develop

					case CStage.Eステージ.コンフィグ:
						#region [ *** ]
						//-----------------------------
<<<<<<< HEAD
						if( this.n進行描画の戻り値 != 0 )
						{
							switch( r直前のステージ.eステージID )
=======
						if (this.n進行描画の戻り値 != 0)
						{
							switch (r直前のステージ.eステージID)
>>>>>>> twopointzero/develop
							{
								case CStage.Eステージ.タイトル:
									#region [ *** ]
									//-----------------------------
									r現在のステージ.On非活性化();
<<<<<<< HEAD
									Trace.TraceInformation( "----------------------" );
									Trace.TraceInformation( "■ タイトル" );
=======
									Trace.TraceInformation("----------------------");
									Trace.TraceInformation("■ タイトル");
>>>>>>> twopointzero/develop
									stageタイトル.On活性化();
									r直前のステージ = r現在のステージ;
									r現在のステージ = stageタイトル;

<<<<<<< HEAD
									foreach( STPlugin pg in this.listプラグイン )
									{
										Directory.SetCurrentDirectory( pg.strプラグインフォルダ );
										pg.plugin.Onステージ変更();
										Directory.SetCurrentDirectory( TJAPlayer3.strEXEのあるフォルダ );
									}

									this.tガベージコレクションを実行する();
									break;
								//-----------------------------
									#endregion
=======
									this.tガベージコレクションを実行する();
									break;
								//-----------------------------
								#endregion
>>>>>>> twopointzero/develop

								case CStage.Eステージ.選曲:
									#region [ *** ]
									//-----------------------------
									r現在のステージ.On非活性化();
<<<<<<< HEAD
									Trace.TraceInformation( "----------------------" );
									Trace.TraceInformation( "■ 選曲" );
=======
									Trace.TraceInformation("----------------------");
									Trace.TraceInformation("■ 選曲");
>>>>>>> twopointzero/develop
									stage選曲.On活性化();
									r直前のステージ = r現在のステージ;
									r現在のステージ = stage選曲;

<<<<<<< HEAD
									foreach( STPlugin pg in this.listプラグイン )
									{
										Directory.SetCurrentDirectory( pg.strプラグインフォルダ );
										pg.plugin.Onステージ変更();
										Directory.SetCurrentDirectory( TJAPlayer3.strEXEのあるフォルダ );
									}

									this.tガベージコレクションを実行する();
									break;
								//-----------------------------
=======
									this.tガベージコレクションを実行する();
									break;
									//-----------------------------
>>>>>>> twopointzero/develop
									#endregion
							}
						}
						//-----------------------------
						#endregion
						break;

					case CStage.Eステージ.選曲:
						#region [ *** ]
						//-----------------------------
<<<<<<< HEAD
						switch( this.n進行描画の戻り値 )
						{
							case (int) CStage選曲.E戻り値.タイトルに戻る:
								#region [ *** ]
								//-----------------------------
								r現在のステージ.On非活性化();
								Trace.TraceInformation( "----------------------" );
								Trace.TraceInformation( "■ タイトル" );
=======
						switch (this.n進行描画の戻り値)
						{
							case (int)CStage選曲.E戻り値.タイトルに戻る:
								#region [ *** ]
								//-----------------------------
								r現在のステージ.On非活性化();
								Trace.TraceInformation("----------------------");
								Trace.TraceInformation("■ タイトル");
>>>>>>> twopointzero/develop
								stageタイトル.On活性化();
								r直前のステージ = r現在のステージ;
								r現在のステージ = stageタイトル;

<<<<<<< HEAD
								foreach( STPlugin pg in this.listプラグイン )
								{
									Directory.SetCurrentDirectory( pg.strプラグインフォルダ );
									pg.plugin.Onステージ変更();
									Directory.SetCurrentDirectory( TJAPlayer3.strEXEのあるフォルダ );
								}

								this.tガベージコレクションを実行する();
								break;
							//-----------------------------
								#endregion

							case (int) CStage選曲.E戻り値.選曲した:
								#region [ *** ]
								//-----------------------------
								r現在のステージ.On非活性化();
								Trace.TraceInformation( "----------------------" );
								Trace.TraceInformation( "■ 曲読み込み" );
=======
								this.tガベージコレクションを実行する();
								break;
							//-----------------------------
							#endregion

							case (int)CStage選曲.E戻り値.選曲した:
								#region [ *** ]
								//-----------------------------
								r現在のステージ.On非活性化();
								Trace.TraceInformation("----------------------");
								Trace.TraceInformation("■ 曲読み込み");
>>>>>>> twopointzero/develop
								stage曲読み込み.On活性化();
								r直前のステージ = r現在のステージ;
								r現在のステージ = stage曲読み込み;

<<<<<<< HEAD
								foreach( STPlugin pg in this.listプラグイン )
								{
									Directory.SetCurrentDirectory( pg.strプラグインフォルダ );
									pg.plugin.Onステージ変更();
									Directory.SetCurrentDirectory( TJAPlayer3.strEXEのあるフォルダ );
								}

								this.tガベージコレクションを実行する();
								break;
							//-----------------------------
								#endregion

//							case (int) CStage選曲.E戻り値.オプション呼び出し:
								#region [ *** ]
//								//-----------------------------
//								r現在のステージ.On非活性化();
//								Trace.TraceInformation( "----------------------" );
//								Trace.TraceInformation( "■ オプション" );
//								stageオプション.On活性化();
//								r直前のステージ = r現在のステージ;
//								r現在のステージ = stageオプション;
//
//								foreach( STPlugin pg in this.listプラグイン )
//								{
//									Directory.SetCurrentDirectory( pg.strプラグインフォルダ );
//									pg.plugin.Onステージ変更();
//									Directory.SetCurrentDirectory( CDTXMania.strEXEのあるフォルダ );
//								}
//
//								this.tガベージコレクションを実行する();
//								break;
//							//-----------------------------
								#endregion

							case (int) CStage選曲.E戻り値.コンフィグ呼び出し:
								#region [ *** ]
								//-----------------------------
								r現在のステージ.On非活性化();
								Trace.TraceInformation( "----------------------" );
								Trace.TraceInformation( "■ コンフィグ" );
=======
								this.tガベージコレクションを実行する();
								break;
							//-----------------------------
							#endregion

							//							case (int) CStage選曲.E戻り値.オプション呼び出し:
							#region [ *** ]
							//								//-----------------------------
							//								r現在のステージ.On非活性化();
							//								Trace.TraceInformation( "----------------------" );
							//								Trace.TraceInformation( "■ オプション" );
							//								stageオプション.On活性化();
							//								r直前のステージ = r現在のステージ;
							//								r現在のステージ = stageオプション;
							//
							//								this.tガベージコレクションを実行する();
							//								break;
							//							//-----------------------------
							#endregion

							case (int)CStage選曲.E戻り値.コンフィグ呼び出し:
								#region [ *** ]
								//-----------------------------
								r現在のステージ.On非活性化();
								Trace.TraceInformation("----------------------");
								Trace.TraceInformation("■ コンフィグ");
>>>>>>> twopointzero/develop
								stageコンフィグ.On活性化();
								r直前のステージ = r現在のステージ;
								r現在のステージ = stageコンフィグ;

<<<<<<< HEAD
								foreach( STPlugin pg in this.listプラグイン )
								{
									Directory.SetCurrentDirectory( pg.strプラグインフォルダ );
									pg.plugin.Onステージ変更();
									Directory.SetCurrentDirectory( TJAPlayer3.strEXEのあるフォルダ );
								}

								this.tガベージコレクションを実行する();
								break;
							//-----------------------------
								#endregion

							case (int) CStage選曲.E戻り値.スキン変更:
=======
								this.tガベージコレクションを実行する();
								break;
							//-----------------------------
							#endregion

							case (int)CStage選曲.E戻り値.スキン変更:
>>>>>>> twopointzero/develop

								#region [ *** ]
								//-----------------------------
								r現在のステージ.On非活性化();
<<<<<<< HEAD
								Trace.TraceInformation( "----------------------" );
								Trace.TraceInformation( "■ スキン切り替え" );
=======
								Trace.TraceInformation("----------------------");
								Trace.TraceInformation("■ スキン切り替え");
>>>>>>> twopointzero/develop
								stageChangeSkin.On活性化();
								r直前のステージ = r現在のステージ;
								r現在のステージ = stageChangeSkin;
								break;
<<<<<<< HEAD
							//-----------------------------
=======
								//-----------------------------
>>>>>>> twopointzero/develop
								#endregion
						}
						//-----------------------------
						#endregion
						break;

					case CStage.Eステージ.曲読み込み:
						#region [ *** ]
						//-----------------------------
<<<<<<< HEAD
						DTXVmode.Refreshed = false;		// 曲のリロード中に発生した再リロードは、無視する。
						if( this.n進行描画の戻り値 != 0 )
						{
							TJAPlayer3.Pad.st検知したデバイス.Clear();	// 入力デバイスフラグクリア(2010.9.11)
							r現在のステージ.On非活性化();
							#region [ ESC押下時は、曲の読み込みを中止して選曲画面に戻る ]
							if ( this.n進行描画の戻り値 == (int) E曲読込画面の戻り値.読込中止 )
							{
								//DTX.t全チップの再生停止();
								if( DTX != null )
                                    DTX.On非活性化();
								Trace.TraceInformation( "曲の読み込みを中止しました。" );
								this.tガベージコレクションを実行する();
								Trace.TraceInformation( "----------------------" );
								Trace.TraceInformation( "■ 選曲" );
								stage選曲.On活性化();
								r直前のステージ = r現在のステージ;
								r現在のステージ = stage選曲;
								foreach ( STPlugin pg in this.listプラグイン )
								{
									Directory.SetCurrentDirectory( pg.strプラグインフォルダ );
									pg.plugin.Onステージ変更();
									Directory.SetCurrentDirectory( TJAPlayer3.strEXEのあるフォルダ );
								}
=======
						if (this.n進行描画の戻り値 != 0)
						{
							TJAPlayer3.Pad.st検知したデバイス.Clear();  // 入力デバイスフラグクリア(2010.9.11)
							r現在のステージ.On非活性化();
							#region [ ESC押下時は、曲の読み込みを中止して選曲画面に戻る ]
							if (this.n進行描画の戻り値 == (int)E曲読込画面の戻り値.読込中止)
							{
								//DTX.t全チップの再生停止();
								if (DTX != null)
									DTX.On非活性化();
								Trace.TraceInformation("曲の読み込みを中止しました。");
								this.tガベージコレクションを実行する();
								Trace.TraceInformation("----------------------");
								Trace.TraceInformation("■ 選曲");
								stage選曲.On活性化();
								r直前のステージ = r現在のステージ;
								r現在のステージ = stage選曲;

>>>>>>> twopointzero/develop
								break;
							}
							#endregion

<<<<<<< HEAD
							Trace.TraceInformation( "----------------------" );
							Trace.TraceInformation( "■ 演奏（ドラム画面）" );
#if false		// #23625 2011.1.11 Config.iniからダメージ/回復値の定数変更を行う場合はここを有効にする 087リリースに合わせ機能無効化
=======
							Trace.TraceInformation("----------------------");
							Trace.TraceInformation("■ 演奏（ドラム画面）");
#if false       // #23625 2011.1.11 Config.iniからダメージ/回復値の定数変更を行う場合はここを有効にする 087リリースに合わせ機能無効化
>>>>>>> twopointzero/develop
for (int i = 0; i < 5; i++)
{
	for (int j = 0; j < 2; j++)
	{
		stage演奏ドラム画面.fDamageGaugeDelta[i, j] = ConfigIni.fGaugeFactor[i, j];
	}
}
for (int i = 0; i < 3; i++) {
	stage演奏ドラム画面.fDamageLevelFactor[i] = ConfigIni.fDamageLevelFactor[i];
}		
#endif
							r直前のステージ = r現在のステージ;
							r現在のステージ = stage演奏ドラム画面;
<<<<<<< HEAD
							foreach( STPlugin pg in this.listプラグイン )
							{
								Directory.SetCurrentDirectory( pg.strプラグインフォルダ );
								pg.plugin.Onステージ変更();
								Directory.SetCurrentDirectory( TJAPlayer3.strEXEのあるフォルダ );
							}
=======
>>>>>>> twopointzero/develop

							this.tガベージコレクションを実行する();
						}
						//-----------------------------
						#endregion
						break;

					case CStage.Eステージ.演奏:
						#region [ *** ]
						//-----------------------------
						//long n1 = FDK.CSound管理.rc演奏用タイマ.nシステム時刻ms;
						//long n2 = FDK.CSound管理.SoundDevice.n経過時間ms;
						//long n3 = FDK.CSound管理.SoundDevice.tmシステムタイマ.nシステム時刻ms;
						//long n4 = FDK.CSound管理.rc演奏用タイマ.n現在時刻;
						//long n5 = FDK.CSound管理.SoundDevice.n経過時間を更新したシステム時刻ms;

						//swlist1.Add( Convert.ToInt32(n1) );
						//swlist2.Add( Convert.ToInt32(n2) );
						//swlist3.Add( Convert.ToInt32( n3 ) );
						//swlist4.Add( Convert.ToInt32( n4 ) );
						//swlist5.Add( Convert.ToInt32( n5 ) );

<<<<<<< HEAD
						#region [ DTXVモード中にDTXCreatorから指示を受けた場合の処理 ]
						if ( DTXVmode.Enabled && DTXVmode.Refreshed )
						{
							DTXVmode.Refreshed = false;

							if ( DTXVmode.Command == CDTXVmode.ECommand.Stop )
							{
								TJAPlayer3.stage演奏ドラム画面.t停止();
								if ( previewSound != null )
								{
									this.previewSound.tサウンドを停止する();
									this.previewSound.Dispose();
									this.previewSound = null;
								}
								//{
								//    int lastd = 0;
								//    int f = 0;
								//    for ( int i = 0; i < swlist1.Count; i++ )
								//    {
								//        int d1 = swlist1[ i ];
								//        int d2 = swlist2[ i ];
								//        int d3 = swlist3[ i ];
								//        int d4 = swlist4[ i ];
								//        int d5 = swlist5[ i ];

								//        int dif = d1 - lastd;
								//        string s = "";
								//        if ( 16 <= dif && dif <= 17 )
								//        {
								//        }
								//        else
								//        {
								//            s = "★";
								//        }
								//        Trace.TraceInformation( "frame {0:D4}: {1:D3} ( {2:D3}, {3:D3} - {7:D3}, {4:D3} ) {5}, n現在時刻={6}", f, dif, d1, d2, d3, s, d4, d5 );
								//        lastd = d1;
								//        f++;
								//    }
								//    swlist1.Clear();
								//    swlist2.Clear();
								//    swlist3.Clear();
								//    swlist4.Clear();
								//    swlist5.Clear();

								//}
							}
							else if ( DTXVmode.Command == CDTXVmode.ECommand.Play )
							{
								if ( DTXVmode.NeedReload )
								{
									TJAPlayer3.stage演奏ドラム画面.t再読込();

									TJAPlayer3.ConfigIni.bTimeStretch = DTXVmode.TimeStretch;
									CSound管理.bIsTimeStretch = DTXVmode.TimeStretch;
									if ( TJAPlayer3.ConfigIni.b垂直帰線待ちを行う != DTXVmode.VSyncWait )
									{
										TJAPlayer3.ConfigIni.b垂直帰線待ちを行う = DTXVmode.VSyncWait;
										TJAPlayer3.app.b次のタイミングで垂直帰線同期切り替えを行う = true;
									}
								}
								else
								{
									TJAPlayer3.stage演奏ドラム画面.t演奏位置の変更( TJAPlayer3.DTXVmode.nStartBar, 0 );
								}
							}
						}
						#endregion

						switch( this.n進行描画の戻り値 )
						{
							case (int) E演奏画面の戻り値.再読込_再演奏:
=======
						switch (this.n進行描画の戻り値)
						{
							case (int)E演奏画面の戻り値.再読込_再演奏:
>>>>>>> twopointzero/develop
								#region [ DTXファイルを再読み込みして、再演奏 ]
								DTX.t全チップの再生停止();
								DTX.On非活性化();
								r現在のステージ.On非活性化();
								stage曲読み込み.On活性化();
								r直前のステージ = r現在のステージ;
								r現在のステージ = stage曲読み込み;
								this.tガベージコレクションを実行する();
								break;
<<<<<<< HEAD
								#endregion
=======
							#endregion
>>>>>>> twopointzero/develop

							//case (int) E演奏画面の戻り値.再演奏:
							#region [ 再読み込み無しで、再演奏 ]
							#endregion
							//	break;

<<<<<<< HEAD
							case (int) E演奏画面の戻り値.継続:
								break;

							case (int) E演奏画面の戻り値.演奏中断:
								#region [ 演奏キャンセル ]
								//-----------------------------
								scoreIni = this.tScoreIniへBGMAdjustとHistoryとPlayCountを更新( "Play canceled" );
=======
							case (int)E演奏画面の戻り値.継続:
								break;

							case (int)E演奏画面の戻り値.演奏中断:
								#region [ 演奏キャンセル ]
								//-----------------------------
								scoreIni = this.tScoreIniへBGMAdjustとHistoryとPlayCountを更新("Play canceled");
>>>>>>> twopointzero/develop

								//int lastd = 0;
								//int f = 0;
								//for (int i = 0; i < swlist1.Count; i++)
								//{
								//    int d1 = swlist1[ i ];
								//    int d2 = swlist2[ i ];
								//    int d3 = swlist3[ i ];
								//    int d4 = swlist4[ i ];

								//    int dif = d1 - lastd;
								//    string s = "";
								//    if ( 16 <= dif && dif <= 17 )
								//    {
								//    }
								//    else
								//    {
								//        s = "★";
								//    }
								//    Trace.TraceInformation( "frame {0:D4}: {1:D3} ( {2:D3}, {3:D3}, {4:D3} ) {5}, n現在時刻={6}", f, dif, d1, d2, d3, s, d4 );
								//    lastd = d1;
								//    f++;
								//}
								//swlist1.Clear();
								//swlist2.Clear();
								//swlist3.Clear();
								//swlist4.Clear();
<<<<<<< HEAD
		
								#region [ プラグイン On演奏キャンセル() の呼び出し ]
								//---------------------
								foreach( STPlugin pg in this.listプラグイン )
								{
									Directory.SetCurrentDirectory( pg.strプラグインフォルダ );
									pg.plugin.On演奏キャンセル( scoreIni );
									Directory.SetCurrentDirectory( TJAPlayer3.strEXEのあるフォルダ );
								}
								//---------------------
								#endregion
=======
>>>>>>> twopointzero/develop

								DTX.t全チップの再生停止();
								DTX.On非活性化();
								r現在のステージ.On非活性化();
<<<<<<< HEAD
								if( bコンパクトモード )
								{
									base.Window.Close();
								}
								else
								{
									Trace.TraceInformation( "----------------------" );
									Trace.TraceInformation( "■ 選曲" );
									stage選曲.On活性化();
									r直前のステージ = r現在のステージ;
									r現在のステージ = stage選曲;

									#region [ プラグイン Onステージ変更() の呼び出し ]
									//---------------------
									foreach( STPlugin pg in this.listプラグイン )
									{
										Directory.SetCurrentDirectory( pg.strプラグインフォルダ );
										pg.plugin.Onステージ変更();
										Directory.SetCurrentDirectory( TJAPlayer3.strEXEのあるフォルダ );
									}
									//---------------------
									#endregion

									this.tガベージコレクションを実行する();
								}
                                this.tガベージコレクションを実行する();
                                break;
								//-----------------------------
								#endregion

							case (int) E演奏画面の戻り値.ステージ失敗:
								#region [ 演奏失敗(StageFailed) ]
								//-----------------------------
								scoreIni = this.tScoreIniへBGMAdjustとHistoryとPlayCountを更新( "Stage failed" );

								#region [ プラグイン On演奏失敗() の呼び出し ]
								//---------------------
								foreach( STPlugin pg in this.listプラグイン )
								{
									Directory.SetCurrentDirectory( pg.strプラグインフォルダ );
									pg.plugin.On演奏失敗( scoreIni );
									Directory.SetCurrentDirectory( TJAPlayer3.strEXEのあるフォルダ );
								}
								//---------------------
								#endregion
=======
								Trace.TraceInformation("----------------------");
								Trace.TraceInformation("■ 選曲");
								stage選曲.On活性化();
								r直前のステージ = r現在のステージ;
								r現在のステージ = stage選曲;

								this.tガベージコレクションを実行する();
								break;
							//-----------------------------
							#endregion

							case (int)E演奏画面の戻り値.ステージ失敗:
								#region [ 演奏失敗(StageFailed) ]
								//-----------------------------
								scoreIni = this.tScoreIniへBGMAdjustとHistoryとPlayCountを更新("Stage failed");
>>>>>>> twopointzero/develop

								DTX.t全チップの再生停止();
								DTX.On非活性化();
								r現在のステージ.On非活性化();
<<<<<<< HEAD
								if( bコンパクトモード )
								{
									base.Window.Close();
								}
								else
								{
									Trace.TraceInformation( "----------------------" );
									Trace.TraceInformation( "■ 選曲" );
									stage選曲.On活性化();
									r直前のステージ = r現在のステージ;
									r現在のステージ = stage選曲;

									#region [ プラグイン Onステージ変更() の呼び出し ]
									//---------------------
									foreach( STPlugin pg in this.listプラグイン )
									{
										Directory.SetCurrentDirectory( pg.strプラグインフォルダ );
										pg.plugin.Onステージ変更();
										Directory.SetCurrentDirectory( TJAPlayer3.strEXEのあるフォルダ );
									}
									//---------------------
									#endregion

									this.tガベージコレクションを実行する();
								}
								break;
								//-----------------------------
								#endregion

							case (int) E演奏画面の戻り値.ステージクリア:
								#region [ 演奏クリア ]
								//-----------------------------
								CScoreIni.C演奏記録 c演奏記録_Drums;
								stage演奏ドラム画面.t演奏結果を格納する( out c演奏記録_Drums );

                                double ps = 0.0, gs = 0.0;
								if ( !c演奏記録_Drums.b全AUTOである && c演奏記録_Drums.n全チップ数 > 0) {
									ps = c演奏記録_Drums.db演奏型スキル値;
									gs = c演奏記録_Drums.dbゲーム型スキル値;
								}
								string str = "Cleared";
								switch( CScoreIni.t総合ランク値を計算して返す( c演奏記録_Drums, null, null ) )
								{
									case (int)CScoreIni.ERANK.SS:
										str = string.Format( "Cleared (SS: {0:F2})", ps );
										break;

									case (int) CScoreIni.ERANK.S:
										str = string.Format( "Cleared (S: {0:F2})", ps );
										break;

									case (int) CScoreIni.ERANK.A:
										str = string.Format( "Cleared (A: {0:F2})", ps );
										break;

									case (int) CScoreIni.ERANK.B:
										str = string.Format( "Cleared (B: {0:F2})", ps );
										break;

									case (int) CScoreIni.ERANK.C:
										str = string.Format( "Cleared (C: {0:F2})", ps );
										break;

									case (int) CScoreIni.ERANK.D:
										str = string.Format( "Cleared (D: {0:F2})", ps );
										break;

									case (int) CScoreIni.ERANK.E:
										str = string.Format( "Cleared (E: {0:F2})", ps );
										break;

									case (int)CScoreIni.ERANK.UNKNOWN:	// #23534 2010.10.28 yyagi add: 演奏チップが0個のとき
=======
								Trace.TraceInformation("----------------------");
								Trace.TraceInformation("■ 選曲");
								stage選曲.On活性化();
								r直前のステージ = r現在のステージ;
								r現在のステージ = stage選曲;

								this.tガベージコレクションを実行する();
								break;
							//-----------------------------
							#endregion

							case (int)E演奏画面の戻り値.ステージ失敗_ハード:
								#region 演奏失敗(ハードゲージ)
								//-----------------------------
								CScoreIni.C演奏記録 c演奏記録_Drums;
								stage演奏ドラム画面.t演奏結果を格納する(out c演奏記録_Drums);

								double ps = 0.0, gs = 0.0;
								if (!c演奏記録_Drums.b全AUTOである && c演奏記録_Drums.n全チップ数 > 0)
								{
									ps = c演奏記録_Drums.db演奏型スキル値;
									gs = c演奏記録_Drums.dbゲーム型スキル値;
								}
								string str = "Failed";
								switch (CScoreIni.t総合ランク値を計算して返す(c演奏記録_Drums, null, null))
								{
									case (int)CScoreIni.ERANK.SS:
										str = string.Format("Failed (SS: {0:F2})", ps);
										break;

									case (int)CScoreIni.ERANK.S:
										str = string.Format("Failed (S: {0:F2})", ps);
										break;

									case (int)CScoreIni.ERANK.A:
										str = string.Format("Failed (A: {0:F2})", ps);
										break;

									case (int)CScoreIni.ERANK.B:
										str = string.Format("Failed (B: {0:F2})", ps);
										break;

									case (int)CScoreIni.ERANK.C:
										str = string.Format("Failed (C: {0:F2})", ps);
										break;

									case (int)CScoreIni.ERANK.D:
										str = string.Format("Failed (D: {0:F2})", ps);
										break;

									case (int)CScoreIni.ERANK.E:
										str = string.Format("Failed (E: {0:F2})", ps);
										break;

									case (int)CScoreIni.ERANK.UNKNOWN:  // #23534 2010.10.28 yyagi add: 演奏チップが0個のとき
										str = "Failed (GAUGE:HARD)";
										break;
								}

								scoreIni = this.tScoreIniへBGMAdjustとHistoryとPlayCountを更新(str);

								r現在のステージ.On非活性化();
								Trace.TraceInformation("----------------------");
								Trace.TraceInformation("■ 結果");
								stage結果.st演奏記録.Drums = c演奏記録_Drums;
								stage結果.On活性化();
								r直前のステージ = r現在のステージ;
								r現在のステージ = stage結果;

								break;
							#endregion

							case (int)E演奏画面の戻り値.ステージクリア:
								#region [ 演奏クリア ]
								//-----------------------------
								stage演奏ドラム画面.t演奏結果を格納する(out c演奏記録_Drums);

								ps = 0.0;
								gs = 0.0;
								if (!c演奏記録_Drums.b全AUTOである && c演奏記録_Drums.n全チップ数 > 0)
								{
									ps = c演奏記録_Drums.db演奏型スキル値;
									gs = c演奏記録_Drums.dbゲーム型スキル値;
								}
								str = "Cleared";
								switch (CScoreIni.t総合ランク値を計算して返す(c演奏記録_Drums, null, null))
								{
									case (int)CScoreIni.ERANK.SS:
										str = string.Format("Cleared (SS: {0:F2})", ps);
										break;

									case (int)CScoreIni.ERANK.S:
										str = string.Format("Cleared (S: {0:F2})", ps);
										break;

									case (int)CScoreIni.ERANK.A:
										str = string.Format("Cleared (A: {0:F2})", ps);
										break;

									case (int)CScoreIni.ERANK.B:
										str = string.Format("Cleared (B: {0:F2})", ps);
										break;

									case (int)CScoreIni.ERANK.C:
										str = string.Format("Cleared (C: {0:F2})", ps);
										break;

									case (int)CScoreIni.ERANK.D:
										str = string.Format("Cleared (D: {0:F2})", ps);
										break;

									case (int)CScoreIni.ERANK.E:
										str = string.Format("Cleared (E: {0:F2})", ps);
										break;

									case (int)CScoreIni.ERANK.UNKNOWN:  // #23534 2010.10.28 yyagi add: 演奏チップが0個のとき
>>>>>>> twopointzero/develop
										str = "Cleared (No chips)";
										break;
								}

<<<<<<< HEAD
								scoreIni = this.tScoreIniへBGMAdjustとHistoryとPlayCountを更新( str );

								#region [ プラグイン On演奏クリア() の呼び出し ]
								//---------------------
								foreach( STPlugin pg in this.listプラグイン )
								{
									Directory.SetCurrentDirectory( pg.strプラグインフォルダ );
									pg.plugin.On演奏クリア( scoreIni );
									Directory.SetCurrentDirectory( TJAPlayer3.strEXEのあるフォルダ );
								}
								//---------------------
								#endregion

								r現在のステージ.On非活性化();
								Trace.TraceInformation( "----------------------" );
								Trace.TraceInformation( "■ 結果" );
=======
								scoreIni = this.tScoreIniへBGMAdjustとHistoryとPlayCountを更新(str);

								r現在のステージ.On非活性化();
								Trace.TraceInformation("----------------------");
								Trace.TraceInformation("■ 結果");
>>>>>>> twopointzero/develop
								stage結果.st演奏記録.Drums = c演奏記録_Drums;
								stage結果.On活性化();
								r直前のステージ = r現在のステージ;
								r現在のステージ = stage結果;

<<<<<<< HEAD
								#region [ プラグイン Onステージ変更() の呼び出し ]
								//---------------------
								foreach( STPlugin pg in this.listプラグイン )
								{
									Directory.SetCurrentDirectory( pg.strプラグインフォルダ );
									pg.plugin.Onステージ変更();
									Directory.SetCurrentDirectory( TJAPlayer3.strEXEのあるフォルダ );
								}
								//---------------------
								#endregion

=======
>>>>>>> twopointzero/develop
								break;
								//-----------------------------
								#endregion
						}
						//-----------------------------
						#endregion
						break;

					case CStage.Eステージ.結果:
						#region [ *** ]
						//-----------------------------
<<<<<<< HEAD
						if( this.n進行描画の戻り値 != 0 )
						{
							//DTX.t全チップの再生一時停止();
                            DTX.t全チップの再生停止とミキサーからの削除();
                            DTX.On非活性化();
							r現在のステージ.On非活性化();
                            this.tガベージコレクションを実行する();
                            if ( !bコンパクトモード )
							{
								Trace.TraceInformation( "----------------------" );
								Trace.TraceInformation( "■ 選曲" );
								stage選曲.On活性化();
								r直前のステージ = r現在のステージ;
								r現在のステージ = stage選曲;

								foreach( STPlugin pg in this.listプラグイン )
								{
									Directory.SetCurrentDirectory( pg.strプラグインフォルダ );
									pg.plugin.Onステージ変更();
									Directory.SetCurrentDirectory( TJAPlayer3.strEXEのあるフォルダ );
								}

								this.tガベージコレクションを実行する();
							}
							else
							{
								base.Window.Close();
							}
=======
						if (this.n進行描画の戻り値 != 0)
						{
							//DTX.t全チップの再生一時停止();
							DTX.t全チップの再生停止とミキサーからの削除();
							DTX.On非活性化();
							r現在のステージ.On非活性化();
							this.tガベージコレクションを実行する();
							Trace.TraceInformation("----------------------");
							Trace.TraceInformation("■ 選曲");
							stage選曲.On活性化();
							r直前のステージ = r現在のステージ;
							r現在のステージ = stage選曲;

							this.tガベージコレクションを実行する();
>>>>>>> twopointzero/develop
						}
						//-----------------------------
						#endregion
						break;

					case CStage.Eステージ.ChangeSkin:
						#region [ *** ]
						//-----------------------------
<<<<<<< HEAD
						if ( this.n進行描画の戻り値 != 0 )
						{
							r現在のステージ.On非活性化();
							Trace.TraceInformation( "----------------------" );
							Trace.TraceInformation( "■ 選曲" );
=======
						if (this.n進行描画の戻り値 != 0)
						{
							r現在のステージ.On非活性化();
							Trace.TraceInformation("----------------------");
							Trace.TraceInformation("■ 選曲");
>>>>>>> twopointzero/develop
							stage選曲.On活性化();
							r直前のステージ = r現在のステージ;
							r現在のステージ = stage選曲;
							this.tガベージコレクションを実行する();
						}
						//-----------------------------
						#endregion
						break;

					case CStage.Eステージ.終了:
						#region [ *** ]
						//-----------------------------
<<<<<<< HEAD
						if( this.n進行描画の戻り値 != 0 )
=======
						if (this.n進行描画の戻り値 != 0)
>>>>>>> twopointzero/develop
						{
							base.Exit();
						}
						//-----------------------------
						#endregion
						break;
				}

<<<<<<< HEAD
			    actScanningLoudness.On進行描画();

                // オーバレイを描画する(テクスチャの生成されていない起動ステージは例外
                if(r現在のステージ != null && r現在のステージ.eステージID != CStage.Eステージ.起動 && TJAPlayer3.Tx.Overlay != null)
                {
                    TJAPlayer3.Tx.Overlay.t2D描画(app.Device, 0, 0);
                }
			}
			this.Device.EndScene();			// Present()は game.csのOnFrameEnd()に登録された、GraphicsDeviceManager.game_FrameEnd() 内で実行されるので不要
											// (つまり、Present()は、Draw()完了後に実行される)
#if !GPUFlushAfterPresent
			actFlushGPU?.On進行描画();		// Flush GPU	// EndScene()～Present()間 (つまりVSync前) でFlush実行
#endif
			if ( Sound管理?.GetCurrentSoundDeviceType() != "DirectSound" )
			{
				Sound管理?.t再生中の処理をする();	// サウンドバッファの更新; 画面描画と同期させることで、スクロールをスムーズにする
			}


			#region [ 全画面_ウインドウ切り替え ]
			if ( this.b次のタイミングで全画面_ウィンドウ切り替えを行う )
=======
				actScanningLoudness.On進行描画();

				// オーバレイを描画する(テクスチャの生成されていない起動ステージは例外
				if (r現在のステージ != null && r現在のステージ.eステージID != CStage.Eステージ.起動 && TJAPlayer3.Tx.Overlay != null)
				{
					TJAPlayer3.Tx.Overlay.t2D描画(app.Device, 0, 0);
				}
			}
			this.Device.EndScene();         // Present()は game.csのOnFrameEnd()に登録された、GraphicsDeviceManager.game_FrameEnd() 内で実行されるので不要
											// (つまり、Present()は、Draw()完了後に実行される)
#if !GPUFlushAfterPresent
			actFlushGPU?.On進行描画();      // Flush GPU	// EndScene()～Present()間 (つまりVSync前) でFlush実行
#endif

			#region [ 全画面_ウインドウ切り替え ]
			if (this.b次のタイミングで全画面_ウィンドウ切り替えを行う)
>>>>>>> twopointzero/develop
			{
				ConfigIni.b全画面モード = !ConfigIni.b全画面モード;
				app.t全画面_ウィンドウモード切り替え();
				this.b次のタイミングで全画面_ウィンドウ切り替えを行う = false;
			}
			#endregion
			#region [ 垂直基線同期切り替え ]
<<<<<<< HEAD
			if ( this.b次のタイミングで垂直帰線同期切り替えを行う )
			{
				bool bIsMaximized = this.Window.IsMaximized;											// #23510 2010.11.3 yyagi: to backup current window mode before changing VSyncWait
				currentClientSize = this.Window.ClientSize;												// #23510 2010.11.3 yyagi: to backup current window size before changing VSyncWait
				DeviceSettings currentSettings = app.GraphicsDeviceManager.CurrentSettings;
				currentSettings.EnableVSync = ConfigIni.b垂直帰線待ちを行う;
				app.GraphicsDeviceManager.ChangeDevice( currentSettings );
				this.b次のタイミングで垂直帰線同期切り替えを行う = false;
				base.Window.ClientSize = new Size(currentClientSize.Width, currentClientSize.Height);	// #23510 2010.11.3 yyagi: to resume window size after changing VSyncWait
				if (bIsMaximized)
				{
					this.Window.WindowState = FormWindowState.Maximized;								// #23510 2010.11.3 yyagi: to resume window mode after changing VSyncWait
=======
			if (this.b次のタイミングで垂直帰線同期切り替えを行う)
			{
				bool bIsMaximized = this.Window.IsMaximized;                                            // #23510 2010.11.3 yyagi: to backup current window mode before changing VSyncWait
				currentClientSize = this.Window.ClientSize;                                             // #23510 2010.11.3 yyagi: to backup current window size before changing VSyncWait
				DeviceSettings currentSettings = app.GraphicsDeviceManager.CurrentSettings;
				currentSettings.EnableVSync = ConfigIni.b垂直帰線待ちを行う;
				app.GraphicsDeviceManager.ChangeDevice(currentSettings);
				this.b次のタイミングで垂直帰線同期切り替えを行う = false;
				base.Window.ClientSize = new Size(currentClientSize.Width, currentClientSize.Height);   // #23510 2010.11.3 yyagi: to resume window size after changing VSyncWait
				if (bIsMaximized)
				{
					this.Window.WindowState = FormWindowState.Maximized;                                // #23510 2010.11.3 yyagi: to resume window mode after changing VSyncWait
>>>>>>> twopointzero/develop
				}
			}
			#endregion
		}

		// その他

		#region [ 汎用ヘルパー ]
		//-----------------
<<<<<<< HEAD
		public static CTexture tテクスチャの生成( string fileName )
		{
			return tテクスチャの生成( fileName, false );
		}
		public static CTexture tテクスチャの生成( string fileName, bool b黒を透過する )
		{
			if ( app == null )
=======
		public static CTexture tテクスチャの生成(string fileName)
		{
			return tテクスチャの生成(fileName, false);
		}
		public static CTexture tテクスチャの生成(string fileName, bool b黒を透過する)
		{
			if (app == null)
>>>>>>> twopointzero/develop
			{
				return null;
			}
			try
			{
<<<<<<< HEAD
				return new CTexture( app.Device, fileName, TextureFormat, b黒を透過する );
			}
			catch ( CTextureCreateFailedException e )
			{
				Trace.TraceError( e.ToString() );
				Trace.TraceError( "テクスチャの生成に失敗しました。({0})", fileName );
				return null;
			}
			catch ( FileNotFoundException )
			{
				Trace.TraceWarning( "テクスチャファイルが見つかりませんでした。({0})", fileName );
				return null;
			}
		}
		public static void tテクスチャの解放(ref CTexture tx )
		{
			TJAPlayer3.t安全にDisposeする( ref tx );
		}
        public static void tテクスチャの解放( ref CTextureAf tx )
		{
			TJAPlayer3.t安全にDisposeする( ref tx );
		}
		public static CTexture tテクスチャの生成( byte[] txData )
		{
			return tテクスチャの生成( txData, false );
		}
		public static CTexture tテクスチャの生成( byte[] txData, bool b黒を透過する )
		{
			if ( app == null )
			{
				return null;
			}
			try
			{
				return new CTexture( app.Device, txData, TextureFormat, b黒を透過する );
			}
			catch ( CTextureCreateFailedException e )
			{
				Trace.TraceError( e.ToString() );
				Trace.TraceError( "テクスチャの生成に失敗しました。(txData)" );
				return null;
			}
		}
		public static CTexture tテクスチャの生成( Bitmap bitmap )
		{
			return tテクスチャの生成( bitmap, false );
		}
		public static CTexture tテクスチャの生成( Bitmap bitmap, bool b黒を透過する )
		{
			if ( app == null )
			{
				return null;
			}
            if (bitmap == null)
            {
                Trace.TraceError("テクスチャの生成に失敗しました。(bitmap==null)");
                return null;
            }
            try
			{
				return new CTexture( app.Device, bitmap, TextureFormat, b黒を透過する );
			}
			catch ( CTextureCreateFailedException e )
			{
				Trace.TraceError( e.ToString() );
				Trace.TraceError( "テクスチャの生成に失敗しました。(txData)" );
=======
				return new CTexture(app.Device, fileName, TextureFormat, b黒を透過する);
			}
			catch (CTextureCreateFailedException e)
			{
				Trace.TraceError(e.ToString());
				Trace.TraceError("テクスチャの生成に失敗しました。({0})", fileName);
				return null;
			}
			catch (FileNotFoundException)
			{
				Trace.TraceWarning("テクスチャファイルが見つかりませんでした。({0})", fileName);
				return null;
			}
		}

		public static CTexture tテクスチャの生成(Bitmap bitmap)
		{
			return tテクスチャの生成(bitmap, false);
		}
		public static CTexture tテクスチャの生成(Bitmap bitmap, bool b黒を透過する)
		{
			if (app == null)
			{
				return null;
			}
			if (bitmap == null)
			{
				Trace.TraceError("テクスチャの生成に失敗しました。(bitmap==null)");
				return null;
			}
			try
			{
				return new CTexture(app.Device, bitmap, TextureFormat, b黒を透過する);
			}
			catch (CTextureCreateFailedException e)
			{
				Trace.TraceError(e.ToString());
				Trace.TraceError("テクスチャの生成に失敗しました。(txData)");
				return null;
			}
		}

		public static CTextureAf tテクスチャの生成Af(string fileName)
		{
			return tテクスチャの生成Af(fileName, false);
		}

        private static CTextureAf tテクスチャの生成Af( string fileName, bool b黒を透過する )
		{
			if (app == null)
			{
				return null;
			}
			try
			{
				return new CTextureAf(app.Device, fileName, TextureFormat, b黒を透過する);
			}
			catch (CTextureCreateFailedException e)
			{
				Trace.TraceError(e.ToString());
				Trace.TraceError("テクスチャの生成に失敗しました。({0})", fileName);
				return null;
			}
			catch (FileNotFoundException e)
			{
				Trace.TraceError(e.ToString());
				Trace.TraceError("テクスチャファイルが見つかりませんでした。({0})", fileName);
>>>>>>> twopointzero/develop
				return null;
			}
		}

<<<<<<< HEAD
        public static CTextureAf tテクスチャの生成Af( string fileName )
		{
			return tテクスチャの生成Af( fileName, false );
		}
		public static CTextureAf tテクスチャの生成Af( string fileName, bool b黒を透過する )
		{
			if ( app == null )
			{
				return null;
			}
			try
			{
				return new CTextureAf( app.Device, fileName, TextureFormat, b黒を透過する );
			}
			catch ( CTextureCreateFailedException e )
			{
				Trace.TraceError( e.ToString() );
				Trace.TraceError( "テクスチャの生成に失敗しました。({0})", fileName );
				return null;
			}
			catch ( FileNotFoundException e )
			{
				Trace.TraceError( e.ToString() );
				Trace.TraceError( "テクスチャファイルが見つかりませんでした。({0})", fileName );
				return null;
			}
		}
        public static CDirectShow t失敗してもスキップ可能なDirectShowを生成する(string fileName, IntPtr hWnd, bool bオーディオレンダラなし)
        {
            CDirectShow ds = null;
            if( File.Exists( fileName ) )
            {
                try
                {
                    ds = new CDirectShow(fileName, hWnd, bオーディオレンダラなし);
                }
                catch (FileNotFoundException e)
                {
                    Trace.TraceError( e.ToString() );
                    Trace.TraceError("動画ファイルが見つかりませんでした。({0})", fileName);
                    ds = null;      // Dispose はコンストラクタ内で実施済み
                }
                catch (Exception e)
                {
                    Trace.TraceError( e.ToString() );
                    Trace.TraceError("DirectShow の生成に失敗しました。[{0}]", fileName);
                    ds = null;      // Dispose はコンストラクタ内で実施済み
                }
            }
            else
            {
                Trace.TraceError("動画ファイルが見つかりませんでした。({0})", fileName);
                return null;
            }

            return ds;
        }

        /// <summary>プロパティ、インデクサには ref は使用できないので注意。</summary>
        public static void t安全にDisposeする<T>(ref T obj)
        {
            if (obj == null)
                return;

            var d = obj as IDisposable;

            if (d != null)
                d.Dispose();

            obj = default(T);
        }

        /// <summary>
        /// そのフォルダの連番画像の最大値を返す。
        /// </summary>
        public static int t連番画像の枚数を数える(string ディレクトリ名, string プレフィックス = "", string 拡張子 = ".png")
        {
            int num = 0;
            while(File.Exists(ディレクトリ名 + プレフィックス + num + 拡張子))
            {
                num++;
            }
            return num;
        }

        /// <summary>
        /// 曲名テクスチャの縮小倍率を返す。
        /// </summary>
        /// <param name="cTexture">曲名テクスチャ。</param>
        /// <param name="samePixel">等倍で表示するピクセル数の最大値(デフォルト値:645)</param>
        /// <returns>曲名テクスチャの縮小倍率。そのテクスチャがnullならば一倍(1f)を返す。</returns>
        public static float GetSongNameXScaling(ref CTexture cTexture, int samePixel = 660)
        {
            if (cTexture == null) return 1f;
            float scalingRate = (float)samePixel / (float)cTexture.szテクスチャサイズ.Width;
            if (cTexture.szテクスチャサイズ.Width <= samePixel)
                scalingRate = 1.0f;
            return scalingRate;
        }

        /// <summary>
        /// 難易度を表す数字を列挙体に変換します。
        /// </summary>
        /// <param name="number">難易度を表す数字。</param>
        /// <returns>Difficulty 列挙体</returns>
        public static Difficulty DifficultyNumberToEnum(int number)
        {
            switch (number)
            {
                case 0:
                    return Difficulty.Easy;
                case 1:
                    return Difficulty.Normal;
                case 2:
                    return Difficulty.Hard;
                case 3:
                    return Difficulty.Oni;
                case 4:
                    return Difficulty.Edit;
                case 5:
                    return Difficulty.Tower;
                case 6:
                    return Difficulty.Dan;
                default:
                    throw new IndexOutOfRangeException();
            }
        }

        //-----------------
        #endregion

        #region [ private ]
        //-----------------
        private bool bマウスカーソル表示中 = true;
		private bool b終了処理完了済み;
		private static CDTX[] dtx = new CDTX[ 4 ];

        public static TextureLoader Tx = new TextureLoader();
=======
		/// <summary>プロパティ、インデクサには ref は使用できないので注意。</summary>
		public static void t安全にDisposeする<T>(ref T obj) where T : class, IDisposable
		{
			if (obj == null)
			{
				return;
			}

			obj.Dispose();
			obj = null;
		}

		public static void t安全にDisposeする<T>(T[] array) where T : class, IDisposable
		{
			if (array == null)
			{
				return;
			}

			for (var i = 0; i < array.Length; i++)
			{
				array[i]?.Dispose();
				array[i] = null;
			}
		}

		/// <summary>
		/// そのフォルダの連番画像の最大値を返す。
		/// </summary>
		public static int t連番画像の枚数を数える(string ディレクトリ名, string プレフィックス = "", string 拡張子 = ".png")
		{
			int num = 0;
			while (File.Exists(ディレクトリ名 + プレフィックス + num + 拡張子))
			{
				num++;
			}
			return num;
		}

		/// <summary>
		/// 曲名テクスチャの縮小倍率を返す。
		/// </summary>
		/// <param name="cTexture">曲名テクスチャ。</param>
		/// <param name="samePixel">等倍で表示するピクセル数の最大値(デフォルト値:645)</param>
		/// <returns>曲名テクスチャの縮小倍率。そのテクスチャがnullならば一倍(1f)を返す。</returns>
		public static float GetSongNameXScaling(ref CTexture cTexture, int samePixel = 660)
		{
			if (cTexture == null) return 1f;
			float scalingRate = (float)samePixel / (float)cTexture.szテクスチャサイズ.Width;
			if (cTexture.szテクスチャサイズ.Width <= samePixel)
				scalingRate = 1.0f;
			return scalingRate;
		}

		/// <summary>
		/// 難易度を表す数字を列挙体に変換します。
		/// </summary>
		/// <param name="number">難易度を表す数字。</param>
		/// <returns>Difficulty 列挙体</returns>
		public static Difficulty DifficultyNumberToEnum(int number)
		{
			switch (number)
			{
				case 0:
					return Difficulty.Easy;
				case 1:
					return Difficulty.Normal;
				case 2:
					return Difficulty.Hard;
				case 3:
					return Difficulty.Oni;
				case 4:
					return Difficulty.Edit;
				case 5:
					return Difficulty.Tower;
				case 6:
					return Difficulty.Dan;
				default:
					throw new IndexOutOfRangeException();
			}
		}

		//-----------------
		#endregion

		#region [ private ]
		//-----------------
		private bool bマウスカーソル表示中 = true;
		private bool b終了処理完了済み;
		private static CDTX[] dtx = new CDTX[4];

		public static TextureLoader Tx = new TextureLoader();
>>>>>>> twopointzero/develop

		private List<CActivity> listトップレベルActivities;
		private int n進行描画の戻り値;
		private MouseButtons mb = System.Windows.Forms.MouseButtons.Left;
<<<<<<< HEAD
		private string strWindowTitle
		{
			get
			{
				if ( DTXVmode.Enabled )
				{
					return "DTXViewer release " + VERSION;
				}
				else
				{
					return "TJAPlayer3 feat.DTXMania";
				}
			}
		}
		private CSound previewSound;
        public static long StartupTime
        {
            get;
            private set;
        }

        private void t起動処理()
		{
			#region [ strEXEのあるフォルダを決定する ]
			//-----------------
// BEGIN #23629 2010.11.13 from: デバッグ時は Application.ExecutablePath が ($SolutionDir)/bin/x86/Debug/ などになり System/ の読み込みに失敗するので、カレントディレクトリを採用する。（プロジェクトのプロパティ→デバッグ→作業ディレクトリが有効になる）
=======
		private CSound previewSound;
		public static long StartupTime
		{
			get;
			private set;
		}

		private void t起動処理()
		{
			#region [ strEXEのあるフォルダを決定する ]
			//-----------------
			// BEGIN #23629 2010.11.13 from: デバッグ時は Application.ExecutablePath が ($SolutionDir)/bin/x86/Debug/ などになり System/ の読み込みに失敗するので、カレントディレクトリを採用する。（プロジェクトのプロパティ→デバッグ→作業ディレクトリが有効になる）
>>>>>>> twopointzero/develop
#if DEBUG
			strEXEのあるフォルダ = Environment.CurrentDirectory + @"\";
#else
			strEXEのあるフォルダ = Path.GetDirectoryName( Application.ExecutablePath ) + @"\";	// #23629 2010.11.9 yyagi: set correct pathname where DTXManiaGR.exe is.
#endif
<<<<<<< HEAD
// END #23629 2010.11.13 from
=======
			// END #23629 2010.11.13 from
>>>>>>> twopointzero/develop
			//-----------------
			#endregion

			#region [ Config.ini の読込み ]
			//---------------------
			ConfigIni = new CConfigIni();
			string path = strEXEのあるフォルダ + "Config.ini";
<<<<<<< HEAD
			if( File.Exists( path ) )
			{
				try
				{
					ConfigIni.tファイルから読み込み( path );
=======
			if (File.Exists(path))
			{
				try
				{
					ConfigIni.tファイルから読み込み(path);
>>>>>>> twopointzero/develop
				}
				catch (Exception e)
				{
					//ConfigIni = new CConfigIni();	// 存在してなければ新規生成
<<<<<<< HEAD
					Trace.TraceError( e.ToString() );
					Trace.TraceError( "例外が発生しましたが処理を継続します。 (b8d93255-bbe4-4ca3-8264-7ee5175b19f3)" );
				}
			}
			this.Window.EnableSystemMenu = TJAPlayer3.ConfigIni.bIsEnabledSystemMenu;	// #28200 2011.5.1 yyagi
			// 2012.8.22 Config.iniが無いときに初期値が適用されるよう、この設定行をifブロック外に移動
=======
					Trace.TraceError(e.ToString());
					Trace.TraceError("例外が発生しましたが処理を継続します。 (b8d93255-bbe4-4ca3-8264-7ee5175b19f3)");
				}
			}
			this.Window.EnableSystemMenu = TJAPlayer3.ConfigIni.bIsEnabledSystemMenu;   // #28200 2011.5.1 yyagi
																						// 2012.8.22 Config.iniが無いときに初期値が適用されるよう、この設定行をifブロック外に移動
>>>>>>> twopointzero/develop

			//---------------------
			#endregion
			#region [ ログ出力開始 ]
			//---------------------
			Trace.AutoFlush = true;
<<<<<<< HEAD
			if( ConfigIni.bログ出力 )
			{
				try
				{
					Trace.Listeners.Add( new CTraceLogListener( new StreamWriter( System.IO.Path.Combine( strEXEのあるフォルダ, "TJAPlayer3.log" ), false, Encoding.GetEncoding( "Shift_JIS" ) ) ) );
				}
				catch ( System.UnauthorizedAccessException )			// #24481 2011.2.20 yyagi
				{
					int c = (CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "ja")? 0 : 1;
=======
			if (ConfigIni.bログ出力)
			{
				try
				{
					Trace.Listeners.Add(new CTraceLogListener(new StreamWriter(System.IO.Path.Combine(strEXEのあるフォルダ, "TJAPlayer3.log"), false, Encoding.GetEncoding("Shift_JIS"))));
				}
				catch (System.UnauthorizedAccessException)          // #24481 2011.2.20 yyagi
				{
					int c = (CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "ja") ? 0 : 1;
>>>>>>> twopointzero/develop
					string[] mes_writeErr = {
						"DTXManiaLog.txtへの書き込みができませんでした。書き込みできるようにしてから、再度起動してください。",
						"Failed to write DTXManiaLog.txt. Please set it writable and try again."
					};
<<<<<<< HEAD
					MessageBox.Show( mes_writeErr[c], "DTXMania boot error", MessageBoxButtons.OK, MessageBoxIcon.Error );
=======
					MessageBox.Show(mes_writeErr[c], "DTXMania boot error", MessageBoxButtons.OK, MessageBoxIcon.Error);
>>>>>>> twopointzero/develop
					Environment.Exit(1);
				}
			}
			Trace.WriteLine("");
<<<<<<< HEAD
			Trace.WriteLine( "DTXMania powered by YAMAHA Silent Session Drums" );
			Trace.WriteLine( string.Format( "Release: {0}", VERSION ) );
			Trace.WriteLine( "" );
			Trace.TraceInformation( "----------------------" );
			Trace.TraceInformation( "■ アプリケーションの初期化" );
			Trace.TraceInformation( "OS Version: " + Environment.OSVersion );
			Trace.TraceInformation( "ProcessorCount: " + Environment.ProcessorCount.ToString() );
			Trace.TraceInformation( "CLR Version: " + Environment.Version.ToString() );
			//---------------------
			#endregion
			#region [ DTXVmodeクラス の初期化 ]
			//---------------------
			//Trace.TraceInformation( "DTXVモードの初期化を行います。" );
			//Trace.Indent();
			try
			{
				DTXVmode = new CDTXVmode();
				DTXVmode.Enabled = false;
				//Trace.TraceInformation( "DTXVモードの初期化を完了しました。" );
			}
			finally
			{
				//Trace.Unindent();
			}
			//---------------------
			#endregion


			#region [ ウィンドウ初期化 ]
			//---------------------
			base.Window.StartPosition = FormStartPosition.Manual;                                                       // #30675 2013.02.04 ikanick add
			base.Window.Location = new Point( ConfigIni.n初期ウィンドウ開始位置X, ConfigIni.n初期ウィンドウ開始位置Y );   // #30675 2013.02.04 ikanick add

            
            base.Window.Text = "";

			base.Window.StartPosition = FormStartPosition.Manual;                                                       // #30675 2013.02.04 ikanick add
            base.Window.Location = new Point(ConfigIni.n初期ウィンドウ開始位置X, ConfigIni.n初期ウィンドウ開始位置Y);   // #30675 2013.02.04 ikanick add

			base.Window.ClientSize = new Size(ConfigIni.nウインドウwidth, ConfigIni.nウインドウheight);	// #34510 yyagi 2010.10.31 to change window size got from Config.ini
#if !WindowedFullscreen
			if (!ConfigIni.bウィンドウモード)						// #23510 2010.11.02 yyagi: add; to recover window size in case bootup with fullscreen mode
			{														// #30666 2013.02.02 yyagi: currentClientSize should be always made
#endif
				currentClientSize = new Size( ConfigIni.nウインドウwidth, ConfigIni.nウインドウheight );
#if !WindowedFullscreen
			}
#endif
			base.Window.MaximizeBox = true;							// #23510 2010.11.04 yyagi: to support maximizing window
			base.Window.FormBorderStyle = FormBorderStyle.Sizable;	// #23510 2010.10.27 yyagi: changed from FixedDialog to Sizable, to support window resize
																		// #30666 2013.02.02 yyagi: moved the code to t全画面_ウインドウモード切り替え()
			base.Window.ShowIcon = true;
			base.Window.Icon = global::TJAPlayer3.Properties.Resources.tjap3;
			base.Window.KeyDown += new KeyEventHandler( this.Window_KeyDown );
			base.Window.MouseUp +=new MouseEventHandler( this.Window_MouseUp);
			base.Window.MouseDoubleClick += new MouseEventHandler(this.Window_MouseDoubleClick);	// #23510 2010.11.13 yyagi: to go fullscreen mode
			base.Window.ResizeEnd += new EventHandler(this.Window_ResizeEnd);						// #23510 2010.11.20 yyagi: to set resized window size in Config.ini
			base.Window.ApplicationActivated += new EventHandler(this.Window_ApplicationActivated);
			base.Window.ApplicationDeactivated += new EventHandler( this.Window_ApplicationDeactivated );
=======
			Trace.WriteLine(AppDisplayNameWithInformationalVersion);
			Trace.WriteLine("");
			Trace.TraceInformation("----------------------");
			Trace.TraceInformation("■ アプリケーションの初期化");
			Trace.TraceInformation("OS Version: " + Environment.OSVersion);
			Trace.TraceInformation("ProcessorCount: " + Environment.ProcessorCount.ToString());
			Trace.TraceInformation("CLR Version: " + Environment.Version.ToString());
			//---------------------
			#endregion

			#region [ ウィンドウ初期化 ]
			//---------------------
			base.Window.StartPosition = FormStartPosition.Manual;                                                       // #30675 2013.02.04 ikanick add
			base.Window.Location = new Point(ConfigIni.n初期ウィンドウ開始位置X, ConfigIni.n初期ウィンドウ開始位置Y);   // #30675 2013.02.04 ikanick add


			base.Window.Text = "";

			base.Window.StartPosition = FormStartPosition.Manual;                                                       // #30675 2013.02.04 ikanick add
			base.Window.Location = new Point(ConfigIni.n初期ウィンドウ開始位置X, ConfigIni.n初期ウィンドウ開始位置Y);   // #30675 2013.02.04 ikanick add

			base.Window.ClientSize = new Size(ConfigIni.nウインドウwidth, ConfigIni.nウインドウheight);   // #34510 yyagi 2010.10.31 to change window size got from Config.ini
#if !WindowedFullscreen
			if (!ConfigIni.bウィンドウモード)                       // #23510 2010.11.02 yyagi: add; to recover window size in case bootup with fullscreen mode
			{                                                       // #30666 2013.02.02 yyagi: currentClientSize should be always made
#endif
				currentClientSize = new Size(ConfigIni.nウインドウwidth, ConfigIni.nウインドウheight);
#if !WindowedFullscreen
			}
#endif
			base.Window.MaximizeBox = true;                         // #23510 2010.11.04 yyagi: to support maximizing window
			base.Window.FormBorderStyle = FormBorderStyle.Sizable;  // #23510 2010.10.27 yyagi: changed from FixedDialog to Sizable, to support window resize
																	// #30666 2013.02.02 yyagi: moved the code to t全画面_ウインドウモード切り替え()
			base.Window.ShowIcon = true;
			base.Window.Icon = global::TJAPlayer3.Properties.Resources.tjap3;
			base.Window.KeyDown += new KeyEventHandler(this.Window_KeyDown);
			base.Window.MouseUp += new MouseEventHandler(this.Window_MouseUp);
			base.Window.MouseDoubleClick += new MouseEventHandler(this.Window_MouseDoubleClick);    // #23510 2010.11.13 yyagi: to go fullscreen mode
			base.Window.ResizeEnd += new EventHandler(this.Window_ResizeEnd);                       // #23510 2010.11.20 yyagi: to set resized window size in Config.ini
			base.Window.ApplicationActivated += new EventHandler(this.Window_ApplicationActivated);
			base.Window.ApplicationDeactivated += new EventHandler(this.Window_ApplicationDeactivated);
>>>>>>> twopointzero/develop
			//---------------------
			#endregion
			#region [ Direct3D9Exを使うかどうか判定 ]
			#endregion
			#region [ Direct3D9 デバイスの生成 ]
			//---------------------
			DeviceSettings settings = new DeviceSettings();
#if WindowedFullscreen
			settings.Windowed = true;								// #30666 2013.2.2 yyagi: Fullscreenmode is "Maximized window" mode
#else
			settings.Windowed = ConfigIni.bウィンドウモード;
#endif
			settings.BackBufferWidth = SampleFramework.GameWindowSize.Width;
			settings.BackBufferHeight = SampleFramework.GameWindowSize.Height;
<<<<<<< HEAD
//			settings.BackBufferCount = 3;
			settings.EnableVSync = ConfigIni.b垂直帰線待ちを行う;
//			settings.BackBufferFormat = Format.A8R8G8B8;
//			settings.MultisampleType = MultisampleType.FourSamples;
//			settings.MultisampleQuality = 4;
//			settings.MultisampleType = MultisampleType.None;
//			settings.MultisampleQuality = 0;
			
=======
			//			settings.BackBufferCount = 3;
			settings.EnableVSync = ConfigIni.b垂直帰線待ちを行う;
			//			settings.BackBufferFormat = Format.A8R8G8B8;
			//			settings.MultisampleType = MultisampleType.FourSamples;
			//			settings.MultisampleQuality = 4;
			//			settings.MultisampleType = MultisampleType.None;
			//			settings.MultisampleQuality = 0;

>>>>>>> twopointzero/develop
			try
			{
				base.GraphicsDeviceManager.ChangeDevice(settings);
			}
			catch (DeviceCreationException e)
			{
				Trace.TraceError(e.ToString());
				MessageBox.Show(e.ToString(), "DTXMania failed to boot: DirectX9 Initialize Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Environment.Exit(-1);
			}
<<<<<<< HEAD
			
			base.IsFixedTimeStep = false;
//			base.TargetElapsedTime = TimeSpan.FromTicks( 10000000 / 75 );
			base.Window.ClientSize = new Size(ConfigIni.nウインドウwidth, ConfigIni.nウインドウheight);	// #23510 2010.10.31 yyagi: to recover window size. width and height are able to get from Config.ini.
			base.InactiveSleepTime = TimeSpan.FromMilliseconds((float)(ConfigIni.n非フォーカス時スリープms));	// #23568 2010.11.3 yyagi: to support valiable sleep value when !IsActive
																												// #23568 2010.11.4 ikanick changed ( 1 -> ConfigIni )
=======

			base.IsFixedTimeStep = false;
			//			base.TargetElapsedTime = TimeSpan.FromTicks( 10000000 / 75 );
			base.Window.ClientSize = new Size(ConfigIni.nウインドウwidth, ConfigIni.nウインドウheight);   // #23510 2010.10.31 yyagi: to recover window size. width and height are able to get from Config.ini.
			base.InactiveSleepTime = TimeSpan.FromMilliseconds((float)(ConfigIni.n非フォーカス時スリープms));  // #23568 2010.11.3 yyagi: to support valiable sleep value when !IsActive
																									// #23568 2010.11.4 ikanick changed ( 1 -> ConfigIni )
>>>>>>> twopointzero/develop
#if WindowedFullscreen
			this.t全画面_ウィンドウモード切り替え();				// #30666 2013.2.2 yyagi: finalize settings for "Maximized window mode"
#endif
			actFlushGPU = new CActFlushGPU();
			//---------------------
			#endregion

			DTX = null;

			#region [ Skin の初期化 ]
			//---------------------
<<<<<<< HEAD
			Trace.TraceInformation( "スキンの初期化を行います。" );
			Trace.Indent();
			try
			{
				Skin = new CSkin( TJAPlayer3.ConfigIni.strSystemSkinSubfolderFullName, false);
				TJAPlayer3.ConfigIni.strSystemSkinSubfolderFullName = TJAPlayer3.Skin.GetCurrentSkinSubfolderFullName( true );	// 旧指定のSkinフォルダが消滅していた場合に備える
				Trace.TraceInformation( "スキンの初期化を完了しました。" );
			}
			catch (Exception e)
			{
				Trace.TraceInformation( "スキンの初期化に失敗しました。" );
=======
			Trace.TraceInformation("スキンの初期化を行います。");
			Trace.Indent();
			try
			{
				Skin = new CSkin(TJAPlayer3.ConfigIni.strSystemSkinSubfolderFullName, false);
				TJAPlayer3.ConfigIni.strSystemSkinSubfolderFullName = TJAPlayer3.Skin.GetCurrentSkinSubfolderFullName(true);    // 旧指定のSkinフォルダが消滅していた場合に備える
				Trace.TraceInformation("スキンの初期化を完了しました。");
			}
			catch (Exception e)
			{
				Trace.TraceInformation("スキンの初期化に失敗しました。");
>>>>>>> twopointzero/develop
				throw;
			}
			finally
			{
				Trace.Unindent();
			}
			//---------------------
			#endregion
			//-----------
			#region [ Timer の初期化 ]
			//---------------------
<<<<<<< HEAD
			Trace.TraceInformation( "タイマの初期化を行います。" );
			Trace.Indent();
			try
			{
				Timer = new CTimer( CTimer.E種別.MultiMedia );
				Trace.TraceInformation( "タイマの初期化を完了しました。" );
=======
			Trace.TraceInformation("タイマの初期化を行います。");
			Trace.Indent();
			try
			{
				Timer = new CTimer(CTimer.E種別.MultiMedia);
				Trace.TraceInformation("タイマの初期化を完了しました。");
>>>>>>> twopointzero/develop
			}
			finally
			{
				Trace.Unindent();
			}
			//---------------------
			#endregion
			//-----------

			#region [ FPS カウンタの初期化 ]
			//---------------------
<<<<<<< HEAD
			Trace.TraceInformation( "FPSカウンタの初期化を行います。" );
=======
			Trace.TraceInformation("FPSカウンタの初期化を行います。");
>>>>>>> twopointzero/develop
			Trace.Indent();
			try
			{
				FPS = new CFPS();
<<<<<<< HEAD
				Trace.TraceInformation( "FPSカウンタを生成しました。" );
=======
				Trace.TraceInformation("FPSカウンタを生成しました。");
>>>>>>> twopointzero/develop
			}
			finally
			{
				Trace.Unindent();
			}
			//---------------------
			#endregion
			#region [ act文字コンソールの初期化 ]
			//---------------------
<<<<<<< HEAD
			Trace.TraceInformation( "文字コンソールの初期化を行います。" );
=======
			Trace.TraceInformation("文字コンソールの初期化を行います。");
>>>>>>> twopointzero/develop
			Trace.Indent();
			try
			{
				act文字コンソール = new C文字コンソール();
<<<<<<< HEAD
				Trace.TraceInformation( "文字コンソールを生成しました。" );
				act文字コンソール.On活性化();
				Trace.TraceInformation( "文字コンソールを活性化しました。" );
				Trace.TraceInformation( "文字コンソールの初期化を完了しました。" );
			}
			catch( Exception exception )
			{
				Trace.TraceError( exception.ToString() );
				Trace.TraceError( "文字コンソールの初期化に失敗しました。" );
=======
				Trace.TraceInformation("文字コンソールを生成しました。");
				act文字コンソール.On活性化();
				Trace.TraceInformation("文字コンソールを活性化しました。");
				Trace.TraceInformation("文字コンソールの初期化を完了しました。");
			}
			catch (Exception exception)
			{
				Trace.TraceError(exception.ToString());
				Trace.TraceError("文字コンソールの初期化に失敗しました。");
>>>>>>> twopointzero/develop
			}
			finally
			{
				Trace.Unindent();
			}
			//---------------------
			#endregion
			#region [ Input管理 の初期化 ]
			//---------------------
<<<<<<< HEAD
			Trace.TraceInformation( "DirectInput, MIDI入力の初期化を行います。" );
			Trace.Indent();
			try
			{
				bool bUseMIDIIn = !DTXVmode.Enabled;
				Input管理 = new CInput管理( base.Window.Handle, bUseMIDIIn );
				foreach( IInputDevice device in Input管理.list入力デバイス )
				{
					if( ( device.e入力デバイス種別 == E入力デバイス種別.Joystick ) && !ConfigIni.dicJoystick.ContainsValue( device.GUID ) )
					{
						int key = 0;
						while( ConfigIni.dicJoystick.ContainsKey( key ) )
						{
							key++;
						}
						ConfigIni.dicJoystick.Add( key, device.GUID );
					}
				}
				foreach( IInputDevice device2 in Input管理.list入力デバイス )
				{
					if( device2.e入力デバイス種別 == E入力デバイス種別.Joystick )
					{
						foreach( KeyValuePair<int, string> pair in ConfigIni.dicJoystick )
						{
							if( device2.GUID.Equals( pair.Value ) )
							{
								( (CInputJoystick) device2 ).SetID( pair.Key );
=======
			Trace.TraceInformation("DirectInput, MIDI入力の初期化を行います。");
			Trace.Indent();
			try
			{
				Input管理 = new CInput管理(base.Window.Handle);
				foreach (IInputDevice device in Input管理.list入力デバイス)
				{
					if ((device.e入力デバイス種別 == E入力デバイス種別.Joystick) && !ConfigIni.dicJoystick.ContainsValue(device.GUID))
					{
						int key = 0;
						while (ConfigIni.dicJoystick.ContainsKey(key))
						{
							key++;
						}
						ConfigIni.dicJoystick.Add(key, device.GUID);
					}
				}
				foreach (IInputDevice device2 in Input管理.list入力デバイス)
				{
					if (device2.e入力デバイス種別 == E入力デバイス種別.Joystick)
					{
						foreach (KeyValuePair<int, string> pair in ConfigIni.dicJoystick)
						{
							if (device2.GUID.Equals(pair.Value))
							{
								((CInputJoystick)device2).SetID(pair.Key);
>>>>>>> twopointzero/develop
								break;
							}
						}
						continue;
					}
				}
<<<<<<< HEAD
				Trace.TraceInformation( "DirectInput の初期化を完了しました。" );
			}
			catch( Exception exception2 )
			{
				Trace.TraceError( "DirectInput, MIDI入力の初期化に失敗しました。" );
=======
				Trace.TraceInformation("DirectInput の初期化を完了しました。");
			}
			catch (Exception exception2)
			{
				Trace.TraceError("DirectInput, MIDI入力の初期化に失敗しました。");
>>>>>>> twopointzero/develop
				throw;
			}
			finally
			{
				Trace.Unindent();
			}
			//---------------------
			#endregion
			#region [ Pad の初期化 ]
			//---------------------
<<<<<<< HEAD
			Trace.TraceInformation( "パッドの初期化を行います。" );
			Trace.Indent();
			try
			{
				Pad = new CPad( ConfigIni, Input管理 );
				Trace.TraceInformation( "パッドの初期化を完了しました。" );
			}
			catch( Exception exception3 )
			{
				Trace.TraceError( exception3.ToString() );
				Trace.TraceError( "パッドの初期化に失敗しました。" );
=======
			Trace.TraceInformation("パッドの初期化を行います。");
			Trace.Indent();
			try
			{
				Pad = new CPad(ConfigIni, Input管理);
				Trace.TraceInformation("パッドの初期化を完了しました。");
			}
			catch (Exception exception3)
			{
				Trace.TraceError(exception3.ToString());
				Trace.TraceError("パッドの初期化に失敗しました。");
>>>>>>> twopointzero/develop
			}
			finally
			{
				Trace.Unindent();
			}
			//---------------------
			#endregion
			#region [ Sound管理 の初期化 ]
			//---------------------
<<<<<<< HEAD
			Trace.TraceInformation( "サウンドデバイスの初期化を行います。" );
=======
			Trace.TraceInformation("サウンドデバイスの初期化を行います。");
>>>>>>> twopointzero/develop
			Trace.Indent();
			try
			{
				ESoundDeviceType soundDeviceType;
<<<<<<< HEAD
				switch ( TJAPlayer3.ConfigIni.nSoundDeviceType )
=======
				switch (TJAPlayer3.ConfigIni.nSoundDeviceType)
>>>>>>> twopointzero/develop
				{
					case 0:
						soundDeviceType = ESoundDeviceType.DirectSound;
						break;
					case 1:
						soundDeviceType = ESoundDeviceType.ASIO;
						break;
					case 2:
						soundDeviceType = ESoundDeviceType.ExclusiveWASAPI;
						break;
					default:
						soundDeviceType = ESoundDeviceType.Unknown;
						break;
				}
				Sound管理 = new CSound管理(base.Window.Handle,
											soundDeviceType,
											TJAPlayer3.ConfigIni.nWASAPIBufferSizeMs,
<<<<<<< HEAD
					// CDTXMania.ConfigIni.nASIOBufferSizeMs,
=======
											// CDTXMania.ConfigIni.nASIOBufferSizeMs,
>>>>>>> twopointzero/develop
											0,
											TJAPlayer3.ConfigIni.nASIODevice,
											TJAPlayer3.ConfigIni.bUseOSTimer
				);
				//Sound管理 = FDK.CSound管理.Instance;
				//Sound管理.t初期化( soundDeviceType, 0, 0, CDTXMania.ConfigIni.nASIODevice, base.Window.Handle );


				Trace.TraceInformation("Initializing loudness scanning, song gain control, and sound group level control...");
				Trace.Indent();
				try
				{
<<<<<<< HEAD
				    actScanningLoudness = new CActScanningLoudness();
				    actScanningLoudness.On活性化();
				    LoudnessMetadataScanner.ScanningStateChanged +=
				        (_, args) => actScanningLoudness.bIsActivelyScanning = args.IsActivelyScanning;
				    LoudnessMetadataScanner.StartBackgroundScanning();
=======
					actScanningLoudness = new CActScanningLoudness();
					actScanningLoudness.On活性化();
					LoudnessMetadataScanner.ScanningStateChanged +=
						(_, args) => actScanningLoudness.bIsActivelyScanning = args.IsActivelyScanning;
					LoudnessMetadataScanner.StartBackgroundScanning();
>>>>>>> twopointzero/develop

					SongGainController = new SongGainController();
					ConfigIniToSongGainControllerBinder.Bind(ConfigIni, SongGainController);

					SoundGroupLevelController = new SoundGroupLevelController(CSound.listインスタンス);
					ConfigIniToSoundGroupLevelControllerBinder.Bind(ConfigIni, SoundGroupLevelController);
				}
				finally
				{
					Trace.Unindent();
					Trace.TraceInformation("Initialized loudness scanning, song gain control, and sound group level control.");
				}

				ShowWindowTitleWithSoundType();
				FDK.CSound管理.bIsTimeStretch = TJAPlayer3.ConfigIni.bTimeStretch;
				Sound管理.nMasterVolume = TJAPlayer3.ConfigIni.nMasterVolume;
				//FDK.CSound管理.bIsMP3DecodeByWindowsCodec = CDTXMania.ConfigIni.bNoMP3Streaming;
<<<<<<< HEAD
				Trace.TraceInformation( "サウンドデバイスの初期化を完了しました。" );
			}
			catch (Exception e)
			{
                throw new NullReferenceException("サウンドデバイスがひとつも有効になっていないため、サウンドデバイスの初期化ができませんでした。", e);
=======
				Trace.TraceInformation("サウンドデバイスの初期化を完了しました。");
			}
			catch (Exception e)
			{
				throw new NullReferenceException("サウンドデバイスがひとつも有効になっていないため、サウンドデバイスの初期化ができませんでした。", e);
>>>>>>> twopointzero/develop
			}
			finally
			{
				Trace.Unindent();
			}
			//---------------------
			#endregion
			#region [ Songs管理 の初期化 ]
			//---------------------
<<<<<<< HEAD
			Trace.TraceInformation( "曲リストの初期化を行います。" );
=======
			Trace.TraceInformation("曲リストの初期化を行います。");
>>>>>>> twopointzero/develop
			Trace.Indent();
			try
			{
				Songs管理 = new CSongs管理();
<<<<<<< HEAD
//				Songs管理_裏読 = new CSongs管理();
				EnumSongs = new CEnumSongs();
				actEnumSongs = new CActEnumSongs();
				Trace.TraceInformation( "曲リストの初期化を完了しました。" );
			}
			catch( Exception e )
			{
				Trace.TraceError( e.ToString() );
				Trace.TraceError( "曲リストの初期化に失敗しました。" );
=======
				//				Songs管理_裏読 = new CSongs管理();
				EnumSongs = new CEnumSongs();
				actEnumSongs = new CActEnumSongs();
				Trace.TraceInformation("曲リストの初期化を完了しました。");
			}
			catch (Exception e)
			{
				Trace.TraceError(e.ToString());
				Trace.TraceError("曲リストの初期化に失敗しました。");
>>>>>>> twopointzero/develop
			}
			finally
			{
				Trace.Unindent();
			}
			//---------------------
			#endregion
			#region [ CAvi の初期化 ]
			//---------------------
			CAvi.t初期化();
			//---------------------
			#endregion
			#region [ Random の初期化 ]
			//---------------------
<<<<<<< HEAD
			Random = new Random( (int) Timer.nシステム時刻 );
=======
			Random = new Random((int)Timer.nシステム時刻);
>>>>>>> twopointzero/develop
			//---------------------
			#endregion
			#region [ ステージの初期化 ]
			//---------------------
			r現在のステージ = null;
			r直前のステージ = null;
<<<<<<< HEAD
			NamePlate = new CNamePlate();
			stage起動 = new CStage起動();
			stageタイトル = new CStageタイトル();
//			stageオプション = new CStageオプション();
=======
			stage起動 = new CStage起動();
			stageタイトル = new CStageタイトル();
			//			stageオプション = new CStageオプション();
>>>>>>> twopointzero/develop
			stageコンフィグ = new CStageコンフィグ();
			stage選曲 = new CStage選曲();
			stage曲読み込み = new CStage曲読み込み();
			stage演奏ドラム画面 = new CStage演奏ドラム画面();
			stage結果 = new CStage結果();
			stageChangeSkin = new CStageChangeSkin();
			stage終了 = new CStage終了();
			this.listトップレベルActivities = new List<CActivity>();
<<<<<<< HEAD
			this.listトップレベルActivities.Add( actEnumSongs );
			this.listトップレベルActivities.Add( act文字コンソール );
			this.listトップレベルActivities.Add( stage起動 );
			this.listトップレベルActivities.Add( stageタイトル );
//			this.listトップレベルActivities.Add( stageオプション );
			this.listトップレベルActivities.Add( stageコンフィグ );
			this.listトップレベルActivities.Add( stage選曲 );
			this.listトップレベルActivities.Add( stage曲読み込み );
			this.listトップレベルActivities.Add( stage演奏ドラム画面 );
			this.listトップレベルActivities.Add( stage結果 );
			this.listトップレベルActivities.Add( stageChangeSkin );
			this.listトップレベルActivities.Add( stage終了 );
			this.listトップレベルActivities.Add( actFlushGPU );
			//---------------------
			#endregion
			#region [ プラグインの検索と生成 ]
			//---------------------
			PluginHost = new CPluginHost();

			Trace.TraceInformation( "プラグインの検索と生成を行います。" );
			Trace.Indent();
			try
			{
				this.tプラグイン検索と生成();
				Trace.TraceInformation( "プラグインの検索と生成を完了しました。" );
			}
			finally
			{
				Trace.Unindent();
			}
			//---------------------
			#endregion
			#region [ プラグインの初期化 ]
			//---------------------
			if( this.listプラグイン != null && this.listプラグイン.Count > 0 )
			{
				Trace.TraceInformation( "プラグインの初期化を行います。" );
				Trace.Indent();
				try
				{
					foreach( STPlugin st in this.listプラグイン )
					{
						Directory.SetCurrentDirectory( st.strプラグインフォルダ );
						st.plugin.On初期化( this.PluginHost );
						st.plugin.OnManagedリソースの作成();
						st.plugin.OnUnmanagedリソースの作成();
						Directory.SetCurrentDirectory( TJAPlayer3.strEXEのあるフォルダ );
					}
					Trace.TraceInformation( "すべてのプラグインの初期化を完了しました。" );
				}
				catch
				{
					Trace.TraceError( "プラグインのどれかの初期化に失敗しました。" );
					throw;
				}
				finally
				{
					Trace.Unindent();
				}
			}

            //---------------------
            #endregion

            #region Discordの処理
            Discord.Initialize("764870299879079947");
            StartupTime = Discord.GetUnixTime();
            Discord.UpdatePresence("", Properties.Discord.Stage_StartUp, StartupTime);
            #endregion


            Trace.TraceInformation( "アプリケーションの初期化を完了しました。" );


            #region [ 最初のステージの起動 ]
            //---------------------
            Trace.TraceInformation( "----------------------" );
			Trace.TraceInformation( "■ 起動" );

			if ( TJAPlayer3.bコンパクトモード )
			{
				r現在のステージ = stage曲読み込み;
			}
			else
			{
				r現在のステージ = stage起動;
			}
=======
			this.listトップレベルActivities.Add(actEnumSongs);
			this.listトップレベルActivities.Add(act文字コンソール);
			this.listトップレベルActivities.Add(stage起動);
			this.listトップレベルActivities.Add(stageタイトル);
			//			this.listトップレベルActivities.Add( stageオプション );
			this.listトップレベルActivities.Add(stageコンフィグ);
			this.listトップレベルActivities.Add(stage選曲);
			this.listトップレベルActivities.Add(stage曲読み込み);
			this.listトップレベルActivities.Add(stage演奏ドラム画面);
			this.listトップレベルActivities.Add(stage結果);
			this.listトップレベルActivities.Add(stageChangeSkin);
			this.listトップレベルActivities.Add(stage終了);
			this.listトップレベルActivities.Add(actFlushGPU);
			//---------------------
			#endregion

			#region Discordの処理
			Discord.Initialize("428233983025741855");
			StartupTime = Discord.GetUnixTime();
			Discord.UpdatePresence("", Properties.Discord.Stage_StartUp, StartupTime);
			#endregion


			Trace.TraceInformation("アプリケーションの初期化を完了しました。");


			#region [ 最初のステージの起動 ]
			//---------------------
			Trace.TraceInformation("----------------------");
			Trace.TraceInformation("■ 起動");

			r現在のステージ = stage起動;
>>>>>>> twopointzero/develop
			r現在のステージ.On活性化();

			//---------------------
			#endregion
		}

		public void ShowWindowTitleWithSoundType()
		{
			string delay = "";
<<<<<<< HEAD
			if ( Sound管理.GetCurrentSoundDeviceType() != "DirectSound" )
			{
				delay = "(" + Sound管理.GetSoundDelay() + "ms)";
			}
            AssemblyName asmApp = Assembly.GetExecutingAssembly().GetName();
            base.Window.Text = asmApp.Name + " - Build " + VERSION + " (" + Sound管理.GetCurrentSoundDeviceType() + delay + ")";
=======
			if (CSound管理.GetCurrentSoundDeviceType() != "DirectSound")
			{
				delay = " (" + Sound管理.GetSoundDelay() + "ms)";
			}
			base.Window.Text = $"{AppDisplayNameWithInformationalVersion} ({CSound管理.GetCurrentSoundDeviceType()}{delay})";
>>>>>>> twopointzero/develop
		}

		private void t終了処理()
		{
<<<<<<< HEAD
			if( !this.b終了処理完了済み )
			{
				Trace.TraceInformation( "----------------------" );
				Trace.TraceInformation( "■ アプリケーションの終了" );
				#region [ 曲検索の終了処理 ]
				//---------------------
				if ( actEnumSongs != null )
				{
					Trace.TraceInformation( "曲検索actの終了処理を行います。" );
=======
			if (!this.b終了処理完了済み)
			{
				Trace.TraceInformation("----------------------");
				Trace.TraceInformation("■ アプリケーションの終了");
				#region [ 曲検索の終了処理 ]
				//---------------------
				if (actEnumSongs != null)
				{
					Trace.TraceInformation("曲検索actの終了処理を行います。");
>>>>>>> twopointzero/develop
					Trace.Indent();
					try
					{
						actEnumSongs.On非活性化();
<<<<<<< HEAD
						actEnumSongs= null;
						Trace.TraceInformation( "曲検索actの終了処理を完了しました。" );
					}
					catch ( Exception e )
					{
						Trace.TraceError( e.ToString() );
						Trace.TraceError( "曲検索actの終了処理に失敗しました。" );
=======
						actEnumSongs = null;
						Trace.TraceInformation("曲検索actの終了処理を完了しました。");
					}
					catch (Exception e)
					{
						Trace.TraceError(e.ToString());
						Trace.TraceError("曲検索actの終了処理に失敗しました。");
>>>>>>> twopointzero/develop
					}
					finally
					{
						Trace.Unindent();
					}
				}
				//---------------------
				#endregion
				#region [ 現在のステージの終了処理 ]
				//---------------------
<<<<<<< HEAD
				if( TJAPlayer3.r現在のステージ != null && TJAPlayer3.r現在のステージ.b活性化してる )		// #25398 2011.06.07 MODIFY FROM
				{
					Trace.TraceInformation( "現在のステージを終了します。" );
=======
				if (TJAPlayer3.r現在のステージ != null && TJAPlayer3.r現在のステージ.b活性化してる)     // #25398 2011.06.07 MODIFY FROM
				{
					Trace.TraceInformation("現在のステージを終了します。");
>>>>>>> twopointzero/develop
					Trace.Indent();
					try
					{
						r現在のステージ.On非活性化();
<<<<<<< HEAD
						Trace.TraceInformation( "現在のステージの終了処理を完了しました。" );
=======
						Trace.TraceInformation("現在のステージの終了処理を完了しました。");
>>>>>>> twopointzero/develop
					}
					finally
					{
						Trace.Unindent();
					}
				}
				//---------------------
				#endregion
<<<<<<< HEAD
				#region [ プラグインの終了処理 ]
				//---------------------
				if (this.listプラグイン != null && this.listプラグイン.Count > 0)
				{
					Trace.TraceInformation( "すべてのプラグインを終了します。" );
					Trace.Indent();
					try
					{
						foreach( STPlugin st in this.listプラグイン )
						{
							Directory.SetCurrentDirectory( st.strプラグインフォルダ );
							st.plugin.OnUnmanagedリソースの解放();
							st.plugin.OnManagedリソースの解放();
							st.plugin.On終了();
							Directory.SetCurrentDirectory( TJAPlayer3.strEXEのあるフォルダ );
						}
						PluginHost = null;
						Trace.TraceInformation( "すべてのプラグインの終了処理を完了しました。" );
					}
					finally
					{
						Trace.Unindent();
					}
				}
                //---------------------
                #endregion
                #region Discordの処理
                Discord.Shutdown();
                #endregion
                #region [ 曲リストの終了処理 ]
                //---------------------
                if (Songs管理 != null)
				{
					Trace.TraceInformation( "曲リストの終了処理を行います。" );
=======

				#region Discordの処理
				Discord.Shutdown();
				#endregion
				#region [ 曲リストの終了処理 ]
				//---------------------
				if (Songs管理 != null)
				{
					Trace.TraceInformation("曲リストの終了処理を行います。");
>>>>>>> twopointzero/develop
					Trace.Indent();
					try
					{
						Songs管理 = null;
<<<<<<< HEAD
						Trace.TraceInformation( "曲リストの終了処理を完了しました。" );
					}
					catch( Exception exception )
					{
						Trace.TraceError( exception.ToString() );
						Trace.TraceError( "曲リストの終了処理に失敗しました。" );
=======
						Trace.TraceInformation("曲リストの終了処理を完了しました。");
					}
					catch (Exception exception)
					{
						Trace.TraceError(exception.ToString());
						Trace.TraceError("曲リストの終了処理に失敗しました。");
>>>>>>> twopointzero/develop
					}
					finally
					{
						Trace.Unindent();
					}
				}
				CAvi.t終了();
                //---------------------
                #endregion
                #region TextureLoaderの処理
<<<<<<< HEAD
                Tx.DisposeTexture();
=======
                Tx.Dispose();
                Tx = null;
>>>>>>> twopointzero/develop
                #endregion
                #region [ スキンの終了処理 ]
                //---------------------
                if (Skin != null)
				{
<<<<<<< HEAD
					Trace.TraceInformation( "スキンの終了処理を行います。" );
=======
					Trace.TraceInformation("スキンの終了処理を行います。");
>>>>>>> twopointzero/develop
					Trace.Indent();
					try
					{
						Skin.Dispose();
						Skin = null;
<<<<<<< HEAD
						Trace.TraceInformation( "スキンの終了処理を完了しました。" );
					}
					catch( Exception exception2 )
					{
						Trace.TraceError( exception2.ToString() );
						Trace.TraceError( "スキンの終了処理に失敗しました。" );
=======
						Trace.TraceInformation("スキンの終了処理を完了しました。");
					}
					catch (Exception exception2)
					{
						Trace.TraceError(exception2.ToString());
						Trace.TraceError("スキンの終了処理に失敗しました。");
>>>>>>> twopointzero/develop
					}
					finally
					{
						Trace.Unindent();
					}
				}
				//---------------------
				#endregion
				#region [ DirectSoundの終了処理 ]
				//---------------------
				if (Sound管理 != null)
				{
<<<<<<< HEAD
					Trace.TraceInformation( "DirectSound の終了処理を行います。" );
=======
					Trace.TraceInformation("DirectSound の終了処理を行います。");
>>>>>>> twopointzero/develop
					Trace.Indent();
					try
					{
						Sound管理.Dispose();
						Sound管理 = null;
<<<<<<< HEAD
						Trace.TraceInformation( "DirectSound の終了処理を完了しました。" );
					}
					catch( Exception exception3 )
					{
						Trace.TraceError( exception3.ToString() );
						Trace.TraceError( "DirectSound の終了処理に失敗しました。" );
=======
						Trace.TraceInformation("DirectSound の終了処理を完了しました。");
					}
					catch (Exception exception3)
					{
						Trace.TraceError(exception3.ToString());
						Trace.TraceError("DirectSound の終了処理に失敗しました。");
>>>>>>> twopointzero/develop
					}
					finally
					{
						Trace.Unindent();
					}
				}
				//---------------------
				#endregion
				#region [ パッドの終了処理 ]
				//---------------------
				if (Pad != null)
				{
<<<<<<< HEAD
					Trace.TraceInformation( "パッドの終了処理を行います。" );
=======
					Trace.TraceInformation("パッドの終了処理を行います。");
>>>>>>> twopointzero/develop
					Trace.Indent();
					try
					{
						Pad = null;
<<<<<<< HEAD
						Trace.TraceInformation( "パッドの終了処理を完了しました。" );
					}
					catch( Exception exception4 )
					{
						Trace.TraceError( exception4.ToString() );
						Trace.TraceError( "パッドの終了処理に失敗しました。" );
=======
						Trace.TraceInformation("パッドの終了処理を完了しました。");
					}
					catch (Exception exception4)
					{
						Trace.TraceError(exception4.ToString());
						Trace.TraceError("パッドの終了処理に失敗しました。");
>>>>>>> twopointzero/develop
					}
					finally
					{
						Trace.Unindent();
					}
				}
				//---------------------
				#endregion
				#region [ DirectInput, MIDI入力の終了処理 ]
				//---------------------
				if (Input管理 != null)
				{
<<<<<<< HEAD
					Trace.TraceInformation( "DirectInput, MIDI入力の終了処理を行います。" );
=======
					Trace.TraceInformation("DirectInput, MIDI入力の終了処理を行います。");
>>>>>>> twopointzero/develop
					Trace.Indent();
					try
					{
						Input管理.Dispose();
						Input管理 = null;
<<<<<<< HEAD
						Trace.TraceInformation( "DirectInput, MIDI入力の終了処理を完了しました。" );
					}
					catch( Exception exception5 )
					{
						Trace.TraceError( exception5.ToString() );
						Trace.TraceError( "DirectInput, MIDI入力の終了処理に失敗しました。" );
=======
						Trace.TraceInformation("DirectInput, MIDI入力の終了処理を完了しました。");
					}
					catch (Exception exception5)
					{
						Trace.TraceError(exception5.ToString());
						Trace.TraceError("DirectInput, MIDI入力の終了処理に失敗しました。");
>>>>>>> twopointzero/develop
					}
					finally
					{
						Trace.Unindent();
					}
				}
				//---------------------
				#endregion
				#region [ 文字コンソールの終了処理 ]
				//---------------------
				if (act文字コンソール != null)
				{
<<<<<<< HEAD
					Trace.TraceInformation( "文字コンソールの終了処理を行います。" );
=======
					Trace.TraceInformation("文字コンソールの終了処理を行います。");
>>>>>>> twopointzero/develop
					Trace.Indent();
					try
					{
						act文字コンソール.On非活性化();
						act文字コンソール = null;
<<<<<<< HEAD
						Trace.TraceInformation( "文字コンソールの終了処理を完了しました。" );
					}
					catch( Exception exception6 )
					{
						Trace.TraceError( exception6.ToString() );
						Trace.TraceError( "文字コンソールの終了処理に失敗しました。" );
=======
						Trace.TraceInformation("文字コンソールの終了処理を完了しました。");
					}
					catch (Exception exception6)
					{
						Trace.TraceError(exception6.ToString());
						Trace.TraceError("文字コンソールの終了処理に失敗しました。");
>>>>>>> twopointzero/develop
					}
					finally
					{
						Trace.Unindent();
					}
				}
				//---------------------
				#endregion
				#region [ FPSカウンタの終了処理 ]
				//---------------------
				Trace.TraceInformation("FPSカウンタの終了処理を行います。");
				Trace.Indent();
				try
				{
<<<<<<< HEAD
					if( FPS != null )
					{
						FPS = null;
					}
					Trace.TraceInformation( "FPSカウンタの終了処理を完了しました。" );
=======
					if (FPS != null)
					{
						FPS = null;
					}
					Trace.TraceInformation("FPSカウンタの終了処理を完了しました。");
>>>>>>> twopointzero/develop
				}
				finally
				{
					Trace.Unindent();
				}
				//---------------------
				#endregion
				#region [ タイマの終了処理 ]
				//---------------------
				Trace.TraceInformation("タイマの終了処理を行います。");
				Trace.Indent();
				try
				{
<<<<<<< HEAD
					if( Timer != null )
					{
						Timer.Dispose();
						Timer = null;
						Trace.TraceInformation( "タイマの終了処理を完了しました。" );
					}
					else
					{
						Trace.TraceInformation( "タイマは使用されていません。" );
=======
					if (Timer != null)
					{
						Timer.Dispose();
						Timer = null;
						Trace.TraceInformation("タイマの終了処理を完了しました。");
					}
					else
					{
						Trace.TraceInformation("タイマは使用されていません。");
>>>>>>> twopointzero/develop
					}
				}
				finally
				{
					Trace.Unindent();
				}
				//---------------------
				#endregion
				#region [ Config.iniの出力 ]
				//---------------------
				Trace.TraceInformation("Config.ini を出力します。");
<<<<<<< HEAD
//				if ( ConfigIni.bIsSwappedGuitarBass )			// #24063 2011.1.16 yyagi ギターベースがスワップしているときは元に戻す
=======
				//				if ( ConfigIni.bIsSwappedGuitarBass )			// #24063 2011.1.16 yyagi ギターベースがスワップしているときは元に戻す
>>>>>>> twopointzero/develop
				string str = strEXEのあるフォルダ + "Config.ini";
				Trace.Indent();
				try
				{
<<<<<<< HEAD
					if ( DTXVmode.Enabled )
					{
						DTXVmode.tUpdateConfigIni();
						Trace.TraceInformation( "DTXVモードの設定情報を、Config.iniに保存しました。" );
					}
					else
					{
						ConfigIni.t書き出し( str );
						Trace.TraceInformation( "保存しました。({0})", str );
					}
				}
				catch( Exception e )
				{
					Trace.TraceError( e.ToString() );
					Trace.TraceError( "Config.ini の出力に失敗しました。({0})", str );
=======
					ConfigIni.t書き出し(str);
					Trace.TraceInformation("保存しました。({0})", str);
				}
				catch (Exception e)
				{
					Trace.TraceError(e.ToString());
					Trace.TraceError("Config.ini の出力に失敗しました。({0})", str);
>>>>>>> twopointzero/develop
				}
				finally
				{
					Trace.Unindent();
				}

<<<<<<< HEAD
			    Trace.TraceInformation("Deinitializing loudness scanning, song gain control, and sound group level control...");
			    Trace.Indent();
			    try
			    {
			        SoundGroupLevelController = null;
			        SongGainController = null;
			        LoudnessMetadataScanner.StopBackgroundScanning(joinImmediately: true);
                    actScanningLoudness.On非活性化();
			        actScanningLoudness = null;
			    }
			    finally
			    {
			        Trace.Unindent();
			        Trace.TraceInformation("Deinitialized loudness scanning, song gain control, and sound group level control.");
			    }

			    ConfigIni = null;

				//---------------------
				#endregion
				#region [ DTXVmodeの終了処理 ]
				//---------------------
				//Trace.TraceInformation( "DTXVモードの終了処理を行います。" );
				//Trace.Indent();
				try
				{
					if ( DTXVmode != null )
					{
						DTXVmode = null;
						//Trace.TraceInformation( "DTXVモードの終了処理を完了しました。" );
					}
					else
					{
						//Trace.TraceInformation( "DTXVモードは使用されていません。" );
					}
				}
				finally
				{
					//Trace.Unindent();
				}
				//---------------------
				#endregion
                #region [ DirectXの終了処理 ]
                base.GraphicsDeviceManager.Dispose();
                #endregion
                Trace.TraceInformation( "アプリケーションの終了処理を完了しました。" );
=======
				Trace.TraceInformation("Deinitializing loudness scanning, song gain control, and sound group level control...");
				Trace.Indent();
				try
				{
					SoundGroupLevelController = null;
					SongGainController = null;
					LoudnessMetadataScanner.StopBackgroundScanning(joinImmediately: true);
					actScanningLoudness.On非活性化();
					actScanningLoudness = null;
				}
				finally
				{
					Trace.Unindent();
					Trace.TraceInformation("Deinitialized loudness scanning, song gain control, and sound group level control.");
				}

				ConfigIni = null;

				//---------------------
				#endregion

				#region [ DirectXの終了処理 ]
				base.GraphicsDeviceManager.Dispose();
				#endregion
				Trace.TraceInformation("アプリケーションの終了処理を完了しました。");
>>>>>>> twopointzero/develop


				this.b終了処理完了済み = true;
			}
		}
		private CScoreIni tScoreIniへBGMAdjustとHistoryとPlayCountを更新(string str新ヒストリ行)
		{
			bool bIsUpdatedDrums, bIsUpdatedGuitar, bIsUpdatedBass;
			string strFilename = DTX.strファイル名の絶対パス + ".score.ini";
<<<<<<< HEAD
			CScoreIni ini = new CScoreIni( strFilename );
			if( !File.Exists( strFilename ) )
			{
				ini.stファイル.Title = DTX.TITLE;
				ini.stファイル.Name = DTX.strファイル名;
				ini.stファイル.Hash = CScoreIni.tファイルのMD5を求めて返す( DTX.strファイル名の絶対パス );
				for( int i = 0; i < 1; i++ )
				{
					ini.stセクション[ i ].nPerfectになる範囲ms = nPerfect範囲ms;
					ini.stセクション[ i ].nGreatになる範囲ms = nGreat範囲ms;
					ini.stセクション[ i ].nGoodになる範囲ms = nGood範囲ms;
					ini.stセクション[ i ].nPoorになる範囲ms = nPoor範囲ms;
				}
			}
			ini.stファイル.BGMAdjust = DTX.nBGMAdjust;
			CScoreIni.t更新条件を取得する( out bIsUpdatedDrums, out bIsUpdatedGuitar, out bIsUpdatedBass );
			if( bIsUpdatedDrums || bIsUpdatedGuitar || bIsUpdatedBass )
			{
				if( bIsUpdatedDrums )
				{
					ini.stファイル.PlayCountDrums++;
				}
				if( bIsUpdatedGuitar )
				{
					ini.stファイル.PlayCountGuitar++;
				}
				if( bIsUpdatedBass )
				{
					ini.stファイル.PlayCountBass++;
				}
				ini.tヒストリを追加する( str新ヒストリ行 );
				if( !bコンパクトモード )
				{
					stage選曲.r現在選択中のスコア.譜面情報.演奏回数.Drums = ini.stファイル.PlayCountDrums;
					stage選曲.r現在選択中のスコア.譜面情報.演奏回数.Guitar = ini.stファイル.PlayCountGuitar;
					stage選曲.r現在選択中のスコア.譜面情報.演奏回数.Bass = ini.stファイル.PlayCountBass;
					for( int j = 0; j < ini.stファイル.History.Length; j++ )
					{
						stage選曲.r現在選択中のスコア.譜面情報.演奏履歴[ j ] = ini.stファイル.History[ j ];
					}
				}
			}
			if( ConfigIni.bScoreIniを出力する )
			{
				ini.t書き出し( strFilename );
=======
			CScoreIni ini = new CScoreIni(strFilename);
			if (!File.Exists(strFilename))
			{
				ini.stファイル.Title = DTX.TITLE;
				ini.stファイル.Name = DTX.strファイル名;
				ini.stファイル.Hash = CScoreIni.tファイルのMD5を求めて返す(DTX.strファイル名の絶対パス);
				for (int i = 0; i < 6; i++)
				{
					ini.stセクション[i].nPerfectになる範囲ms = nPerfect範囲ms;
					ini.stセクション[i].nGreatになる範囲ms = nGreat範囲ms;
					ini.stセクション[i].nGoodになる範囲ms = nGood範囲ms;
					ini.stセクション[i].nPoorになる範囲ms = nPoor範囲ms;
				}
			}
			ini.stファイル.BGMAdjust = DTX.nBGMAdjust;
			CScoreIni.t更新条件を取得する(out bIsUpdatedDrums, out bIsUpdatedGuitar, out bIsUpdatedBass);
			if (bIsUpdatedDrums || bIsUpdatedGuitar || bIsUpdatedBass)
			{
				if (bIsUpdatedDrums)
				{
					ini.stファイル.PlayCountDrums++;
				}
				if (bIsUpdatedGuitar)
				{
					ini.stファイル.PlayCountGuitar++;
				}
				if (bIsUpdatedBass)
				{
					ini.stファイル.PlayCountBass++;
				}
				ini.tヒストリを追加する(str新ヒストリ行);
				stage選曲.r現在選択中のスコア.譜面情報.演奏回数.Drums = ini.stファイル.PlayCountDrums;
				stage選曲.r現在選択中のスコア.譜面情報.演奏回数.Guitar = ini.stファイル.PlayCountGuitar;
				stage選曲.r現在選択中のスコア.譜面情報.演奏回数.Bass = ini.stファイル.PlayCountBass;
				for (int j = 0; j < ini.stファイル.History.Length; j++)
				{
					stage選曲.r現在選択中のスコア.譜面情報.演奏履歴[j] = ini.stファイル.History[j];
				}
			}
			if (ConfigIni.bScoreIniを出力する)
			{
				ini.t書き出し(strFilename);
>>>>>>> twopointzero/develop
			}

			return ini;
		}
		private void tガベージコレクションを実行する()
		{
			GC.Collect(GC.MaxGeneration);
			GC.WaitForPendingFinalizers();
			GC.Collect(GC.MaxGeneration);
		}
<<<<<<< HEAD
		private void tプラグイン検索と生成()
		{
			this.listプラグイン = new List<STPlugin>();

			string strIPluginActivityの名前 = typeof( IPluginActivity ).FullName;
			string strプラグインフォルダパス = strEXEのあるフォルダ + "Plugins\\";

			this.t指定フォルダ内でのプラグイン検索と生成( strプラグインフォルダパス, strIPluginActivityの名前 );

			if( this.listプラグイン.Count > 0 )
				Trace.TraceInformation( this.listプラグイン.Count + " 個のプラグインを読み込みました。" );
		}

        public void RefleshSkin()
        {
            Trace.TraceInformation("スキン変更:" + TJAPlayer3.Skin.GetCurrentSkinSubfolderFullName(false));

            TJAPlayer3.act文字コンソール.On非活性化();

            TJAPlayer3.Skin.Dispose();
            TJAPlayer3.Skin = null;
            TJAPlayer3.Skin = new CSkin(TJAPlayer3.ConfigIni.strSystemSkinSubfolderFullName, false);


            TJAPlayer3.Tx.DisposeTexture();
            TJAPlayer3.Tx.LoadTexture();

            TJAPlayer3.act文字コンソール.On活性化();
        }
		#region [ Windowイベント処理 ]
		private void t指定フォルダ内でのプラグイン検索と生成( string strプラグインフォルダパス, string strプラグイン型名 )
		{
			// 指定されたパスが存在しないとエラー
			if( !Directory.Exists( strプラグインフォルダパス ) )
			{
				Trace.TraceWarning( "プラグインフォルダが存在しません。(" + strプラグインフォルダパス + ")" );
				return;
			}

			// (1) すべての *.dll について…
			string[] strDLLs = System.IO.Directory.GetFiles( strプラグインフォルダパス, "*.dll" );
			foreach( string dllName in strDLLs )
			{
				try
				{
					// (1-1) dll をアセンブリとして読み込む。
					System.Reflection.Assembly asm = System.Reflection.Assembly.LoadFrom( dllName );

					// (1-2) アセンブリ内のすべての型について、プラグインとして有効か調べる
					foreach( Type t in asm.GetTypes() )
					{
						//  (1-3) ↓クラスであり↓Publicであり↓抽象クラスでなく↓IPlugin型のインスタンスが作れる　型を持っていれば有効
						if( t.IsClass && t.IsPublic && !t.IsAbstract && t.GetInterface( strプラグイン型名 ) != null )
						{
							// (1-4) クラス名からインスタンスを作成する
							var st = new STPlugin() {
								plugin = (IPluginActivity) asm.CreateInstance( t.FullName ),
								strプラグインフォルダ = Path.GetDirectoryName( dllName ),
								strアセンブリ簡易名 = asm.GetName().Name,
								Version = asm.GetName().Version,
							};

							// (1-5) プラグインリストへ登録
							this.listプラグイン.Add( st );
							Trace.TraceInformation( "プラグイン {0} ({1}, {2}, {3}) を読み込みました。", t.FullName, Path.GetFileName( dllName ), st.strアセンブリ簡易名, st.Version.ToString() );
						}
					}
				}
				catch (Exception e)
				{
					Trace.TraceError( e.ToString() );
					Trace.TraceInformation( dllName + " からプラグインを生成することに失敗しました。スキップします。" );
				}
			}

			// (2) サブフォルダがあれば再帰する
			string[] strDirs = Directory.GetDirectories( strプラグインフォルダパス, "*" );
			foreach( string dir in strDirs )
				this.t指定フォルダ内でのプラグイン検索と生成( dir + "\\", strプラグイン型名 );
		}
		//-----------------
		private void Window_ApplicationActivated( object sender, EventArgs e )
		{
			this.bApplicationActive = true;
		}
		private void Window_ApplicationDeactivated( object sender, EventArgs e )
		{
			this.bApplicationActive = false;
		}
		private void Window_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyCode == Keys.Menu )
=======

		public void RefleshSkin()
		{
			Trace.TraceInformation("スキン変更:" + TJAPlayer3.Skin.GetCurrentSkinSubfolderFullName(false));

			TJAPlayer3.act文字コンソール.On非活性化();

			TJAPlayer3.Skin.Dispose();
			TJAPlayer3.Skin = null;
			TJAPlayer3.Skin = new CSkin(TJAPlayer3.ConfigIni.strSystemSkinSubfolderFullName, false);

            TJAPlayer3.Tx.Dispose();
            TJAPlayer3.Tx = new TextureLoader();
            TJAPlayer3.Tx.Load();

			TJAPlayer3.act文字コンソール.On活性化();
		}
		#region [ Windowイベント処理 ]
		//-----------------
		private void Window_ApplicationActivated(object sender, EventArgs e)
		{
			this.bApplicationActive = true;
		}
		private void Window_ApplicationDeactivated(object sender, EventArgs e)
		{
			this.bApplicationActive = false;
		}
		private void Window_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Menu)
>>>>>>> twopointzero/develop
			{
				e.Handled = true;
				e.SuppressKeyPress = true;
			}
<<<<<<< HEAD
			else if ( ( e.KeyCode == Keys.Return ) && e.Alt )
			{
				if ( ConfigIni != null )
=======
			else if ((e.KeyCode == Keys.Return) && e.Alt)
			{
				if (ConfigIni != null)
>>>>>>> twopointzero/develop
				{
					ConfigIni.bウィンドウモード = !ConfigIni.bウィンドウモード;
					this.t全画面_ウィンドウモード切り替え();
				}
				e.Handled = true;
				e.SuppressKeyPress = true;
			}
			else
			{
<<<<<<< HEAD
				for ( int i = 0; i < 0x10; i++ )
				{
					if ( ConfigIni.KeyAssign.System.Capture[ i ].コード > 0 &&
						 e.KeyCode == DeviceConstantConverter.KeyToKeyCode( (SlimDX.DirectInput.Key) ConfigIni.KeyAssign.System.Capture[ i ].コード ) )
					{
						// Debug.WriteLine( "capture: " + string.Format( "{0:2x}", (int) e.KeyCode ) + " " + (int) e.KeyCode );
						string strFullPath =
						   Path.Combine( TJAPlayer3.strEXEのあるフォルダ, "Capture_img" );
						strFullPath = Path.Combine( strFullPath, DateTime.Now.ToString( "yyyyMMddHHmmss" ) + ".png" );
						SaveResultScreen( strFullPath );
=======
				for (int i = 0; i < 0x10; i++)
				{
					if (ConfigIni.KeyAssign.System.Capture[i].コード > 0 &&
						 e.KeyCode == DeviceConstantConverter.KeyToKeyCode((SlimDX.DirectInput.Key)ConfigIni.KeyAssign.System.Capture[i].コード))
					{
						// Debug.WriteLine( "capture: " + string.Format( "{0:2x}", (int) e.KeyCode ) + " " + (int) e.KeyCode );
						string strFullPath =
						   Path.Combine(TJAPlayer3.strEXEのあるフォルダ, "Capture_img");
						strFullPath = Path.Combine(strFullPath, DateTime.Now.ToString("yyyyMMddHHmmss") + ".png");
						SaveResultScreen(strFullPath);
>>>>>>> twopointzero/develop
					}
				}
			}
		}
<<<<<<< HEAD
		private void Window_MouseUp( object sender, MouseEventArgs e )
=======
		private void Window_MouseUp(object sender, MouseEventArgs e)
>>>>>>> twopointzero/develop
		{
			mb = e.Button;
		}

<<<<<<< HEAD
		private void Window_MouseDoubleClick( object sender, MouseEventArgs e)	// #23510 2010.11.13 yyagi: to go full screen mode
		{
			if ( mb.Equals(MouseButtons.Left) && ConfigIni.bIsAllowedDoubleClickFullscreen )	// #26752 2011.11.27 yyagi
=======
		private void Window_MouseDoubleClick(object sender, MouseEventArgs e)   // #23510 2010.11.13 yyagi: to go full screen mode
		{
			if (mb.Equals(MouseButtons.Left) && ConfigIni.bIsAllowedDoubleClickFullscreen)  // #26752 2011.11.27 yyagi
>>>>>>> twopointzero/develop
			{
				ConfigIni.bウィンドウモード = false;
				this.t全画面_ウィンドウモード切り替え();
			}
		}
<<<<<<< HEAD
		private void Window_ResizeEnd(object sender, EventArgs e)				// #23510 2010.11.20 yyagi: to get resized window size
		{
			if ( ConfigIni.bウィンドウモード )
			{
				ConfigIni.n初期ウィンドウ開始位置X = base.Window.Location.X;	// #30675 2013.02.04 ikanick add
				ConfigIni.n初期ウィンドウ開始位置Y = base.Window.Location.Y;	//
			}

			ConfigIni.nウインドウwidth = (ConfigIni.bウィンドウモード) ? base.Window.ClientSize.Width : currentClientSize.Width;	// #23510 2010.10.31 yyagi add
=======
		private void Window_ResizeEnd(object sender, EventArgs e)               // #23510 2010.11.20 yyagi: to get resized window size
		{
			if (ConfigIni.bウィンドウモード)
			{
				ConfigIni.n初期ウィンドウ開始位置X = base.Window.Location.X;   // #30675 2013.02.04 ikanick add
				ConfigIni.n初期ウィンドウ開始位置Y = base.Window.Location.Y;   //
			}

			ConfigIni.nウインドウwidth = (ConfigIni.bウィンドウモード) ? base.Window.ClientSize.Width : currentClientSize.Width; // #23510 2010.10.31 yyagi add
>>>>>>> twopointzero/develop
			ConfigIni.nウインドウheight = (ConfigIni.bウィンドウモード) ? base.Window.ClientSize.Height : currentClientSize.Height;
		}
		#endregion
		#endregion
	}
<<<<<<< HEAD
}
=======
}
>>>>>>> twopointzero/develop
