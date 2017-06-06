using System;

namespace NACache
{
    public class Cache<T> : ICache<T>
    {
        private TimeSpan _timeValid;
        private T _value;

        public bool IsValid { get { return UntilTimeValid >= DateTime.Now; } }

        public TimeSpan TimeValid
        {
            get { return _timeValid; }
            set
            {
                if (_timeValid == value)
                {
                    return;
                }
                if (!IsValid)
                {
                    Reset();
                }
                _timeValid = value;
            }
        }

        public DateTime UntilTimeValid { get; protected set; }

        public T Value
        {
            get { return _value; }
            set
            {
                if (Equals(_value, value))
                    return;
                _value = value;
                UntilTimeValid = DateTime.Now.Add(TimeValid);
            }
        }

        public void Reset()
        {
            _value = default(T);
            UntilTimeValid = DateTime.MinValue;
        }
    }
}
