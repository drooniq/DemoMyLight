using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using DemoLightMenu.Models;

namespace DemoLightMenu.UserControls;

public partial class LightMenu : UserControl
{
    // contains all menuchoices
    public List<LightMenuItem> MenuItems { get; set; } = [];
    
    public static readonly StyledProperty<bool> IsMenuOpenProperty =
        AvaloniaProperty.Register<LightMenu, bool>(nameof(IsMenuOpen), false);

    public bool IsMenuOpen
    {
        get => GetValue(IsMenuOpenProperty);
        set => SetValue(IsMenuOpenProperty, value);
    }
    
    public static readonly StyledProperty<double> DotSizeProperty =
        AvaloniaProperty.Register<LightMenu, double>(nameof(DotSize), 6.0);  // Default dot size
    
    public double DotSize
    {
        get => GetValue(DotSizeProperty);
        set => SetValue(DotSizeProperty, value);
    }
    
    // setup up some stylish parameters. 
    public static readonly StyledProperty<double> IconHeightProperty =
        AvaloniaProperty.Register<LightMenu, double>(nameof(IconHeight), 40.0);  // Default Height

    public double IconHeight
    {
        get => GetValue(IconHeightProperty);
        set => SetValue(IconHeightProperty, value);
    }

    public static readonly StyledProperty<double> IconWidthProperty =
        AvaloniaProperty.Register<LightMenu, double>(nameof(IconWidth), 40.0);   // Default Width    
    public double IconWidth
    {
        get => GetValue(IconWidthProperty);
        set => SetValue(IconWidthProperty, value);
    }    

    public LightMenu()
    {
        InitializeComponent();
        DataContext = this;
        MenuItems.Add(new LightMenuItem { Title = "Option 1" });
        MenuItems.Add(new LightMenuItem { Title = "Option 2" });
        MenuItems.Add(new LightMenuItem { Title = "Option 3" });
    }
    
    private void OnMenuButtonClick(object? sender, RoutedEventArgs e)
    {
        IsMenuOpen = !IsMenuOpen;
    }    
}