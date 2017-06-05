using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LanguageExt;

namespace Lens {
  public static class LensExtensions {
    public static T Lens<T>(this ILens<T> lens, int x, ref Option<int> y) => lens.Lens(ref x, ref y);
    public static T Lens<T>(this ILens<T> lens, long x, ref Option<long> y) => lens.Lens(ref x, ref y);
    public static T Lens<T>(this ILens<T> lens, short x, ref Option<short> y) => lens.Lens(ref x, ref y);
    public static T Lens<T>(this ILens<T> lens, float x, ref Option<float> y) => lens.Lens(ref x, ref y);
    public static T Lens<T>(this ILens<T> lens, double x, ref Option<double> y) => lens.Lens(ref x, ref y);
    public static T Lens<T>(this ILens<T> lens, string x, ref Option<string> y) => lens.Lens(ref x, ref y);
    public static T Lens<T>(this ILens<T> lens, bool x, ref Option<bool> y) => lens.Lens(ref x, ref y);

    public static T Lens<T>(this ILens<T> lens, int x, Option<int> y) => lens.Lens(ref x, ref y);
    public static T Lens<T>(this ILens<T> lens, long x, Option<long> y) => lens.Lens(ref x, ref y);
    public static T Lens<T>(this ILens<T> lens, short x, Option<short> y) => lens.Lens(ref x, ref y);
    public static T Lens<T>(this ILens<T> lens, float x, Option<float> y) => lens.Lens(ref x, ref y);
    public static T Lens<T>(this ILens<T> lens, double x, Option<double> y) => lens.Lens(ref x, ref y);
    public static T Lens<T>(this ILens<T> lens, string x, Option<string> y) => lens.Lens(ref x, ref y);
    public static T Lens<T>(this ILens<T> lens, bool x, Option<bool> y) => lens.Lens(ref x, ref y);
    public static T Lens<T>(this ILens<T> lens, ref int x, Option<int> y) => lens.Lens(ref x, ref y);
    public static T Lens<T>(this ILens<T> lens, ref long x, Option<long> y) => lens.Lens(ref x, ref y);
    public static T Lens<T>(this ILens<T> lens, ref short x, Option<short> y) => lens.Lens(ref x, ref y);
    public static T Lens<T>(this ILens<T> lens, ref float x, Option<float> y) => lens.Lens(ref x, ref y);
    public static T Lens<T>(this ILens<T> lens, ref double x, Option<double> y) => lens.Lens(ref x, ref y);
    public static T Lens<T>(this ILens<T> lens, ref string x, Option<string> y) => lens.Lens(ref x, ref y);
    public static T Lens<T>(this ILens<T> lens, ref bool x, Option<bool> y) => lens.Lens(ref x, ref y);
  }
}
