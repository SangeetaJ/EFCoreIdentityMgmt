using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace MainApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
            car c = new car();
            c.IsCircle();

        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }

    public abstract class Aclass
    {
        public abstract void AnyMethod();

        public abstract int Tyers { get; set; }
    }

    public class Aiclass : Aclass
    {
        public override void AnyMethod()
        {
        }
        public override int Tyers { get; set; }
    }

    public interface ITyre
    {
        int TyreCount { get; set; }
        byte TyreDiameter { get; set; }
        string TyreMaterial { get; set; }
        byte TyreWidth { get; set; }

        void IsCircle();
    }

    public interface ISterring
    {
        void IsCircle();
    }

    public class car : ITyre , ISterring
    {
        public int TyreCount { get; set; }
        public byte TyreDiameter { get; set; }
        public string TyreMaterial { get; set; }
        public byte TyreWidth { get; set; }

        public void IsCircle() {
        }
    }
}
