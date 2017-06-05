using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lens {
  public static class Lenses {
    public static EqualsLens EqualsLens => new EqualsLens();
    public static IsNoneLens None => new IsNoneLens();
    public static CopyForwardLens CopyForward => new CopyForwardLens();
  }
}
