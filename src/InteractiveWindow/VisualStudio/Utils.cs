// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.Diagnostics;

namespace Roslyn.VisualStudio.InteractiveWindow
{
    internal static class SpecializedCollections
    {
        internal static class Empty
        {
            internal class Array<T>
            {
                public static readonly T[] Instance = new T[0];
            }
        }

        public static T[] EmptyArray<T>()
        {
            return Empty.Array<T>.Instance;
        }
    }

    internal static class ExceptionUtilities
    {
        [DebuggerDisplay("Unreachable")]
        public static Exception Unreachable
        {
            get
            {
                Debug.Fail("This code path should not be reachable");
                return new InvalidOperationException();
            }
        }
    }
}
