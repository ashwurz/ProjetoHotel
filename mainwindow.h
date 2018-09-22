#ifndef MAINWINDOW_H
#define MAINWINDOW_H


#include <QMainWindow>
#include <QGroupBox>
#include <QRadioButton>
#include <QString>
#include <QMessageBox>

namespace Ui {
class MainWindow;
}

class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    explicit MainWindow(QWidget *parent = nullptr);
    ~MainWindow();

private slots:
    void on_BtnReserva_clicked();

private:

    Ui::MainWindow *ui;
    QGroupBox *ExclusiveGroup();
};

#endif // MAINWINDOW_H
