using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Drawing;

namespace TJAPlayer3
{
	internal class CBoxDef
	{
<<<<<<< HEAD
		// プロパティ

		public Color Color;
		public string Genre;
		public string Title;
		public string[] BoxExplanation = new string[3];
        public Color ForeColor;
        public Color BackColor;
        public bool IsChangedForeColor;
        public bool IsChangedBackColor;


		// コンストラクタ

		public CBoxDef()
		{
			this.Title = "";
			this.Genre = "";
			this.BoxExplanation[0] = "";
			this.BoxExplanation[1] = "";
			this.BoxExplanation[2] = "";
            ForeColor = Color.White;
            BackColor = Color.Black;

		}
		public CBoxDef( string boxdefファイル名 )
			: this()
		{
			this.t読み込み( boxdefファイル名 );
		}


		// メソッド

		public void t読み込み( string boxdefファイル名 )
=======
        private static readonly Dictionary<DirectoryInfo, CBoxDef> Cache = new Dictionary<DirectoryInfo, CBoxDef>();

		// プロパティ
        public string Genre;
        public string Title;
        public Color? ForeColor;
        public Color? BackColor;

        // Factory methods, used to leverage the cache.

        public static CBoxDef Find(DirectoryInfo directoryInfo)
        {
            while (true)
            {
                var boxdef = Get(directoryInfo);
                if (boxdef != null)
                {
                    return boxdef;
                }

                directoryInfo = directoryInfo.Parent;
                if (directoryInfo == null)
                {
                    return null;
                }
            }
        }

        public static CBoxDef Get(DirectoryInfo directoryInfo)
        {
            if (Cache.TryGetValue(directoryInfo, out var boxdef))
            {
                return boxdef;
            }

            boxdef = GetImpl(directoryInfo);
            Cache[directoryInfo] = boxdef;

            return boxdef;
        }

        private static CBoxDef GetImpl(DirectoryInfo directoryInfo)
        {
            var boxdefファイル名 = Path.Combine(directoryInfo.FullName, "box.def");

            if (File.Exists(boxdefファイル名))
            {
                return new CBoxDef(directoryInfo, boxdefファイル名);
            }

            return null;
        }

		// コンストラクタ

		private CBoxDef(DirectoryInfo directoryInfo, string boxdefファイル名)
>>>>>>> twopointzero/develop
		{
			StreamReader reader = new StreamReader( boxdefファイル名, Encoding.GetEncoding( "Shift_JIS" ) );
			string str = null;
			while( ( str = reader.ReadLine() ) != null )
			{
				if( str.Length != 0 )
				{
					try
					{
						char[] ignoreCharsWoColon = new char[] { ' ', '\t' };

						str = str.TrimStart( ignoreCharsWoColon );
						if( ( str[ 0 ] == '#' ) && ( str[ 0 ] != ';' ) )
						{
							if( str.IndexOf( ';' ) != -1 )
							{
								str = str.Substring( 0, str.IndexOf( ';' ) );
							}
                        
							char[] ignoreChars = new char[] { ':', ' ', '\t' };
		
							if ( str.StartsWith( "#TITLE", StringComparison.OrdinalIgnoreCase ) )
<<<<<<< HEAD
							{
								this.Title = str.Substring( 6 ).Trim( ignoreChars );
							}
							else if ( str.StartsWith("#BOXEXPLANATION1", StringComparison.OrdinalIgnoreCase ) )
							{
								this.BoxExplanation[0] = str.Substring( 16 ).Trim( ignoreChars );
							}
							else if (str.StartsWith("#BOXEXPLANATION2", StringComparison.OrdinalIgnoreCase))
							{
								this.BoxExplanation[1] = str.Substring(16).Trim(ignoreChars);
							}
							else if (str.StartsWith("#BOXEXPLANATION3", StringComparison.OrdinalIgnoreCase))
							{
								this.BoxExplanation[2] = str.Substring(16).Trim(ignoreChars);
							}
=======
                            {
                                var title = str.Substring( 6 ).Trim( ignoreChars );
                                if (!string.IsNullOrEmpty(title))
                                {
                                    this.Title = title;
                                }
                            }
>>>>>>> twopointzero/develop
							else if( str.StartsWith( "#GENRE", StringComparison.OrdinalIgnoreCase ) )
							{
								this.Genre = str.Substring( 6 ).Trim( ignoreChars );
							}
<<<<<<< HEAD
							else if ( str.StartsWith( "#FONTCOLOR", StringComparison.OrdinalIgnoreCase ) )
							{
								this.Color = ColorTranslator.FromHtml( str.Substring( 10 ).Trim( ignoreChars ) );
							}
                            else if (str.StartsWith("#FORECOLOR", StringComparison.OrdinalIgnoreCase))
                            {
                                this.ForeColor = ColorTranslator.FromHtml(str.Substring(10).Trim(ignoreChars));
                                IsChangedForeColor = true;
=======
                            else if (str.StartsWith("#FORECOLOR", StringComparison.OrdinalIgnoreCase))
                            {
                                this.ForeColor = ColorTranslator.FromHtml(str.Substring(10).Trim(ignoreChars));
>>>>>>> twopointzero/develop
                            }
                            else if (str.StartsWith("#BACKCOLOR", StringComparison.OrdinalIgnoreCase))
                            {
                                this.BackColor = ColorTranslator.FromHtml(str.Substring(10).Trim(ignoreChars));
<<<<<<< HEAD
                                IsChangedBackColor = true;
                            }
                        }
						continue;
=======
                            }
                        }
>>>>>>> twopointzero/develop
					}
					catch (Exception e)
					{
					    Trace.TraceError( e.ToString() );
					    Trace.TraceError( "例外が発生しましたが処理を継続します。 (178a9a36-a59e-4264-8e4c-b3c3459db43c)" );
<<<<<<< HEAD
						continue;
=======
>>>>>>> twopointzero/develop
					}
				}
			}
			reader.Close();
<<<<<<< HEAD
=======

            if (Genre == null || Title == null || ForeColor == null || BackColor == null)
            {
                if (directoryInfo.Parent == null)
                {
                    return;
                }

                var ancestor = Find(directoryInfo.Parent);
                if (ancestor == null)
                {
                    return;
                }

                if (Genre == null)
                {
                    Genre = ancestor.Genre;
                }

                if (Title == null)
                {
                    Title = ancestor.Title;
                }

                if (ForeColor == null)
                {
                    ForeColor = ancestor.ForeColor;
                }

                if (BackColor == null)
                {
                    BackColor = ancestor.BackColor;
                }
            }
>>>>>>> twopointzero/develop
		}
	}
}
