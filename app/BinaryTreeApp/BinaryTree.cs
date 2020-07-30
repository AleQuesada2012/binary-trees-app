using System;
using System.Collections.Concurrent;
using Android.Sax;

namespace BinaryTreeApp
{
    public class BinaryTree
    {
        private BTNode root { get; set; }

        public BinaryTree() {
            root = null;
        }

        public bool contains(int data)
        {
            return this.contains(data, this.root);
        }

        private bool contains(int data, BTNode node)
        {
            if (node == null)
            {
                return false;
            }
            else
            {
                if (data < node.GetData())
                {
                    return contains(data, node.GetLeft());
                }
                else if(data > node.GetData())
                {
                    return contains(data, node.GetRight());
                }
                else
                {
                    return true;
                }
            }
        }

        public int getData(int data)
        {
            return getData(data, this.root);
        }

        private int getData(int data, BTNode node)
        {
            if (node == null)
            {
                return 0;
            }

            if (data < node.GetData())
            {
                return getData(data, node.GetLeft());
            }
            else if (data > node.GetData())
            {
                return getData(data, node.GetRight());
            }
            else
            {
                return node.GetData();
            }
        }

        public void Insert(int data)
        {
            this.root = this.Insert(data, this.root);
        }

        private BTNode Insert(int data, BTNode tmp)
        {
            if (tmp == null)
            {
                BTNode node = new BTNode();
                node.SetData(data);
                return node;
            }

            if (data < tmp.GetData())
            {
                tmp.SetLeft(this.Insert(data, tmp.GetLeft()));
            }
            else if(data>tmp.GetData())
            {
                tmp.SetRight(this.Insert(data, tmp.GetRight()));
            }

            return tmp;
        }

        public string PreOrder()
        {
            string value = "";
            return PreOrder(this.root, value);
        }
        private string PreOrder(BTNode node, string value)
        {
            if (node != null)
            {
                value += node.GetData()+" ";
                PreOrder(node.GetLeft(), value);
                PreOrder(node.GetRight(), value);
            }
            return value;
        }

        public string InOrder()
        {
            string value = "";
            return InOrder(this.root, value);
        }

        private string InOrder(BTNode node, string value)
        {
            if (node != null)
            {
                InOrder(node.GetLeft(), value);
                value += node.GetData()+" ";
                InOrder(node.GetRight(), value);
            }

            return value;
        }
        
        public string PostOrder()
        {
            string value = "";
            return PostOrder(this.root, value);
        }

        private string PostOrder(BTNode node, string value)
        {
            if (node != null)
            {
                InOrder(node.GetLeft(), value);
                InOrder(node.GetRight(), value);
                value += node.GetData()+" ";

            }

            return value;
        }
    }
}