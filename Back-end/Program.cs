using Back_end.Authorization;
using Back_end.Entities;
using Back_end.Helper;
using Back_end.Models;
using Back_end.Respository;
using Back_end.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Configuration;
using System.Text.Json.Serialization;
using static System.Net.Mime.MediaTypeNames;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddMvcCore();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers().AddJsonOptions(x =>
{
    // serialize enums as strings in api responses (e.g. Role)
    x.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    x.JsonSerializerOptions.AllowTrailingCommas = true;
});


var service = builder.Services;
service.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});


service.AddDbContext<ParkingDbContext>(
    options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
            o=>o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery));

    }

);

service.AddTransient<IEmailSender, EmailSender>();

// Đăng ký các tùy chọn cấu hình của EmailSender
service.Configure<EmailSenderOptions>(builder.Configuration.GetSection("SendGrid"));


service.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));
service.Configure<CloudarySettings>(builder.Configuration.GetSection("CloudarySettings"));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


service.AddTransient<IJwtUtils, JwtUtils>();
service.AddTransient<IUserRespository, UserRespository>();
service.AddTransient<ICRUDSRespository<CarModel,CarModelx2>, CarModelRespository>();
service.AddTransient<IParkingRespository,ParkingRespository>();
service.AddTransient<ICarRepository, CarRepository>();
service.AddTransient<ISlotRepository, SlotRepository>();
service.AddTransient<IRequestRepository, RequestRepository>();
service.AddTransient<IImageRepository, ImageRepository>();
service.AddTransient<IEmailSender, EmailSender>();

service.AddTransient<IFeedBackReposiotory , FeedBackReposiotory>();
/*service.AddTransient<ICRUDSRespository<Image, ImageModel>, ImageRepository>();
*/
service.AddTransient<IVnPayService, VnPayService>();
service.AddTransient<IMembershipPackageRespository, MembershipPackageRespository>();
service.AddTransient <IParkingDetailRepository,ParkingDetailRepository>();


service.AddTransient<IImageService, ImageService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

//builder.Services.AddSwaggerGen();

builder.Services.AddSwaggerGen(option =>
{
    option.SwaggerDoc("v1", new OpenApiInfo { Title = "Demo API", Version = "v1" });
    option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter a valid token",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "Bearer"
    });
    option.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type=ReferenceType.SecurityScheme,
                    Id="Bearer"
                }
            },
            new string[]{}
        }
    });
});




var app = builder.Build();

app.UseCors(x => x
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());

app.UseHttpsRedirection();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//if(true)
//{
//    app.UseSwagger();
//  app.UseSwaggerUI();
//app.UseExceptionHandler("/Error");
//app.UseHsts();
//}
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

// using static System.Net.Mime.MediaTypeNames;
app.UseStatusCodePages(Text.Plain, "Status Code Page: {0}");


app.UseMiddleware<JWTMiddleware>();
app.UseMiddleware<ErrorHandlerMiddleware>();

app.UseAuthorization();

app.MapControllers();

app.Run();
