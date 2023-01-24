using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using WEBAPI.Controllers;
using WEBAPI.Middleware;
using WEBAPI.PERSISTANCE;
using WEBAPI.SERVICES;
using WEBAPI.SERVICES.Interfaces;
using static System.Net.Mime.MediaTypeNames;


var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IDesignationServices, DesignationServices>();
builder.Services.AddScoped<ICustomerProjectServices, CustomerProjectServices>();
builder.Services.AddScoped<IDayTypeServices, DayTypeServices>();
builder.Services.AddScoped<IEmployeeServices, EmployeeServices>();
builder.Services.AddScoped<ISkillTypeServices, SkillTypeServices>();
builder.Services.AddScoped<IProjectAllocationServices, ProjectAllocationServices>();
builder.Services.AddScoped<IActiveCarderService, ActiveCarderService>();


builder.Services.AddDbContext<DataAccess>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("connString"));
});





var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}

app.UseMiddleware<ErrorHandlingMiddleware>();
//else
//{
//    app.UseExceptionHandler(exceptionHandlerApp =>
//  {
//      exceptionHandlerApp.Run(async context =>
//      {
//          context.Response.StatusCode = StatusCodes.Status500InternalServerError;

//          // using static System.Net.Mime.MediaTypeNames;
//          context.Response.ContentType = Text.Plain;

//          await context.Response.WriteAsync("An exception was thrown.");

//          var exceptionHandlerPathFeature =
//              context.Features.Get<IExceptionHandlerPathFeature>();

//          if (exceptionHandlerPathFeature?.Error is FileNotFoundException)
//          {
//              await context.Response.WriteAsync(" The file was not found.");
//          }

//          if (exceptionHandlerPathFeature?.Path == "/")
//          {
//              await context.Response.WriteAsync(" Page: Home.");
//          }
//      });
//  });

//app.UseHsts();
//}




app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
