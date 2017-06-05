using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LanguageExt;

namespace Lens {
  public class EqualsLens : ILens<bool> {
    public bool Lens(ref int x, ref Option<int> y) => (x == y);
    public bool Lens(ref long x, ref Option<long> y) => (x == y);
    public bool Lens(ref short x, ref Option<short> y) => (x == y);
    public bool Lens(ref float x, ref Option<float> y) => (x == y);
    public bool Lens(ref double x, ref Option<double> y) => (x == y);
    public bool Lens(ref bool x, ref Option<bool> y) => (x == y);
    public bool Lens(ref string x, ref Option<string> y) => (x == y);
  }
}
