using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_dir
{
    public class FolderData
    {
        static Stack<int> index_stack = new Stack<int>();

        public string folder_name { get; set; }
        public List<string> files { get; set; }
        public List<FolderData> folders { get; set; }

        public FolderData(string name)
        {
            folder_name = name;
            folders = new List<FolderData>();
        }
        
        public string ConvertToSTR()
        {
            int current; 
            if (index_stack.Count == 0)
            {
                current = 1;
            }
            else
            {
                current = index_stack.Pop();
                current++;
            }
            index_stack.Push(current);
            Stack<int> stack2 = new Stack<int>(index_stack.ToArray());
            var count_index = string.Join(".", stack2);
            var str = string.Format("{0}-{1} \r\n", count_index, folder_name);
            var i = 0;
            foreach (var folder in folders)
            {
                index_stack.Push(i);
                str += folder.ConvertToSTR();
                index_stack.Pop();
                i++;
            }
            i = i == 0 ? 1 : i;
            foreach (var file in files)
            {
                str += string.Format("{0}.{1}-{2} \r\n", count_index, i, file);
                i++;
            }

            return str;
        }
        
    }
}
