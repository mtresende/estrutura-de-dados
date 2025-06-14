using System;

public class Fila<T>
{
    private Celula<T> frente;
    private Celula<T> tras;
    private int qtde = 0;

    public Fila()
    {
        frente = new Celula<T>();
        tras = frente;
    }

    public void Enfileira(T valorItem) //Enqueue
    {
        tras.prox = new Celula<T>(valorItem);
        tras = tras.prox;
        qtde++;
    }

    public T Desenfileira() // Dequeue
    {
        if (frente != tras)
        {
            frente = frente.prox;
            T item = frente.item;
            qtde --;
            return item;
        }
        return default(T);
    }

    public T Espia() // Peek
    {
        if (frente != tras)
        {
            return frente.prox.item;
        }
        return default(T);
    }

    public int Count() // Count
    {
        return qtde;
    }

    public bool Contem(T valorItem) { // Contains
        for (Celula<T> aux = frente.prox; aux != null; aux = aux.prox) {
            if (EqualityComparer<T>.Default.Equals(aux.item, valorItem)) {
                return true;
            }
        }
        return false;
    }

    public T[] paraArray() { // ToArray
        T[] array = new T[qtde];
        int i = 0;
        for (Celula<T> aux = frente.prox; aux != null; aux = aux.prox) {
            array[i] = aux.item;
            i++;
        }
        return array;
    }
}