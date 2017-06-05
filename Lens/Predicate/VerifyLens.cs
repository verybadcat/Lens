using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lens {
  public class InvokePredicateLens : UniformPredicateLens<bool> {
    public override bool LensAnyType<T>(ref T x, ref Predicate<T> y) => y(x);

  }
}
