using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using DemoLightMenu.Models;

namespace DemoLightMenu.UserControls;

public partial class LightMenu : UserControl
{
    // contains all menuchoices
    public List<LightMenuItem> MenuItems { get; set; } = [];
    
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
    }
}