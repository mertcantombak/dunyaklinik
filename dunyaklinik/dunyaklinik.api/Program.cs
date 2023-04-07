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

builder.Services.AddScoped<IUsersService, UsersManager>();
builder.Services.AddScoped<IUsersDal, EfUsersDal>();
builder.Services.AddScoped<INesneService, NesneManager>();
builder.Services.AddScoped<INesneDal, EfNesneDal>();
builder.Services.AddScoped<ITreatmentsService, TreatmentsManager>();
builder.Services.AddScoped<ITreatmentsDal, EfTreatmentsDal>();
builder.Services.AddScoped<ITreatmentTypesService, TreatmentTypesManager>();
builder.Services.AddScoped<ITreatmentTypesDal, EfTreatmentTypesDal>();
builder.Services.AddScoped<ITreatmentServiceRatingsService, TreatmentServiceRatingsManager>();
builder.Services.AddScoped<ITreatmentServiceRatingsDal, EfTreatmentServiceRatingsDal>();
builder.Services.AddScoped<ITreatmentExercisesService, TreatmentExercisesManager>();
builder.Services.AddScoped<ITreatmentExercisesDal, EfTreatmentExercisesDal>();
builder.Services.AddScoped<ITreatmentDocumentsService, TreatmentDocumentsManager>();
builder.Services.AddScoped<ITreatmentDocumentsDal, EfTratmentDocumentsDal>();
builder.Services.AddScoped<ITreatmentClientRatingsService, TreatmentClientRatingsManager>();
builder.Services.AddScoped<ITreatmentClientRatingsDal, EfTreatmentClientRatingsDal>();
builder.Services.AddScoped<ILogLoginsService, LogLoginsManager>();
builder.Services.AddScoped<ILogLoginsDal, EfLogLoginsDal>();
builder.Services.AddScoped<IAppointmentsService, AppointmentsManager>();
builder.Services.AddScoped<IAppointmentsDal, EfAppointmentsDal>();
builder.Services.AddScoped<IClientUsersService, ClientUsersManager>();
builder.Services.AddScoped<IClientUsersDal, EfClientUsersDal>();
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
