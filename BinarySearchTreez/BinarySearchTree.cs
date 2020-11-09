using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreez
{
    public class BinarySearchTree
    {
            public Node root;

            public void Add(int currentNodeValue)
            {
                Node newNode = new Node(currentNodeValue);
                
                    if (root == null)
                    {
                        
                        root = newNode;
                        return;
                    }
                
                Node currentNode = root;
                while (currentNode != null)
                {
                    if (currentNode.Data == newNode.Data) break;
                    else if (currentNode.Data > newNode.Data)
                    {
                        
                            if (currentNode.leftNode == null)
                            {
                                
                                currentNode.leftNode = newNode;
                                break;
                            }
                        
                        currentNode = currentNode.leftNode;
                    }
                    else if (currentNode.Data < newNode.Data)
                    {
                        
                            if (currentNode.rightNode == null)
                            {
                                
                                currentNode.rightNode = newNode;
                                break;
                            }
                        
                        currentNode = currentNode.rightNode;
                    }
                }
            }
            public bool Search(int value)
            {
                bool found = false;
                string nodeDirections = "";
                Node currentNode = root;
                while (currentNode != null)
                {
                    if (currentNode.Data == value)
                    {
                        found = true;
                        break;
                    }
                    else if (currentNode.Data > value)
                    {
                        nodeDirections += currentNode.Data + " Left\n";
                        currentNode = currentNode.leftNode;
                    }
                    else if (currentNode.Data < value)
                    {
                        nodeDirections += currentNode.Data + " Right\n";
                        currentNode = currentNode.rightNode;
                    }
                }
                
                return found;
            }
        }
}
