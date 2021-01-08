// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Connect
{
	/// <summary>
	/// Input parameters for the <see cref="ConnectInterface.QueryExternalAccountMappings" /> function.
	/// </summary>
	public class QueryExternalAccountMappingsOptions
	{
		/// <summary>
		/// The Product User ID of the existing, logged-in user who is querying account mappings
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// External auth service supplying the account IDs in string form
		/// </summary>
		public ExternalAccountType AccountIdType { get; set; }

		/// <summary>
		/// An array of external account IDs to map to the product user ID representation
		/// </summary>
		public string[] ExternalAccountIds { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct QueryExternalAccountMappingsOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private ExternalAccountType m_AccountIdType;
		private System.IntPtr m_ExternalAccountIds;
		private uint m_ExternalAccountIdCount;

		public ProductUserId LocalUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LocalUserId, value);
			}
		}

		public ExternalAccountType AccountIdType
		{
			set
			{
				m_AccountIdType = value;
			}
		}

		public string[] ExternalAccountIds
		{
			set
			{
				Helper.TryMarshalSet(ref m_ExternalAccountIds, value, out m_ExternalAccountIdCount, true);
			}
		}

		public void Set(QueryExternalAccountMappingsOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = ConnectInterface.QueryexternalaccountmappingsApiLatest;
				LocalUserId = other.LocalUserId;
				AccountIdType = other.AccountIdType;
				ExternalAccountIds = other.ExternalAccountIds;
			}
		}

		public void Set(object other)
		{
			Set(other as QueryExternalAccountMappingsOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_ExternalAccountIds);
		}
	}
}