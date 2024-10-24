using System.Diagnostics;

namespace RefreshViewIssue;

public class RefreshViewOverride : RefreshView
{
    protected override Size MeasureOverride(double widthConstraint, double heightConstraint)
    {
        var size = base.MeasureOverride(widthConstraint, heightConstraint);
        Trace.WriteLine($"RefreshView: MeasureOverride(W:{widthConstraint:N0}, H:{heightConstraint:N0}), Result: W:{size.Width:N0}, H:{size.Height:N0}");
        return size;
    }

    protected override Size ArrangeOverride(Rect bounds)
    {
        var size = base.ArrangeOverride(bounds);
        Trace.WriteLine($"RefreshView: ArrangeOverride(W:{bounds.Width:N0}, H:{bounds.Height:N0}), Result: W:{size.Width:N0}, H:{size.Height:N0}");
        return size;
    }
}