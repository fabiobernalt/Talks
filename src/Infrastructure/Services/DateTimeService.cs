﻿using Talks.Application.Common.Interfaces;
using System;

namespace Talks.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.UtcNow;
    }
}
