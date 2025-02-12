using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;

namespace DemoLightMenu.Models;

public class LightMenuItem
{
    public string? Title { get; set; }
    public IRelayCommand? Command { get; set; }
}