namespace OrleansWebAPI7AppDemo.Models.Journal
{
    [GenerateSerializer]
    public class JournalItem
    {
        // 仕訳番号
        [Id(0)]
        public int 仕訳番号 { get; set; } = int.MaxValue;
        // 仕訳日付
        [Id(1)]
        public string 仕訳日付 { get; set; } = string.Empty;
        // 年度
        [Id(2)]
        public string 年度 { get; set; } = String.Empty;
        // 会計単位
        [Id(3)]
        public 会計単位 会計単位 { get; set; } = 会計単位.設定なし;
        // 計上種類区分
        [Id(4)]
        public 区分 区分 { get; set; } = 区分.設定なし;
        // 入力日付
        [Id(5)]
        public string 入力日付 { get; set; } = String.Empty;
        // 入力者
        [Id(6)]
        public string 入力者 { get; set; } = String.Empty;
        // 付箋
        [Id(7)]
        public 付箋 付箋 { get; set; } = 付箋.無し;
        // 対象期間
        [Id(8)]
        public string 対象期間 { get; set; } = String.Empty;
        /// <summary>
        /// 貸借
        /// 0：借方科目
        /// 1：貸方科目
        /// </summary>
        // 勘定科目帳表種類
        [Id(9)]
        public string 消費税科目 { get; set; } = String.Empty;

    }
}
