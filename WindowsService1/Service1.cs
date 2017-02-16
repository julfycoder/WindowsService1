using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsService1
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        public void OnDebug()
        {
            OnStart(null);
        }

        protected override void OnStart(string[] args)
        {
            FileStream fs = File.Create(AppDomain.CurrentDomain.BaseDirectory + "Hello_World_File.txt");
            StreamWriter writer = new StreamWriter(fs);
            writer.WriteLine("Hi, you've wrote this message from windows service!!");
            writer.Close();
            fs.Close();
        }

        protected override void OnStop()
        {
        }
    }
}
