using System.Reflection;
using API.Manual_CQRS.Commands.Requests;
using API.Manual_CQRS.Handlers.Commands;
using API.Manual_CQRS.Handlers.Queries;
using API.Modals;
using MediatR;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Manual CQRS

builder.Services.AddSingleton<CreateProductCommandHandler>();
builder.Services.AddSingleton<DeleteProductCommandHandler>();
builder.Services.AddSingleton<GetAllProductQueryHandler>();
builder.Services.AddSingleton<GetByIdProductQueryHandler>();

#endregion

#region Mediatr-CQRS
builder.Services.AddMediatR(opt => opt.RegisterServicesFromAssembly(typeof(ApplicationDbContext).Assembly));
#endregion

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();