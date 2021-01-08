// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Lobby
{
	/// <summary>
	/// Input parameters for the <see cref="LobbySearch.Find" /> function.
	/// </summary>
	public class LobbySearchFindOptions
	{
		/// <summary>
		/// The Product User ID of the user making the search request
		/// </summary>
		public ProductUserId LocalUserId { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct LobbySearchFindOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;

		public ProductUserId LocalUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LocalUserId, value);
			}
		}

		public void Set(LobbySearchFindOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = LobbySearch.LobbysearchFindApiLatest;
				LocalUserId = other.LocalUserId;
			}
		}

		public void Set(object other)
		{
			Set(other as LobbySearchFindOptions);
		}

		public void Dispose()
		{
		}
	}
}