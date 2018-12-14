﻿using MLS.Project.Generators;

namespace MLS.Protocol.Tests.CodeSamples
{
    internal static class SourceCodeProvider
    {
        public static string ConsoleProgramCollidingRegions =>
            @"using System;

namespace ConsoleProgramSingleRegion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region alpha
            var a = 10;
            #endregion

            #region alpha
            var b = 10;
            #endregion
        }
    }
}".EnforceLF();

        public static string ConsoleProgramMultipleRegions =>
            @"using System;

namespace ConsoleProgramSingleRegion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region alpha
            var a = 10;
            #endregion

            #region beta
            var b = 10;
            #endregion
        }
    }
}".EnforceLF();

        public static string ConsoleProgramSingleRegion =>
            @"using System;

namespace ConsoleProgramSingleRegion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region alpha
            var a = 10;
            #endregion
        }
    }
}".EnforceLF();

        public static string ConsoleProgramNoRegion => @"using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramSingleRegion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var a = 10;
        }
    }
}".EnforceLF();

        public static string ConsoleProgramSingleRegionExtraUsing =>
            @"using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramSingleRegion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region alpha
            var a = 10;
            #endregion
        }
    }
}".EnforceLF();
    }
}