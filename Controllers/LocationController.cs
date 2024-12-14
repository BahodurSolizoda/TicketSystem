using Domain.Models;
using Infrastructure.ApiResponse;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;

[ApiController]
[Route("[controller]")]

public class LocationController(ILocationService locationService):ControllerBase
{
    [HttpGet]
    public Response<List<Location>> GetAll()
    {
        var response = locationService.GetAllLocations();
        return response;
    }
    [HttpPost("{id:int}")]
    public Response<Location> GetCustomerById(int id)
    {
        var response = locationService.GetLocationById(id);
        return response;
    }

    [HttpPost]
    public Response<bool> Create(Location location)
    {
        var response = locationService.CreateLocation(location);
        return response;
    }

    [HttpPut]
    public Response<bool> Update(Location location)
    {
        var response = locationService.UpdateLocation(location);
        return response;
    }

    [HttpDelete]
    public Response<bool> Delete(int id)
    {
        var response = locationService.DeleteLocation(id);
        return response;
    }
}
