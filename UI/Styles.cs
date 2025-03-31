using Microsoft.Maui.Controls.Shapes;

namespace Calculator;

/// <summary>
/// Styles cho Shadow
/// </summary>
public static partial class Styles
{
    public static readonly Shadow Shadow = new()
    {
        Offset = new Point(0, 4),
        Brush = new SolidColorBrush(Colors.Purple),
        Opacity = 0.1f
    };
}

/// <summary>
/// Styles cho Border
/// </summary>
public static partial class Styles
{
    public static readonly Style ButtonBorder = CreateStyle<Border>()
        .Set(VisualElement.HeightRequestProperty, 60)
        .Set(VisualElement.WidthRequestProperty, 60)
        .Set(Border.StrokeProperty, Colors.GreyLight)
        .Set(Border.StrokeThicknessProperty, 1)
        .Set(Border.StrokeShapeProperty, new RoundRectangle
        {
            CornerRadius = new CornerRadius(30)
        });

    public static readonly Style CardBorder = CreateStyle<Border>()
        .Set(Border.StrokeProperty, Microsoft.Maui.Graphics.Colors.Transparent)
        .Set(Border.PaddingProperty, new Thickness(16))
        .Set(Border.StrokeShapeProperty, new RoundRectangle
        {
            CornerRadius = new CornerRadius(20)
        });

    public static readonly Style ProfileBorder = CreateStyle<Border>()
        .Set(VisualElement.HeightRequestProperty, 150)
        .Set(VisualElement.WidthRequestProperty, 150)
        .Set(Border.StrokeThicknessProperty, 0)
        .Set(Border.StrokeProperty, Colors.White)
        .Set(Border.StrokeShapeProperty, new RoundRectangle
        {
            CornerRadius = new CornerRadius(75)
        });

    public static readonly Style CornerBorder = CreateStyle<Border>()
        .Set(Border.StrokeProperty, Microsoft.Maui.Graphics.Colors.Transparent)
        .Set(Border.PaddingProperty, new Thickness(32))
        .Set(Border.StrokeShapeProperty, new RoundRectangle
        {
            CornerRadius = new CornerRadius(10)
        });

    public static readonly Style ItemBorder = CreateStyle<Border>()
        .Set(Border.PaddingProperty, new Thickness(20))
        .Set(View.MarginProperty, new Thickness(5))
        .Set(Border.StrokeProperty, Colors.GreyLight)
        .Set(Border.StrokeThicknessProperty, 1)
        .Set(Border.StrokeShapeProperty, new RoundRectangle
        {
            CornerRadius = new CornerRadius(30)
        });

    public static readonly Style KeyboardBorder = CreateStyle<Border>()
        .Set(View.MarginProperty, new Thickness(0, 10, 0, 0))
        .Set(Border.PaddingProperty, new Thickness(0, 40, 0, 20));

    public static readonly Style FrameBorder = CreateStyle<Border>()
        .Set(Border.StrokeProperty, Microsoft.Maui.Graphics.Colors.Transparent);

}

/// <summary>
/// Styles cho button
/// </summary>
public static partial class Styles
{
    public static readonly Style NumberButton = CreateStyle<Button>()
        .Set(VisualElement.HeightRequestProperty, 60)
        .Set(VisualElement.WidthRequestProperty, 60)
        .Set(Button.FontSizeProperty, 30)
        .Set(Button.CornerRadiusProperty, 30);

    public static readonly Style OperatorButton = CreateStyle<ImageButton>()
        .Set(VisualElement.HeightRequestProperty, 60)
        .Set(VisualElement.WidthRequestProperty, 60)
        .Set(ImageButton.CornerRadiusProperty, 30);

    public static readonly Style CaculateButton = CreateStyle<Button>()
        .Set(VisualElement.HeightRequestProperty, 120)
        .Set(VisualElement.WidthRequestProperty, 60)
        .Set(VisualElement.BackgroundColorProperty, Colors.Pink)
        .Set(Button.CornerRadiusProperty, 30)
        .Set(Button.FontSizeProperty, 30);

    public static readonly Style UpgradeButton = CreateStyle<Button>()
        .Set(VisualElement.BackgroundProperty, Colors.White)
        .Set(Button.TextColorProperty, Colors.Blue)
        .Set(View.HorizontalOptionsProperty, LayoutOptions.Center);
}

/// <summary>
/// Styles cho Label
/// </summary>
public static partial class Styles
{
    public static readonly Style ExpressionLabel = CreateStyle<Label>()
        .Set(VisualElement.OpacityProperty, 0.7)
        .Set(Label.FontSizeProperty, 22)
        .Set(Label.CharacterSpacingProperty, 6)
        .Set(Label.PaddingProperty, new Thickness(0, 0, 40, 0))
        .Set(Label.HorizontalTextAlignmentProperty, TextAlignment.End)
        .Set(Label.VerticalTextAlignmentProperty, TextAlignment.End);

    public static readonly Style ResultLabel = CreateStyle<Label>()
        .Set(Label.FontSizeProperty, 42)
        .Set(Label.PaddingProperty, new Thickness(0, 0, 40, 0))
        .Set(Label.HorizontalTextAlignmentProperty, TextAlignment.End)
        .Set(Label.VerticalTextAlignmentProperty, TextAlignment.End);

    public static readonly Style MenuCaptionLabel = CreateStyle<Label>()
        .Set(VisualElement.HeightRequestProperty, 104)
        .Set(Label.FontSizeProperty, 28)
        .Set(Label.FontFamilyProperty, "BalooFont")
        .Set(Label.FontAttributesProperty, FontAttributes.Bold)
        .Set(Label.TextColorProperty, Colors.White)
        .Set(Label.HorizontalTextAlignmentProperty, TextAlignment.Center)
        .Set(View.MarginProperty, new Thickness(0, 0, 0, 36));

    public static readonly Style NavigateLabel = CreateStyle<Label>()
        .Set(Label.VerticalTextAlignmentProperty, TextAlignment.Center)
        .Set(Label.TextColorProperty, Colors.White)
        .Set(Label.PaddingProperty, new Thickness(24, 0, 0, 0));
}

/// <summary>
/// Styles cho Entry
/// </summary>
public static partial class Styles
{
}

/// <summary>
/// Styles cho Background
/// </summary>
public static partial class Styles
{
}

/// <summary>
/// Những phương thức của styles
/// </summary>
public static partial class Styles
{
    private static Style CreateStyle<T>()
    {
        return new Style(typeof(T));
    }

    private static Style BaseOn(this Style style, Style basedOn)
    {
        style.BasedOn = basedOn;
        return style;
    }

    private static Style Set(this Style style, BindableProperty property, object value)
    {
        style.Setters.Add(new Setter
        {
            Property = property,
            Value = value
        });
        return style;
    }

    private static Style BindTrigger(this Style style, Binding binding, object value,
        params (BindableProperty p, object value)[] setters)
    {
        var dataTrigger = new DataTrigger(style.TargetType)
        {
            Binding = binding,
            Value = value
        };

        for (var i = 0; i < setters.Length; i++)
            dataTrigger.Setters.Add(new Setter
            {
                Property = setters[i].p,
                Value = setters[i].value
            });

        style.Triggers.Add(dataTrigger);

        return style;
    }
}