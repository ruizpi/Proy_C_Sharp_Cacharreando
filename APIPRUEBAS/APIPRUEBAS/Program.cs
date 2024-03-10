// añadimos estos 2 using
using Microsoft.EntityFrameworkCore;
using APIPRUEBAS.Model;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



// escribimos esto para tomar el contexto de la BBDD
builder.Services.AddDbContext<DbapiContext>(opt =>  opt.UseSqlServer(builder.Configuration.GetConnectionString("cadenaSQL")));


builder.Services.AddControllers().AddJsonOptions(opt =>

    opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles

);


// UNA VEZ CREADO EL GET, LIST, ETC ES IMPORTANTE HACER ESTAS LINEAS SIGUIENTES
// QUE SIRVEN PARA ANTES DE PUBLICAR LA API HAY QUE DECIRLES QUE REGLAS "CORS"
// // DEBE CUMPLIR
// AQUI LE DECIMOS QUE PERMITA CUALQUIER CABECERA, CUALQUIER METODO Y CUALQUIER ORIGEN
// AQUI NO SE PUEDE ACTIVAR, HAY QUE IR A ACTIVARLO MAS ABAJO
var misReglasCors = "ReglasCors";
builder.Services.AddCors(opt =>
{
    opt.AddPolicy(name: misReglasCors, builder =>
    {
        builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
    });
});




var app = builder.Build();


// COMENTAMOS TODO ESTO DE APP.ENVIROMENT.ISDEVELOPMENT DESPUES DE HABER CREADO UNA CUENTA 
// EN https://somee.com/ Y CREADO LA BASE DE DATOS EN DICHO ENTORNO
// EN EL JSON DE SETTINGS HEMOS PUESTO LA CADENA DE CONEXION QUE NOS DA LA WEB SOMEE


// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseSwagger();
app.UseSwaggerUI();

// AQUI SE ACTIVA COMO SE ACTIVA LOS CORS O POLITICAS DE USO
// PERO FALTA AL PRINCIPIO DE TODO PONER UN USING QUE HACE REFERENCIA A CORS EN PRODUCTOS
app.UseCors(misReglasCors);

app.UseAuthorization();

app.MapControllers();

app.Run();
