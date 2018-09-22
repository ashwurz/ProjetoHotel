#include "mainwindow.h"
#include "ui_mainwindow.h"
#include <QGroupBox>
#include <QRadioButton>
#include <QVBoxLayout>

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);
}

MainWindow::~MainWindow()
{
    delete ui;
}

QGroupBox *MainWindow::ExclusiveGroup()
{
    QGroupBox *groupBox = new QGroupBox(tr("Exclusive Radio Buttons"));

    QRadioButton *radio1 = ui->Dia1;
    QRadioButton *radio2 = ui->Dia7;
    QRadioButton *radio3 = ui->Dia14;
    QRadioButton *radio4 = ui->Dia21;
    QRadioButton *radio5 = ui->Dia30;

    radio1->setChecked(true);

    QVBoxLayout *vbox = new QVBoxLayout;
        vbox->addWidget(radio1);
        vbox->addWidget(radio2);
        vbox->addWidget(radio3);
        vbox->addWidget(radio4);
        vbox->addWidget(radio5);
        vbox->addStretch(1);
        groupBox->setLayout(vbox);

        return groupBox;

}



void MainWindow::on_BtnReserva_clicked()
{
    QString nome = ui->EdtNome->text();
    if(nome.isEmpty()) return;
    if(ui->Dia1->isChecked()){
        QMessageBox::about(this, "confirm", "Seu Quarto foi reservado para 1 dia Sr(a)" + nome);
    }
    else if(ui->Dia7->isChecked()){
        QMessageBox::about(this, "confirm", "Seu Quarto foi reservado para 7 dia Sr(a)" + nome);
    }
    else if(ui->Dia14->isChecked()){
        QMessageBox::about(this, "confirm", "Seu Quarto foi reservado para 14 dia Sr(a)" + nome);
    }
    else if(ui->Dia21->isChecked()){
        QMessageBox::about(this, "confirm", "Seu Quarto foi reservado para 21 dia Sr(a)" + nome);
    }
    else if(ui->Dia30->isChecked()){
        QMessageBox::about(this, "confirm", "Seu Quarto foi reservado para 30 dia Sr(a)" + nome);
    }
}
