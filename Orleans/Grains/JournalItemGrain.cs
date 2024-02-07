using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Orleans.Runtime;
using OrleansCodeGen.Orleans.Serialization.Codecs;
using OrleansWebAPI7AppDemo.Models.Journal;
using OrleansWebAPI7AppDemo.Orleans.Abstractions;

namespace OrleansWebAPI7AppDemo.Orleans.Grains
{
    public class JournalItemGrain : Grain , IJournalItemGrain
    {
        private JournalItem? _model { get; set; }
        private List<JournalItemDetail>? _items { get; set; }

        public JournalItemGrain()
        {
        }

        /// <summary>
        /// グレイン有効化時の処理
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override Task OnActivateAsync(CancellationToken cancellationToken)
        {

            string primaryKey = this.GetPrimaryKeyString(); //Grain IDを取得

            // ↓　本来はデータベースから取得する
            switch (primaryKey)
            {
                case "1":
                    {
                        _model = new JournalItem();
                        _model.仕訳番号 = 1;
                        _model.年度 = "2023";
                        _model.区分 = 区分.設定なし;
                        _model.会計単位 = 会計単位.本社;
                        _model.対象期間 = "";
                        _model.消費税科目 = "";

                        _items = new List<JournalItemDetail> 
                        { 
                           new JournalItemDetail() {
                                仕訳番号 = 1,
                                行番号 = 1,
                                借方科目 = お気に入り科目.消耗品費,
                                借方補助 = "",
                                借方金額 = "10000",
                                借方部門 = "営業部",
                                借方摘要 = "事務用品購入",
                                借方消費税区分 = 消費税区分.対象外,
                                借方消費税 = 消費税.原則課税,
                                貸方科目 = お気に入り科目.消耗品費,
                                貸方補助 = "",
                                貸方金額 = "10000",
                                貸方部門 = "営業部",
                                貸方摘要 = "事務用品購入",
                                貸方消費税区分 = 消費税区分.対象外,
                                貸方消費税 = 消費税.原則課税,
                                名称 = "ノートPC"
                            },
                        };



            }
                    break;
                case "2":
                    {
                        _model = new JournalItem();
                        _model.仕訳番号 = 2;
                        _model.年度 = "2023";
                        _model.区分 = 区分.期末決算;
                        _model.会計単位 = 会計単位.本社;
                        _model.対象期間 = "";
                        _model.消費税科目 = "";

                        _items = new List<JournalItemDetail>();
                        _items.Add(new JournalItemDetail() { 仕訳番号 = 2, 行番号 = 1, });
                        _items.Add(new JournalItemDetail() { 仕訳番号 = 2, 行番号 = 2, });

                    }
                    break;

                default:

                    break;
            }

            return base.OnActivateAsync(cancellationToken);
        }



        public Task<JournalItem?> GetJournalItem()
        {
            return Task.FromResult(_model);
        }
        public Task<List<JournalItemDetail>?> GetJournalItemDetails()
        {
            return Task.FromResult(_items);
        }

        public Task Set(JournalItem JournalItem)
        {
            // UPDATE company SET 住所1 = '**** ;
            _model = JournalItem;
            return Task.CompletedTask;
        }

        public Task Set(JournalItemDetail JournalItemDetail)
        {
            _items = new List<JournalItemDetail>();
            return Task.CompletedTask;
        }

        public Task Remove()
        {
            // DELETE FROM company where ID = '****' ;
            _model = null;
            return Task.CompletedTask;
        }
    }
}
