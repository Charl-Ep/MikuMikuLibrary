﻿namespace MikuMikuLibrary.IO
{
    public enum BinaryFormat
    {
        /// <summary>
        ///     Dreamy Theater
        /// </summary>
        DT,

        /// <summary>
        ///     F
        /// </summary>
        F,

        /// <summary>
        ///     Future Tone
        /// </summary>
        FT,

        /// <summary>
        ///     F 2nd
        /// </summary>
        F2nd,

        /// <summary>
        ///     X
        /// </summary>
        X
    }

    public static class BinaryFormatEx
    {
        public static bool IsClassic( this BinaryFormat format )
        {
            return BinaryFormatUtilities.IsClassic( format );
        }

        public static bool IsModern( this BinaryFormat format )
        {
            return BinaryFormatUtilities.IsModern( format );
        }

        public static AddressSpace GetAddressSpace( this BinaryFormat format )
        {
            return BinaryFormatUtilities.GetAddressSpace( format );
        }
    }
}