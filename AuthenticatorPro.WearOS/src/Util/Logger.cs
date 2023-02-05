// Copyright (C) 2023 jmh
// SPDX-License-Identifier: GPL-3.0-only

using Android.Util;
using System;

namespace AuthenticatorPro.WearOS.Util
{
    internal static class Logger
    {
        private const string Tag = "AUTHPROWEAR";

        public static void Error(string message)
        {
            Log.Error(Tag, message);
        }

        public static void Error(Exception e)
        {
            Log.Error(Tag, e.ToString());
        }

        public static void Info(string message)
        {
            Log.Info(Tag, message);
        }
    }
}