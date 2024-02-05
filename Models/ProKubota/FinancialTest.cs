using Orleans;

namespace OrleansWebAPI7AppDemo.Models.ProKubota
{
    [GenerateSerializer]
    public class FinancialTest
    {
        [Id(0)] 
        public string Name { get; set; } = String.Empty;
        [Id(1)]
        public string CompanyName { get; set; } = String.Empty;
        [Id(2)]
        public string Address { get; set; } = String.Empty;
        [Id(3)]
        public string Address2 { get; set; } = String.Empty;
        [Id(4)]
        public string KessanKi { get; set; } = String.Empty;
        [Id(5)]
        public 決算区分 Kubun { get; set;} = 決算区分.期末決算;
        [Id(6)]
        public 消費税 Zei { get; set; } = 消費税.税抜集計;
        [Id(7)]
        public int Year { get; set; } = 0;
        [Id(8)]
        public string FisicalYearEnd { get; set; } = String.Empty;
    }
    public enum 決算区分
    {
        期末決算 = 0,
        中間決算 = 1,

    }
    public enum 消費税
    {
        税抜集計 = 0,
        税込集計 = 1,
    }
}
