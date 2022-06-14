using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notes.Models
{
    public class NotesModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public User NoteUser { get; set; }
        public string Text { get; set; }
    }
}
