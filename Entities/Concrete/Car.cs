﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public int Id    { get; set; }
        public int BrandId { get; set; }  //marka ıd
        public int ModelYear { get; set; } 
        public decimal DailyPrice { get; set; }   //günlük fiyat
        public string Description { get; set; } //açıklama
        //public string PaymentMetod { get; set; } //ödeme yöntemi

    }
}
