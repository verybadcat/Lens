using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LanguageExt;

namespace Lens {
  class NonDefaultPredicateLens : AssignPredicateLens {
    public NonDefaultPredicateLens(StringComparison compare): base(compare) { }
    public override Unit LensAnyType<T>(ref T x, ref Predicate<T> y) {
      var x_ = x;
      if (x_ != null && !(x_.Equals(default(T)))) {
        y = z => z.Equals(x_);
      }
      return Unit.Default;
    }
    public override Unit Lens(ref string x, ref Predicate<string> y) {
      var x_ = x;
      if (x_ != null) {
        y = z => z.Equals(x_, _stringCompare);
      }
      return Unit.Default;
    }
  }
}
