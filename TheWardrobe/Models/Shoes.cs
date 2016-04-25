using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheWardrobe.Models
{
    public class Shoes
    {
        private string nickname;
        private string photo;
        private string type;
        private string color;
        private string season;
        private string occasion;

        [Key]
        public int ID { get; set; }

        public string Nickname
        {
            get { return this.nickname; }
            set { this.nickname = value; }
        }

        public string Photo
        {
            get { return this.photo; }
            set { this.photo = value; }
        }

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public string Season
        {
            get { return this.season; }
            set { this.season = value; }
        }

        public string Occasion
        {
            get { return this.occasion; }
            set { this.occasion = value; }
        }

    }
}