using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_dir
{
    public class FolderData
    {
        public string folder_name { get; set; }
        public List<string> files { get; set; }
        public List<FolderData> folders { get; set; }

        public FolderData(string name)
        {
            folder_name = name;
            folders = new List<FolderData>();
        }
    }
}
