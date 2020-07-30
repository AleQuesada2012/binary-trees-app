namespace BinaryTreeApp {
    /// <summary>
    /// This class represents a Binary Tree Node implementation, restricted to integer elements.
    /// </summary>
    public class BTNode {
        /// <summary>
        /// 
        /// </summary>
        private int data { get; set; }
        /// <summary>
        /// 
        /// </summary>
        private BTNode left { get; set; }
        private BTNode right { get; set; }

        /// <summary>
        /// Constructor for the Binary Tree Node class
        /// </summary>
        public BTNode()
        {
            left = null;
            right = null;
        }

        /// <summary>
        /// Private constructor for Node objects.
        /// Sets the child values.
        /// </summary>
        /// <param name="left">integer value to set as the right child's</param>
        /// <param name="right">integer value to set as the right child's</param>
        private BTNode(BTNode left, BTNode right)
        {
            this.left = left;
            this.right = right;
        }

        /// <summary>
        /// public get method for the node value.
        /// </summary>
        /// <returns>the integer value of the node's element</returns>
        public int GetData()
        {
            return data;
        }

        /// <summary>
        /// public set method for the node value.
        /// </summary>
        /// <param name="data">integer value to set as the node element</param>
        public void SetData(int data)
        {
            this.data = data;
        }

        /// <summary>
        /// public get method for the node's left child
        /// </summary>
        /// <returns>Node object reference to the left child</returns>
        public BTNode GetLeft()
        {
            return left;
        }

        /// <summary>
        /// public set method for the node's left child
        /// </summary>
        /// <param name="left">a Node that is desired to be the left child of the actual node</param>
        public void SetLeft(BTNode left)
        {
            this.left = left;
        }

        /// <summary>
        /// public get method for the node's right child
        /// </summary>
        /// <returns>Node object reference for the right child</returns>
        public BTNode GetRight()
        {
            return right;
        }

        /// <summary>
        /// public set method the node's right child
        /// </summary>
        /// <param name="right">a Node that is desired to be the right child of the actual node</param>
        public void SetRight(BTNode right)
        {
            this.right = right;
        }
    }


}