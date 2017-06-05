using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lens {
  public static class CompoundLenses {
    public static CompoundLens<bool> Or(ILens<bool> l1, ILens<bool> l2) =>
      new CompoundLens<bool>(l1, l2, (x, y) => x || y);

    public static CompoundLens<bool> EqualsOrNone =>
      Or(Lenses.EqualsLens, Lenses.None);
  }
}
