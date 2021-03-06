using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HueMicIndicator.Hue.State;

internal class NoOpHueState : IHueState
{
    private NoOpHueState() { }

    public static NoOpHueState Instance { get; } = new();

    public Task ApplyAsync(HueContext _)
        => Task.CompletedTask;

    public IEnumerable<string> GetAffectedLights()
        => Array.Empty<string>();
}