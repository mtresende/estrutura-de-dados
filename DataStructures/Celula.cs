using System;

class Celula<T>
{
    public T item;
    public Celula<T> prox;

    public Celula()
    {
        item = default(T);
        prox = null;
    }

    public Celula(T valorItem)
    {
        item = valorItem;
        prox = null;
    }

    public Celula(T valorItem, Celula<T> valorProx)
    {
        item = valorItem;
        prox = valorProx;
    }
}
