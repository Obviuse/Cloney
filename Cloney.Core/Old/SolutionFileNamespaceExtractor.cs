﻿using System;
using System.IO;
using Cloney.Core.Old.Abstractions;

namespace Cloney.Core.Old
{
    public class SolutionFileNamespaceExtractor : ICanExtractNamespace
    {
        public string ExtractNamespace(string folderPath)
        {
            if (!Directory.Exists(folderPath))
                return string.Empty;

            foreach (var file in Directory.GetFiles(folderPath))
            {
                var fileInfo = new FileInfo(file);
                if (fileInfo.Extension != ".sln")
                    continue;

                return fileInfo.Name.Replace(fileInfo.Extension, "");
            }

            return String.Empty;
        }
    }
}