using ASMTP.Data;
using log4net.Config;
using log4net;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;
using ASMPT.Data.Contract;
using ASMPT.Data.Repository;
using ASMPT.Domain;
using ASMPT.ApplicationService.Contract;
using ASMPT.ApplicationService;
using Microsoft.AspNetCore.Hosting;
using ASMPT.Data;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DbModelContext>(c => c.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString")));



builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<IBorrowRepository, BorrowRepository>();
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IAuthorService, AuthorService>();
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<IBorrowService, BorrowService>();
builder.Services.AddScoped<IBookService, BookService>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddSingleton(typeof(log4net.ILog), log => log4net.LogManager.GetLogger(typeof(Program)));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularOrigins",
    builder =>
    {
        builder.WithOrigins(
                            "http://localhost:4200"
                            )
                            .AllowAnyHeader()
                            .AllowAnyMethod();
    });
});

builder.Services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);

//builder.Services.Configure<JsonOptions>(o => o.SerializerOptions.Converters.Add(new JsonStringEnumConverter()));

//builder.Services.AddControllers()
//      .AddJsonOptions(options =>
//      {
//          options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
//      });

var log4netRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
XmlConfigurator.Configure(log4netRepository, new FileInfo("log4net.config"));
builder.Logging.AddLog4Net();
var app = builder.Build();
// Configure the HTTP request pipeline.
app.UseDeveloperExceptionPage();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
//    app.UseSwaggerUI(c => {

//        c.SwaggerEndpoint("/ swagger / v1 / swagger.json", "Testing API V1");
//});
}




builder.Services.AddCors();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
