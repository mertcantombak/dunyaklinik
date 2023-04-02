using dunyaklinik.business.Abstract;
using dunyaklinik.business.Concrete;
using dunyaklinik.dataaccess.Abstract;
using dunyaklinik.dataaccess.Concrete;
using dunyaklinik.dataaccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUserService, UserManager>();
builder.Services.AddScoped<IUserDal, EfUserDal>();
builder.Services.AddScoped<INesneService, NesneManager>();
builder.Services.AddScoped<INesneDal, EfNesneDal>();
builder.Services.AddScoped<ITreatmentService, TreatmentManager>();
builder.Services.AddScoped<ITreatmentDal, EfTreatmentDal>();
builder.Services.AddScoped<ITreatment_TypeService, Treatment_TypeManager>();
builder.Services.AddScoped<ITreatment_TypeDal, EfTreatment_TypeDal>();
builder.Services.AddControllers();
builder.Services.AddDbContext<DunyaKlinikContext>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
