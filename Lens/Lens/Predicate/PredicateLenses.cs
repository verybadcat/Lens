using System;
namespace Lens {
  public static class PredicateLenses {
    public static IPredicateLens<LanguageExt.Unit> AssignPredicate(StringComparison compare) =>
      new AssignPredicateLens(compare);
    public static IPredicateLens<bool> InvokePredicate =>
      new InvokePredicateLens();
    public static IPredicateLens<LanguageExt.Unit> AssignPredicateUnlessDefault(StringComparison compare) =>
      new NonDefaultPredicateLens(compare);
  }
}
