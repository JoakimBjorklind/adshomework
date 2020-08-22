using System;
using System.Collections.Generic;

namespace part4
{
    public class Order
    {
        int[] preOrder;
        int[] inOrder;
        int[] nodeLocationInOrder;
        int[] result;
        public int[] Create(int[] a, int[] b)
        {
            this.preOrder = a;
            this.inOrder = b;
            int n = preOrder.Length;
            nodeLocationInOrder = new int[n + 1];
            result = new int[n];

            for (int i = 0; i < n; i++)
            {
                nodeLocationInOrder[inOrder[i]] = i;
            }
            FormTree(0, n - 1, 0, n - 1, 0, n - 1);

            return result;
        }

        void FormTree(int preOrderFirst, int preOrderLast, int inOrderFirst, int inOrderLast, int postOrderFirst, int postOrderLast)
        {
            if (preOrderFirst > preOrderLast)
            {
                return;
            }
            int root = preOrder[preOrderFirst];
            result[postOrderLast] = root;
            int location = nodeLocationInOrder[root];
            int amount = location - inOrderFirst;
            FormTree(preOrderFirst + 1, preOrderFirst + 1 + amount - 1, inOrderFirst, inOrderFirst + amount - 1, postOrderFirst, postOrderFirst + amount -1);
            FormTree(preOrderFirst + 1 + amount, preOrderLast, location + 1, inOrderLast, postOrderFirst + amount, postOrderLast -1);
        }
    }
}