﻿using System;

namespace Bridge
{
    /// <summary>
    /// The output folder path for generated JavaScript. A non-absolute path is concatenated with a project's root.
    /// Examples: "Bridge/output/", "../Bridge/output/", "c:\\output\\"
    /// </summary>
    [External]
    [AttributeUsage(AttributeTargets.Assembly)]
    [NonScriptable]
    public sealed class OutputAttribute : Attribute
    {
        public OutputAttribute(string path)
        {
        }
    }
}