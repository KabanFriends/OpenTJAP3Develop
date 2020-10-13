﻿using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.Text;
=======
>>>>>>> twopointzero/develop
using System.Runtime.InteropServices;
using System.Globalization;
using SlimDX;
using SlimDX.Direct3D9;

namespace FDK
{
	[StructLayout( LayoutKind.Sequential )]
	public struct PositionColoredTexturedVertex : IEquatable<PositionColoredTexturedVertex>
	{
		public Vector3	Position;
		public int		Color;
		public Vector2	TextureCoordinates;

<<<<<<< HEAD
		public static int SizeInBytes
		{
			get
			{
				return Marshal.SizeOf( typeof( PositionColoredTexturedVertex ) );
			}
		}
=======
>>>>>>> twopointzero/develop
		public static VertexFormat Format
		{
			get
			{
				return ( VertexFormat.Texture1 | VertexFormat.Diffuse | VertexFormat.Position );
			}
		}
<<<<<<< HEAD
		public PositionColoredTexturedVertex( Vector3 position, int color, Vector2 textureCoordinates )
		{
			this = new PositionColoredTexturedVertex();
			this.Position = position;
			this.Color = color;
			this.TextureCoordinates = textureCoordinates;
		}
=======
>>>>>>> twopointzero/develop

		public static bool operator ==( PositionColoredTexturedVertex left, PositionColoredTexturedVertex right )
		{
			return left.Equals( right );
		}
		public static bool operator !=( PositionColoredTexturedVertex left, PositionColoredTexturedVertex right )
		{
			return !( left == right );
		}
		public override int GetHashCode()
		{
			return ( ( this.Position.GetHashCode() + this.Color.GetHashCode() ) + this.TextureCoordinates.GetHashCode() );
		}
		public override bool Equals( object obj )
		{
			if( obj == null )
			{
				return false;
			}
			if( base.GetType() != obj.GetType() )
			{
				return false;
			}
			return this.Equals( (PositionColoredTexturedVertex) obj );
		}
		public bool Equals( PositionColoredTexturedVertex other )
		{
			return ( ( ( this.Position == other.Position ) && ( this.Color == other.Color ) ) && ( this.TextureCoordinates == other.TextureCoordinates ) );
		}
		public override string ToString()
		{
			return string.Format( CultureInfo.CurrentCulture, "{0} ({1}, {2})", new object[] { this.Position.ToString(), System.Drawing.Color.FromArgb( this.Color ).ToString(), this.TextureCoordinates.ToString() } );
		}
	}
}
