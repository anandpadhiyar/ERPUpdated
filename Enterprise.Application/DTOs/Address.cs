namespace Enterprise.Application.DTOs;

public record Address(int AddressId, string Line1, string? Line2, string City, string State, long Zipcode );