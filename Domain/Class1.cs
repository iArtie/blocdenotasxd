using System;

namespace Domain
{
    public class Class1
    {
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
