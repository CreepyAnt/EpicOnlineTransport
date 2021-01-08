// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Input parameters for the <see cref="SessionsInterface.CreateSessionSearch" /> function.
	/// </summary>
	public class CreateSessionSearchOptions
	{
		/// <summary>
		/// Max number of results to return
		/// </summary>
		public uint MaxSearchResults { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct CreateSessionSearchOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private uint m_MaxSearchResults;

		public uint MaxSearchResults
		{
			set
			{
				m_MaxSearchResults = value;
			}
		}

		public void Set(CreateSessionSearchOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = SessionsInterface.CreatesessionsearchApiLatest;
				MaxSearchResults = other.MaxSearchResults;
			}
		}

		public void Set(object other)
		{
			Set(other as CreateSessionSearchOptions);
		}

		public void Dispose()
		{
		}
	}
}