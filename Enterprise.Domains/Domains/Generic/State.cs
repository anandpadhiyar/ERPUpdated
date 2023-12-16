namespace Enterprise.Domains.Domains.Generic;

public sealed class State
{
    private State(Guid stateId, string stateTitle, Country country)
    {
        StateId = stateId;
        StateTitle = stateTitle;
        Country = country;
    }
    public Guid StateId { get; }
    public string StateTitle { get; }
    public Country Country { get; }

    public static State Create(Guid stateId, string stateTitle, Country country)
    {
        return new State(stateId, stateTitle, country);
    }
}