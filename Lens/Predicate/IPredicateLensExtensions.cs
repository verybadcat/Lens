using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lens {
  public static class IPredicateLensExtensions {
    public static T Lens<T>(this IPredicateLens<T> lens, int value, ref Predicate<int> predicate)
      => lens.Lens(ref value, ref predicate);
    public static T Lens<T>(this IPredicateLens<T> lens, short value, ref Predicate<short> predicate)
      => lens.Lens(ref value, ref predicate);
    public static T Lens<T>(this IPredicateLens<T> lens, long value, ref Predicate<long> predicate)
      => lens.Lens(ref value, ref predicate);
    public static T Lens<T>(this IPredicateLens<T> lens, float value, ref Predicate<float> predicate)
      => lens.Lens(ref value, ref predicate);
    public static T Lens<T>(this IPredicateLens<T> lens, double value, ref Predicate<double> predicate)
      => lens.Lens(ref value, ref predicate);
    public static T Lens<T>(this IPredicateLens<T> lens, bool value, ref Predicate<bool> predicate)
      => lens.Lens(ref value, ref predicate);
    public static T Lens<T>(this IPredicateLens<T> lens, string value, ref Predicate<string> predicate)
     => lens.Lens(ref value, ref predicate);
    public static T Lens<T>(this IPredicateLens<T> lens, ref int value, Predicate<int> predicate)
  => lens.Lens(ref value, ref predicate);
    public static T Lens<T>(this IPredicateLens<T> lens, ref short value, Predicate<short> predicate)
      => lens.Lens(ref value, ref predicate);
    public static T Lens<T>(this IPredicateLens<T> lens, ref long value, Predicate<long> predicate)
      => lens.Lens(ref value, ref predicate);
    public static T Lens<T>(this IPredicateLens<T> lens, ref float value, Predicate<float> predicate)
      => lens.Lens(ref value, ref predicate);
    public static T Lens<T>(this IPredicateLens<T> lens, ref double value, Predicate<double> predicate)
      => lens.Lens(ref value, ref predicate);
    public static T Lens<T>(this IPredicateLens<T> lens, ref bool value, Predicate<bool> predicate)
      => lens.Lens(ref value, ref predicate);
    public static T Lens<T>(this IPredicateLens<T> lens, ref string value, Predicate<string> predicate)
     => lens.Lens(ref value, ref predicate);
  }
}
