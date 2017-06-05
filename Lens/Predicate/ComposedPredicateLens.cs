using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lens.Predicate {
  public class ComposedPredicateLens<TMid, TOutput>: IPredicateLens<TOutput> {
    private readonly IPredicateLens<TMid> _Inner;
    private readonly Func<TMid, TOutput> _AfterInner;

    public ComposedPredicateLens(IPredicateLens<TMid> inner, Func<TMid, TOutput> afterInner) {
      _Inner = inner;
      _AfterInner = afterInner;
    }

    public TOutput Lens(ref int x, ref Predicate<int> y)
      => _AfterInner(_Inner.Lens(ref x, ref y));
    public TOutput Lens(ref long x, ref Predicate<long> y)
      => _AfterInner(_Inner.Lens(ref x, ref y));
    public TOutput Lens(ref float x, ref Predicate<float> y)
      => _AfterInner(_Inner.Lens(ref x, ref y));
    public TOutput Lens(ref double x, ref Predicate<double> y)
      => _AfterInner(_Inner.Lens(ref x, ref y));
    public TOutput Lens(ref string x, ref Predicate<string> y)
      => _AfterInner(_Inner.Lens(ref x, ref y));
    public TOutput Lens(ref bool x, ref Predicate<bool> y)
      => _AfterInner(_Inner.Lens(ref x, ref y));
    public TOutput Lens(ref short x, ref Predicate<short> y)
      => _AfterInner(_Inner.Lens(ref x, ref y));
  }
}
