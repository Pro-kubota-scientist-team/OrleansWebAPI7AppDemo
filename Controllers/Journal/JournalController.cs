using Microsoft.AspNetCore.Mvc;
using OrleansWebAPI7AppDemo.Models.Journal;
using OrleansWebAPI7AppDemo.Orleans.Abstractions;

namespace OrleansWebAPI7AppDemo.Controllers.Journal
{
    [ApiController]
    [Route("Journal/[controller]")]
    public class JournalController : ControllerBase
    {

        private readonly IGrainFactory _grains;

        public JournalController(IGrainFactory grains)
        {
            _grains = grains;
        }
        /// <summary>
        /// 仕訳番号を取得します
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
        [Route("")]
        public IList<string> Index()
        {
            var items = new List<string>();
            // ↓↓　一般的にはデータベースから取得する
            // SELECT * FROM AccountItem;
            items.Add("1");
            items.Add("2");
            // ↑↑　
            return items;
        }

        /// <summary>
        /// 指定したコードの仕訳帳を取得します
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
        [Route("{id}")]

        public async Task<IActionResult> Get(String id)
        {
            // グレインの呼び出し
            var campanyGrain = _grains.GetGrain<IJournalItemGrain>(id);
            // 指定グレインのGETメソッドを実行して結果を取得する
            var journalItem = await campanyGrain.GetJournalItem();
            if (journalItem == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(journalItem);
            }
        }
    }
}
