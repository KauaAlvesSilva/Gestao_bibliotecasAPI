using Application.Interfaces;
using Application.Services;
using Infra.DBContext;
using Microsoft.EntityFrameworkCore;


    var builder = WebApplication.CreateBuilder(args);

    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

    //Builder das services
    builder.Services.AddScoped<IEmprestimoService, EmprestimoService>();
    builder.Services.AddScoped<ILivroService, LivroService>();

    var app = builder.Build();

    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();

    app.Run();
