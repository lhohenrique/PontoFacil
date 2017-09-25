using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontoFacil.Models
{
    class ClockIn
    {
        private bool _isOpen;
        public bool IsOpen
        {
            get { return _isOpen; }
            private set { _isOpen = value; }
        }

        private DateTime _start;
        public DateTime Start
        {
            get { return _start; }
            private set { _start = value; }
        }

        private DateTime _end;
        public DateTime End
        {
            get { return _end; }
            private set { _end = value; }
        }

        public void open(DateTime dt)
        {
            _start = dt;
            _isOpen = false;
        }

        public void close(DateTime dt)
        {
            _end = dt;
            _isOpen = false;
        }

        public ClockIn()
        {
            _isOpen = true;
        }
    }
}
