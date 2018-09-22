#include<iostream>
#ifndef FEC_H
#define FEC_H

#define max 11//10 quartos de 1,7,14,21,30 dias de estadia totalizando 50 quartos de hotel,
              // o max é 11 pois 1 espaço não pode ser usado.

template<typename T>
class FEC
{
private:
    int i; // inicio da fila.
    int f; // fim da fila.
    int n = max;  //variavel para o maximo de quartos.
    T v[max]; //fila de tamanho do maximo de quartos.
    int time[max]; //Tempo da estadia de cada cliente.
public:
    FEC();
    bool insere(T valor, int t);
    bool passaTempo();
    bool remove(T *confirma = nullptr);
    void imprime();

};

#endif // FEC_H
