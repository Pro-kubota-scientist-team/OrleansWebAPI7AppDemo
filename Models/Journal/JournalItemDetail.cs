namespace OrleansWebAPI7AppDemo.Models.Journal
{
    [GenerateSerializer]
    public class JournalItemDetail
    {
        [Id(1)]
        // 仕訳番号
        public int 仕訳番号 { get; set; } = -1;

        [Id(2)]
        public int 行番号 { get; set; } = -1;

        [Id(3)]
        public お気に入り科目 借方科目 { get; set; } = お気に入り科目.設定なし;
        [Id(4)]
        public string 借方補助 { get; set; } = String.Empty;
        [Id(5)]
        public string 借方金額 { get; set; } = String.Empty;
        [Id(6)]
        public string 借方部門 { get; set; } = String.Empty;
        [Id(7)]
        public string 借方摘要 { get; set; } = String.Empty;
        [Id(8)] 
        public 消費税区分 借方消費税区分 { get; set; } = 消費税区分.対象外;
        [Id(9)] 
        public 消費税 借方消費税 { get; set; } = 消費税.設定なし;




        [Id(10)] 
        public お気に入り科目 貸方科目 { get; set; } = お気に入り科目.設定なし;

        [Id(11)] 
        public string 貸方補助 { get; set; } = String.Empty;
        [Id(12)] 
        public string 貸方金額 { get; set; } = String.Empty;
        [Id(13)] 
        public string 貸方部門 { get; set; } = String.Empty;
        [Id(14)] 
        public string 貸方摘要 { get; set; } = String.Empty;
        [Id(15)] 
        public 消費税区分 貸方消費税区分 { get; set; } = 消費税区分.対象外;
        [Id(16)] 
        public 消費税 貸方消費税 { get; set; } = 消費税.設定なし;


        [Id(17)]
        public string 名称 { get; set; } = String.Empty;

    }

}
