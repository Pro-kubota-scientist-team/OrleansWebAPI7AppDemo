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
                        _model.����� = �����.�ݒ�Ȃ�;
                        _model.�Ώۊ��� = "";
                        _model.�Ȗ� = ���C�ɓ���Ȗ�.�ݒ�Ȃ�;
                        _model.�⏕ = "";
                        _model.���� = "";
                        _model.���z = "";
                        _model.����ŉȖ� = "";
                        _model.���� = "";
                        _model.�E�v = "";



                    }
                    break;
                case "2":
                    {
                        _model = new JournalItem();
                        _model.�d��ԍ� = 2;
                        _model.�N�x = "2023";
                        _model.�敪 = �敪.�������Z;
                        _model.��v�P�� = ��v�P��.�{��;
                        _model.����� = �����.�����ې�;
                        _model.�Ώۊ��� = "";
                        _model.�Ȗ� = ���C�ɓ���Ȗ�.���|��;
                        _model.�⏕ = "";
                        _model.���� = "";
                        _model.���z = "";
                        _model.����ŉȖ� = "";
                        _model.���� = "";
                        _model.�E�v = "";

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
            // UPDATE company SET �Z��1 = '**** ;
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
