// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamUnifiedMessages001VTable
	{
		public IntPtr SendMethod0;
		public IntPtr GetMethodResponseInfo1;
		public IntPtr GetMethodResponseData2;
		public IntPtr ReleaseMethod3;
		public IntPtr SendNotification4;
		private IntPtr DTorISteamUnifiedMessages0015;
	};
	
	[InteropHelp.InterfaceVersion("STEAMUNIFIEDMESSAGES_INTERFACE_VERSION001")]
	public class ISteamUnifiedMessages001 : InteropHelp.NativeWrapper<ISteamUnifiedMessages001VTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeSendMethodSBUU( IntPtr thisptr, string arg0, Byte[] arg1, UInt32 arg2, UInt64 arg3 );
		public UInt64 SendMethod( string arg0, Byte[] arg1, UInt32 arg2, UInt64 arg3 ) 
		{
			return this.GetFunction<NativeSendMethodSBUU>( this.Functions.SendMethod0 )( this.ObjectAddress, arg0, arg1, arg2, arg3 ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetMethodResponseInfoUUE( IntPtr thisptr, UInt64 arg0, ref UInt32 arg1, ref EResult arg2 );
		public bool GetMethodResponseInfo( UInt64 arg0, ref UInt32 arg1, ref EResult arg2 ) 
		{
			return this.GetFunction<NativeGetMethodResponseInfoUUE>( this.Functions.GetMethodResponseInfo1 )( this.ObjectAddress, arg0, ref arg1, ref arg2 ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetMethodResponseDataUBUB( IntPtr thisptr, UInt64 arg0, Byte[] arg1, UInt32 arg2, [MarshalAs(UnmanagedType.I1)] bool arg3 );
		public bool GetMethodResponseData( UInt64 arg0, Byte[] arg1, UInt32 arg2, bool arg3 ) 
		{
			return this.GetFunction<NativeGetMethodResponseDataUBUB>( this.Functions.GetMethodResponseData2 )( this.ObjectAddress, arg0, arg1, arg2, arg3 ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeReleaseMethodU( IntPtr thisptr, UInt64 arg0 );
		public bool ReleaseMethod( UInt64 arg0 ) 
		{
			return this.GetFunction<NativeReleaseMethodU>( this.Functions.ReleaseMethod3 )( this.ObjectAddress, arg0 ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSendNotificationSBU( IntPtr thisptr, string arg0, Byte[] arg1, UInt32 arg2 );
		public bool SendNotification( string arg0, Byte[] arg1, UInt32 arg2 ) 
		{
			return this.GetFunction<NativeSendNotificationSBU>( this.Functions.SendNotification4 )( this.ObjectAddress, arg0, arg1, arg2 ); 
		}
		
	};
}
