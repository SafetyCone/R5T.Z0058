using System;


namespace R5T.Z0058
{
    public class DotnetMajorVersions : IDotnetMajorVersions
    {
        #region Infrastructure

        public static IDotnetMajorVersions Instance { get; } = new DotnetMajorVersions();


        private DotnetMajorVersions()
        {
        }

        #endregion
    }
}
