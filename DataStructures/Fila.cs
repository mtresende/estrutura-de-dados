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

    public int Contador() // Count
    {
        return qtde;
    }
}