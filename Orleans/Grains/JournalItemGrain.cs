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
        /// OCLø»Ì
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override Task OnActivateAsync(CancellationToken cancellationToken)
        {

            string primaryKey = this.GetPrimaryKeyString(); //Grain IDðæ¾

            // «@{Íf[^x[X©çæ¾·é
            switch (primaryKey)
            {
                case "1":
                    {
                        _model = new JournalItem();
                        _model.dóÔ = 1;
                        _model.Nx = "2023";
                        _model.æª = æª.ÝèÈµ;
                        _model.ïvPÊ = ïvPÊ.{Ð;
                        _model.ÎÛúÔ = "";
                        _model.ÁïÅÈÚ = "";

                        _items = new List<JournalItemDetail> 
                        { 
                           new JournalItemDetail() {
                                dóÔ = 1,
                                sÔ = 1,
                                ØûÈÚ = ¨CÉüèÈÚ.ÁÕiï,
                                Øûâ = "",
                                Øûàz = "10000",
                                Øûå = "cÆ",
                                ØûEv = "±piwü",
                                ØûÁïÅæª = ÁïÅæª.ÎÛO,
                                ØûÁïÅ = ÁïÅ.´¥ÛÅ,
                                ÝûÈÚ = ¨CÉüèÈÚ.ÁÕiï,
                                Ýûâ = "",
                                Ýûàz = "10000",
                                Ýûå = "cÆ",
                                ÝûEv = "±piwü",
                                ÝûÁïÅæª = ÁïÅæª.ÎÛO,
                                ÝûÁïÅ = ÁïÅ.´¥ÛÅ,
                                ¼Ì = "m[gPC"
                            },
                        };



            }
                    break;
                case "2":
                    {
                        _model = new JournalItem();
                        _model.dóÔ = 2;
                        _model.Nx = "2023";
                        _model.æª = æª.úZ;
                        _model.ïvPÊ = ïvPÊ.{Ð;
                        _model.ÎÛúÔ = "";
                        _model.ÁïÅÈÚ = "";

                        _items = new List<JournalItemDetail>();
                        _items.Add(new JournalItemDetail() { dóÔ = 2, sÔ = 1, });
                        _items.Add(new JournalItemDetail() { dóÔ = 2, sÔ = 2, });

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
            // UPDATE company SET Z1 = '**** ;
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
