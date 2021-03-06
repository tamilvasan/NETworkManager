﻿using NETworkManager.Localization;
using System.Collections.Generic;

namespace NETworkManager.Documentation
{
    public class DocumentationInfo
    {
        public DocumentationIdentifier Identifier { get; set; }
        public string Path { get; set; }
        public List<LocalizationInfo> Localizations { get; set; }

        public DocumentationInfo(DocumentationIdentifier identifier, string path, List<LocalizationInfo> localizations)
        {
            Identifier = identifier;
            Path = path;
            Localizations = localizations;
        }
    }
}
