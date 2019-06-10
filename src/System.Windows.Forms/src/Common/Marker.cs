// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Text;

namespace System.Windows.Forms
{
    public class Marker : Attribute
    {
        IEnumerable<string> Data { get; set; }

        public Marker()
        {
            Data = new List<string>();
        }

        public Marker(params string[] data)
        {
            Data = data;
        }
    }
}
