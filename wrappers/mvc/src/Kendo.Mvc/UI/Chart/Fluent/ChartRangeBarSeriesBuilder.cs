﻿namespace Kendo.Mvc.UI.Fluent
{
    using System;
    using Kendo.Mvc.UI;
    using System.ComponentModel;

    public class ChartRangeBarSeriesBuilder<T> : ChartBarSeriesBuilderBase<IChartBarSeries, ChartBarSeriesBuilder<T>>
        where T : class
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="series"></param>
        public ChartRangeBarSeriesBuilder(IChartRangeBarSeries series)
            : base((IChartBarSeries)series)
        {
            RangeBarSeries = series;
        }

        public IChartRangeBarSeries RangeBarSeries
        {
            get;
            private set;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override ChartBarSeriesBuilder<T> Stack(bool stacked)
        {
            return base.Stack(stacked);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override ChartBarSeriesBuilder<T> Stack(string stackGroup)
        {
            return base.Stack(stackGroup);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override ChartBarSeriesBuilder<T> Stack(ChartStackType stackType, string stackGroup = null)
        {
            return base.Stack(stackType, stackGroup);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override ChartBarSeriesBuilder<T> Aggregate(ChartSeriesAggregate aggregate)
        {
            return base.Aggregate(aggregate);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override ChartBarSeriesBuilder<T> Labels(Action<ChartBarLabelsBuilder> configurator)
        {
            return base.Labels(configurator);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override ChartBarSeriesBuilder<T> Labels(bool visible)
        {
            return base.Labels(visible);
        }

        public ChartRangeBarSeriesBuilder<T> Labels(Action<ChartRangeBarLabelsBuilder> configurator)
        {
            configurator(new ChartRangeBarLabelsBuilder(RangeBarSeries.RangeBarLabel));

            return this;
        }
    }
}
