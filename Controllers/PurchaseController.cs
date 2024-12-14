using Domain.Models;
using Infrastructure.ApiResponse;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;

[ApiController]
[Route("[controller]")]

public class PurchaseController(IPurchaseService purchaseService):ControllerBase
{
    [HttpGet]
    public Response<List<Purchase>> GetAll()
    {
        var response = purchaseService.GetAllPurchases();
        return response;
    }
    [HttpPost("{id:int}")]
    public Response<Purchase> GetCustomerById(int id)
    {
        var response = purchaseService.GetPurchaseById(id);
        return response;
    }

    [HttpPost]
    public Response<bool> Create(Purchase purchase)
    {
        var response = purchaseService.CreatePurchase(purchase);
        return response;
    }

    [HttpPut]
    public Response<bool> Update(Purchase purchase)
    {
        var response = purchaseService.UpdatePurchase(purchase);
        return response;
    }

    [HttpDelete]
    public Response<bool> Delete(int id)
    {
        var response = purchaseService.DeletePurchase(id);
        return response;
    }
}