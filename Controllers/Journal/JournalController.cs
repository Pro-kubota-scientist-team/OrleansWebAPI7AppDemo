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
            var journalGrain = _grains.GetGrain<IJournalItemGrain>(id);
            // 指定グレインのGETメソッドを実行して結果を取得する
            var journalItem = await journalGrain.GetJournalItem();
            var journalItemDetail = await journalGrain.GetJournalItemDetails();
            if (journalItem == null)
            {
                return NotFound();
            }
            else if (journalItemDetail == null)
            {
                var result = new { journalItem = journalItem, journalItemDetail = ""};
                return Ok(result);
            }
            else
            {
                var result = new { journalItem = journalItem, journalItemDetail = journalItemDetail};
                return Ok(result);
            }
        }
    }
}
