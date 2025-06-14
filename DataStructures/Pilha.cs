using System;

public class Pilha<T> {
    private Celula<T> topo = null;
    private int qtde = 0;

    public void Empilha(T valorItem) { // Push
        topo = new Celula<T>(valorItem, topo);
        qtde++;
    }

    public T Desempilha() { // Pop
        if (topo != null) {
            T item = topo.item;
            topo = topo.prox;
            qtde--;
            return item;
        }
        return default(T);
    }
    
    
}
