﻿using System;

namespace ProtoBuf.BuildTools.Internal
{
    [Flags]
    internal enum TypeContextFlags
    {
        None = 0,
        IsProtoContract = 1 << 0,
        SkipConstructor = 1 << 1,
        IgnoreUnknownSubTypes = 1 << 2,
    }
}
