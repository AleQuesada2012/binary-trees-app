using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Permissions;

namespace BinaryTreeApp {
    public class BTNode
    {
        private int data { get; set; }
        
        private BTNode left { get; set; }
        private BTNode right { get; set; }

        public BTNode()
        {
            left = null;
            right = null;
        }

        private BTNode(BTNode left, BTNode right)
        {
            this.left = left;
            this.right = right;
        }

        public int GetData()
        {
            return data;
        }

        public void SetData(int data)
        {
            this.data = data;
        }

        public BTNode GetLeft()
        {
            return left;
        }

        public void SetLeft(BTNode left)
        {
            this.left = left;
        }

        public BTNode GetRight()
        {
            return right;
        }

        public void SetRight(BTNode right)
        {
            this.right = right;
        }
    }


}