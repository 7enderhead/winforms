// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Text;

namespace System.Windows.Forms
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class Marker : Attribute
    {
        string Data { get; set; }
        public Marker(string data)
        {
            Data = data;
        }
    }
}
