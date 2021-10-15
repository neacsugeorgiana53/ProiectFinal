using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMaster.Models.DTO
{
    public class IdNameDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IdNameDto()
        {

        }

        public IdNameDto(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
