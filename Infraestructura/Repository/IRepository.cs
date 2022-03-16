using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infraestructura.Repository
{
    
    public class IRepository
        
    {
       
        public string directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)); /*"xd"*/
        public TreeNode ReadFiles(DirectoryInfo directoryInfo)
        {

            TreeNode treeNode = new TreeNode(directoryInfo.Name);
            foreach (var item in directoryInfo.GetDirectories())
            {
                treeNode.Nodes.Add(ReadFiles(item));
            }
            foreach (var item in directoryInfo.GetFiles())
            {
                treeNode.Nodes.Add(new TreeNode(item.Name));
            }
            return treeNode;
        }
    }
}
