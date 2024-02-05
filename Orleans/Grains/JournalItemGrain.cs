using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Orleans.Runtime;
using OrleansCodeGen.Orleans.Serialization.Codecs;
using OrleansWebAPI7AppDemo.Models.Accounting;
using OrleansWebAPI7AppDemo.Models.Journal;
using OrleansWebAPI7AppDemo.Orleans.Abstractions;

namespace OrleansWebAPI7AppDemo.Orleans.Grains
{
    public class JournalItemGrain : Grain , IJournalItemGrain
    {
        private JournalItem? _model { get; set; }

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
                        _model.消費税 = 消費税.設定なし;
                        _model.対象期間 = "";
                        _model.科目 = お気に入り科目.設定なし;
                        _model.補助 = "";
                        _model.名称 = "";
                        _model.金額 = "";
                        _model.消費税科目 = "";
                        _model.部門 = "";
                        _model.摘要 = "";



                    }
                    break;
                case "2":
                    {
                        _model = new JournalItem();
                        _model.仕訳番号 = 2;
                        _model.年度 = "2023";
                        _model.区分 = 区分.期末決算;
                        _model.会計単位 = 会計単位.本社;
                        _model.消費税 = 消費税.原則課税;
                        _model.対象期間 = "";
                        _model.科目 = お気に入り科目.売掛金;
                        _model.補助 = "";
                        _model.名称 = "";
                        _model.金額 = "";
                        _model.消費税科目 = "";
                        _model.部門 = "";
                        _model.摘要 = "";

                    }
                    break;

                default:

                    break;
            }

            return base.OnActivateAsync(cancellationToken);
        }

        public Task<JournalItem?> Get()
        {
            return Task.FromResult(_model);
        }

        public Task Set(JournalItem JournalItem)
        {
            // UPDATE company SET 住所1 = '**** ;
            _model = JournalItem;
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
