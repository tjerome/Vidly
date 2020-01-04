using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.DTO
{
    public class GenreDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}