# EmptyCoffee.WinVersionHelper

 >> Install-Package EmptyCoffee.WinVersionHelper -Version 1.0.0

 A simple version detection library for us in Windows applications. 

 Inspired by library here - https://www.nuget.org/packages/VersionHelpers/

which works in many situations but which does not function in all situations when apps are not manifested to properly target a platform.  The concept was rebuilt to use the Environment.OSVersion API, using the info here https://msdn.microsoft.com/en-us/library/windows/desktop/ms724832(v=vs.85).aspx to populate the values.

The whole library is contained in a single static class which can be called like:


            if (WinVersionHelper.IsWindows8OrGreater)
            {
                //do something version specific
            } 