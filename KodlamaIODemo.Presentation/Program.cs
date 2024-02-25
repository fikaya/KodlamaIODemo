using KodlamaIODemo.Business.Abstract;
using KodlamaIODemo.Business.Concrete;
using KodlamaIODemo.DataAccess.Abstract.CourseRepository;
using KodlamaIODemo.DataAccess.Abstract.GeneralRepository;
using KodlamaIODemo.DataAccess.Concrete.CourseRepository;
using KodlamaIODemo.DataAccess.Concrete.DatabaseContext;
using KodlamaIODemo.Entities.DTO.Course;
using KodlamaIODemo.Entities.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

builder.Services.AddScoped<IGetAllWithRelationship<CourseInformationDTO>, KodlamaIODemo.DataAccess.Concrete.CourseRepository.Dapper.GetAllWithRelationship<CourseInformationDTO, MssqlDatabaseContext>>();

builder.Services.AddScoped<IGetAll<Category>, KodlamaIODemo.DataAccess.Concrete.GeneralRepository.Dapper.GetAll<Category, MssqlDatabaseContext>>();
builder.Services.AddScoped<IGetAll<Course>, KodlamaIODemo.DataAccess.Concrete.GeneralRepository.Dapper.GetAll<Course, MssqlDatabaseContext>>();
builder.Services.AddScoped<IGetAll<Instructor>, KodlamaIODemo.DataAccess.Concrete.GeneralRepository.Dapper.GetAll<Instructor, MssqlDatabaseContext>>();
builder.Services.AddScoped<IGetAll<CourseCategory>, KodlamaIODemo.DataAccess.Concrete.GeneralRepository.Dapper.GetAll<CourseCategory, MssqlDatabaseContext>>();
builder.Services.AddScoped<IGetAll<CourseInstructor>, KodlamaIODemo.DataAccess.Concrete.GeneralRepository.Dapper.GetAll<CourseInstructor, MssqlDatabaseContext>>();
builder.Services.AddScoped<IGetAll<CourseStudent>, KodlamaIODemo.DataAccess.Concrete.GeneralRepository.Dapper.GetAll<CourseStudent, MssqlDatabaseContext>>();
builder.Services.AddScoped<IGetAll<Student>, KodlamaIODemo.DataAccess.Concrete.GeneralRepository.Dapper.GetAll<Student, MssqlDatabaseContext>>();

builder.Services.AddScoped<IGetById<Category>, KodlamaIODemo.DataAccess.Concrete.GeneralRepository.Dapper.GetByID<Category, MssqlDatabaseContext>>();
builder.Services.AddScoped<IGetById<Course>, KodlamaIODemo.DataAccess.Concrete.GeneralRepository.Dapper.GetByID<Course, MssqlDatabaseContext>>();
builder.Services.AddScoped<IGetById<CourseCategory>, KodlamaIODemo.DataAccess.Concrete.GeneralRepository.Dapper.GetByID<CourseCategory, MssqlDatabaseContext>>();
builder.Services.AddScoped<IGetById<CourseInstructor>, KodlamaIODemo.DataAccess.Concrete.GeneralRepository.Dapper.GetByID<CourseInstructor, MssqlDatabaseContext>>();
builder.Services.AddScoped<IGetById<CourseStudent>, KodlamaIODemo.DataAccess.Concrete.GeneralRepository.Dapper.GetByID<CourseStudent, MssqlDatabaseContext>>();
builder.Services.AddScoped<IGetById<Instructor>, KodlamaIODemo.DataAccess.Concrete.GeneralRepository.Dapper.GetByID<Instructor, MssqlDatabaseContext>>();
builder.Services.AddScoped<IGetById<Student>, KodlamaIODemo.DataAccess.Concrete.GeneralRepository.Dapper.GetByID<Student, MssqlDatabaseContext>>();

