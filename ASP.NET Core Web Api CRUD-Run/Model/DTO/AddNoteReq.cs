﻿using ASP.NET_Core_Web_Api_CRUD_Run.Model.DomainModel;

    namespace ASP.NET_Core_Web_Api_CRUD_Run.Model.DTO
{
    public class AddNoteReq
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Colorhex { get; set; }                  
    }
}
