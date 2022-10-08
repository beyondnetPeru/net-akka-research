﻿using System.Collections.Immutable;

namespace BuildingMonitor.Messages
{
    public sealed class RespondAllTemperatures
    {
        public long RequestId { get; }
        public IImmutableDictionary<string, ITemperatureQueryReading> TemperatureReadings { get; }

        public RespondAllTemperatures(
            long requestId,
            IImmutableDictionary<string, ITemperatureQueryReading> temperatures)
        {
            RequestId = requestId;
            TemperatureReadings = temperatures;
        }
    }
}
