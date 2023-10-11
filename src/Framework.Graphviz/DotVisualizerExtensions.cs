using System;

namespace Framework.Graphviz
{
    public static class DotVisualizerExtensions
    {
        public static IDotVisualizer<TNewInput> OverrideInput<TOldInput, TNewInput>(this IDotVisualizer<TOldInput> visualizer, Func<TNewInput, TOldInput> selector)
        {
            if (visualizer == null) throw new ArgumentNullException(nameof(visualizer));
            if (selector == null) throw new ArgumentNullException(nameof(selector));

            return new FuncDotVisualizer<TNewInput>((input, format) => visualizer.Render(selector(input), format));
        }

        private class FuncDotVisualizer<TNewInput> : IDotVisualizer<TNewInput>
        {
            private readonly Func<TNewInput, GraphvizFormat, byte[]> _func;


            public FuncDotVisualizer(Func<TNewInput, GraphvizFormat, byte[]> func)
            {
                this._func = func ?? throw new ArgumentNullException(nameof(func));
            }

            public byte[] Render(TNewInput dot, GraphvizFormat format)
            {
                return this._func(dot, format);
            }
        }
    }
}
