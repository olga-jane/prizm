﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Resources;

namespace Prizm.Main.Languages
{
    public interface ILanguageManager
    {
        IReadOnlyList<CultureInfo> GetCultures(out int indexDefault);
        bool LoadTranslation(CultureInfo culture);
        ResourceManager Current { get; }
        ResourceManager Default { get; }
        CultureInfo CurrentCulture { get; }
        CultureInfo DefaultCulture { get; }
    }
}