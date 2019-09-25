﻿/*
    Derived from liblzma header files (Public Domain)

    C# Wrapper written by Hajin Jang
    Copyright (C) 2018-2019 Hajin Jang

    MIT License

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in all
    copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    SOFTWARE.
*/

using System;
using System.Runtime.InteropServices;
// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming

namespace Joveler.Compression.XZ
{
    public static class XZInit
    {
        #region GlobalInit
        public static void GlobalInit(string libPath, int bufferSize = 64 * 1024)
        {
            NativeMethods.GlobalInit(libPath, bufferSize);
        }
        #endregion

        #region GlobalCleanup
        public static void GlobalCleanup()
        {
            NativeMethods.GlobalCleanup();
        }
        #endregion

        #region Version - (Static)
        public static Version Version()
        {
            NativeMethods.EnsureLoaded();

            /*
             * Note from "lzma\version.h"
             *
             * The version number is of format xyyyzzzs where
             *  - x = major
             *  - yyy = minor
             *  - zzz = revision
             *  - s indicates stability: 0 = alpha, 1 = beta, 2 = stable
             *
             * The same xyyyzzz triplet is never reused with different stability levels.
             * For example, if 5.1.0alpha has been released, there will never be 5.1.0beta
             * or 5.1.0 stable.
             */

            uint verInt = NativeMethods.LzmaVersionNumber();
            int major = (int)(verInt / 10000000u);
            int minor = (int)(verInt % 10000000u / 10000u);
            int revision = (int)(verInt % 10000u / 10u);
            int stability = (int)(verInt % 10u);

            return new Version(major, minor, revision, stability);
        }

        public static string VersionString()
        {
            NativeMethods.EnsureLoaded();

            IntPtr ptr = NativeMethods.LzmaVersionString();
            return Marshal.PtrToStringAnsi(ptr);
        }
        #endregion

        #region Hardware - PhysMem & CPU Threads
        public static ulong PhysMem()
        {
            NativeMethods.EnsureLoaded();

            return NativeMethods.LzmaPhysMem();
        }

        public static uint CpuThreads()
        {
            NativeMethods.EnsureLoaded();

            return NativeMethods.LzmaCpuThreads();
        }
        #endregion
    }
}
