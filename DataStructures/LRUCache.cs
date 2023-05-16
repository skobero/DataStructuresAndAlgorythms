using DataStructures.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class LRUCache<K, V>
    {
        public int Length;
        private int _capacity;
        private NodeLinkedList<V>? _head;
        private NodeLinkedList<V>? _tail;

        private Dictionary<K, NodeLinkedList<V>> _lookup;
        private Dictionary<NodeLinkedList<V>,K> _reverseLookup;

        public LRUCache(int capacity = 10)
        {
            this.Length = 0;
            this._capacity = capacity;
            this._head = null;
            this._tail = null;
            this._lookup = new Dictionary<K, NodeLinkedList<V>>();
            this._reverseLookup = new Dictionary<NodeLinkedList<V>,K>();
        }

        public void Update(K key, V value)
        {
            NodeLinkedList<V> node;
            this._lookup.TryGetValue(key, out node);

            if (node is null)
            {
                node = CreateNode(value);
                this.Length++;
                this.Prepend(node);
                this.TrimCache();

                this._lookup.Add(key, node);
                this._reverseLookup.Add(node, key);
            }
            else
            {
                this.Detach(node);
                this.Prepend(node);
                node.Value = value;
            }
        }

        public V? Get(K key)
        {
            //Check the cache for existance
            NodeLinkedList<V> node;
            this._lookup.TryGetValue(key,out node);

            if (node is null)
            {
                return default(V);
            }

            //update the value we found and move it to the front
            this.Detach(node);
            this.Prepend(node);

            //return out the value found

            return node.Value;
        }

        private void Detach(NodeLinkedList<V> node)
        {
            if (node.Prev is not null)
            {
                node.Prev.Next = node.Next;
            }

            if (node.Next is not null)
            {
                node.Next.Prev = node.Prev;
            }

            if (this._head == node)
            {
                this._head = this._head.Next;
            }

            if (this._tail == node)
            {
                this._tail = this._tail.Prev;
            }

            node.Next = null;
            node.Prev = null;
        }

        private void Prepend(NodeLinkedList<V> node)
        {
            if (this._head is null)
            {
                this._head = this._tail = node;
                return;
            }

            node.Next = this._head;
            this._head.Prev = node;
            this._head = node;
        }

        private void TrimCache()
        {
            if (this.Length <= this._capacity)
            {
                return;
            }

            var tail = this._tail;
            this.Detach(tail);

            var key = this._reverseLookup[tail];

            this._lookup.Remove(key);
            this._reverseLookup.Remove(tail);
            this.Length--;
        }

        private NodeLinkedList<V> CreateNode(V value){
            var node = new NodeLinkedList<V>
            {
                Value = value
            };

            return node;
        }
    }
}
