namespace Common.ValueObjects
{
    public class DateCreated : ValueObject
    {
        public DateTime Value { get; }

        public DateCreated(DateTime value)
        {
            if (value > DateTime.UtcNow)
                throw new ArgumentException("Creation date cannot be in the future.");

            Value = value;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
