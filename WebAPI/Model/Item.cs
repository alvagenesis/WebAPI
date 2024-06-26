﻿using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebAPI.Model
{
    public class Item
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        public required string Code { get; set; }
        
        [Column(TypeName = "varchar(200)")]
        public required string Description { get; set; }        
       
        public bool Status { get; set; }        
       
        public bool IsActive { get; set; }
        
        public List<UnitOfMeasurement> UnitOfMeasurements { get; set;}

    }
}
