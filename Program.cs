using FinanseaAPI.Context;
using FinanseaAPI.Model;
using FinanseaAPI.Repository;
using FinanseaAPI.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<FinanseaContext>(options => options.UseOracle(configuration.GetConnectionString("OracleConnection")));

builder.Services.AddScoped<Repository<Donation>>();
builder.Services.AddScoped<Repository<Project>>();
builder.Services.AddScoped<Repository<Ong>>();
builder.Services.AddScoped<Repository<Financier>>();
builder.Services.AddScoped<Repository<Publication>>();
builder.Services.AddScoped<Repository<BankAccount>>();

builder.Services.AddScoped<DonationService>();
builder.Services.AddScoped<ProjectService>();
builder.Services.AddScoped<OngService>();
builder.Services.AddScoped<FinancierService>();
builder.Services.AddScoped<PublicationService>();
builder.Services.AddScoped<BankAccountService>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();
app.Run();