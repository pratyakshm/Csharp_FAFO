using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Windows.Management.Deployment;

namespace ConsoleApp1
{   
        public class ListPackages
        {
            public static int Main(string[] args)
            {
                PackageManager packageManager = new PackageManager();

                IEnumerable<Windows.ApplicationModel.Package> packages =
                    (IEnumerable<Windows.ApplicationModel.Package>)packageManager.FindPackages();

                int packageCount = 0;
                foreach (var package in packages)
                {
                    DisplayPackageInfo(package);

                    packageCount += 1;
                }

                if (packageCount < 1)
                {
                    Console.WriteLine("No packages were found.");
                }
                return 0;
            }

            private static void DisplayPackageInfo(Windows.ApplicationModel.Package package)
            {
                string[] list;
                list = new string[] { package.Id.Name};
                Console.WriteLine(  );
            }
        }
}