using System;
using System.Collections.Generic;
using System.Text;

namespace TrainGo.Helpers
{
    public class ResultEventArgs : EventArgs
    {

        public bool Success { get; set; }

        public ResultEventArgs(bool success) 
        { 
            Success = success; 
        }

    }
}
