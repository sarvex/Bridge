﻿using System;

namespace Bridge
{
    [Ignore]
    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
    public sealed class CastAttribute : Attribute
    {
        public CastAttribute(string value) 
        { 
        }
    }
}