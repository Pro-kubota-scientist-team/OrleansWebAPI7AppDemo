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
        /// 会社情報のコード一覧を取得します
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
        /// 会社情報をコードを指定して取得します
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        /// <summary>
        /// 会社情報をコードを指定して取得します
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet()]
        [Route("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            // グレインの呼び出し
            var sessionGrain = _grains.GetGrain<IFinancialTestGrain>(id);
            // 指定グレインのGETメソッドを実行して結果を取得する
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
        /// 会社情報を追加・修正します。
        /// </summary>
        /// <param name="id"></param>
        /// <param name="company"></param>
        /// <returns></returns>
    }
}
