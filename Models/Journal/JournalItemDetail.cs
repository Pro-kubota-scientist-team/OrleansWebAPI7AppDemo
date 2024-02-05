namespace OrleansWebAPI7AppDemo.Models.Journal
{
    [GenerateSerializer]
    public class JournalItemDetail
    {
        // 仕訳番号
        public int 仕訳番号 { get; set; } = int.MaxValue;

        public int 行番号 { get; set; } = int.MaxValue;


        public お気に入り科目 借方科目 { get; set; } = お気に入り科目.設定なし;
        public string 借方補助 { get; set; } = String.Empty;
        public string 借方金額 { get; set; } = String.Empty;
        public string 借方部門 { get; set; } = String.Empty;
        public string 借方摘要 { get; set; } = String.Empty;
        public 消費税区分 借方消費税区分 { get; set; } = 消費税区分.対象外;
        public 消費税 借方消費税 { get; set; } = 消費税.設定なし;




        public お気に入り科目 貸方科目 { get; set; } = お気に入り科目.設定なし;
        public string 貸方補助 { get; set; } = String.Empty;
        public string 貸方金額 { get; set; } = String.Empty;
        public string 貸方部門 { get; set; } = String.Empty;
        public string 貸方摘要 { get; set; } = String.Empty;
        public 消費税区分 貸方消費税区分 { get; set; } = 消費税区分.対象外;
        public 消費税 貸方消費税 { get; set; } = 消費税.設定なし;


        [Id(8)]
        public string 名称 { get; set; } = String.Empty;

    }

}
