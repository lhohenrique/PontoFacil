using System.Collections.Generic;
using PontoFacil.Models;
using System.Threading.Tasks;

namespace PontoFacil.Services
{
    interface IPersistencyService
    {
        List<ClockIn> ClockInList { get; set; }
        Planning MyPlanning { get; set; }
        Profile MyProfile { get; set; }

        Task persist();
        void restore();
        void saveClockIn(ClockIn clockIn);
        void savePlanning(Planning planning);
        void saveProfile(Profile profile);
    }
}