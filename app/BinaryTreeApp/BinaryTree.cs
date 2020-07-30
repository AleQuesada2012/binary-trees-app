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
            return PreOrder(this.root);
        }
        private string PreOrder(BTNode node)
        {
            string value = "";
            if (node != null)
            {
                value = value + node.GetData()+" ";
                value = value + PreOrder(node.GetLeft())+" ";
                value = value + PreOrder(node.GetRight())+" ";
            }
            return value;
        }

        public string InOrder()
        {
            return InOrder(this.root);
        }

        private string InOrder(BTNode node)
        {
            string value = "";
            if (node != null)
            {
                value += InOrder(node.GetLeft())+" ";
                value += node.GetData()+" ";
                value += InOrder(node.GetRight())+" ";
            }
            return value;
        }
        
        public string PostOrder()
        {
            return PostOrder(this.root);
        }

        private string PostOrder(BTNode node)
        {
            string value = "";
            if (node != null)
            {
                value += InOrder(node.GetLeft())+" ";
                value += InOrder(node.GetRight())+" ";
                value += node.GetData()+" ";

            }
            return value;
        }
    }
}