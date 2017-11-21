/******************************************************************************
 * 
 *  Copyright © 2017 EmptyCoffee.com 
 * 
 *  Permission is hereby granted, free of charge, to any person obtaining a copy of this software
 *  and associated documentation files (the "Software"), to deal in the Software without
 *  restriction, including without limitation the rights to use, copy, modify, merge, publish,
 *  distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the
 *  Software is furnished to do so, subject to the following conditions:
 *
 *  The above copyright notice and this permission notice shall be included in all copies or
 *  substantial portions of the Software.
 *
 *  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING
 *  BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 *  NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
 *  DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 *  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 *
 **************************************************************************************************/
using System.Windows;

namespace System.Windows
{
    public static class WinVersionHelper
    {        
        /// <summary>
        /// Tests the provided major and minor version against the Environment.OSVersion.Version of the system.
        /// </summary>
        /// <remarks>
        /// This is not suitable for feature detection and should only be used as a last resort to determine the 
        /// OS version (with exception as outlined by Microsoft at https://msdn.microsoft.com/en-us/library/windows/desktop/ms724832(v=vs.85).aspx)
        /// as determined by the Environment object of the running context.
        /// </remarks>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// <paramref name="majorVersion"/> is smaller than 5 or <paramref name="minorVersion"/>
        /// <paramref name="minorVersion"/> is less that zero <paramref name="minorVersion"/>
        /// </exception>
        /// <param name="majorVersion">The major OS version number.</param>
        /// <param name="minorVersion">The minor OS version number.</param>
        /// <returns>True if the specified version matches, or is greater than, the version of the
        /// current Windows OS; otherwise, false.</returns>
        public static bool IsWindowsVersionOrGreater(int majorVersion, int minorVersion)
        {
            // Validate arguments
            if (majorVersion < 5)
            {
                // Error: Major version cannot be smaller than 5
                throw new ArgumentOutOfRangeException("majorVersion");
            }

            if (minorVersion < 0)
            {
                // Error: Minor version cannot be negative
                throw new ArgumentOutOfRangeException("minorVersion");
            }

            // Verify version info
            return Environment.OSVersion.Version.Major >= majorVersion && Environment.OSVersion.Version.Minor >= minorVersion;
        }

        /// <summary>
        /// Indicates if the current OS version matches, or is greater than, the Windows 2000 version.
        /// </summary>
        /// <returns>True if the current OS version matches, or is greater than, the Windows 2000
        /// version; otherwise, false.</returns>
        public static bool IsWindows2000OrGreater => IsWindowsVersionOrGreater(5, 1);

        /// <summary>
        /// Indicates if the current OS version matches, or is greater than, the Windows XP version.
        /// </summary>
        /// <returns>True if the current OS version matches, or is greater than, the Windows XP
        /// version; otherwise, false.</returns>
        public static bool IsWindowsXPOrGreater => IsWindowsVersionOrGreater(5, 1);

        /// <summary>
        /// Indicates if the current OS version matches, or is greater than, the Windows XP(64) version.
        /// </summary>
        /// <returns>True if the current OS version matches, or is greater than, the Windows XP(64)
        /// version; otherwise, false.</returns>
        public static bool IsWindowsXP64OrGreater => IsWindowsVersionOrGreater(5, 2);

        /// <summary>
        /// Indicates if the current OS version matches, or is greater than, the Windows Server 2003 version.
        /// </summary>
        /// <returns>True if the current OS version matches, or is greater than, the Windows Server 2003
        /// version; otherwise, false.</returns>
        public static bool IsWindowsServer2003OrGreater => IsWindowsVersionOrGreater(5, 2);//this matches based on documentation 

        /// <summary>
        /// Indicates if the current OS version matches, or is greater than, the Windows Vista
        /// version.
        /// </summary>
        /// <returns>True if the current OS version matches, or is greater than, the Windows Vista
        /// version; otherwise, false.</returns>
        public static bool IsWindowsVistaOrGreater => IsWindowsVersionOrGreater(6, 0);

