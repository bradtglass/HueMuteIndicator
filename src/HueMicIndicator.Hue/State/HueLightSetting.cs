using HueMicIndicator.Hue.State.Color;
using Q42.HueApi;

namespace HueMicIndicator.Hue.State;

public record HueLightSetting(bool? On, byte? Brightness, HueColor? Color, bool ResetFirst) : IModifiesLightCommand
{
    public void Apply(LightCommand command)
    {
        if (Color != null)
        {
            // Clear any existing color settings to prevent conflicts
            command.ColorCoordinates = null!;
            command.ColorTemperature = null;
            command.Hue = null;
            command.Saturation = null;

            Color?.Apply(command);
        }

        if (On.HasValue)
            command.On = On;

        if (Brightness.HasValue)
            command.Brightness = Brightness;
    }
}