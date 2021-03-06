namespace Microsoft.Protocols.TestSuites.Common
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// RopSaveChangesAttachment request buffer structure
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct RopSaveChangesAttachmentRequest : ISerializable
    {
        /// <summary>
        /// Unsigned 8-bit integer. This value specifies the type of remote operation. For this operation, this field is set to 0x25.
        /// </summary>
        public byte RopId;

        /// <summary>
        /// Unsigned 8-bit integer. This value specifies the logon associated with this operation.
        /// </summary>
        public byte LogonId;

        /// <summary>
        /// Unsigned 8-bit integer. This index specifies the location in the Server Object Handle Table that is referenced in the response.
        /// </summary>
        public byte ResponseHandleIndex;

        /// <summary>
        /// Unsigned 8-bit integer. This index specifies the location in the Server Object Handle Table where the handle 
        /// for the input Server Object is stored.
        /// </summary>
        public byte InputHandleIndex;

        /// <summary>
        /// 8-bit flags structure. The possible values for these flags are specified in [MS-OXCMSG]. 
        /// These flags specify how the save operation behaves.
        /// </summary>
        public byte SaveFlags;

        /// <summary>
        /// Serialize the ROP request buffer.
        /// </summary>
        /// <returns>The ROP request buffer serialized.</returns>
        public byte[] Serialize()
        {
            byte[] serializedBuffer = new byte[Marshal.SizeOf(this)];
            IntPtr requestBuffer = new IntPtr();
            requestBuffer = Marshal.AllocHGlobal(Marshal.SizeOf(this));
            try
            {
                Marshal.StructureToPtr(this, requestBuffer, true);
                Marshal.Copy(requestBuffer, serializedBuffer, 0, Marshal.SizeOf(this));
                return serializedBuffer;
            }
            finally
            {
                Marshal.FreeHGlobal(requestBuffer);
            }
        }

        /// <summary>
        /// Return the size of RopSaveChangesAttachment request buffer structure
        /// </summary>
        /// <returns>The size of RopSaveChangesAttachment request buffer structure.</returns>
        public int Size()
        {
            return Marshal.SizeOf(this);
        }
    }

    /// <summary>
    /// RopSaveChangesAttachment response buffer structure
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct RopSaveChangesAttachmentResponse : IDeserializable
    {
        /// <summary>
        /// Unsigned 8-bit integer. This value specifies the type of remote operation. For this operation, this field is set to 0x25.
        /// </summary>
        public byte RopId;

        /// <summary>
        /// Unsigned 8-bit integer. This index MUST be set to the ResponseHandleIndex specified in the request.
        /// </summary>
        public byte ResponseHandleIndex;

        /// <summary>
        /// Unsigned 32-bit integer. This value specifies the status of the remote operation.
        /// </summary>
        public uint ReturnValue;

        /// <summary>
        /// Deserialize the ROP response buffer.
        /// </summary>
        /// <param name="ropBytes">ROPs bytes in response.</param>
        /// <param name="startIndex">The start index of this ROP.</param>
        /// <returns>The size of response buffer structure.</returns>
        public int Deserialize(byte[] ropBytes, int startIndex)
        {
            IntPtr responseBuffer = new IntPtr();
            responseBuffer = Marshal.AllocHGlobal(Marshal.SizeOf(this));
            try
            {
                Marshal.Copy(ropBytes, startIndex, responseBuffer, Marshal.SizeOf(this));
                this = (RopSaveChangesAttachmentResponse)Marshal.PtrToStructure(responseBuffer, typeof(RopSaveChangesAttachmentResponse));
                return Marshal.SizeOf(this);
            }
            finally
            {
                Marshal.FreeHGlobal(responseBuffer);
            }
        }
    }
}