builder.Services.AddScoped<IAdd<Category>, KodlamaIODemo.DataAccess.Concrete.GeneralRepository.EFCore.Add<Category, MssqlDatabaseContext>>();
builder.Services.AddScoped<IAdd<Course>, KodlamaIODemo.DataAccess.Concrete.GeneralRepository.EFCore.Add<Course, MssqlDatabaseContext>>();
builder.Services.AddScoped<IAdd<CourseCategory>, KodlamaIODemo.DataAccess.Concrete.GeneralRepository.EFCore.Add<CourseCategory, MssqlDatabaseContext>>();
builder.Services.AddScoped<IAdd<CourseInstructor>, KodlamaIODemo.DataAccess.Concrete.GeneralRepository.EFCore.Add<CourseInstructor, MssqlDatabaseContext>>();
builder.Services.AddScoped<IAdd<CourseStudent>, KodlamaIODemo.DataAccess.Concrete.GeneralRepository.EFCore.Add<CourseStudent, MssqlDatabaseContext>>();
builder.Services.AddScoped<IAdd<Instructor>, KodlamaIODemo.DataAccess.Concrete.GeneralRepository.EFCore.Add<Instructor, MssqlDatabaseContext>>();
builder.Services.AddScoped<IAdd<Student>, KodlamaIODemo.DataAccess.Concrete.GeneralRepository.EFCore.Add<Student, MssqlDatabaseContext>>();

builder.Services.AddScoped<IUpdate<Category>, KodlamaIODemo.DataAccess.Concrete.GeneralRepository.EFCore.Update<Category, MssqlDatabaseContext>>();
builder.Services.AddScoped<IUpdate<Course>, KodlamaIODemo.DataAccess.Concrete.GeneralRepository.EFCore.Update<Course, MssqlDatabaseContext>>();
builder.Services.AddScoped<IUpdate<CourseCategory>, KodlamaIODemo.DataAccess.Concrete.GeneralRepository.EFCore.Update<CourseCategory, MssqlDatabaseContext>>();
builder.Services.AddScoped<IUpdate<CourseInstructor>, KodlamaIODemo.DataAccess.Concrete.GeneralRepository.EFCore.Update<CourseInstructor, MssqlDatabaseContext>>();
builder.Services.AddScoped<IUpdate<CourseStudent>, KodlamaIODemo.DataAccess.Concrete.GeneralRepository.EFCore.Update<CourseStudent, MssqlDatabaseContext>>();
builder.Services.AddScoped<IUpdate<Instructor>, KodlamaIODemo.DataAccess.Concrete.GeneralRepository.EFCore.Update<Instructor, MssqlDatabaseContext>>();
builder.Services.AddScoped<IUpdate<Student>, KodlamaIODemo.DataAccess.Concrete.GeneralRepository.EFCore.Update<Student, MssqlDatabaseContext>>();

builder.Services.AddScoped<IRemove<Category>, KodlamaIODemo.DataAccess.Concrete.GeneralRepository.EFCore.Remove<Category, MssqlDatabaseContext>>();
builder.Services.AddScoped<IRemove<Course>, KodlamaIODemo.DataAccess.Concrete.GeneralRepository.EFCore.Remove<Course, MssqlDatabaseContext>>();
builder.Services.AddScoped<IRemove<CourseCategory>, KodlamaIODemo.DataAccess.Concrete.GeneralRepository.EFCore.Remove<CourseCategory, MssqlDatabaseContext>>();
builder.Services.AddScoped<IRemove<CourseInstructor>, KodlamaIODemo.DataAccess.Concrete.GeneralRepository.EFCore.Remove<CourseInstructor, MssqlDatabaseContext>>();
builder.Services.AddScoped<IRemove<CourseStudent>, KodlamaIODemo.DataAccess.Concrete.GeneralRepository.EFCore.Remove<CourseStudent, MssqlDatabaseContext>>();
builder.Services.AddScoped<IRemove<Instructor>, KodlamaIODemo.DataAccess.Concrete.GeneralRepository.EFCore.Remove<Instructor, MssqlDatabaseContext>>();
builder.Services.AddScoped<IRemove<Student>, KodlamaIODemo.DataAccess.Concrete.GeneralRepository.EFCore.Remove<Student, MssqlDatabaseContext>>();

builder.Services.AddScoped<ICourseRepository<Course, CourseInformationDTO>, CourseRepository<Course, CourseInformationDTO>>();
builder.Services.AddScoped<ICourseService<Course, CourseInformationDTO>, CourseService<Course, CourseInformationDTO>>();

var app = builder.Build();

// Configure the HTTP request pipeline.
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
    pattern: "{controller=Course}/{action=Index}/{id?}");

app.Run();
