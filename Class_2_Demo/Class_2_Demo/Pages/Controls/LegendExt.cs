using Syncfusion.Maui.Toolkit.Charts;

namespace Class_2_Demo.Pages.Controls
{
    public class LegendExt : ChartLegend
    {
        protected override double GetMaximumSizeCoefficient()
        {
            return 0.5;
        }
    }
}
