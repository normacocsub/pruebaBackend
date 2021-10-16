using System;
using Entity;
using DAL;
using System.Linq;

namespace BLL
{
    public class HistoryService
    {
        private readonly PruebaContext _context;

        public HistoryService(PruebaContext context)
        {
            _context = context;
        }

        public ResponseClass<History> Guardar(History history)
        {
            try
            {
                _context.Historys.Add(history);
                _context.SaveChanges();
                return new ResponseClass<History>(history);
            }
            catch(Exception e)
            {
                return new ResponseClass<History>($"Error en la Aplicación {e.Message}");
            }
        }

        public ResponseClass<History> Consultar()
        {
            try
            {
                return new ResponseClass<History>(_context.Historys.OrderByDescending(d => d.Id).ToList());
            }
            catch(Exception e)
            {
                return new ResponseClass<History>($"Error en la Aplicación {e.Message}");
            }
        }
    }
}
