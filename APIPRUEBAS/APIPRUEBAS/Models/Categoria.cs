using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace APIPRUEBAS.Model;

public partial class Categoria
{
    public int IdCategoria { get; set; }

    public string? Descripcion { get; set; }


    // esto del jsonignore se pone porque al sacar el JSon resulta que el producto sale 
    // aunque vacio porque en el program.cs le hemos puesto que al generar el json
    // no haga caso a las referencias ciclicas (bucle infinito)
    [JsonIgnore]
    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
