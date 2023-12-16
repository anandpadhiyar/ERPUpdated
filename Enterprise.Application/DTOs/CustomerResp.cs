namespace Enterprise.Application.DTOs;

public record CustomerResp(int CustomerId, string CustomerName, Address Address, decimal Credit);