using dunyaklinik.business.Abstract;
using dunyaklinik.business.Concrete;
using dunyaklinik.dataaccess.Abstract;
using dunyaklinik.dataaccess.Concrete;
using dunyaklinik.dataaccess.Concrete.EntityFramework;
using dunyaklinik.entities.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Test nesnesi
builder.Services.AddScoped<IDenemeService, DenemeManager>();
builder.Services.AddScoped<IDenemeDal, EfDenemeDal>();

builder.Services.AddScoped<IUserService, UserManager>();
builder.Services.AddScoped<IUserDal, EfUserDal>();

builder.Services.AddScoped<ITreatmentService, TreatmentManager>();
builder.Services.AddScoped<ITreatmentDal, EfTreatmentDal>();

builder.Services.AddScoped<ITreatmentTypeService, TreatmentTypeManager>();
builder.Services.AddScoped<ITreatmentTypeDal, EfTreatmentTypeDal>();

builder.Services.AddScoped<ITreatmentServiceRatingService, TreatmentServiceRatingManager>();
builder.Services.AddScoped<ITreatmentServiceRatingDal, EfTreatmentServiceRatingDal>();

builder.Services.AddScoped<ITreatmentExerciseService, TreatmentExerciseManager>();
builder.Services.AddScoped<ITreatmentExerciseDal, EfTreatmentExerciseDal>();

builder.Services.AddScoped<ITreatmentDocumentService, TreatmentDocumentManager>();
builder.Services.AddScoped<ITreatmentDocumentDal, EfTratmentDocumentDal>();

builder.Services.AddScoped<ITreatmentClientRatingService, TreatmentClientRatingManager>();
builder.Services.AddScoped<ITreatmentClientRatingDal, EfTreatmentClientRatingDal>();

builder.Services.AddScoped<ILogLoginService, LogLoginManager>();
builder.Services.AddScoped<ILogLoginDal, EfLogLoginDal>();

builder.Services.AddScoped<IAppointmentService, AppointmentManager>();
builder.Services.AddScoped<IAppointmentDal, EfAppointmentDal>();

builder.Services.AddScoped<IServiceBranchDocumentService, ServiceBranchDocumentManager>();
builder.Services.AddScoped<IServiceBranchDocumentDal, EfServiceBranchDocumentDal>();

builder.Services.AddScoped<IServiceBranchGeneralService, ServiceBranchGeneralManager>();
builder.Services.AddScoped<IServiceBranchGeneralDal, EfServiceBranchGeneralDal>();

builder.Services.AddScoped<IServiceUserService, ServiceUserManager>();
builder.Services.AddScoped<IServiceUserDal, EfServiceUserDal>();

builder.Services.AddScoped<IServiceOrganisationService, ServiceOrganisationManager>();
builder.Services.AddScoped<IServiceOrganisationDal, EfServiceOrganisationDal>();

builder.Services.AddScoped<IServiceUserTitleNameService, ServiceUserTitleNameManager>();
builder.Services.AddScoped<IServiceUserTitleNameDal, EfServiceUserTitleNameDal>();

builder.Services.AddScoped<IServiceUserProfessionService, ServiceUserProfessionManager>();
builder.Services.AddScoped<IServiceUserProfessionDal, EfServiceUserProfessionDal>();

builder.Services.AddScoped<IServiceUserDocumentService, ServiceUserDocumentManager>();
builder.Services.AddScoped<IServiceUserDocumentDal, EfServiceUserDocumentDal>();

builder.Services.AddScoped<IServiceOrganisationDocumentService, ServiceOrganisationDocumentManager>();
builder.Services.AddScoped<IServiceOrganisationDocumentDal, EfServiceOrganisationDocumentDal>();


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
