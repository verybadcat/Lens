using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lens
{
  public interface IPredicateLens<TOutput> {
    TOutput Lens(ref int x, ref Predicate<int> y);
    TOutput Lens(ref long x, ref Predicate<long> y);
    TOutput Lens(ref float x, ref Predicate<float> y);
    TOutput Lens(ref double x, ref Predicate<double> y);
    TOutput Lens(ref string x, ref Predicate<string> y);
    TOutput Lens(ref bool x, ref Predicate<bool> y);
    TOutput Lens(ref short x, ref Predicate<short> y);
  }
}
