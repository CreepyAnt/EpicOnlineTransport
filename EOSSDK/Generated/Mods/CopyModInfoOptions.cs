// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Mods
{
	/// <summary>
	/// Data for the <see cref="ModsInterface.CopyModInfo" /> function.
	/// </summary>
	public class CopyModInfoOptions
	{
		/// <summary>
		/// The Epic Online Services Account ID of the user for which mods should be copied
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }

		/// <summary>
		/// Type of the enumerated mod to copy
		/// </summary>
		public ModEnumerationType Type { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct CopyModInfoOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private ModEnumerationType m_Type;

		public EpicAccountId LocalUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LocalUserId, value);
			}
		}

		public ModEnumerationType Type
		{
			set
			{
				m_Type = value;
			}
		}

		public void Set(CopyModInfoOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = ModsInterface.CopymodinfoApiLatest;
				LocalUserId = other.LocalUserId;
				Type = other.Type;
			}
		}

		public void Set(object other)
		{
			Set(other as CopyModInfoOptions);
		}

		public void Dispose()
		{
		}
	}
}