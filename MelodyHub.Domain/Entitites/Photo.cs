﻿using MelodyHub.Domain.Entitites.Cammon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Domain.Entitites
{
    public class Photo : BaseEntity
    {
        public int ParentId { get; set; }
        public string Url { get; set; }
        public PhotoType PhotoType { get; set; }
    }

    public enum PhotoType
    {
        Profile,  
        Banner,     
        Playlist,   
        Album       
    }
}
