namespace Enterprise.Domains.Domains.Generic;

public sealed class Country
{
    private Country(Guid countryId, string countryName)
    {
        CountryId = countryId;
        CountryName = countryName;
    }
    public Guid CountryId { get; }
    public string CountryName { get; }

    public static Country Create(Guid countryId, string countryName)
    {
        return new Country(countryId, countryName);
    }
}