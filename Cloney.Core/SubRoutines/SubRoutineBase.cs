﻿using System.Collections.Generic;

namespace Cloney.Core.SubRoutines
{
    /// <summary>
    /// This abstract base class can provide sub
    /// routines with basic functionality.
    /// </summary>
    public abstract class SubRoutineBase
    {
        protected bool ArgsHaveKeyValue(IDictionary<string, string> args, string key, string value)
        {
            return (args.ContainsKey(key) && args[key] == value);
        }

        protected bool ArgsHaveSingleKeyValue(IDictionary<string, string> args, string key, string value)
        {
            return args.Count == 1 && ArgsHaveKeyValue(args, key, value);
        }
    }
}
