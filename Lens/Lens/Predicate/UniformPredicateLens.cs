using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lens {
  public abstract class UniformPredicateLens<T>: IPredicateLens<T> {
    public T Lens(ref int x, ref Predicate<int> y) => LensAnyType(ref x, ref y);
    public T Lens(ref long x, ref Predicate<long> y) => LensAnyType(ref x, ref y);
    public T Lens(ref float x, ref Predicate<float> y) => LensAnyType(ref x, ref y);
    public T Lens(ref double x, ref Predicate<double> y) => LensAnyType(ref x, ref y);
    public virtual T Lens(ref string x, ref Predicate<string> y) => LensAnyType(ref x, ref y);
    public T Lens(ref bool x, ref Predicate<bool> y) => LensAnyType(ref x, ref y);
    public T Lens(ref short x, ref Predicate<short> y) => LensAnyType(ref x, ref y);
    public abstract T LensAnyType<Q>(ref Q q, ref Predicate<Q> predicate)
      where Q : IEquatable<Q>;
  }
}
