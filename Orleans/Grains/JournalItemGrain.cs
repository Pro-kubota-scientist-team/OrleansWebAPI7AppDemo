using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Orleans.Runtime;
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
                case "100":
                    {
                        _model = new JournalItem
                        {
                            
                        };
                    }
                    break;
                case "700":
                    {
                        _model = new JournalItem()
                        {

                        };
                        
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
    }
}
