using System;

using R5T.T0131;
using R5T.T0219;
using R5T.T0219.Extensions;


namespace R5T.Z0058
{
    [ValuesMarker]
    public partial interface IDotnetMajorVersions : IValuesMarker
    {
        public IDotnetMajorVersion V2 => 2.ToDotnetMajorVersion();
        public IDotnetMajorVersion V3 => 3.ToDotnetMajorVersion();
        public IDotnetMajorVersion V5 => 5.ToDotnetMajorVersion();
        public IDotnetMajorVersion V6 => 6.ToDotnetMajorVersion();
        public IDotnetMajorVersion V7 => 7.ToDotnetMajorVersion();
        public IDotnetMajorVersion V8 => 8.ToDotnetMajorVersion();
    }
}
