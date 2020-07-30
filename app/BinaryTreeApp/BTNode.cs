using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

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
    }


}