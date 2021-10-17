using System.Collections.Generic;
using System.Linq;
using BLL;
using DAL;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pruebaWeb.Models;

namespace pruebaWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HistoryController : ControllerBase
    {
        private readonly HistoryService _service;

        public HistoryController(PruebaContext context)
        {
            _service = new HistoryService(context);
        }

        // api/History
        [HttpPost]
        public ActionResult<HistoryViewModels> Guardar(HistoryInputModels historyInput)
        {
            History history = MapearHistory(historyInput);
            var response = _service.Guardar(history);
            if(response.Error)
            {
                return BadRequest(response.Mensaje);
            }
            return Ok(new HistoryViewModels(response.Object));
        }

        // api/History
        [HttpGet]
        public ActionResult<IEnumerable<HistoryViewModels>> Consultar()
        {
            var response = _service.Consultar();
            if(response.Error)
            {
                return BadRequest(response.Mensaje);
            }
            return Ok(response.Objects.Select(h => new HistoryViewModels(h)));
        }

        private History MapearHistory(HistoryInputModels historyInput)
        {
            var history = new History
            {
                City = historyInput.City,
                Info = historyInput.Info
            };
            return history;
        }
    }
}