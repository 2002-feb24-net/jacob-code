using System.Collections.Generic;

namespace NotesService.Api.Controllers.Models.NewFolder
{
    public interface INoteRepository
    {
        void Add(Note note);
        IEnumerable<Note> GetAll();
        Note GetById(int id);
    }
}