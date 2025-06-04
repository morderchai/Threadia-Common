namespace Common.ValueObjects
{
    public class TagName : ValueObject
    {
        public string Value { get; }

        public TagName(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Tag name cannot be empty.");

            if (value.Length > 50)
                throw new ArgumentException("Tag name is too long.");

            Value = value.Trim().ToLowerInvariant();
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
