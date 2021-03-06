﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotesService.Api.Controllers.Models.NewFolder
{
    public class NoteRepository : INoteRepository
    {
        private readonly List<Note> _data = new List<Note>
        {
            new Note {
                Id = 1,
                Author = "Nick",
                IsPublic = true,
                Text = "Rest stands for representational state transfer"}
        };

        public IEnumerable<Note> GetAll()
        {
            return _data.ToList();
        }

        public Note GetById(int id)
        {
            return _data.FirstOrDefault(n => n.Id == id);
        }

        public void Add(Note note)
        {
            note.Id = _data.Max(n => n.Id) + 1;
            _data.Add(note);
        }
    }
}
