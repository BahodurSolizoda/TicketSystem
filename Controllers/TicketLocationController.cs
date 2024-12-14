using Domain.Models;
using Infrastructure.ApiResponse;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;

public class TicketLocationController(ITicketLocationService ticketLocationService):ControllerBase
{
    [HttpGet]
    public Response<List<TicketLocation>> GetAll()
    {
        var response = ticketLocationService.GetAllTicketLocations();
        return response;
    }
    [HttpPost("{id:int}")]
    public Response<TicketLocation> GetTicketById(int id)
    {
        var response = ticketLocationService.GetTicketLocationById(id);
        return response;
    }

    [HttpPost]
    public Response<bool> Create(TicketLocation ticketLocation)
    {
        var response = ticketLocationService.CreateTicketLocation(ticketLocation);
        return response;
    }

    [HttpPut]
    public Response<bool> Update(TicketLocation ticketLocation)
    {
        var response = ticketLocationService.UpdateTicketLocation(ticketLocation);
        return response;
    }

    [HttpDelete]
    public Response<bool> Delete(int id)
    {
        var response = ticketLocationService.DeleteTicketLocation(id);
        return response;
    }
}