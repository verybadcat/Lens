using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LanguageExt;

namespace Lens {
  public class CompoundLens<TOutput>: ILens<TOutput> {
    public CompoundLens(ILens<TOutput> lens1, ILens<TOutput> lens2, Func<TOutput, TOutput, TOutput> combine) {
      Lens1 = lens1;
      Lens2 = lens2;
      CombineOutputs = combine;
    }
    private ILens<TOutput> Lens1 { get; set; }
    private ILens<TOutput> Lens2 { get; set; }
    private Func<TOutput, TOutput, TOutput> CombineOutputs { get; set; }

    public TOutput Lens(ref int x, ref Option<int> y) {
      TOutput out1 = Lens1.Lens(ref x, ref y);
      TOutput out2 = Lens2.Lens(ref x, ref y);
      TOutput r = CombineOutputs(out1, out2);
      return r;
    }
    public TOutput Lens(ref long x, ref Option<long> y) {
      TOutput out1 = Lens1.Lens(ref x, ref y);
      TOutput out2 = Lens2.Lens(ref x, ref y);
      TOutput r = CombineOutputs(out1, out2);
      return r;
    }
    public TOutput Lens(ref short x, ref Option<short> y) {
      TOutput out1 = Lens1.Lens(ref x, ref y);
      TOutput out2 = Lens2.Lens(ref x, ref y);
      TOutput r = CombineOutputs(out1, out2);
      return r;
    }
    public TOutput Lens(ref bool x, ref Option<bool> y) {
      TOutput out1 = Lens1.Lens(ref x, ref y);
      TOutput out2 = Lens2.Lens(ref x, ref y);
      TOutput r = CombineOutputs(out1, out2);
      return r;
    }

    public TOutput Lens(ref double x, ref Option<double> y) {
      TOutput out1 = Lens1.Lens(ref x, ref y);
      TOutput out2 = Lens2.Lens(ref x, ref y);
      TOutput r = CombineOutputs(out1, out2);
      return r;
    }

    public TOutput Lens(ref float x, ref Option<float> y) {
      TOutput out1 = Lens1.Lens(ref x, ref y);
      TOutput out2 = Lens2.Lens(ref x, ref y);
      TOutput r = CombineOutputs(out1, out2);
      return r;
    }

    public TOutput Lens(ref string x, ref Option<string> y) {
      TOutput out1 = Lens1.Lens(ref x, ref y);
      TOutput out2 = Lens2.Lens(ref x, ref y);
      TOutput r = CombineOutputs(out1, out2);
      return r;
    }
  }
}
