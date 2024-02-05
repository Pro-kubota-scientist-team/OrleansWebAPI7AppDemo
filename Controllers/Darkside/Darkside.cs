using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Orleans;
using OrleansWebAPI7AppDemo.Models.ProKubota;
using OrleansWebAPI7AppDemo.Orleans.Abstractions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrleansWebAPI7AppDemo.Controllers.Darkside
{
    [ApiController]
    [Route("Darkside/[controller]")]
    public class Darkside : ControllerBase
    {

        private readonly IGrainFactory _grains;

        public Darkside(IGrainFactory grains)
        {
            _grains = grains;
        }
        /// ��Џ��̃R�[�h�ꗗ���擾���܂�
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
        [Route("")]
        public IList<string> Index()
        {
            var companies = new List<string>();
            companies.Add("t283162780");

            return companies;
        }
        /// <summary>
        /// ��Џ����R�[�h���w�肵�Ď擾���܂�
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        /// <summary>
        /// ��Џ����R�[�h���w�肵�Ď擾���܂�
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet()]
        [Route("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            // �O���C���̌Ăяo��
            var sessionGrain = _grains.GetGrain<IFinancialTestGrain>(id);
            // �w��O���C����GET���\�b�h�����s���Č��ʂ��擾����
            var session = await sessionGrain.Get();
            if (session == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(session);
            }
        }
        /// <summary>
        /// ��Џ���ǉ��E�C�����܂��B
        /// </summary>
        /// <param name="id"></param>
        /// <param name="company"></param>
        /// <returns></returns>
    }
}
