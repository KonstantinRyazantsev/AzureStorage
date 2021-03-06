﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Common.Log;

namespace Lykke.AzureStorage
{
    public class EmptyLog : ILog
    {
        public static EmptyLog Instance { get; } = new EmptyLog();

        public Task WriteInfoAsync(string component, string process, string context, string info, DateTime? dateTime = null)
        {
            return Task.CompletedTask;
        }

        public Task WriteWarningAsync(string component, string process, string context, string info, DateTime? dateTime = null)
        {
            return Task.CompletedTask;
        }

        public Task WriteErrorAsync(string component, string process, string context, Exception exeption, DateTime? dateTime = null)
        {
            return Task.CompletedTask;
        }

        public Task WriteFatalErrorAsync(string component, string process, string context, Exception exeption,
            DateTime? dateTime = null)
        {
            return Task.CompletedTask;
        }
    }
}
