using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
=======
>>>>>>> twopointzero/develop

namespace FDK
{
	/// <summary>
	/// xa,oggデコード用の基底クラス
	/// </summary>
	public abstract class SoundDecoder //: IDisposable
	{
		public abstract int Open( string filename );
		public abstract int GetFormat( int nHandle, ref CWin32.WAVEFORMATEX wfx );
		public abstract uint GetTotalPCMSize( int nHandle );
<<<<<<< HEAD
		public abstract int Seek( int nHandle, uint dwPosition );
=======
>>>>>>> twopointzero/develop
		public abstract int Decode( int nHandle, IntPtr pDest, uint szDestSize, int bLoop );
		public abstract void Close( int nHandle );
	}
}
