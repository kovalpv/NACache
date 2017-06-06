using System;

namespace NACache
{
    /// <summary>
    /// Интерфайс для кешированного значания
    /// </summary>
    public interface ICache<T>
    {
        /// <summary>
        /// Время действия значения
        /// </summary>
        TimeSpan TimeValid { get; set; }

        /// <summary>
        /// Время до которого объекты действительны 
        /// </summary>
        DateTime UntilTimeValid { get; }

        /// <summary>
        /// Действителен ли кеш на текущий момент
        /// </summary>
        bool IsValid { get; }

        /// <summary>
        /// Значение кеша
        /// </summary>
        T Value { get; set; }

        /// <summary>
        /// Сбросить кеш
        /// </summary>
        void Reset();
    }
}
