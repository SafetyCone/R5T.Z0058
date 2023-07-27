using System;

using R5T.T0131;
using R5T.T0219;
using R5T.T0219.Extensions;


namespace R5T.Z0058
{
    [ValuesMarker]
    public partial interface IDotnetMajorVersions : IValuesMarker
    {
        public IDotnetMajorVersion V6 => 6.ToDotnetMajorVersion();
    }
}
