﻿#region License and copyright notice
/* 
 * Kaliko Content Management System
 * 
 * Copyright (c) Fredrik Schultz
 * 
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 3.0 of the License, or (at your option) any later version.
 * 
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
 * Lesser General Public License for more details.
 * http://www.gnu.org/licenses/lgpl-3.0.html
 */
#endregion

namespace KalikoSearch.Analyzers {
    using Configuration;
    using Lucene.Net.Analysis;

    public class SnowballAnalyzer : IAnalyzer {
        // TODO: Allow language also to be passed
        public SnowballAnalyzer() {
            Analyzer = new Lucene.Net.Analysis.Snowball.SnowballAnalyzer(SearchSettings.Instance.LuceneVersion, SearchSettings.Instance.Language, StopWords.DefaultEnglish);
        }

        public Analyzer Analyzer { get; private set; }
    }
}