//------------------------------------------------------------------------------
// <copyright file="SQLUtility.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>                                                                
// <owner current="true" primary="true">[....]</owner>
// <owner current="true" primary="false">[....]</owner>
//------------------------------------------------------------------------------

namespace System.Data.SqlTypes {

    public interface INullable {

        bool IsNull {
            get;
        }
    }
}