        /// <summary>
        /// Indicates if the current OS version matches, or is greater than, the Windows Server 2008 version.
        /// </summary>
        /// <returns>True if the current OS version matches, or is greater than, the Windows Server 2008
        /// version; otherwise, false.</returns>
        public static bool IsWindowsServer2008OrGreater => IsWindowsVersionOrGreater(6, 0);//this matches based on documentation 

        /// <summary>
        /// Indicates if the current OS version matches, or is greater than, the Windows Server 2008 R2 version.
        /// </summary>
        /// <returns>True if the current OS version matches, or is greater than, the Windows Server 2008 R2
        /// version; otherwise, false.</returns>
        public static bool IsWindowsServer2008R2OrGreater => IsWindowsVersionOrGreater(6, 1);//this matches based on documentation 

        /// <summary>
        /// Indicates if the current OS version matches, or is greater than, the Windows 7 version.
        /// </summary>
        /// <returns>True if the current OS version matches, or is greater than, the Windows 7
        /// version; otherwise, false.</returns>
        public static bool IsWindows7OrGreater => IsWindowsVersionOrGreater(6, 1);

        /// <summary>
        /// Indicates if the current OS version matches, or is greater than, the Windows Server 2012 version.
        /// </summary>
        /// <returns>True if the current OS version matches, or is greater than, the Windows Server 2012
        /// version; otherwise, false.</returns>
        public static bool IsWindowsServer2012OrGreater => IsWindowsVersionOrGreater(6, 2);

        /// <summary>
        /// Indicates if the current OS version matches, or is greater than, the Windows 8 version.
        /// </summary>
        /// <returns>True if the current OS version matches, or is greater than, the Windows 8
        /// version; otherwise, false.</returns>
        public static bool IsWindows8OrGreater => IsWindowsVersionOrGreater(6, 2);

        /// <summary>
        /// Indicates if the current OS version matches, or is greater than, the Windows Server 2012 R2 version.
        /// </summary>
        /// <returns>True if the current OS version matches, or is greater than, the Windows Server 2012 R2
        /// version; otherwise, false.</returns>
        public static bool IsWindowsServer2012R2OrGreater => IsWindowsVersionOrGreater(6, 3); //this matches based on documentation

        /// <summary>
        /// Indicates if the current OS version matches, or is greater than, the Windows 8.1
        /// version.
        /// </summary>
        ///  <returns>True if the current OS version matches, or is greater than, the Windows 8.1
        /// version; otherwise, false.</returns>
        public static bool IsWindows8Point1OrGreater => IsWindowsVersionOrGreater(6, 3);

        /// <summary>
        /// Indicates if the current OS version matches, or is greater than, the Windows 10
        /// version.
        /// </summary>
        ///  <returns>True if the current OS version matches, or is greater than, the Windows 10
        /// version; otherwise, false.</returns>
        public static bool IsWindows10OrGreater => IsWindowsVersionOrGreater(10, 0); 

        /// <summary>
        /// Indicates if the current OS version matches, or is greater than, the Windows Server 2016 version.
        /// </summary>
        /// <returns>True if the current OS version matches, or is greater than, Windows Server 2016
        /// version; otherwise, false.</returns>
        public static bool IsWindowsServer2016OrGreater => IsWindowsVersionOrGreater(10, 0);  //matches per documentation

        /// <summary>
        /// Indicates if the current OS version matches, or is greater than, Windows 8 but the application is not properly targeted to Operating System(s) versioned higher than 8.
        /// </summary>
        /// <returns>True if the current OS version matches, or is greater than, Windows 8 and that isn't properly targeted to a post Windows 8 OS version.
        /// ; otherwise, false.</returns>
        public static bool IsUnmanifestTargetedWindows8OrGreater => IsWindowsVersionOrGreater(6, 2);//all version past 8 currently match the same version per documentation

    }
}
