using OrleansWebAPI7AppDemo.Models.ProKubota;

namespace OrleansWebAPI7AppDemo.Orleans.Abstractions
{
    public interface IFinancialTestGrain : IGrainWithStringKey
    {
        Task<FinancialTest?> Get();

        Task Set(FinancialTest value);

        Task Remove();
    }
}
