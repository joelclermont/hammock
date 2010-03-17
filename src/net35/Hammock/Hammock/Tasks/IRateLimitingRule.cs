using System;

namespace Hammock.Tasks
{
    public interface IRateLimitingRule<T>
    {
        double? LimitToPercentOfTotal { get; }
        RateLimitType RateLimitType { get; }
        Func<T> GetRateLimitStatus { get; set; }
        Predicate<T> RateLimitPredicate { get; }
    }
}