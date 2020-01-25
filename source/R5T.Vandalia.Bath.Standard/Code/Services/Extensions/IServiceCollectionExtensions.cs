using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Bath.Standard;


namespace R5T.Vandalia.Bath.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// See adds an <see cref="IValueEqualityComparer{T}"/> service for the <typeparamref name="TValue"/> type.
        /// </summary>
        public static IServiceCollection AddValueEqualityComparer<TValue, TValueEqualityComparer>(this IServiceCollection services)
            where TValueEqualityComparer: HumanOutputValueEqualityComparer<TValue>
        {
            services
                .AddSingleton<IValueEqualityComparer<TValue>, TValueEqualityComparer>()
                .AddHumanOutput()
                ;

            return services;
        }
    }
}
