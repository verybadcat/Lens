using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LanguageExt;

namespace Lens {
  public interface ILens<TOutput> {
    TOutput Lens(ref int x, ref Option<int> y);
    TOutput Lens(ref long x, ref Option<long> y);
    TOutput Lens(ref float x, ref Option<float> y);
    TOutput Lens(ref double x, ref Option<double> y);
    TOutput Lens(ref string x, ref Option<string> y);
    TOutput Lens(ref bool x, ref Option<bool> y);
    TOutput Lens(ref short x, ref Option<short> y);
  }
}
