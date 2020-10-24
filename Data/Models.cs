
using System;
using Microsoft.AspNetCore.Identity;

namespace misTesoros.Data
{
    public class AppUser : IdentityUser
    {
        public Guid Uid {get; set;}
        public string Name {get; set;}
        public string Color {get; set;}
    }

    public class Treasure
    {
        public Guid Uid {get; set;}
        public Guid Id {get; set;}
        public string Name {get; set;}
        public string Description {get; set;}
        public DateTime Date {get; set;}
        public float Weigth {get; set;}
        public string Place {get; set;}
        public float Value {get; set;}
        public Coordinate Coordinates {get; set;}
        public string UrlRef {get; set;}
    }

    public class Coordinate 
    {
        public Guid Id {get; set;}
        public Guid Tid {get; set;}
        public Guid Uid {get; set;}
        public float Lat {get; set;}
        public float Lng {get; set;}
    }
}

/*
Nombre *
- Descripción * 
- Fecha *
- Lugar *
- Lat y Long *
- Valor *
- Peso *
- Url de referencia
*/