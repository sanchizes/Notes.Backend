using MediatR;

namespace Notes.Application.Notes.Queries.GetNoteDetails
{
    internal class GetNoteDetailsQuery : IRequest<NoteDetailsVm>
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
    }
}
