﻿using System;
namespace SportsStore.Models.ViewModels
{
    public class PageInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPage =>
            (int)Math.Ceiling((decimal)TotalItems/ItemsPerPage);
    }
}
