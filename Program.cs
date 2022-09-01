using System.Configuration;
using System.Resources;
using Cleaner.Tools;


#pragma warning disable CS8604 // 禁用将 null 字面量或可能为 null 的值转换为非 null 类型。
namespace Cleaner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean debug = false;
            ResourceManager resManager = new ResourceManager(typeof(Resource1));
            Console.WriteLine(resManager.GetString("banner"));
            Console.WriteLine(resManager.GetString("info"));
            Console.WriteLine(resManager.GetString("auther"));
            if (args.Length == 0)
            {
                Console.WriteLine("[信息] {0}", resManager.GetString("argsifempty"));
                Console.WriteLine("[信息] 开始执行默认任务");
                Console.ReadKey();
            }
            else
            {
                if (args[0].Equals("调试") || args[0].Equals("--v"))
                {
                    debug = true;
                    //Debug
                    Console.WriteLine("目录占用空间的计算：" + Size.Getsize(Checker.GetDirectorySpace(ConfigurationManager.AppSettings.Get("DEBUG_DIRECTORY"))));
                    Console.WriteLine("文件占用空间的计算：" + Size.Getsize(Checker.GetDirectorySpace(ConfigurationManager.AppSettings.Get("DEBUG_FILES"))));
                    Console.WriteLine("目录大小的计算：" + Size.Getsize(Checker.GetDirectoryLength(ConfigurationManager.AppSettings.Get("DEBUG_DIRECTORY"))));
                    Console.WriteLine("文件大小的计算：" + Size.Getsize(Checker.GetFileLength(ConfigurationManager.AppSettings.Get("DEBUG_FILES"))));
                    Console.ReadKey();
                };
            }
        }
    }
}