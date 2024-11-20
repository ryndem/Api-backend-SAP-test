using Core.VentaDigitalPQF.ExceptionHandler;
using Core.VentaDigitalPQF.Messages.Dto.General;
using Core.VentaDigitalPQF.Messages.Interfaces;
using Logic.VentaDigitalPQF.AutoMapper;
using Logic.VentaDigitalPQF.Interfaces;
using Logic.VentaDigitalPQF.Interfaces.Address;
using Logic.VentaDigitalPQF.Interfaces.IdentityServer;
using Logic.VentaDigitalPQF.Interfaces.Order;
using Logic.VentaDigitalPQF.Interfaces.Product;
using Logic.VentaDigitalPQF.Interfaces.PurchaseOrder;
using Logic.VentaDigitalPQF.Interfaces.Quotation;
using Logic.VentaDigitalPQF.Interfaces.SuggestedContact;
using Logic.VentaDigitalPQF.Interfaces.User;
using Logic.VentaDigitalPQF.Interfaces.UserRegistration;
using Logic.VentaDigitalPQF.Services;
using Logic.VentaDigitalPQF.Services.Address;
using Logic.VentaDigitalPQF.Services.IdentityServer;
using Logic.VentaDigitalPQF.Services.Order;
using Logic.VentaDigitalPQF.Services.Product;
using Logic.VentaDigitalPQF.Services.PurchaseOrder;
using Logic.VentaDigitalPQF.Services.Quotation;
using Logic.VentaDigitalPQF.Services.SuggestedContact;
using Logic.VentaDigitalPQF.Services.User;
using Logic.VentaDigitalPQF.Services.UserRegistration;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Proxy.ProquifaDotNet;
using Proxy.ProquifaDotNet.Interfaces;
using Proxy.ProquifaDotNet.Proxy;
using Proxy.ProquifaDotNet.Services;
using Proxy.ProquifaDotNet.Services.Interfaces.Direccion;
using Proxy.ProquifaDotNet.Services.Service;
using System.Net.Security;
using System.Security.Authentication;
using VentaDigitalPQF.ExceptionHandler;

var builder = WebApplication.CreateBuilder(args);

AppConfiguration appConfiguration = new AppConfiguration();
var config = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json")
                 .Build();

var handler = new HttpClientHandler();

handler.ClientCertificateOptions = ClientCertificateOption.Automatic;
handler.SslProtocols = SslProtocols.Tls12;//SslProtocols.Tls12;

//handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;//(message, cert, chain, errors) => true;
//handler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
handler.ServerCertificateCustomValidationCallback = (message, cert, chain, sslPolicyErrors) =>
{
    Console.WriteLine($"Requested URI: {message.RequestUri}");
    Console.WriteLine($"Effective date: {cert?.GetEffectiveDateString()}");
    Console.WriteLine($"Exp date: {cert?.GetExpirationDateString()}");
    Console.WriteLine($"Issuer: {cert?.Issuer}");
    Console.WriteLine($"Subject: {cert?.Subject}");

    // Based on the custom logic it is possible to decide whether the client considers certificate valid or not
    Console.WriteLine($"Errors: {sslPolicyErrors}");

    if (sslPolicyErrors == SslPolicyErrors.None)
    {
        return true;   //Is valid
    }
    return true;
};

builder.Services
    .AddAuthentication(options =>
    {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(options =>
    {
        options.Authority = config["IdentityServer:Url"];
        options.RequireHttpsMetadata = false;
        options.TokenValidationParameters.ValidAudiences = new List<string>() { "default" };
        options.BackchannelHttpHandler = handler;
    });

builder.Services.AddSingleton(new ApiProquifaDotNetCatalogoUrl("" + config["ApiProquifaDotNetCatalogoUrl"]));
builder.Services.AddSingleton( new ApiProquifaDotNetLogisticaUrl( "" + config["ApiProquifaDotNetLogisticaUrl"] ) );
builder.Services.AddSingleton( new ApiProquifaDotNetFinanzasUrl( "" + config["ApiProquifaDotNetFinanzasUrl"] ) );
builder.Services.AddSingleton(new TokenAsynProquifaDotNet());//config



// Add services to the container.
builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<IProductCustomerService, ProductCustomerService>();
builder.Services.AddTransient<IProductWebService, ProductWebService>();

builder.Services.AddTransient<ISuggestedContactService, SuggestedContactService>();
builder.Services.AddTransient<IUserRegistrationService, UserRegistrationService>();
builder.Services.AddTransient<ISuggestedContactProviderService, SuggestedContactProviderService>();
builder.Services.AddTransient<IUserValidatorService, UserValidatorService>();
builder.Services.AddTransient<IAddressServices, AddressService>();
builder.Services.AddTransient<IQuotationService, QuotationService>();
builder.Services.AddTransient<IPurchaseOrderService, PurchaseOrderService>();
builder.Services.AddTransient<IOrderService, OrderService>();
builder.Services.AddTransient<IModelMessage, ModelMessage>();
builder.Services.AddTransient<ITwoFactorService,TwoFactorService>();
builder.Services.AddTransient<IIdentityServerAccessManager, IdentityServerAccessManagerService>(
    provider =>
    {
        return new IdentityServerAccessManagerService(
            config["IdentityServer:CliendId"],
            config["IdentityServer:GrantType"],
            config["IdentityServer:ClientAllowedScopes"],
            config["IdentityServer:Url"]);
    });
builder.Services.AddTransient<IVentaDigitalAccessManager, VentaDigitalAccessManagerService>();

builder.Services.AddTransient<IUserService, UserService>();

builder.Services.AddHttpClient<IApiCallerProxy, ApiCallerProxy>();
builder.Services.AddTransient<IOfertaProductoProxy, OfertaProductoProxy>();
builder.Services.AddTransient<IProductoProxy, ProductoProxy>();
builder.Services.AddTransient<IDireccionProxy, DireccionProxy>();
//builder.Services.AddAutoMapper( typeof( AutoMapping ) );
builder.Services.AddAutoMapperService();


builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


/* Autentificacion */


var app = builder.Build();

app.UseExceptionHandler( opt => { } );

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    
}
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
