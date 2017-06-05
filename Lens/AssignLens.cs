using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LanguageExt;
using TOutput = LanguageExt.Unit;

namespace Lens {

  public class CopyForwardLens : ILens<TOutput> {
    public TOutput Lens(ref int x, ref Option<int> y) {
      y = x;
      return TOutput.Default;
    }
    public TOutput Lens(ref long x, ref Option<long> y) {
      y = x;
      return TOutput.Default;
    }
    public TOutput Lens(ref short x, ref Option<short> y) {
      y = x;
      return TOutput.Default;
    }
    public TOutput Lens(ref float x, ref Option<float> y) {
      y = x;
      return TOutput.Default;
    }
    public TOutput Lens(ref double x, ref Option<double> y) {
      y = x;
      return TOutput.Default;
    }
    public TOutput Lens(ref bool x, ref Option<bool> y) {
      y = x;
      return TOutput.Default;
    }
    public TOutput Lens(ref string x, ref Option<string> y) {
      if (x !=null) {
        y = x;
      }
      return TOutput.Default;
    }
  }
}
