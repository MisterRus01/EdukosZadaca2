using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Note
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; private set; }

        public Note(string title, string text)
        {
            Title = title;
            Text = text;
            Date = DateTime.Now;
        }
    }

    public class Notebook
    {
        public string Author { get; private set; }
        public List<Note> notes;

        public Notebook(string author)
        {
            Author = author;
            notes = new List<Note>();
        }

        public void AddNote(Note note)
        {
            notes.Add(note);
        }
    }
}
