﻿// FFXIVAPP.Client
// ConstantsHelper.cs
// 
// © 2013 Ryan Wilson

#region Usings

using FFXIVAPP.Common.Core.Constant;
using SmartAssembly.Attributes;

#endregion

namespace FFXIVAPP.Client.Helpers
{
    [DoNotObfuscate]
    public static class ConstantsHelper
    {
        public static void UpdatePluginConstants()
        {
            ApplicationContextHelper.GetContext()
                                    .ConstantWorker.RaiseValuesEvent(new ConstantEntry
                                    {
                                        AutoTranslate = Constants.AutoTranslate,
                                        CharacterName = Constants.CharacterName,
                                        ChatCodes = Constants.ChatCodes,
                                        ChatCodesXml = Constants.ChatCodesXml,
                                        Colors = Constants.Colors,
                                        CultureInfo = Constants.CultureInfo,
                                        EnableHelpLabels = Constants.EnableHelpLabels,
                                        EnableNLog = Constants.EnableNLog,
                                        GameLanguage = Constants.GameLanguage,
                                        ServerName = Constants.ServerName
                                    });
        }
    }
}
