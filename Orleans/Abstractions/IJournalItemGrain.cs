using OrleansWebAPI7AppDemo.Models.Journal;

namespace OrleansWebAPI7AppDemo.Orleans.Abstractions
{
    public interface IJournalItemGrain : IGrainWithStringKey
    {
        Task<JournalItem?> Get();

    }
}
