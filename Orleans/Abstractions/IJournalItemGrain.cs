using OrleansWebAPI7AppDemo.Models.Accounting;
using OrleansWebAPI7AppDemo.Models.Journal;

namespace OrleansWebAPI7AppDemo.Orleans.Abstractions
{
    public interface IJournalItemGrain : IGrainWithStringKey
    {
        Task<JournalItem?> GetJournalItem();

        Task<List<JournalItemDetail>?> GetJournalItemDetails();

        Task Set(JournalItem value);

        Task Remove();
    }
}
