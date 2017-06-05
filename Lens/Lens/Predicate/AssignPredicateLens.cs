using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LanguageExt;

namespace Lens {
  public class AssignPredicateLens : UniformPredicateLens<LanguageExt.Unit> {
    protected readonly StringComparison _stringCompare;

    public AssignPredicateLens(StringComparison compare) {
      _stringCompare = compare;
    }
    public override Unit LensAnyType<T>(ref T x, ref Predicate<T> y) { 
      var x_ = x;
      y = z => Equals(z, x_);
      return Unit.Default;
    }
    public override Unit Lens(ref string x, ref Predicate<string> y) {
      var x_ = x;
      y = z => (z == null && x_ == null || z.Equals(x_, _stringCompare));
      return Unit.Default;
    }
  }
}
