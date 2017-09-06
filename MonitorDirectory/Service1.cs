using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace MonitorDirectory
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();


            if (!System.Diagnostics.EventLog.SourceExists("FolderServiceSource"))
            {
                System.Diagnostics.EventLog.CreateEventSource("FolderServiceSource", "FolderServiceLog");
            }

            eventLog1.Source = "FolderServiceSource";
            eventLog1.Log = "FolderServiceLog";

        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("My service started");
                
            FileSystemWatcher fsw = new FileSystemWatcher(@"C:\Users\newase_p\Desktop\resume");
            fsw.Filter = "*.*";
            fsw.IncludeSubdirectories = true;
            fsw.NotifyFilter = NotifyFilters.FileName|NotifyFilters.LastAccess|NotifyFilters.LastWrite|NotifyFilters.DirectoryName|NotifyFilters.FileName | NotifyFilters.DirectoryName;

            fsw.Changed += new FileSystemEventHandler(OnChange);

            fsw.Created += new FileSystemEventHandler(OnCreate);

            fsw.Deleted += new FileSystemEventHandler(OnDelete);

            fsw.Renamed += new RenamedEventHandler(OnRenamed);

            fsw.EnableRaisingEvents = true;

        }

      

        private void OnCreate(object sender, FileSystemEventArgs e)
        {
            eventLog1.WriteEntry(e.Name.ToString() +"Created");
            string fileName = e.Name;
            string sourcePath = e.FullPath;
            string destFile = System.IO.Path.Combine(@"C:\Users\newase_p\Desktop\newresume", fileName);

            FileAttributes attr = File.GetAttributes(e.FullPath);
            if ((attr & FileAttributes.Directory) != FileAttributes.Directory)
            {
                File.Copy(sourcePath, destFile, true);
            }

            else
            {
                eventLog1.WriteEntry("Folder");

                DirectoryInfo dir = new DirectoryInfo(e.FullPath);
                DirectoryInfo[] dirs = dir.GetDirectories();

                if (!Directory.Exists(destFile))
                {
                    Directory.CreateDirectory(destFile);
                                    
                }
            }
          
            eventLog1.WriteEntry("File created in another folder");

        }

        private void OnChange(object sender, FileSystemEventArgs e)
        {
            eventLog1.WriteEntry(e.FullPath.ToString()+"Changed");
        
        }

        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            eventLog1.WriteEntry(e.FullPath.ToString() +" Renamed");

            string oldfileName = e.OldName;
            string destOldFile = System.IO.Path.Combine(@"C:\Users\newase_p\Desktop\newresume", oldfileName);
            string destFile = System.IO.Path.Combine(@"C:\Users\newase_p\Desktop\newresume", e.Name);

            

            FileAttributes attr = File.GetAttributes(e.FullPath);
            if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                Directory.Move(destOldFile, destFile);

            }
            else
            {
                if (File.Exists(destOldFile))
                {
                    File.Delete(destOldFile);
                }

                File.Copy(e.FullPath, destFile, true);
            }


            eventLog1.WriteEntry("FileName Changed in another folder");

        }

        private void OnDelete(object sender, FileSystemEventArgs e)
        {
            eventLog1.WriteEntry(e.FullPath.ToString() +"Deleted");
            Console.WriteLine(e);
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("Service Stopped");

        }

     
    }
}
