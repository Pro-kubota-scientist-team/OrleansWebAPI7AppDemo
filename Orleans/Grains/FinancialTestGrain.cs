using Orleans.Runtime;
using OrleansWebAPI7AppDemo.Models.ProKubota;
using OrleansWebAPI7AppDemo.Orleans.Abstractions;

namespace OrleansWebAPI7AppDemo.Orleans.Grains
{
    public class FinancialTestGrain : Grain , IFinancialTestGrain
    {
        private FinancialTest? _financialTest {  get; set; }

        public FinancialTestGrain()
        {

        }
        public override Task OnActivateAsync(CancellationToken cancellationToken)
        {
            string primaryKey = this.GetPrimaryKeyString();

            switch(primaryKey)
            {
                case "test":
                    {
                        _financialTest = new FinancialTest();
                        _financialTest.Name = "ブラック黒ノ助";
                        _financialTest.CompanyName = "漆黒かんぱに～";
                    }
                    break;
                default:
                    break;
            }
            return base.OnActivateAsync(cancellationToken);
        }
        public Task<FinancialTest?> Get()
        {
            return Task.FromResult(_financialTest);
        }

        public Task Set(FinancialTest financial)
        {
            _financialTest = financial;
            return Task.CompletedTask;
        }

        public Task Remove()
        {
            _financialTest = null;
            return Task.CompletedTask;
        }
    }
}
