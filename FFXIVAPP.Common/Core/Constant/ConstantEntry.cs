﻿// FFXIVAPP.Common
// ConstantEntry.cs
// 
// © 2013 Ryan Wilson

#region Usings

using System.Collections.Generic;
using System.Globalization;

#endregion

namespace FFXIVAPP.Common.Core.Constant
{
    public class ConstantEntry : IConstantEntry
    {
        public Dictionary<string, string> AutoTranslate { get; set; }
        public Dictionary<string, string> ChatCodes { get; set; }
        public string ChatCodesXml { get; set; }
        public Dictionary<string, string[]> Colors { get; set; }
        public CultureInfo CultureInfo { get; set; }
        public string CharacterName { get; set; }
        public string ServerName { get; set; }
        public string GameLanguage { get; set; }
        public bool EnableNLog { get; set; }
        public bool EnableHelpLabels { get; set; }
    }
}
