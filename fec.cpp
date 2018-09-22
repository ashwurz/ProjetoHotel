#include <iostream>
#include "fec.h"

using namespace std;

template<typename T>
FEC<T>::FEC(): i(0), f(0) {}
// insere o valor na fila com seu devido tempo de estadia.
template<typename T>
bool FEC<T>::insere(T valor, int t) {
    if ((f+1)%n == i){
        cout << "a lista ta cheia" << endl;
        return false;
    }
    v[f] = valor;
    time[f] = t;
    f = (f+1)%n;
    return true;
}

//passa um dia.
template<typename T>
bool FEC<T>::passaTempo(){
    for(int i = this->i; i < f; i ++){
        time[i]--;
        if(time[i] == 0){
            remove();
        }
    }
}

// remove quem entrou primeiro em uma fila.
template<typename T>
bool FEC<T>::remove(T *confirma = nullptr){
    if( f == i){
        return false;
    }
    if( confirma){
        *confirma = v[i];
    }
    i = (i+1)%n;
    return true;
}

// impressão para confirmação dos resultados e relatorio de quem ainda está no hotel.
template<typename T>
void FEC<T>::imprime(){
    int k = this->i;
    for( k ; k != f; k = (k+1)%n){
        cout << v[k] << endl;
    }
}

