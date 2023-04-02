using SLLStack;
using System;

namespace SLLStack
{
    public class Stack //Se define la clase Stack que contiene los métodos para manipular una pila basada en nodos.
    {
        private Node? root; //Se declara el campo privado "root" de tipo Node que servirá como el nodo superior de la pila.

        public Stack()
        {
            root = null; //Se define el constructor de la clase Stack que inicializa el campo "root" en null.
        }

        public void Push(int info) //Se define el método Push que recibe un valor entero "info" como parámetro
        {
            /*Este método crea un nuevo nodo, asigna el valor "info" al campo "info" del nuevo nodo y verifica si la pila está vacía.
            Si es así, el nuevo nodo se convierte en la raíz de la pila.*/
            Node newNode;
            newNode = new Node();
            newNode.info = info;
            if (emptyStack())
            {
                newNode.next = null;
                root = newNode;
                Console.WriteLine($"u inserted the value {info} correctly");
            }
            /*Si la pila no está vacía, el nuevo nodo se coloca en la cima de la pila y se actualiza el campo "next" del nuevo nodo
            para que apunte al nodo que antes estaba en la cima de la pila.*/
            else
            {
                newNode.next = root;
                root = newNode;
                Console.WriteLine($"u inserted the value {info} correctly");
            }
        }

        public int Pop() //Se define el método Pop que extrae el nodo de la cima de la pila y devuelve el valor "info" que contiene ese nodo.
        {
            if (root != null)
            {
                int info = root.info;
                root = root.next;
                Console.WriteLine($"u got rid of the value {info} successfully :c");
                return info;
            }
            //Si la pila está vacía, el método imprime un mensaje en la consola que indica que la pila está vacía y devuelve -1.
            else
            {
                Console.WriteLine("empty Stack");
                return -1; // retorna un valor por defecto en caso de estar vacía
            }
        }

        public int Peek()//Se define el método Peek que muestra el valor "info" del nodo en la cima de la pila sin extraerlo de la pila.
        {
            if (emptyStack())
            {
                Console.WriteLine("empty Stack");
                return -1; // retorna un valor por defecto en caso de estar vacía
            }
            Console.WriteLine("Peek: " + root.info);
            return root.info;
        }

        public bool emptyStack()//Se define el método emptyStack que devuelve "true" si la pila está vacía, y "false" en caso contrario.
        {
            return root == null;
        }

        public int Size()//Se define el método Size que imprime el número de nodos en la pila en la consola mientras cuenta los nodos.
        {
            int size = 0;
            Node? current = root;

            while (current != null)
            {
                size++;
                current = current.next;
            }
            Console.WriteLine("Stack size: \t\t" + size);
            Console.WriteLine("Stack nodes: ");
            current = root;
            while (current != null)
            {
                Console.WriteLine("\t\t\t" + current.info);
                current = current.next;
            }
            return size;
        }
    }
}

