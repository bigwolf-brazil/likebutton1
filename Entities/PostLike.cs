namespace BlazorApp.Entities
{
    using System;
    using System.Collections.Generic;

    public partial class PostLike
    {
        public int Id { get; set; } 
        public int PostId { get; set; } 
        public string UserAgent { get; set; }   
        public string IPAddress { get; set; }   
        public bool UserLike { get; set; }  

        public virtual Post Post { get; set; }
    }
}