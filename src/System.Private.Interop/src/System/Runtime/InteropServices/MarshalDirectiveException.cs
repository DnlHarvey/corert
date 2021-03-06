// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

/*=============================================================================
**
** Class: MarshalDirectiveException
**
** Purpose: This exception is thrown when the marshaller encounters a signature
**          that has an invalid MarshalAs CA for a given argument or is not
**          supported.
**
=============================================================================*/

using System;

namespace System.Runtime.InteropServices
{
    public class MarshalDirectiveException : Exception
    {
        public MarshalDirectiveException()
            : base(SR.Arg_MarshalDirectiveException)
        {
            HResult = __HResults.COR_E_MARSHALDIRECTIVE;
        }

        public MarshalDirectiveException(String message)
            : base(message)
        {
            HResult = __HResults.COR_E_MARSHALDIRECTIVE;
        }

        public MarshalDirectiveException(String message, Exception inner)
            : base(message, inner)
        {
            HResult = __HResults.COR_E_MARSHALDIRECTIVE;
        }
    }
}
