using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countly_sdk_xamarin.Models
{
    class Crash
    {
        //device metrics
        private string _os;
        private string _os_version ;
        private string _manufacture;
        private string _device;
        private string _resolution;
        private string _app_version;
        private string _cpu;
        private string _opengl ;

        //state of device
        private string _ram_current;
        private string _ram_total;
        private string _disk_current;
        private string _disk_total;
        private string _bat;
        private string _orientation;

        //bools
        private string _root;
        private string _online;
        private string _muted;
        private string _background;

        //error info
        private string _name;
        private string _error;
        private string _nonfatal;
        private string _logs;
        private string _run;

        //custom key
        private string _custom;
    }
}
