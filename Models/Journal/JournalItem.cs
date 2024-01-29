namespace OrleansWebAPI7AppDemo.Models.Journal
{
    [GenerateSerializer]
    public class JournalItem
    {
        // 年度
        [Id(0)]
        public string 年度 { get; set; } = String.Empty;
        // 区分
        [Id(1)]
        public 区分 区分 { get; set; } = 区分.設定なし;
        // 会計単位
        [Id(2)]
        public 会計単位 会計単位 { get; set; } = 会計単位.設定なし;
        // 消費税
        [Id(3)]
        public 消費税 消費税 { get; set; } = 消費税.設定なし;
        // 対象期間
        [Id(4)]
        public string 対象期間 { get; set; } = String.Empty;
        /// <summary>
        /// 貸借
        /// 0：借方科目
        /// 1：貸方科目
        /// </summary>
        [Id(5)]
        public お気に入り科目 科目 { get; set; } = お気に入り科目.設定なし;

        // 補助
        [Id(6)]
        public string 補助 { get; set;} = String.Empty;

        [Id(7)]
        public string 名称 { get; set;} = String.Empty;

        [Id(8)]
        public string 金額 { get; set;} = String.Empty;

        // 勘定科目消費税
        [Id(9)]
        public 消費税区分 消費税区分 { get; set; } = 消費税区分.対象外;
        // 勘定科目帳表種類
        [Id(10)]
        public string 消費税科目 { get; set; } = String.Empty;
        // 勘定科目集計先科目
        [Id(11)]
        public string 部門 { get; set; } = String.Empty;
        // 勘定科目帳簿区分
        [Id(8)]
        public string 摘要 { get; set; } = String.Empty;

    }

    public enum お気に入り科目
    {
        設定なし = 0,
        売掛金 = 142,
        旅費交通費 = 755,
        通信費 = 756,
        消耗品費 = 760,
        支払手数料 = 777,
        雑費 = 111,
    }
    public enum 消費税区分
    {
        対象外 = 0,
        売上 = 1,
        仕入 = 2,
        非課税 = 3
    }

    public enum 区分
    {
        設定なし = 0,
        月次 = 1,
        中間決算 = 2,
        期末決算 = 3,
        決算再振替 = 4,
        期中 = 5
    }

    public enum 会計単位
    {
        設定なし = 0,
        本社 = 1
    }

    public enum 消費税
    {
        設定なし = 0,
        原則課税 = 1
    }
}
