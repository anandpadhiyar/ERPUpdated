namespace Enterprise.Domains.Domains.Generic;

public sealed class Address
{
    private Address(int addressId, string line1, string? line2, string city, State state, long zipcode)
    {
        AddressId = addressId;
        Line1 = line1;
        Line2 = line2;
        City = city;
        State = state;
        Zipcode = zipcode;
    }
    public int AddressId { get; }
    public string Line1 { get; }
    public string? Line2 { get; }
    public string City { get; }
    public State State { get; }
    public long Zipcode { get; }

    public static Address Create(int addressId, string line1, string? line2, string city, State state, long zipcode)
    {
        return new Address(addressId, line1, line2, city, state, zipcode);
    }
}