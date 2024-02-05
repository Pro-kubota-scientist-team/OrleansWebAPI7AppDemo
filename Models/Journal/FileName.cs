namespace OrleansWebAPI7AppDemo.Models.Journal
{


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

    public enum 付箋
    {
        無し = 0,
        あり = 1
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
