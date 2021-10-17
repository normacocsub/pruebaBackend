using Entity;
namespace pruebaWeb.Models
{
    public class HistoryInputModels
    {
        public string City { get; set; }
        public string Info { get; set; }
    }

    public class HistoryViewModels : HistoryInputModels 
    {
        public HistoryViewModels(History history)
        {
            City = history.City;
            Info = history.Info;
        }
    }
}