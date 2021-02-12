using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    //---------------------Dto: Data transfer object----------------
    public class CarDetailDto:IDto
    {
        public int CarId { get; set; }
        public int BranId { get; set; }
        public int ColorId { get; set; }
        public int DailyPrice { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
    }
}
