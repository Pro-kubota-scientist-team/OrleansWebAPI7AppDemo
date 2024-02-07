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
        /// �O���C���L�������̏���
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override Task OnActivateAsync(CancellationToken cancellationToken)
        {

            string primaryKey = this.GetPrimaryKeyString(); //Grain ID���擾

            // ���@�{���̓f�[�^�x�[�X����擾����
            switch (primaryKey)
            {
                case "1":
                    {
                        _model = new JournalItem();
                        _model.�d��ԍ� = 1;
                        _model.�N�x = "2023";
                        _model.�敪 = �敪.�ݒ�Ȃ�;
                        _model.��v�P�� = ��v�P��.�{��;
                        _model.�Ώۊ��� = "";
                        _model.����ŉȖ� = "";

                        _items = new List<JournalItemDetail> 
                        { 
                           new JournalItemDetail() {
                                �d��ԍ� = 1,
                                �s�ԍ� = 1,
                                �ؕ��Ȗ� = ���C�ɓ���Ȗ�.���Օi��,
                                �ؕ��⏕ = "",
                                �ؕ����z = "10000",
                                �ؕ����� = "�c�ƕ�",
                                �ؕ��E�v = "�����p�i�w��",
                                �ؕ�����ŋ敪 = ����ŋ敪.�ΏۊO,
                                �ؕ������ = �����.�����ې�,
                                �ݕ��Ȗ� = ���C�ɓ���Ȗ�.���Օi��,
                                �ݕ��⏕ = "",
                                �ݕ����z = "10000",
                                �ݕ����� = "�c�ƕ�",
                                �ݕ��E�v = "�����p�i�w��",
                                �ݕ�����ŋ敪 = ����ŋ敪.�ΏۊO,
                                �ݕ������ = �����.�����ې�,
                                ���� = "�m�[�gPC"
                            },
                        };



            }
                    break;
                case "2":
                    {
                        _model = new JournalItem();
                        _model.�d��ԍ� = 2;
                        _model.�N�x = "2023";
                        _model.�敪 = �敪.�������Z;
                        _model.��v�P�� = ��v�P��.�{��;
                        _model.�Ώۊ��� = "";
                        _model.����ŉȖ� = "";

                        _items = new List<JournalItemDetail>();
                        _items.Add(new JournalItemDetail() { �d��ԍ� = 2, �s�ԍ� = 1, });
                        _items.Add(new JournalItemDetail() { �d��ԍ� = 2, �s�ԍ� = 2, });

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
            // UPDATE company SET �Z��1 = '**** ;
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
