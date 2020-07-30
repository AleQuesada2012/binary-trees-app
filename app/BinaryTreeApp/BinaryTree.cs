namespace BinaryTreeApp {
    /// <summary>
    /// this class represents a Binary Search Tree implementation.
    /// It's node objects are restricted to integer values.
    /// </summary>
    public class BinaryTree {
        private BTNode root { get; set; }

        public BinaryTree() {
            root = null;
        }

        /// <summary>
        /// This method is used to add a new numeric value to a referenced instance
        /// </summary>
        /// <param name="data"></param>
        public void Insert(int data)
        {
            this.root = this.Insert(data, this.root);
        }

        /// <summary>
        /// This is the private Insertion method.
        /// invoked by the public insert method to simplify the user interaction with inserting operations
        /// </summary>
        /// <param name="data">integer value to insert in the BST instance</param>
        /// <param name="tmp">temporal node reference started as the BST instance's root</param>
        /// <returns></returns>
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

        /// <summary>
        /// This method returns a string ordered using the PreOrder logic it uses a private method to determine the order
        /// </summary>
        /// <returns>
        /// a string with the ordered integers
        /// </returns>
        public string PreOrder()
        {
            return PreOrder(this.root);
        }
        
        /// <summary>
        /// This method is used by PreOrder using recursion
        /// </summary>
        /// <param name="node">
        /// the current node that the algorithm is using
        /// </param>
        /// <returns>
        /// the full string of values
        /// </returns>
        private string PreOrder(BTNode node)
        {
            string value = "";
            if (node != null)
            {
                value = value + node.GetData()+", ";
                value = value + PreOrder(node.GetLeft());
                value = value + PreOrder(node.GetRight());
            }
            return value;
        }
        
        /// <summary>
        /// This method returns a string ordered using the InOrder logic it uses a private method to determine the order
        /// </summary>
        /// <returns>
        /// a string with the ordered integers
        /// </returns>
        public string InOrder()
        {
            return InOrder(this.root);
        }

        /// <summary>
        /// This method is used by InOrder using recursion
        /// </summary>
        /// <param name="node">
        /// the current node that the algorithm is using
        /// </param>
        /// <returns>
        /// the full string of values
        /// </returns>
        private string InOrder(BTNode node)
        {
            string value = "";
            if (node != null)
            {
                value += InOrder(node.GetLeft());
                value += node.GetData()+", ";
                value += InOrder(node.GetRight());
            }
            return value;
        }
        
        /// <summary>
        /// This method returns a string ordered using the PostOrder logic it uses a private method to determine the order
        /// </summary>
        /// <returns>
        /// a string with the ordered integers
        /// </returns>
        public string PostOrder()
        {
            return PostOrder(this.root);
        }

        /// <summary>
        /// This method is used by PostOrder using recursion
        /// </summary>
        /// <param name="node">
        /// the current node that the algorithm is using
        /// </param>
        /// <returns>
        /// the full string of values
        /// </returns>
        private string PostOrder(BTNode node)
        {
            
            string value = "";
            if (node != null) {
                value += PostOrder(node.GetLeft());
                value += PostOrder(node.GetRight());
                value += node.GetData()+", ";
            }
            return value;
        }
    }
}