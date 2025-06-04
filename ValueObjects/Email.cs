namespace Common.ValueObjects
{
    public class Email : ValueObject
    {
        public string Address { get; }

        public Email(string address)
        {
            if (string.IsNullOrWhiteSpace(address) || !address.Contains("@"))
                throw new ArgumentException("Invalid email address.");

            Address = address.Trim().ToLowerInvariant();
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Address;
        }
    }
}
