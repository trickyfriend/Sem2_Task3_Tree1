using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Sem2_Tree1
{
    class Tree
    {
        private Node root;

        public void Create(string inputFile, ref Tree tree)
        {
            if (tree == null)
                tree = new Tree();
            List<string> s = ArrayUtils.ReadFromFile(inputFile);
            for (int i = 0; i < s.Count; i++)
                tree.Add(s[i]);
        }
        public void Add(string value)
        {
            Add(value, ref root);
        }
        private void Add(string value, ref Node local)
        {
            if (local == null)
            {
                local = new Node();
                local.value = value;
                return;
            }
            if (local.value.Length < value.Length)
            {
                Add(value, ref local.right);
            }
            else
            {
                Add(value, ref local.left);
            }
        }

        public void Drawing(Graphics g, int x, int y, int dy)
        {
            DrawingTree(g, root, x, y, dy);
        }
        private void DrawingTree(Graphics g, Node p, int x, int y, int dy)
        {
            if (p == null)
                return;
            else
            {
                if (p.left != null)
                    Draw.Edge(g, x, y, x / 2, y + dy);
                if (p.right != null)
                    Draw.Edge(g, x, y, x + x / 2, y + dy);
                Draw.Ellipse(g, x, y, p);
                Draw.Node(g, x, y, p);
                DrawingTree(g, p.left, x / 2, y + dy, dy);
                DrawingTree(g, p.right, x + x / 2, y + dy, dy);
            }
        }

        public List<string> Sort()
        {
            List<string> list = new List<string>();
            SortTree(root, list);
            return list;
        }
        private void SortTree(Node p, List<string> list)
        {
            if (p == null)
                return;
            else
            {
                SortTree(p.left, list);
                list.Add(p.value);
                SortTree(p.right, list);
            }
        }
    }
}
