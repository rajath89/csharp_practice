using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;


namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class TestController : ControllerBase
{
    private readonly TransientService _transientService;

    private readonly TransientService _transientService2;
    private readonly ScopedService _scopedService;

    private readonly ScopedService _scopedService2;
    private readonly SingletonService _singletonService;

    private readonly SingletonService _singletonService2;

    private readonly MyExpensiveService _myExpensiveService;

    public TestController(TransientService transientService, TransientService transientService2,ScopedService scopedService,ScopedService scopedService2, SingletonService singletonService, SingletonService singletonService2, MyExpensiveService expensiveService)
    {
        _transientService = transientService;
        _scopedService = scopedService;
        _singletonService = singletonService;
        _transientService2 = transientService2;
        _singletonService2 = singletonService2;
        _scopedService2 = scopedService2;
        _myExpensiveService = expensiveService;
    }

    [HttpGet(Name = "GetLifetimes")]
    public JsonResult GetLifetimes()
    {
        _myExpensiveService.DoSomethingThatNeedsExpensiveWork();

        var dt = new Dictionary<string,string>()
        {
            { "Singleton GUID1", _singletonService.Serve() },
            {  "Singleton GUID2", _singletonService2.Serve() },
            { "Transient GUID1", _transientService.Serve() },
            { "Transient GUID2", _transientService2.Serve() },
            { "Scoped GUID1", _scopedService.Serve() },
            { "Scoped GUID2", _scopedService2.Serve() }
        };
 
        return new JsonResult(dt);
    }

}
