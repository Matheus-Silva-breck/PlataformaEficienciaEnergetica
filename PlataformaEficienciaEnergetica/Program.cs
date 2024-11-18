using Microsoft.EntityFrameworkCore;
using PlataformaEficienciaEnergetica.Data;
using PlataformaEficienciaEnergetica.Repositories;
using System;

var builder = WebApplication.CreateBuilder(args);

// Adicionando o contexto do banco de dados
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseOracle(builder.Configuration.GetConnectionString("DefaultConnection")));

// Adicionando o servi�o do reposit�rio como inje��o de depend�ncia
builder.Services.AddScoped<IPredioRepository, PredioRepository>();

// Configura��es do MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configura��o do pipeline HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
