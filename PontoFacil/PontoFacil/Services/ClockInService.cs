using PontoFacil.Models;
using PontoFacil.Repositories;
using System;

namespace PontoFacil.Services
{
    class ClockInService
    {
        private IRepository<ClockIn> Rep;
        private ClockIn clockIn;

        public ClockInService(IRepository<ClockIn> rep)
        {
            Rep = rep;
        }

        public void Register(DateTime date)
        {
            if (clockIn.IsOpen)
                EndCurrentDay(date);
            else
                StartNewDay(date);
        }

        private void StartNewDay(DateTime dt)
        {
            clockIn = new ClockIn();
            clockIn.open(dt);
        }

        private void EndCurrentDay(DateTime dt)
        {
            clockIn.close(dt);
            Rep.SaveClockIn(clockIn);
        }
    }
}
