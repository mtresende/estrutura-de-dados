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

    public bool EstaVazia() => frente == tras;

    public void Enfileira(T valorItem)
    {
        tras.prox = new Celula<T>(valorItem);
        tras = tras.prox;
    }

    public T Desenfileira()
    {
        if (frente != tras)
        {
            frente = frente.prox;
            T item = frente.item;
            return item;
        }
        return default(T);
    }
}