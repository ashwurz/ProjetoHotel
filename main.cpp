#include <iostream>

#define max 11  //10 quartos de 1,7,14,21,30 dias de estadia totalizando 50 quartos de hotel,
                // o max é 11 pois 1 espaço não pode ser usado.

using namespace std;

template <typename T>
class FEC{
private:
    int i; // inicio da fila.
    int f; // fim da fila.
    int n = max;  //variavel para o maximo de quartos.
    T v[max]; //fila de tamanho do maximo de quartos.
    int time[max]; //Tempo da estadia de cada cliente.
public:
    FEC(): i(0), f(0) {}
    // insere o valor na fila com seu devido tempo de estadia.
    bool insere(T valor, int t) {
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
    bool passaTempo(){
        for(int i = this->i; i < f; i ++){
            time[i]--;
            if(time[i] == 0){
                remove();
            }
        }
    }

    // remove quem entrou primeiro em uma fila.
    bool remove(T *confirma = nullptr){
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
    void imprime(){
        int k = this->i;
        for( k ; k != f; k = (k+1)%n){
            cout << v[k] << endl;
        }
    }


};

int main() {
    FEC <string> v1;
    FEC <string> v7;
    FEC <string> v14;
    v1.insere("a",1);
    v1.insere("b",1);
    v1.insere("c",1);
    v1.insere("d",1);
    v7.insere("e",7);
    v7.insere("f",7);
    v7.insere("g",7);
    v14.insere("h",14);
    v14.insere("i",14);
    v1.imprime();
    v7.imprime();
    v14.imprime();
    v1.passaTempo();
    v7.passaTempo();
    v14.passaTempo();
    v1.imprime();
    v7.imprime();
    v14.imprime();
    for (int i =0; i < 6 ;i++){
        v7.passaTempo();
        v14.passaTempo();
    }
    v7.imprime();
    v14.imprime();
    for (int i =0; i < 7;i++){
        v14.passaTempo();
    }
    v14.imprime();
    return 0;
}