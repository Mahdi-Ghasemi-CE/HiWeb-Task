using System.Net;
using HiWeb_Task.Application.Utils;
using Microsoft.AspNetCore.Mvc;

namespace HiWeb_Task.API.Extensions;

public static class ControllerExtension
{
    public static IActionResult ReturnResponse(this ControllerBase controller, OperationResult operation)
    {
        object response = operation.Value;

        return operation.Status switch
        {
            HttpStatusCode.OK => controller.Ok(response),
            HttpStatusCode.NotAcceptable => controller.BadRequest(response),
            HttpStatusCode.NotFound => controller.NotFound(response),
            _ => controller.UnprocessableEntity(response)
        };
    }
}