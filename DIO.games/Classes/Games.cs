using System;
using System.Collections.Generic;
using System.Text;

namespace DIO.games
{
    class Games : BaseEntity
    {
        // Atributes

        private Genre Genre { get; set; }

        private string Title { get; set; }

        private string Description { get; set; }

        private int Year { get; set; }

        private bool Excluded { get; set; }


        public Games(int id, Genre genre, string title, string description, int year)
        {
            this.Id = id;
            this.Genre = genre;
            this.Title = title;
            this.Description = description;
            this.Year = year;
            this.Excluded = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Genre: " + this.Genre + Environment.NewLine;
            retorno += "Title: " + this.Title + Environment.NewLine;
            retorno += "Description: " + this.Description + Environment.NewLine;
            retorno += "Year: " + this.Year + Environment.NewLine;
            retorno += "Deleted: " + this.Excluded;

            return retorno;
        }

        public string ReturnTitle()
        {
            return this.Title;
        }

        public int ReturnId()
        {
            return this.Id;
        }

        public void Exclude()
        {
            this.Excluded = true;
        }
    }
}
